namespace CharacterChanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Karakterleri değiştirilecek cümleyi yazınız...");
            string sentence = Console.ReadLine();
            
            string[] words = sentence.Split(" ");
            string word;
            char[] letters;
            sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                letters = new char[word.Length];
                for (int j = 0; j < word.Length; j++)
                {
                    letters[j] = word[j];
                }

                char gecici = letters[0];
                letters[0] = letters[letters.Length - 1];
                letters[letters.Length - 1] = gecici;
                word = "";
                foreach (char ch in letters)
                {
                    word += ch;
                }
                if (sentence.Length == 0)
                {
                    sentence = word + " ";
                }
                else
                {
                    sentence += word + " ";
                }
            }

            Console.WriteLine(sentence);
        }
    }
}