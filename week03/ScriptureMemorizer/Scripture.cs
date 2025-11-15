public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random random = new Random();
    
    public Scripture(Reference reference, string text)
{
    _reference = reference;

    // Split the text into word objects
    _words = new List<Word>();
    foreach (string wordText in text.Split(' '))
    {
        _words.Add(new Word(wordText));
    }
}
HideWordsRandomly(numberToHide)
{
    repeat numberToHide times;
    {
        // Pick a random word to hide
        int index = random.Next(0, _words.Count);
        _words[index].Hide();
    }

    if (isHidden == true)
    {
        return true;
    }
    else
    {
        return false;
    }
}
}

