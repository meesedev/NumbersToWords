using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords.Core
{
    public class NumberToWordsConverter
    {

        // Words for numbers 0 through 19
        private static readonly string[] UnitsBelow20 =
        {
            "Zero", "One", "Two", "Three", "Four", "Five", "Six","Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve","Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen","Eighteen", "Nineteen"
        };

        // Words for tens multiples (20, 30, ..., 90)
        private static readonly string[] Tens =
        {
            "", "", "Twenty", "Thirty", "Forty", "Fifty","Sixty", "Seventy", "Eighty", "Ninety"
        };

        // Convert a numeric string (e.g. "42.66") to words (e.g. "Forty-Two point Sixty Six")
        public static string Convert(string numberInput)
        {
            // Return empty if input is empty
            if (string.IsNullOrWhiteSpace(numberInput)) return "";

            // Try to parse the input string into a decimal
            if (!decimal.TryParse(numberInput, out decimal number))
                return "Invalid number";
            
            // Validate number is within supported range
            if (number < 0 || number > 9999.99m)
                return "Number out of range";


            // Split the number into whole and decimal
            string[] splitNumber = numberInput.Split('.');
            if (!int.TryParse(splitNumber[0], out int wholeNumber))
                return "Invalid whole part";

            // Convert the whole number to words
            string englishWords = ConvertWholeNumber(wholeNumber);

            // If there is a decimal, process it
            if (splitNumber.Length > 1)
            {
                string decimalNumber= splitNumber[1].Trim();

                // Limit decimal part to 2 digits
                if (decimalNumber.Length > 2)
                    return "Too many decimal places";

                englishWords += " point";

                if (decimalNumber.Length == 1)
                {
                    // Single-digit decimal (.4 equates "point Four")
                    englishWords += " " + UnitsBelow20[int.Parse(decimalNumber)];
                }
                else if (decimalNumber.Length == 2)
                {
                    // Decimal starts with 0 (.04 equates "point Zero Four")                        
                    foreach (char digit in decimalNumber)
                        englishWords += " " + UnitsBelow20[int.Parse(digit.ToString())];
                }
            }

            return englishWords;
        }


        //Convert an integer (0–9999) into Words
        private static string ConvertWholeNumber(int number)
        {
            if (number < 20)
                return UnitsBelow20[number]; // for numbers < 20
            else if (number < 100)
                return Tens[number / 10] + (number % 10 > 0 ? "-" + UnitsBelow20[number % 10] : ""); // 42 equates Forty-Two
            else if (number < 1000)
                return UnitsBelow20[number / 100] + " hundred" + (number % 100 > 0 ? " and " + ConvertWholeNumber(number % 100) : ""); // 342 equates Three hundred and Forty-Two
            else if (number <= 9999)
                return UnitsBelow20[number / 1000] + " thousand" + (number % 1000 > 0 ? (number % 1000 < 100 ? " and " : " ") + ConvertWholeNumber(number % 1000) : ""); // 2345 equates Two thousand Three hundred and Forty-Five
            else
                return "Out of range";
        }
    }
}
