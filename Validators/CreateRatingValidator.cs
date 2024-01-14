using BookRatingManager.Api.Models;
using FluentValidation;

namespace BookRatingManager.Api.Validators
{
    public class CreateRatingValidator : AbstractValidator<CreateRatingModel>
    {
        public CreateRatingValidator()
        {
            RuleFor(c => c.Rate)
                .InclusiveBetween(1,5)
                .WithMessage("The Rate must be between 1 and 5.");

           
            RuleFor(c => c.EndDate)
                .NotEmpty().WithMessage("*Required")
                .GreaterThanOrEqualTo(r => r.Created).WithMessage("End date must after Start date");
        }
    }
}
