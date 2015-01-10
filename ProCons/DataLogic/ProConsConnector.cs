using ProCons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.UI;
using ProCons.ProConsServiceReference;
using RetrieveAccountsRequest = ProCons.ProConsServiceReference.RetrieveAccountsRequest;

namespace ProCons.DataLogic
{
    public class ProConsConnector
    {
        private readonly IProConsService _proConsService = new ProConsServiceReference.ProConsServiceClient();
        public List<Account> RetrieveAccounts()
        {
            var request = new RetrieveMultipleRequest();
            var accountsWs = _proConsService.RetrieveAccounts(request);
            return accountsWs.Select(p => new Account(p)).ToList();
            //request.Criteria = new List<FilterCondition>
            //{
            //    new FilterCondition()
            //    {
            //        FieldName = "accountid",
            //        FilterOperator = FilterOperators.Equal,
            //        Value = accountId
            //    }
            //};
        }

        public Guid CreateAccount(Account account)
        {
            return _proConsService.CreateAccount(account.ToServiceEntity());
        }

        public void DeleteAccount(Guid acсountId)
        {
            throw new NotImplementedException();
        }

        public List<Record> RetrieveRecords(Guid accountId)
        {
            var request = new RetrieveMultipleRequest();
            request.Criteria = new List<FilterCondition>
            {
                new FilterCondition()
                {
                    FieldName = "accountid",
                    FilterOperator = FilterOperators.Equal,
                    Value = accountId
                }
            };
            var accountsWs = _proConsService.RetrieveRecords(request);
            return accountsWs.Select(p => new Record(p)).ToList();
            
        }

        public Guid CreateRecord(Record record)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecord(Guid recordId)
        {
            throw new NotImplementedException();
        }

        public Account RetrieveAccount(Guid accountId)
        {
            return new Account(_proConsService.RetrieveAccount(accountId));
        }
    }
}