using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h4_opdracht_21
{
    internal class Book
    {
        private string name;
        private int pages;
        private int publicationYear;

        public Book(string name, int pages, int publicationYear)
        {
            this.name = name;
            this.pages = pages;
            this.publicationYear = publicationYear;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }
    }
}
