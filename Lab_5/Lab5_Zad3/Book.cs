using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{
    public class Book : IEntity<int>, ICreationDate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublication { get; set; }
        public DateTime CreationDate { get; set; }
    }

}
