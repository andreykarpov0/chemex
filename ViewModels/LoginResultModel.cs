using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chemex.ViewModels
{
    public class LoginResultModel
    {
        public LoginResults loginResult;
    }

    public enum LoginResults 
    {
        Success,
        LoginOrPasswordIsNotCorrect
    }
}
