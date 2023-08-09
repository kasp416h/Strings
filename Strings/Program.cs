namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(AddSeparator("chocolate", "-"));

            Console.WriteLine(IsPalindrome("hannah"));

            Console.WriteLine(LengthOfAString("computer"));

            Console.WriteLine(StringInReverseOrder("oe93 kr"));

            Console.WriteLine(NumberOfWords("OK"));

            Console.WriteLine(RevertWordsOrder("A, B. C"));

            Console.WriteLine(HowManyOccurrences("nicht", "do"));

            Console.WriteLine(SortCharactersDescending("fohjwf42os"));

            Console.WriteLine(CompressString("p555ppp7www"));
        }

        static string AddSeparator(string input, string separator) 
        {
            char[] chars = input.ToCharArray();
            return string.Join(separator, chars);
        }

        static bool IsPalindrome(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string charString = new String(chars);
            if (charString == input)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static int LengthOfAString(string input)
        {
            int inputLength = 0;
            foreach (char letter in input)
            {
                inputLength++;
            }

            return inputLength;
        }

        static string StringInReverseOrder(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            string charString = new String(chars);
            return charString;
        }

        static int NumberOfWords(string input)
        {
            string[] items = input.Split(" ");
            return items.Length;
        }

        static string RevertWordsOrder(string input)
        {
            string[] items = input.Split(" ");
            Array.Reverse(items);
            return string.Join(" ", items);
        }

        static int HowManyOccurrences(string input, string seperator)
        {
            string[] items = input.Split(seperator);
            return items.Length - 1;
        }

        static char[] SortCharactersDescending(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Sort(chars);
            Array.Reverse(chars);
            return chars;
        }

        static string CompressString(string input)
        {
            int freq = 0;
            char last = input[0];
            string newString = "";

            foreach (char s in input)
            {
                if (s == last)
                {
                    freq++;
                }
                else
                {
                    newString += last.ToString() + freq;
                    last = s;
                    freq = 1;
                }
            }
            newString += last.ToString() + freq;
            return newString;
        }
    }
}