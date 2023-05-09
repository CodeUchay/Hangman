using System.Collections;

namespace HangMann
{
    internal class Class1
    {

        static void Main(string[] args)
        {
            Char[] word = { 'a', 'p', 'p', 'l', 'e' };
            Char[] guessed_word = { '*', '*', '*', '*', '*' };
            int num_of_tries = 5;
            ArrayList entered_letters = new ArrayList();

            do
            {
            label: Console.WriteLine("guess => " + StringOf(guessed_word));
                Console.WriteLine("number of tries left is " + num_of_tries);
                Char letter = Char.Parse(Console.ReadLine());


                if (entered_letters.Contains(letter))
                {
                    Console.WriteLine("'" + letter + "' has already been proposed");
                    goto label;
                }
                else
                {
                    entered_letters.Add(letter);


                    if (word.Contains(letter))
                    {
                        replaceChar(word, guessed_word, letter);

                    }
                    else
                    {
                        num_of_tries--;
                    }
                }

                if (isEqual(word, guessed_word))
                {
                    Console.WriteLine("You WON !!");
                    break;
                }
            } while (num_of_tries > 0);
            Console.WriteLine("You Are out of Tries!!");
        }

        private static string StringOf(char[] guessed_word)
        {
            String result = "";
            for (int i = 0; i < guessed_word.Length; i++)
            {
                result = result + guessed_word[i];
            }
            return result;
        }

        private static void replaceChar(char[] real_word, char[] guessed, Char guessed_letter)
        {

            for (int i = 0; i < real_word.Length; i++)
            {
                if (real_word[i] == guessed_letter)
                {
                    guessed[i] = guessed_letter;

                }

            }
        }
        private static Boolean isEqual(char[] real_word, char[] guessed)
        {
            for (int i = 0; i < real_word.Length; i++)
            {
                if (real_word[i] != guessed[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
