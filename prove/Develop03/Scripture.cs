class Scripture
{
    private List<Verse> _verses = new List<Verse>();

    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse _verses = new Verse(verseStr);
        }
    }
    public bool HideWords(int count)
    {
        return true;
    }
    public bool IsAllHiddeN()
    {
        /*skdjskdjskj*/
        return true;
    }
    public void Display()
    {
        foreach (Verse v in _verses)
        {
            v.Display();
        }
    }
}