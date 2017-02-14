using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoundationsMastery;

namespace FoundationsMasteryTests
{
    [TestClass]
    public class CustomStringTests
    {
        [TestMethod]
        public void EnsureICanCreateAnInstance()
        {
            CustomString customString = new CustomString();

            Assert.IsNotNull(customString);
        }

        [TestMethod]
        public void EnsureICanPassInACharEnumerable()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            int expected_length = 3;
            int actual_length = myString.GetMyChars().Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureIHaveContents()
        {
            char[] mychars = new char[] { 'a', 'b', 'c' };
            CustomString myString = new CustomString(mychars);

            // 1. Assert that the Contents property is the correct 'type'
            var actualType = myString.ConvertMyCharsToString().GetType();
            Assert.AreEqual(actualType, typeof(string));

            // 2. Assert that the returned Contents is the coorect length
            int expected_length = 3;
            int actual_length = myString.ConvertMyCharsToString().Length;

            Assert.AreEqual(expected_length, actual_length);
        }

        [TestMethod]
        public void EnsureClearAlwaysSetsEmptyContents()
        {
            CustomString myString = new CustomString();

            myString.Clear();

            // How do you ensure your clear function works?
            var deals = myString.GetMyChars();
            Assert.IsNull(myString.GetMyChars());
        }
    }
}
