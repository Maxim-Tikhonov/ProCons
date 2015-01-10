using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProCons.ProConsServiceReference;

namespace ProCons.Models
{
    public class Account
    {
        private readonly AccountWS _serviceAccount;

        public Account(AccountWS serviceAccount)
        {
            _serviceAccount = serviceAccount;
        }

        public string Name
        {
            get { return _serviceAccount.Name; } 
            set { _serviceAccount.Name = value; }
        }

        public Guid Id
        {
            get { return _serviceAccount.Id; }
        }

        public AccountWS ToServiceEntity()
        {
            return _serviceAccount;
        }
    }
}