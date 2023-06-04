using Zadanie1;
using static System.Console;


Przykład3();

void Przykład3()
{
    Osoba[] osoby =
    {

        new() {
            Imię = "Juliusz",
            Nazwisko = "Cezar",
          dataUrodzenia = new (100, 7, 12),
          dataŚmierci = new (44, 3, 15)
        },
        new() {
           Imię = "Juliusz",
          dataUrodzenia = new (2000, 7, 12)
          
        },
        new() {
            Imię = "józef",
            Nazwisko = "Piłsudski",
          dataUrodzenia = new (1867, 12, 5),
          dataŚmierci = new (1935, 5, 12)
        },
        new() {
            Imię = "Maria ",
            Nazwisko = "Skłodowska-Curie",
         dataUrodzenia = new (1867, 11, 7),
         dataŚmierci = new (1934, 7, 4)
        },
        new() {
            Imię = "Stefan",
            Nazwisko = "Batory",
         dataUrodzenia = new (1533, 9, 27),
         dataŚmierci = new (1586, 12, 12)
        },
        new() {
            Imię = "Napoleon",
            Nazwisko = "Bonaparte",
          dataUrodzenia = new (1769, 8, 15),
         dataŚmierci = new (1821, 5, 5)
        }
    };

    foreach (Osoba osoba in osoby)
    {
        if (osoba.Płeć == "Kobieta")
        {
            WriteLine(osoba.Format + " żyła: "+ osoba.DługośćŻycia/365.4 + " lat");
        }
        else
        {
            WriteLine(osoba.Format + " żył: " + osoba.DługośćŻycia/365.4 + " lat");
        }
    }
}
