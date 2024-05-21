using System;

public partial class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("1 Nephi 3:7");
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        while (!scripture.AllWordsHidden())
        {
            scripture.Display();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else
            {
                scripture.HideRandomWords();
                Console.Clear();
            }
        }
        Console.WriteLine("Program ended.");
    }
}