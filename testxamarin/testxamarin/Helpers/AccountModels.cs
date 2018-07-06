using System;
using System.Collections.Generic;
using System.Text;

namespace testxamarin.Helpers
{
    class LoginBindingModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    class LoginViewModel
    {
        public int Status { get; set; }
    }
}
