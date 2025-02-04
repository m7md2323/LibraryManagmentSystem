using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LibraryManagmentSystem
{
    internal class Loan
    {
        public string ID { get; set; }
        public string BookID {  get; set; }
        public string ReaderID {  get; set; }
        public DateTime BorrowDate {  get; set; }
        public DateTime ReturnDate {  get; set; }
        public bool Status {  get; set; }
    }
}
