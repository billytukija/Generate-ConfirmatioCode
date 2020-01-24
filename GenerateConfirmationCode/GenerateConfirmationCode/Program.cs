using System;

namespace GenerateConfirmationCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your code is : " + GenerateConfirmationCode());
        }

        public static string GenerateConfirmationCode()
        {
            const int size = 4;

            var confirmationCode = string.Empty;

            var random = new Random();

            for (var digit = 0; digit < size; digit++)
            {
                var value = Convert.ToInt32(random.Next(48, 122));

                if ((value >= 48 && value <= 57) || (value >= 97 && value <= 122))
                {
                    var _char = ((char)value);

                    if (!confirmationCode.Contains(_char))
                        confirmationCode += _char;
                    else
                        digit--;
                }
                else
                    digit--;
            }

            return confirmationCode.ToUpper();
        }
    }
}
