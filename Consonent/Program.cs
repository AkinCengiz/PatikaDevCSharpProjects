namespace Consonent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kontrol edilecek cümleyi giriniz : ");
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(" ");
            char[] letters = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            bool kontrol=false;
            
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 1; j < words[i].Length; j++)
                {
                    kontrol = false;
                    if (!letters.Contains(words[i][j]))
                    {
                        if (!letters.Contains(words[i][j - 1]))
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    
                    
                }
                Console.Write(kontrol == true ? "True\t" : "False\t");

            }

            Console.WriteLine();
            
        }
    }
}