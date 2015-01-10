using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ProConsService.Business_Objects;
using ProConsService.Service_Objects;

namespace ProConsService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ProConsService" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ProConsService.svc или ProConsService.svc.cs в обозревателе решений и начните отладку.
    public class ProConsService : IProConsService
    {
        public AccountWS RetrieveAccount(Guid accountId)
        {
            throw new NotImplementedException();
        }

        public List<AccountWS> RetrieveAccounts(RetrieveMultipleRequest request)
        {
            throw new NotImplementedException();
        }

        public Guid CreateAccount(AccountWS account)
        {
            throw new NotImplementedException();
        }

        public List<RecordWs> RetrieveRecords(RetrieveMultipleRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
