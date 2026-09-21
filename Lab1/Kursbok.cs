using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
{
    public class Kursbok : Annons
    {
        private string isbn;
        private string författare;
        private string upplaga;

        public Kursbok(
            string annonsId,
            string titel,
            double prisuppgift,
            DateTime publiceringsdatum,
            string status,
            string skick,
            string isbn,
            string författare,
            string upplaga)
            : base(
                  annonsId,
                  titel,
                  prisuppgift,
                  publiceringsdatum,
                  status,
                  skick,
                  )
        {
            this.isbn = isbn;
            this.författare = författare;
            this.upplaga = upplaga;
        }

        public string GetIsbn()
        {
            return isbn;
        }

        public string GetFörfattare()
        {
            return författare;
        }

        public string GetUpplaga()
        {
            return upplaga;
        }
    }
}
