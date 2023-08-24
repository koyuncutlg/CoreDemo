using EntityLayer.Concrete;
using FluentValidation;

namespace BussinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığı boş geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriği boş geçilemez.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Fotoğraf alanı boş geçilemez.");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen en fazla 150 karakter girişi yapabilirsiniz.");
        }
    }
}