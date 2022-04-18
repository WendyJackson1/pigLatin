
public class Program
{

    static void Main(string[] args)
    {
        bool runAgain = true;
        while (runAgain)
        {
            string sentance = "";
            Console.WriteLine("Enter a sentence to convert to PigLatin:");
            string txtEnglish = Console.ReadLine().ToLower().Trim();
            string[] words = txtEnglish.Split(' ');

            foreach (string word in words)
            {
                string firstLetter = word.Substring(0, 1);
                bool isVowel = "aeiou".IndexOf(firstLetter) >= 0;
                if (isVowel)
                {
                    sentance += word + "way";

                }
                else
                {
                    string wordWithOutFristLetter  = word.Substring(1, word.Length - 1);
                   sentance += wordWithOutFristLetter + firstLetter + "ay";
                }
                sentance += " ";
            }
            Console.WriteLine(sentance);
            runAgain = RunAgain();
        }
    }
    public static bool RunAgain()
    {
        Console.WriteLine("would you like to translate more? y/n");
        string userRepsonse = Console.ReadLine().ToLower();

        if (userRepsonse == "y")
        {
            return true;
        }
        else
        {
            Console.WriteLine("Have a great day! Good bye!");
            return false;
        }
    }
}



