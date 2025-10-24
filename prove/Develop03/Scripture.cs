using System.Data.SqlTypes;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, List<Word> words)
    {
        _words = words;
        _reference = reference;
    }

    public void Display()
    {
        Console.Write(_reference.GetReference());
        foreach (Word word in _words)
        {
            Console.Write($" {word.GetWord()}");
        }
    }
    public void HideWords()
    {
        Random rand = new Random();
        List<Word> shownWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.GetIsHidden() == false)
            {
                shownWords.Add(word);
            }
        }

        for (int i = 0; i < 3; i++)
        {
            if (shownWords.Count() > 0)
            {
                int randomIndex = rand.Next(shownWords.Count());
                shownWords[randomIndex].HideWord();      
            }
            else
            {
                break;
            }
        }
    }
}