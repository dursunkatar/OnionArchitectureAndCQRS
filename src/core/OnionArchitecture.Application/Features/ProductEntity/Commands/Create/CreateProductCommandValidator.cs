using FluentValidation;

namespace OnionArchitecture.Application.Features.ProductEntity.Commands.Create
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommandRequest>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.ProductName)
                .NotNull()
                .WithMessage("Lütfen 'Name'i boş geçmeyiniz.")
                .MaximumLength(20)
                .MinimumLength(3)
                .WithMessage("'Name' değeri 3 ile 20 karakter arasında olmalıdır.");
            RuleFor(p => p.Price)
                .Must(p => p > 0)
                .WithMessage("Lütfen 'Price' değerini doğru giriniz.");
        }
    }
}
