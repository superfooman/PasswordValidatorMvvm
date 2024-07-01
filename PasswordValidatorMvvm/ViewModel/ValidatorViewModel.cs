using PasswordValidatorMvvm.Model;

namespace PasswordValidatorMvvm.ViewModel
{
    public class ValidatorViewModel
    {
        public Validator _validator { get; set; }
        public ValidatorViewModel() 
        { 
            _validator = new Validator();
        }

        //Can be improved with RelayCommand in the future
        public void ValidatePassword()
        {
            _validator.ValidatePassword();
        }

    }
}
