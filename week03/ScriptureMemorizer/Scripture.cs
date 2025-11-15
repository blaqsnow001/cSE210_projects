using System;
using System.Collections.Generic;
using System.Linq;

// Represents a complete scripture with reference and text
class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        // Split the text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }
    
    // Hides a specified number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;
        
        // Get list of words that are not yet hidden
        List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        
        // Hide random words from visible words only
        while (wordsHidden < numberToHide && visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            wordsHidden++;
        }
    }
    
    // Returns formatted scripture text with reference
    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        
        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }
        
        return result.Trim();
    }
    
    // Checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}