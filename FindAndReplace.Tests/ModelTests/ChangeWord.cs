using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindAndReplace.Models;

namespace FindAndReplace.Tests
{
  [TestClass]
  public class ChangeWordTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   ChangeWord.ClearAll();
    // }

    [TestMethod]
    public void ChangeWordConstructor_CreatesInstanceOfChangeWord_ChangeWord()
    {
      ChangeWord newList = new ChangeWord("Hello World", "world", "universe");
      Assert.AreEqual(typeof(ChangeWord), newList.GetType());
    }

    [TestMethod]
    public void GetSentence_ReturnsSentence_String()
    {
      string sentence = "Hello World";
      ChangeWord newList = new ChangeWord("Hello World", "world", "universe");
      string result = newList.Sentence; 
      Assert.AreEqual(sentence, result);
    }

    [TestMethod]
    public void SetSentence_ReturnsSentence_String()
    {
      //Arrange
      ChangeWord newList = new ChangeWord("Hello World", "world", "universe");
      string updatedSentence = "Goodbye World";
      //Act
      newList.Sentence=updatedSentence;
      string result = newList.Sentence;
      //Check 
      Assert.AreEqual(updatedSentence, result);
    }
  }
}




