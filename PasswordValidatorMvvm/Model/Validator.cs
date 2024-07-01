using PasswordValidatorMvvm.Interface;
using System.Collections.Specialized;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;

namespace PasswordValidatorMvvm.Model
{
    public class Validator : ViewModelBase, IInformation
    {
        private string _password;
        private string _information;
        private char[] _specialChars = { '~', '!', '@', '#', '$', '%', '^', '&', '*', '?'};
        private ISet<char> _set;

        public Validator()
        {
            _password = string.Empty;
            _information = string.Empty;
            _set = new HashSet<char>(_specialChars);
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; 
                OnPropertyChanged(nameof(Password));
            }  
        }

        public string Information
        {
            get { return _information; }
            set { _information = value;
                OnPropertyChanged(nameof(Information));   
            }
        }

        //private method (business logic)
        //would be moved to RelayCommand later
        public void ValidatePassword()
        {
            if (Password.Trim().Length < 10)
                Information = "Length of the password is too short";
            else if (Password.Trim().Length > 20)
                Information = "Length of the password is too long";
            else if (!Password.Any(char.IsUpper))
                Information = "Must contain an upper case character";
            else if (!Password.Any(char.IsLower))
                Information = "Must contain a lower case character";
            else if (!Password.Any(char.IsDigit))
                Information = "Must contain a digit";
            else if (!containSpecialCharacters())
                Information = "Must contain a special character";
            else
                Information = "Password is secure";
        }

        private bool containSpecialCharacters()
        {
            foreach (char c in _password)
                if (_set.Contains(c)) return true;
            
            return false;
        }
    }
}
