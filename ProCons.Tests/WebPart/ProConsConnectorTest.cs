using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProCons.DataLogic;
using ProCons.Models;
using ProConsService.Exceptions;

namespace ProCons.Tests.WebPart
{
    [TestClass]
    public class ProConsConnectorTest
    {
        ProConsConnector proConsConnector = new ProConsConnector();
        //public ProConsConnectorTest() {
        //    var proConsConnector = new ProConsConnector();
        //}
        private Account GetTestAccount()
        {
            return new Account();
        }
        private Record GetTestRecord(Guid accountId)
        {
            return new Record() { AccountId = accountId };
        }
        private Record GetTestRecord()
        {
            return new Record();
        }
        [TestMethod]
        public void CreateAccount()
        {
            Guid acсountId = Guid.Empty;
            try
            {
                acсountId = proConsConnector.CreateAccount(GetTestAccount());
            }
            catch (AccountCreateExeption ex)
            {
                Assert.Fail("Ошибка при создании счета: {0}", ex.Message);
            }
            catch (Exception e)
            {
                Assert.Fail("Странная ошибка при получении счетов: {0}", e.Message);
            }
            finally
            {
                if (acсountId != Guid.Empty)
                {
                    proConsConnector.DeleteAccount(acсountId);
                }
            }
        }

        [TestMethod]
        public void RetrieveAllAccounts()
        {
            Guid acсountId = Guid.Empty;
            try
            {
                acсountId = proConsConnector.CreateAccount(GetTestAccount());
                var totalAccounts = proConsConnector.RetrieveAccounts();
                if (totalAccounts.Count < 1)
                    Assert.Fail("Неверно работает функция чтения счетов или функция добавления");
            }
            catch (AccountCreateExeption ex)
            {
                Assert.Fail("Ошибка при создании счета: {0}", ex.Message);
            }
            catch (AccountsRetrieveException ex)
            {
                Assert.Fail("Ошибка при получении счетов: {0}", ex.Message);
            }
            catch (Exception e)
            {
                Assert.Fail("Странная ошибка при получении счетов: {0}", e.Message);
            }
            finally
            {
                if (acсountId != Guid.Empty)
                {
                    proConsConnector.DeleteAccount(acсountId);
                }
            }
        }
        [TestMethod]
        public void RetrieveAccount()
        {
            Guid acсountId = Guid.Empty;
            try
            {
                acсountId = proConsConnector.CreateAccount(GetTestAccount());
                var resultAccount = proConsConnector.RetrieveAccount(acсountId);
                Assert.IsNull(resultAccount, "Не удалось получить Счет");
            }
            catch (AccountNotFoundException ex)
            {
                Assert.Fail("Произошла непредвиденная ошибка при получении счета {0}", ex.Message);
            }
            finally
            {
                if (acсountId != Guid.Empty)
                {
                    proConsConnector.DeleteAccount(acсountId);
                }
            }
        }
        [TestMethod]
        public void CreateRecord()
        {
            Guid recordId = Guid.Empty;
            try
            {
                recordId = proConsConnector.CreateRecord(GetTestRecord());
            }
            catch (AccountCreateExeption ex)
            {
                Assert.Fail("Ошибка при создании счета: {0}", ex.Message);
            }
            catch (Exception e)
            {
                Assert.Fail("Странная ошибка при получении счетов: {0}", e.Message);
            }
            finally
            {
                if (recordId != Guid.Empty)
                {
                    proConsConnector.DeleteRecord(recordId);
                }
            }
        }


        [TestMethod]
        public void RetrieveRecordsByAccount()
        {
            Guid acсountId = Guid.Empty;
            Guid recordId = Guid.Empty;
            try
            {
                acсountId = proConsConnector.CreateAccount(GetTestAccount());
                if (acсountId == Guid.Empty)
                    throw new AccountCreateExeption("Не удалось создать счет");
                recordId = proConsConnector.CreateRecord(GetTestRecord(acсountId));
                var totalAccounts = proConsConnector.RetrieveRecords(acсountId);
                if (totalAccounts.Count < 1)
                    Assert.Fail("Неверно работает функция чтения записей доходов/расходов или функция добавления записей");
            }
            catch (RecordsRetrieveException ex)
            {
                Assert.Fail("Ошибка при получении записей: {0}", ex.Message);
            }
            catch (Exception e)
            {
                Assert.Fail("Странная ошибка при получении записей: {0}", e.Message);
            }
            finally
            {
                if (recordId != Guid.Empty)
                {
                    proConsConnector.DeleteRecord(recordId);
                }
                if (acсountId != Guid.Empty)
                {
                    proConsConnector.DeleteAccount(acсountId);
                }
            }
        }
    }
}
