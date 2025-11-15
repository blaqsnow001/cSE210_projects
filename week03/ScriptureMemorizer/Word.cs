public class Word
{
    private string _text;
    private bool _isHidden;
}

public hidden()
{
    isHidden = true;
}
public Show()
{
    isHidden = false;
}
public string isHidden()
{
    return _isHidden;
}
public string GetDisplayText()
{
    if (isHidden)
    {
        return"______";
    }
    else
    {
        {
            return _text;
        }
    }
}