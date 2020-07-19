using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Shared.Models
{
    public class AuthenticateResult
    {
        public bool Authenticated { get; set; }
        public string UserName { get; set; }
        public string Environment { get; set; }
        public string EmailAddress { get; set; }
        public object FullName { get; set; }
    }
}
