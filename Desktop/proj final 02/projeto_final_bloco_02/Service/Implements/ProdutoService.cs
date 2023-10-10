﻿using Microsoft.EntityFrameworkCore;
using projeto_final_bloco_02.Data;
using projeto_final_bloco_02.Model;

namespace projeto_final_bloco_02.Service.Implements
{
    public class ProdutoService : IProdutoService
    {

        private readonly AppDbContext _context;

        public ProdutoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await _context.Produtos
                //.AsNoTracking()
                //.Include(p => p.Categoria)
                .ToListAsync();
        }

        public async Task<Produto?> GetById(long id)
        {
            try
            {
                var Produtos = await _context.Produtos
                    //.Include(p => p.Categoria)
                    .FirstAsync(i => i.Id == id);

                return Produtos;

            }
            catch
            {
                return null;
            }

        }

        public async Task<Produto?> Create(Produto produto)
        {
            ////categoria
            //if (produto.Categoria is not null)
            //{
            //    var BuscaCategoria = await _context.Categorias.FindAsync(produto.Categoria.Id);

            //    if (BuscaCategoria is null)
            //        return null;

            //    produto.Categoria = BuscaCategoria;

            //}

            //produto.Usuario = produto.Usuario is not null ?
            //    await _context.Users.FirstOrDefaultAsync(u => u.Id == produto.Usuario.Id)
            //    : null;

            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();

            return produto;
        }

        public async Task<Produto?> Update(Produto produto)
        {
            ////categoria
            //var CategoriaUpdate = await _context.Produtos.FindAsync(produto.Id);

            //if (CategoriaUpdate is null)
            //    return null;

            //if (produto.Categoria is not null)
            //{
            //    var BuscaCategoria = await _context.Categorias.FindAsync(produto.Categoria.Id);

            //    if (BuscaCategoria is null)
            //        return null;

            //    produto.Categoria = BuscaCategoria;
            //}

            //produto.Usuario = produto.Usuario is not null ?
            //    await _context.Users.FirstOrDefaultAsync(u => u.Id == produto.Usuario.Id)
            //    : null;

            //_context.Entry(CategoriaUpdate).State = EntityState.Detached;
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return produto;

        }

        public async Task Delete(Produto produto)
        {
            _context.Remove(produto);
            await _context.SaveChangesAsync();

        }

    }
}