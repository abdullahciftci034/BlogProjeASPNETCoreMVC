using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Name is not empty");
			RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail is not empty");
			RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Password is not empty");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Name is min two character");
			RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Name is max fifty character");
		}
	}
}
