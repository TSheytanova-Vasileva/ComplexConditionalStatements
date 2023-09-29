namespace VowelorConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine(); 

            if (letter == "A" || letter == "a" || letter == "i" || letter == "I" || letter == "o" || letter == "O" ||
                letter == "U" || letter == "u" || letter == "e" || letter == "E")
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }
    }
}
