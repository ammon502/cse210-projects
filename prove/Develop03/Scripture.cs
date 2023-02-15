class Scripture
{
    private List<Verse> _verses = new List<Verse>();
    private string refName = "Proverbs 3:5-6";
    public Scripture(List<string> verses)
    {
        foreach (string verseStr in verses)
        {
            Verse newVerse = new Verse(verseStr);
            _verses.Add(newVerse);
            newVerse.Display();
        }
    }
    public void HideWords(int count)
    {
        Random rand = new Random();
        int numWordsToHide = rand.Next(0,count);
        int numTimesRun = 0;
        while (count > 0 && numTimesRun < 100)
        {
            foreach (Verse v in _verses)
            {
                int x = v.hideWords(numWordsToHide);
                count -= numWordsToHide - x;
                numTimesRun++; //making sure its not infinity, figure 100 is a good num to check with
            }
        }
    }
    public bool IsAllHidden()
    {
        // System.Console.WriteLine("hi\n");
        foreach(Verse v in _verses)
        {
            if (v.IsAllHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
    public void Display()
    {
        System.Console.Write($"{refName} ");
        // System.Console.WriteLine(_verses.Count);
        foreach (Verse v in _verses)
        {
            v.Display();
        }
    }
}