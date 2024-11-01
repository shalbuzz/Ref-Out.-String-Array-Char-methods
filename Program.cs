namespace Ref__Out._String__Array__Char_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "   Hello World!   ";
            Console.WriteLine(ReplaceString(text, "World", "hi"));
            Console.WriteLine(TrimString(text));
            Console.WriteLine(SubStringCustom("helloworld", 3, 6));
            Console.WriteLine(ValidatePassword("A1234567!"));

        }



        static string ReplaceString(string original, string oldValue, string newValue)
        {
            if (oldValue == "") return original;

            string result = "";
            int i = 0;

            while (i <= original.Length - oldValue.Length)
            {

                bool match = true;

                for (int j = 0; j < oldValue.Length; j++)
                {

                    if (original[i + j] != oldValue[j])
                    {

                        match = false;
                        break;
                    }

                }

                if (match)
                {

                    result += newValue;
                    i += oldValue.Length;
                }

                else
                {
                    result += original[i];
                    i++;

                }




            }

            while (i < original.Length) { result += original[i]; i++; }
            return result;

        }


        static string TrimString(string word)
        {
            int start = 0;
            int end = word.Length - 1;

            while (start <= end && (word[start] == ' ' || word[start] == '\t' || word[start] == '\n' || word[start] == '\r'))
            {

                start++;

            }

            while (end >= start && (word[end] == ' ' || word[end] == '\t' || word[end] == '\n' || word[end] == '\r'))
            {

                end--;
            }

            if (start > end)
            {
                return "";
            }

            string result = "";

            for (int i = start; i <= end; i++)
            {

                result += word[i];

            }

            return result;
        }

        static string SubStringCustom(string word, int count, int length)
        {

            if (count < 0 || count + length > word.Length || length < 0)
            {
                Console.WriteLine("Wrong");
            }
            string result = "";


            for (int i = 0; i < length; i++)
            {

                result += word[count + i];
            }
            return result;
        }


        static bool ValidatePassword(string password)
        {


            if (password.Length < 8)
            {
                return false;
            }


            if (!char.IsUpper(password[0]))
            {
                return false;
            }


            bool hasDigit = false;
            bool hasSpecialChar = false;

            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (!char.IsLetterOrDigit(c))
                {
                    hasSpecialChar = true;
                }


                if (hasDigit && hasSpecialChar)
                {
                    break;
                }
            }

            return hasDigit && hasSpecialChar;
        }

    }
    }
