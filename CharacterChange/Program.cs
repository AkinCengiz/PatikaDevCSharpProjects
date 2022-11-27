namespace CharacterChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle yazınız : ");
            string sentence = Console.ReadLine();
            Console.WriteLine(sentence);

            string[] words = sentence.Split(' ');
            string word;
            char[] letters;
            string newSentence="";

            for (int i = 0; i < words.Length; i++)
            {
                word = words[i];
                letters = new char[word.Length];
                
                for (int j = 0; j < word.Length; j++)
                {
                   letters[j] = word[j];
                }

                for (int k = 1; k < letters.Length; k++)
                {
                    char gecici = letters[k - 1];
                    letters[k - 1] = letters[k];
                    letters[k] = gecici;
                }

                if (newSentence.Length == 0)
                {
                    newSentence = new string(letters);
                }
                else
                {
                    newSentence += " " + new string(letters);
                }
            }
            Console.WriteLine(newSentence);
        }
    }
}