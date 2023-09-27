using FelizMente.Model;
using FluentValidation;

namespace FelizMente.Validator
{
    public class TemaValidator : AbstractValidator<Tema>
    {
        public TemaValidator()
        {
            RuleFor(t => t.nome)
               .NotEmpty()
               .MinimumLength(5)
               .MaximumLength(255);


            RuleFor(t => t.descricao)
               .NotEmpty()
               .MinimumLength(5)
               .MaximumLength(510);

        }

    }
      
}
