namespace Zadanie1
{
    internal static class TransformacjeTekstu
    {
        private const string
            Łącznik = "-",
            Spacja = " "
            ;

        public static string KapitalizujNazwęWłasną(string nazwa)
        {
            string[] rozbicieGłówne = nazwa.Trim().Split(Spacja);
            for (int ig = 0; ig < rozbicieGłówne.Length; ig++)
            {
                string[] rozbiciePoboczne
                    = rozbicieGłówne[ig].Split(Łącznik);
                for (int ip = 0; ip < rozbiciePoboczne.Length; ip++)
                    rozbiciePoboczne[ip] = KapitalizujPierwsząLiterę(
                        rozbiciePoboczne[ip]
                        );
                rozbicieGłówne[ig] = string.Join(Łącznik, rozbiciePoboczne);
            }
            return string.Join(Spacja, rozbicieGłówne);
        }

        public static string KapitalizujPierwsząLiterę(string wyraz)
        {
            wyraz = wyraz.Trim();
            if (wyraz.Length == 0)
                return "";
            string
                pierwsza = wyraz.Substring(0, 1).ToUpper(),
                reszta = wyraz.Substring(1).ToLower()
                ;
            return pierwsza + reszta;
        }
    }
}