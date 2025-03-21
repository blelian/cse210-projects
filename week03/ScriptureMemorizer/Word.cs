public class Word
{
    private string _text;
    public bool IsHidden { get; private set; } = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public string Display()
    {
        return IsHidden ? new string('_', _text.Length) : _text;
    }
}