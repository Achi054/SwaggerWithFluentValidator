using FluentValidation;

namespace SwaggerWithFluentValidation.Models.Validators
{
    public class HomeViewModelValidator : AbstractValidator<HomeViewModel>
    {
        public HomeViewModelValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Contact).Length(10).WithMessage("Provide a valid contact number");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Provide valid Email");
            RuleFor(x => x.Age).Must(x => x > 18).WithMessage("You are a minor");
            RuleFor(x => x.Age).Must(x => x < 60).WithMessage("You are a major");
        }
    }
}