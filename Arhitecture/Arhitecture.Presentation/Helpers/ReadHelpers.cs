using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arhitecture.Presentation.Helpers
{
    public static class ReadHelpers
    {
        public static bool TryReadLineIfNotEmpty(out string readValue)
        {
            var readLine = Console.ReadLine();
            if (string.IsNullOrEmpty(readLine))
            {
                readValue = null;
                return false;
            }

            readValue = readLine;
            return true;
        }

        public static bool TryReadNumber(out int number)
        {
            var isNumber = int.TryParse(Console.ReadLine(), out var numberRead);
            if (!isNumber)
            {
                Console.WriteLine("Error not number");
                Thread.Sleep(1000);
                Console.Clear();
                number = 0;
                return false;
            }

            number = numberRead;
            return true;
        }

        public static bool TryReadNumberBetween1And3(out int number)
        {
            var isNumber = int.TryParse(Console.ReadLine(), out var numberRead);
            if (!isNumber)
            {
                Console.WriteLine("Error not number");
                Thread.Sleep(1000);
                Console.Clear();
                number = 0;
                return false;
            }
            if (numberRead < 1 || numberRead > 4)
            {
                number = 0;
                return false;
            }

            number = numberRead;
            return true;
        }
    }
}
