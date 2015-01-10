using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProCons.ProConsServiceReference;

namespace ProCons.Models
{
    public class Record
    {
        private readonly RecordWs _recordWs;

        public Record(RecordWs recordWs)
        {
            _recordWs = recordWs;
        }

        public Guid AccountId
        {
            get { return _recordWs.AccountId; }
        }

        public DateTime Date
        {
            get { return _recordWs.Date; }
            set { _recordWs.Date = value; }
        }

        public string CategoryName {
            get { return _recordWs.Category.Name; } 
        }

        public decimal Total
        {
            get { return _recordWs.Total; }
            set { _recordWs.Total = value; }
        }

        public string Comment
        {
            get { return _recordWs.Comment; }
            set { _recordWs.Comment = value; }
        }
    }
}