using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class ChangeWordTests
  {
    [TestMethod]
    public void ChangeWordConstructor_CreatesInstanceOfChangeWord_ChangeWord()
    {
      ChangeWord newRequest = new ChangeWord("Hello World", "world", "universe");
      Assert.AreEqual(typeof(ChangeWord), newRequest.GetType());
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string sentence = "Hello World";
      ChangeWord newRequest = new ChangeWord("Hello World", "world", "universe");
      string result = newRequest.Sentence;
      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void SetSentence_ReturnsSentence_String()
    {
      //Arrange
      ChangeWord newRequest = new ChangeWord("Hello World", "world", "universe");
      string updatedSentence = "Goodbye World";
      //Act
      newRequest.Sentence = updatedSentence;
      string result = newRequest.Sentence;
      //Check 
      Assert.AreEqual(updatedSentence, result);
    }

    [TestMethod]
    public void ReturnSentece_ContainsWord_String()
    { 
      //Arrange
      string sentence="Hello World";
      string firstWord="world";
      string secondWord="universe";   
      ChangeWord newRequest = new ChangeWord(sentence, firstWord, secondWord);
      //Act
      string result= newRequest.ReturnSentence(sentence, firstWord, secondWord);
      //Check
      Assert.AreEqual("true", result);
      
      
    }
  }
}