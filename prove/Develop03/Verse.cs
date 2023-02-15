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
            _words.Add(word);
        }
    }

    public int hideWords(int numWordsToHide)
    {
        // while (IsAllHidden())
        // {

        // }
        int numWordsHidden = 0;
        while (IsAllHidden() == false)
        {
            List <Word> notHidden = new List<Word>();
            Random rand = new Random();
            foreach (Word w in _words)
            {
                if (!w.isWordHidden())
                {
                    notHidden.Add(w);
                }
            }
            for (int i = 0; i < numWordsToHide; i++)
            {
                int hide = rand.Next(0,notHidden.Count);
                notHidden[hide].hideWord();
                notHidden.RemoveAt(hide);
                numWordsToHide--;
                numWordsHidden++;
            }
        }
        return numWordsHidden;
    }

    public bool IsAllHidden()
    {
        bool check = false;
        foreach(Word w in _words)
        {
            check = w.isWordHidden();
            if (check == false)
            {
                return check;
            }
        }
        return true;
    }
    public void Display()
    {
        // System.Console.WriteLine(_words.Count);
        foreach (Word w in _words)
        {
            w.Display();
        }
    }
}