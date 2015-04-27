using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsProject.Dao;
using TestsProject.Model;

namespace TestsProject.Business {
   
    public class InvoiceBusiness {

        private InvoiceDao dao;

        public InvoiceBusiness(InvoiceDao dao){
            this.dao = dao;
        }

        public int TotalInvoice(string nrInvoice) {
            Invoice invoice = dao.GetInvoiceValue();
            return invoice.total + CalculateBusiness.Ipi(invoice.ipi, 1) + CalculateBusiness.Icms(invoice.icms, 2);
        }
    }
}
