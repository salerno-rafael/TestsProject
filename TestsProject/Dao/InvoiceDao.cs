using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsProject.Model;

namespace TestsProject.Dao {
   
    
    public class InvoiceDao {

        //This method simulate connection with database to get invoice values 
        public virtual Invoice GetInvoiceValue() {
            return new Invoice("123",100,2,3);
        }
    }
}
