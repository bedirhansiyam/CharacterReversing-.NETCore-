namespace CharacterReversing;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a word : ");

        string word = Console.ReadLine();
        char firstLetter = word[0];
        string newWord = word.Remove(0,1);
        newWord = newWord + firstLetter;

        Console.WriteLine(newWord);
    }
}
