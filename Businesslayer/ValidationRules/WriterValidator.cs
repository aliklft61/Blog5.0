using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Boş Geçme");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("mailide boş geçme");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("şifre boş geçme");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("2 karakterdende çok olsun");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("50 karakterdende az olsun");
        }
    }
}
