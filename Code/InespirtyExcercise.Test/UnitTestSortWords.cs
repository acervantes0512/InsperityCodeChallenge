using InsperityExcercise.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InespirtyExcercise.Test
{
    [TestClass]
    public class UnitTestSortWords
    {
        [TestMethod]
        public void sortListTest()
        {
            //Arrange
            SortWordsLogic objSort = new SortWordsLogic();
            List<string> inputList = new List<string>()
                                   {
                                    "wzenwebuau",
                                    "wqadfiodgs",
                                    "qakmc",
                                    "pzjim",
                                    "xqycs",
                                    "beoax",
                                    "artrtnqxcr"
                                   };

            List<string> expectedList = new List<string>()
                                   {
                                       "eeuuwwabnz",
                                       "ddafgioqsw",
                                       "ackmq",
                                       "ijmpz",
                                       "cqsxy",
                                       "abeox",
                                       "rrrttacnqx"
                                   };
            //Act
            List<string> resultList = objSort.sortStrings(inputList);
            //Assert
            Assert.IsTrue(expectedList.SequenceEqual(resultList));
        }

        [TestMethod]
        public void sortWordTest()
        {
            //Arrange
            SortWordsLogic objSort = new SortWordsLogic();
            string inputString = "artrtnqxcr";

            string expectedString = "rrrttacnqx";
            //Act
            string resultString = objSort.sortString(inputString);
            //Assert
            Assert.AreEqual(resultString,expectedString);
        }
    }
}
