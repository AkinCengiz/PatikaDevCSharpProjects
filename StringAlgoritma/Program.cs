using System.Runtime.InteropServices;

namespace StringAlgoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            int number;
            Console.WriteLine("Kelimeyi girerek enter tuşuna basınız, ardından kelimeden çıkarılacak karakterin indeks numarasını girerek enter tuşuna basınız.");
            word = Console.ReadLine();
            word += "," + Console.ReadLine();
            Console.WriteLine(word);
            string[] wordList = word.Split(',');
            word = wordList[0];
            number = Convert.ToInt32(wordList[1]);
            Console.WriteLine("Kelime : {0}\nSayı   : {1}",word,number);
            word = word.Remove(number, 1);
            Console.WriteLine(word);
        }
    }
}