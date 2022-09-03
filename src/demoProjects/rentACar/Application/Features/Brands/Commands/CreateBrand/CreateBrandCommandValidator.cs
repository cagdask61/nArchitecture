using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommandValidator : AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandCommandValidator()
        {
            RuleFor(brand => brand.Name).NotNull();
            RuleFor(brand => brand.Name).NotEmpty();
            RuleFor(brand => brand.Name).MinimumLength(2);
        }
    }
}
