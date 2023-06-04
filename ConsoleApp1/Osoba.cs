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
        //  private const string

        // formatImięNazwisko = "{0} {1}";
        /*
                private readonly static Dictionary<string, string>
                    formatPełnegoImienia = new()
                    {
                        ["Kobieta"] = formatImięNazwisko,
                        ["Mężczyzna"] = formatImięNazwisko,
                    };

        */
        /*    static Osoba()
            {
                foreach (string płeć in Płeć)
                    if (!formatPełnegoImienia.ContainsKey(kultura))
                        formatPełnegoImienia[kultura] = formatDomyślny;
            }
        */
        private string
            imię,
            nazwisko,
            płeć;



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
        public string Format => $"{imię},{nazwisko},{Płeć}";
    }
}
