public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "___" : _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }
}
