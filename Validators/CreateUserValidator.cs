using BookRatingManager.Api.Models;
using FluentValidation;

namespace BookRating.Api.Validators
{
    public class CreateUserValidator : AbstractValidator<CreateUserModel>
    {
        public CreateUserValidator() 
        {
            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("the Email is required")
                .MaximumLength(100).WithMessage("The book Author must have maximum of 100 characters");

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("the Name is required")
                .MaximumLength(100).WithMessage("The Title must have maximum of 100 characters");

          
        }
    }
}
