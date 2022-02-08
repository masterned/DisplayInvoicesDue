using DisplayInvoicesDue.DAL;
using PayablesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisplayInvoicesDue.Controller
{
    public class InvoiceController
    {
        private InvoiceDAL _invoiceDAL;

        public InvoiceController()
        {
            _invoiceDAL = new InvoiceDAL();
        }

        public List<Invoice> GetInvoicesDue()
        {
            return _invoiceDAL.GetInvoicesDue();
        }
    }
}
