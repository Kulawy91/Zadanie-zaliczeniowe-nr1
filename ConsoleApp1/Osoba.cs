using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1;

namespace Zadanie1
{
    using static TransformacjeTekstu;
    internal class Osoba
    {
        private string
              imię,
              nazwisko;
           

        public DateTime dataŚmierci;
        public DateTime dataUrodzenia;
        public TimeSpan długośćżycia;
        public string płeć;

        public string ImięNazwisko
        {
            get {
                return string.Format(
               imię,
               nazwisko,
               płeć
               );
            }
            set
            {
                string[] rozbicie = value.Split(' ');
                Imię = rozbicie[0];
                Nazwisko = rozbicie[^1];
            }
        }
        public string Imię
        {
            get => imię;
            set =>
                imię = KapitalizujNazwęWłasną(value);
        }
        public string Nazwisko
        {
            get => nazwisko;
            set =>
                nazwisko = KapitalizujNazwęWłasną(value);
        }

        public string Płeć
        {
            get 
            {
                if (Imię.EndsWith("a"))
                {
                    string płeć = "Kobieta";
                    return płeć;
                }
                else
                {
                    string płeć = "Mężczyzna";
                    return płeć;
                }
            }
        }
        public TimeSpan DługośćŻycia
        {
            get
            {
                if (dataUrodzenia > dataŚmierci)
                {
                    TimeSpan długośćżycia = (dataUrodzenia - dataŚmierci);
                   return długośćżycia;
                }
                else
                {
                    TimeSpan długośćżycia = dataŚmierci - dataUrodzenia;
                   return długośćżycia;
                }
            }

        }
       
       
        public string Format => $"{imię},{nazwisko}";
    }
}
