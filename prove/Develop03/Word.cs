using System.Runtime.CompilerServices;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    public string GetWord()
    {
        if (_isHidden)
        {
            string underscores = "";
            foreach (char c in _word)
            {
                underscores += "_";
            }
            return underscores;
        }
        else
        {
            return _word;
        }
    }
}