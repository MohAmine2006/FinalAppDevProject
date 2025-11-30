using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevProject.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; } 
        public double Amount { get; set; }  
        public string Category { get; set; }  
        public string Type { get; set; }   
        public string Date { get; set; }   
        public string Note { get; set; }
    }
}
