using projeto_final_bloco_02.Data;

namespace projeto_final_bloco_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //// Add services to the container.
            //builder.Services.AddControllers()
            //    .AddNewtonsoftJson(options =>
            //    {
            //        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //        options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            //    });





            //// Registrar a Validação das Entidades
            //builder.Services.AddTransient<IValidator<Produto>, ProdutoValidator>();
            //builder.Services.AddTransient<IValidator<Categoria>, CategoriaValidator>();


            //// Registrar as Classes de Serviço (Service)
            //builder.Services.AddScoped<IProdutoService, ProdutoService>();
            //builder.Services.AddScoped<ICategoriaService, CategoriaService>();



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();


            //Adicionar o Fluent Validation no Swagger
            builder.Services.AddFluentValidationRulesToSwagger();


            // Configuração do CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: "MyPolicy",
                    policy =>
                    {
                        policy.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                    });
            });

            var app = builder.Build();

            // Criar o Banco de dados e as Tabelas
            using (var scope = app.Services.CreateAsyncScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dbContext.Database.EnsureCreated();
            }


            app.UseSwagger();

            app.UseSwaggerUI();

            app.UseCors("MyPolicy");

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
