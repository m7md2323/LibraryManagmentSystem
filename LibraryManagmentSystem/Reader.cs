using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibraryManagmentSystem
{
    internal class Reader
    {
        public string ID {  get; set; }
        public string Name {  get; set; }
        public string PhoneNumber {  get; set; }
        public List<Book>? BorrowedBooks {  get; set; }
    }
}
