using FluentValidation;

namespace ProjectAnimes.Models.Requests.Login
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Email can't be empty.")
                .NotNull().WithMessage("Email can't be null.")
                .EmailAddress().WithMessage("Email must be a valid one.");

            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("Password can't be empty.")
                .NotNull().WithMessage("Password can't be null.");
        }
    }
}
