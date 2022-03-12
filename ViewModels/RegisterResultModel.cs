using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chemex.ViewModels
{
    public class RegisterResultModel
    {
        public RegisterResults registrationResult;
    }

    public enum RegisterResults
    {
        Success,
        EmailIsUsed,
        LoginIsUsed,
        PasswordIsNotValid
    }
}
