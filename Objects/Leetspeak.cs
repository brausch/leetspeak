namespace Leetspeak
{
  public class Leetspeak
  {
    private string _words;
    public Leetspeak (string words)
    {
      _words = words;
    }
    public string GetWords()
    {
      return _words;
    }
    public void SetWords(string newWords)
    {
      _words = newWords;
    }
    public string IsLeetspeak()
    {
      char[] array = _words.ToCharArray();

      for(int i = 0;i<array.Length; i++){
        if(array[i] == 'e' || array[i] == 'E' )
        {
          array[i] = '3';
        }
        else if(array[i] == 'o' || array[i] == 'O' )
        {
          array[i] = '0';
        }
        else if(array[i] == 'i')
        {
          array[i] = '1';
        }
        else if(i !=0 && array[i-1] != ' ' && array[i] == 's' || i == 0)
        {
          array[i] = 'z';
        }
      }
      string result = string.Join("", array);
      return result;
    }
  }
}
