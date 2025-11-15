public class Reference;
{
    private string _book;
    private int _chapter;
    private int _verse ;
    private int _endVerse;
}

Reference(book string , chapter int , verse int)
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = verse;
}

Reference(book string , chapter int , verse int , endVerse int)
{
    _book = book;
    _chapter = chapter;
    _verse = verse;
    _endVerse = endverse;
}

public string GetDisplayText()
{
    if (_verse == _endVerse)
        return $"{_book} {_chapter}:{verse}";
    else
    {
        return $"{_book} {_chapter}:{verse} - {_endVerse}";
    }

}
