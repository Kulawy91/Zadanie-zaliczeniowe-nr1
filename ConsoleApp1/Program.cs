using Zadanie1;
using static System.Console;


Przykład3();

void Przykład3()
{
    Osoba[] osoby =
    {
        new() {
            Imię = "Noe"
        },
        new() {
            Imię = "Adam",
            //Kultura = "idk"
        },
        new() {
            Imię = "Juliusz",
            Nazwisko = "Cezar",
           // Kultura = "spqr"
        },
        new() {
            Imię = "józefa",
            Nazwisko = "Piłsudski",
           // Kultura = "pol"
        },
        new() {
            Imię = "Nobunaga",
            Nazwisko = "Oda",
           // Kultura = "jap"
        },
        new() {
            Imię = "Stefan",
            Nazwisko = "Batory",
          //  Kultura = "hun"
        },
        new() {
            Imię = "Napoleon",
            Nazwisko = "Bonaparte",
          // Kultura = "fra"
        }
    };

    foreach (Osoba osoba in osoby)
        WriteLine(osoba.Format);
}
