﻿using FluentValidation;

namespace ProjectAnimes.Models.Entities.Users
{
    public class UsersEntityValidator : AbstractValidator<UsersEntity>
    {
        public UsersEntityValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2)
                .MaximumLength(100);

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .MinimumLength(5)
                .MaximumLength(30)
                .Must(password => hasNumbers(password))
                .Must(password => hasSpecialCharacters(password))
                .Must(password => hasUpperCaseCharacters(password));

            RuleFor(x => x.DateOfBirth)
                .NotEmpty()
                .NotNull()
                .Must(dateOfBirth => isValidDateOfBirth(dateOfBirth));
        }

        private bool hasNumbers(string password)
        {
            throw new NotImplementedException();
        }

        private bool hasSpecialCharacters(string password)
        {
            throw new NotImplementedException();
        }
        
        private bool hasUpperCaseCharacters(string password)
        {
            throw new NotImplementedException();
        }
        
        private bool isValidDateOfBirth(DateTime dateOfBirth)
        {
            throw new NotImplementedException();
        }
    }
}
