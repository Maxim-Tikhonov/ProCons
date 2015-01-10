using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProConsService.Exceptions
{
    public class AccountCreateExeption: Exception
    {
        public AccountCreateExeption(string message): base(message)
        {
        }
    }
}