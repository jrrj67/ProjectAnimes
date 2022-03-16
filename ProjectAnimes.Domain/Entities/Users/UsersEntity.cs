using FluentValidation;
using FluentValidation.Internal;
using ProjectAnimes.Domain.Exceptions;

namespace ProjectAnimes.Domain.Entities.Users
{
    public class UsersEntity : BaseEntity
    {
        private string _name = default!;

        private string _email = default!;
        
        private string _password = default!;

        private DateTime _dateOfBirth = default!;

        public string Name 
        {
            get => _name; 
            set 
            {
                _name = value;
                ValidateSingleField(nameof(Name));
            } 
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                ValidateSingleField(nameof(Email));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                ValidateSingleField(nameof(Email));
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                ValidateSingleField(nameof(DateOfBirth));
            }
        }

        public UsersEntity(string name, string email, string password, DateTime dateOfBirth)
        {
            _name = name;
            _email = email;
            _password = password;
            _dateOfBirth = dateOfBirth;
            ValidateAllFields();
        }

        public override bool ValidateAllFields()
        {
            var validator = new UsersEntityValidator();

            var validation = validator.Validate(this);

            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    _errors.Add(error.ErrorMessage);
                }

                throw new DomainException(_errors[0], _errors);
            }

            return true;
        }

        public override bool ValidateSingleField(string name)
        {
            var properties = new[] { name };
            
            var context = new ValidationContext<UsersEntity>(this, new PropertyChain(), new MemberNameValidatorSelector(properties));
            
            var validator = new UsersEntityValidator();
            
            var validation = validator.Validate(context);

            if (!validation.IsValid)
            {
                foreach (var error in validation.Errors)
                {
                    _errors.Add(error.ErrorMessage);
                }

                throw new DomainException(_errors[0], _errors);
            }

            return true;
        }
    }
}
