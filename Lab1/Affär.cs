using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Student : Användare
    {
        public Student(
            string användarId,
            string förnamn,
            string efternamn,
            string ePost,
            string telefonnummer)
            : base(
                  användarId,
                  förnamn,
                  efternamn,
                  ePost,
                  telefonnummer)
        {
        }
    }
}
