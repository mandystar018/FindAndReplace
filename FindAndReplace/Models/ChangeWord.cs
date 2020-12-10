

namespace FindAndReplace.Models
{
  public class ChangeWord
  {
    public string Sentence { get; set; }
    public string FirstWord { get; set; }
    public string SecondWord { get; set; }
    
    public ChangeWord(string sentence, string firstWord, string secondWord)
    {
      Sentence = sentence; 
      FirstWord = firstWord;
      SecondWord = secondWord;
    }
  }
}


    
