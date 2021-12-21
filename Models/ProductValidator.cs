using DemoCore5CRUDwDapper.Domain;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCore5CRUDwDapper.Models
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Product Name is required.");
            RuleFor(x => x.Price).NotNull().NotEmpty().WithMessage("Product Price is required.");
            RuleFor(x => x.Quantity).InclusiveBetween(1, 10);
        }
    }
}
