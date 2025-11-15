using System;

// Represents a single word in the scripture
class Word
{
    private string _text;
    private bool _isHidden;
    
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    
    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }
    
    // Checks if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }
    
    // Returns display text (either the word or underscores)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}