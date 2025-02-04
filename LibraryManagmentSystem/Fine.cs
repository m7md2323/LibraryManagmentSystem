using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem
{
    internal class Fine
    {
        public string ID {  get; set; }
        public string ReaderID {  get; set; }
        public double Amount {  get; set; }
        public bool Status {  get; set; }
    }
}
