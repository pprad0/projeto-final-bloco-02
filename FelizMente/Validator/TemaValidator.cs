using FelizMente.Model;
using FluentValidation;

namespace FelizMente.Validator
{
    public class TemaValidator : AbstractValidator<Tema>
    {
        public TemaValidator()
        {
            RuleFor(t => t.Nome)
               .NotEmpty()
               .MinimumLength(5)
               .MaximumLength(255);

            RuleFor(t => t.Descricao)
               .NotEmpty()
               .MinimumLength(5)
               .MaximumLength(510);

        }

    }
      
}
