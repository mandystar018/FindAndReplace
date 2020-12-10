using System.Collections.Generic;

namespace FindAndReplace.Models
{
  public class ChangeWord
  {
    public string Sentence { get; set; }
    public string FirstWord { get; set; }
    public string SecondWord { get; set; }
    
    private static List<ChangeWord> _requestList = new List<ChangeWord> {};
    public ChangeWord(string sentence, string firstWord, string secondWord)
    {
      Sentence = sentence; 
      FirstWord = firstWord;
      SecondWord = secondWord;
      _requestList.Add(this);
    }
  }
}
// public Item(string description, int priority)
    //   : this(description)
    // {
    //   Priority = priority;
    // }

    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
