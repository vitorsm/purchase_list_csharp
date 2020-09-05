using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace purchase_list_csharp.Models.ViewModels
{
    public class LoginErrorViewModel
    {
        public LoginErrorViewModel(string message, string callbackUrl)
        {
            this.Message = message;
            this.CallbackUrl = callbackUrl;
        }

        public string Message { get; set; }
        public string CallbackUrl { get; set; }
    }
}
