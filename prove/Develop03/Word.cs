class Word
{
    private String _text = "";
    public Word(String text)
    {
        _text = text;
    }

    public void Display()
    {
        System.Console.WriteLine(_text);
    }
}