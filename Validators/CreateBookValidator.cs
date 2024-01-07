using BookRatingManager.Api.Models;
using FluentValidation;

namespace BookRatingManager.Api.Validators
{
    public class CreateBookValidator : AbstractValidator<CreateBookModel>
    {
        public CreateBookValidator()
        {
            RuleFor(c => c.Author)
                .NotEmpty().WithMessage("the Author is required")
                .MaximumLength(100).WithMessage("The book Author must have maximum of 100 characters");

            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("the Title is required")
                .MaximumLength(100).WithMessage("The Title must have maximum of 100 characters");

            RuleFor(c => c.Isbn)
                .NotEmpty().WithMessage("the Isbn is in use")
                .MaximumLength(20).WithMessage("The Isbn must have maximum of 20 characters");
            
        }
      
    }
}
