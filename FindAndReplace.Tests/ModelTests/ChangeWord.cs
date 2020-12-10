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
      ChangeWord newList = new ChangeWord("Hello World", "word", "universe");
      Assert.AreEqual(typeof(ChangeWord), newList.GetType());
    }
  }
}



