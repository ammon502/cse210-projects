class Verse
{
    private List<Word> _words = new List<Word>();
    public Verse(String Verse)
    {
        char[] delimiterChars = {' ', ',', '.', ':', '\t'};
        string[] words = Verse.Split(delimiterChars);
        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
        }
    }
    public void Display()
    {
        foreach (Word w in _words)
        {
            w.Display();
        }
    }
}