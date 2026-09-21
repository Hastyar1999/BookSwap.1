using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
{
    public abstract class Annons
    {
        private string annonsId;
        private string titel;
        private double prisuppgift;
        private DateTime publiceringsdatum;
        private string status;
        private string skick;

     

        public Annons(
            string annonsId,
            string titel,
            double prisuppgift,
            DateTime publiceringsdatum,
            string status,
            string skick)
        {
            this.annonsId = annonsId;
            this.titel = titel;
            this.prisuppgift = prisuppgift;
            this.publiceringsdatum = publiceringsdatum;
            this.status = status;
            this.skick = skick;
        }

        public string GetAnnonsId()
        {
            return annonsId;
        }

        public string GetTitel()
        {
            return titel;
        }

        public double GetPrisuppgift()
        {
            return prisuppgift;
        }

        public DateTime GetPubliceringsdatum()
        {
            return publiceringsdatum;
        }

        public string GetStatus()
        {
            return status;
        }

        public void SetStatus(string status)
        {
            this.status = status;
        }

        public string GetSkick()
        {
            return skick;
        }

    }
}
