namespace PeopleListing
{
    public class CheckPESEL
    {
        public static bool ValidCheck(string pesel)
        {
            if (pesel.Length != 11) return false;

            int[] validationConstants = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int validatingNumber = int.Parse(pesel[10].ToString());
            int sum = 0;
            
            for (int i = 9; i >= 0; i--)
            {
                int iloczyn = int.Parse(pesel[i].ToString()) * validationConstants[i];

                while (iloczyn >= 10) iloczyn = iloczyn % 10;

                sum += iloczyn;
            }
            
            while (sum >= 10) sum = sum % 10;

            if ((10 - sum) == validatingNumber) return true;
            else return false;
        }

        public static bool CorrectSex(string pesel, string name)
        {
            int sexSymbol = int.Parse(pesel[9].ToString());
            char characterToCheck = name[name.Length - 1];

            if ((sexSymbol % 2 == 0 && characterToCheck != 'a') || (sexSymbol % 2 != 0 && characterToCheck == 'a'))
                return false;
            else
                return true;
        }
    }
}