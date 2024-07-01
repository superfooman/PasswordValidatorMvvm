using PasswordValidatorMvvm.Model;

namespace PasswordValidatorMvvm.ViewModel
{
    public class ValidatorViewModel
    {
        public Validator Validator { get; set; }
        public ValidatorViewModel() 
        {
            Validator = new Validator();
        }

        #region string
        public string ValidateButtonContent
        {
            get { return "Validate Passowrd"; }
        }
        #endregion

        //Can be improved with RelayCommand in the future
        public void ValidatePassword()
        {
            Validator.ValidatePassword();
        }

    }
}
