

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

    public string ReturnSentence(string Sentence, string FirstWord, string SecondWord)
    {
      string result = "";
      if (Sentence.ToLower().Contains(FirstWord.ToLower()))
      {
        result = "true";
      }
      return result;
    }


  }
}


// method
// if firstWord in sentence{
//   change firstword to the secondWord
// }

