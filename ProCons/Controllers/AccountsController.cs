using ProCons.DataLogic;
using ProCons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProCons.Controllers
{
    public class AccountsController : Controller
    {
        readonly ProConsConnector _proConsConnector = new ProConsConnector();
        //
        // GET: /Accounts/

        public ActionResult Index()
        {
            var accounts = _proConsConnector.RetrieveAccounts();
            return View(accounts);
        }
        public ActionResult AccountEdit(Guid accountId)
        {
            var account= _proConsConnector.RetrieveAccount(accountId);
            return View(account);
        }
        public ActionResult Records(Guid accountId)
        {
            var records = _proConsConnector.RetrieveRecords(accountId);
            var account = _proConsConnector.RetrieveAccount(accountId);
            ViewBag.AccountName = account.Name;
            return View(records);
        }
        public ActionResult AddRecord(Guid accountId) {
            ViewData["accountId"] = accountId;
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult AddRecord(Record targetRecord)
        {
            _proConsConnector.CreateRecord(targetRecord);
            return RedirectToAction("Records", new { accountId = targetRecord.AccountId });
        }
    }
}
