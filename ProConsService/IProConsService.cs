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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IProConsService
    {

        [OperationContract]
        AccountWS RetrieveAccount(Guid accountId);
        [OperationContract]
        List<AccountWS> RetrieveAccounts(RetrieveMultipleRequest request);
        [OperationContract]
        Guid CreateAccount(AccountWS account);
        [OperationContract]
        List<RecordWs> RetrieveRecords(RetrieveMultipleRequest request);
    }
}
