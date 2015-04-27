using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsProject.Model {

    public class Invoice {

        public string nrInvoice;
        public int total;
        public int icms;
        public int ipi;

        public Invoice(string nrInvoice, int total, int icms, int ipi) {
            this.nrInvoice = nrInvoice;
            this.total = total;
            this.icms = icms;
            this.ipi = ipi;
        }
    }
}
