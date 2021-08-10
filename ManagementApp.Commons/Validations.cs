using System.Text.RegularExpressions;

namespace ManagementApp.Commons
{
    public class Validations
    {

        public static bool IsEmailValid(string email)
        {
            if (!Regex.IsMatch(email, @"^[^@\s\.]+@[^@\s]+\.[^@\s]+$"))
            {
                return false;
            }
            return true;
        }
        public static bool checkPassword(string input, int minimum)
        {
            bool hasNum = false;
            // bool hasCap = false;
            bool hasLow = false;
            bool hasSpec = false;
            char currentCharacter;

            if (!(input.Length >= minimum))
            {
                return false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                currentCharacter = input[i];
                if (char.IsDigit(currentCharacter))
                {
                    hasNum = true;
                }
                // else if (char.IsUpper(currentCharacter))
                // {
                //     hasCap = true;
                // }
                else if (char.IsLower(currentCharacter))
                {
                    hasLow = true;
                }
                else if (char.IsLetterOrDigit(currentCharacter))
                {
                    hasSpec = true;
                }
                else if (hasNum && hasLow && hasSpec)
                {
                    return true;
                }

            }
            return false;

        }
    

        public static string CleanName(string name)
        {
            var firstChar = (int)name[0];
            if (!double.IsNaN(firstChar))
            {
                if (firstChar >= 65 && firstChar <= 92)
                {
                    return name;
                }
                else if (firstChar >= 97 && firstChar <= 122)
                {
                    return name.ToUpper()[0] + name.Substring(1);
                }

            }
            while (int.TryParse(name[0].ToString(), out int _))
            {
                name = name.Substring(1);
            }
            return CleanName(name);

        }
        public static int IsvalidInput(string data)
        {
            bool isValid = int.TryParse(data, out int value);
            if (!isValid)
            {
                return -1;
            }
            else if (value < 0 || value > 5)
            {
                return -1;
            }
            else
                return value;


        }
    }
    
    
}