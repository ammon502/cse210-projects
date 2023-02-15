class Word
{
    private String _text = "";
    private bool isHidden = false;
    public Word(String text)
    {
        _text = text;
    }
    public bool isWordHidden()
    {
        return isHidden;
    }
    public void hideWord()
    {
        isHidden = true;
    }
    public void Display()
    {
        if (isHidden == false)
        {
            System.Console.Write($"{_text}");
        }
        else
        {
            foreach (char c in _text)
            {
                System.Console.Write("_");
            }
        }
        System.Console.Write(" ");
    }
}