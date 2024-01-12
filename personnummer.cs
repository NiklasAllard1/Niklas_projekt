namespace PersonnummerKontroll
{
    public static class PersonnummerVerifiera
    {
        public static bool Verifiera(string personnummer)
        {
            // Kontrollera att personnumret har rätt längd.
            if (personnummer.Length != 10 && personnummer.Length != 11 && personnummer.Length != 12)
            {
                return false;
            }

            // Kontrollera att alla tecken är siffror (förutom eventuell bindestreck eller plus).
            foreach (char c in personnummer)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    return false;
                }
            }

            // Om personnumret är i formatet "ÅÅMMDDXXXX" eller "ÅÅMMDD-XXXX"
            if (personnummer.Length == 10 || personnummer.Length == 12)
            {
                int year = int.Parse(personnummer.Substring(0, 2));
                int month = int.Parse(personnummer.Substring(2, 2));
                int day = int.Parse(personnummer.Substring(4, 2));

                // En enkel kontroll för året, månaden och dagen.
                if (year < 0 || month < 1 || month > 12 || day < 1 || day > 31)
                {
                    return false;
                }
            }

            // Här kan vi lägga in fler kontroller av personnummer

            return true;
        }
    }
}
