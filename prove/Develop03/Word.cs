class Word{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
        // constructors dont have return types
    }
    public bool IsHidden()
    {
        return _hidden;
        // get
    }

    public void Hide()
    {
        _hidden = true;
        // set
    }
    public string GetWordString()
    {
        string returnString = "";
        if (_hidden)
        {
            for(int i = 0; i< _word.Length; i++)
            {
                returnString += '_';
            }
        }
        else
        {
            returnString = _word;
        }
        return returnString;
    }
    public void Display()
    {
        Console.Write($"{GetWordString()} ");
    }
}