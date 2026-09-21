using System;
using System.Collections.Generic;
using System.Text;

namespace BookSwap
{
    public class Användare
    {
        private string användarId;
        private string förnamn;
        private string efternamn;
        private string ePost;
        private string telefonnummer;

        public Användare(
            string användarId,
            string förnamn,
            string efternamn,
            string ePost,
            string telefonnummer)
        {
            this.användarId = användarId;
            this.förnamn = förnamn;
            this.efternamn = efternamn;
            this.ePost = ePost;
            this.telefonnummer = telefonnummer;
        }

        public string GetAnvändarId()
        {
            return användarId;
        }

        public string GetFörnamn()
        {
            return förnamn;
        }

        public string GetEfternamn()
        {
            return efternamn;
        }

        public string GetEPost()
        {
            return ePost;
        }

        public string GetTelefonnummer()
        {
            return telefonnummer;
        }
    }
}
