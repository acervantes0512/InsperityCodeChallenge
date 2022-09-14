using InsperityExcercise.Logic;
using System;
using System.Collections.Generic;

namespace InsperityExcercise.Main
{
    public class Program
    {

        static void Main(string[] args)
        {
            bool exitFlag = false;

            while (!exitFlag)
            {
                Console.WriteLine("Choose an Option:");
                Console.WriteLine("   1 - Sort a List\n   2 - Sort a Word");
                int selectedOption = int.Parse(Console.ReadLine());

                switch (selectedOption)
                {
                    case 1:
                        //You can modify inputs here
                        List<string> listInput = new List<string>()
                                   {
                                    "wzenwebuau",
                                    "wqadfiodgs",
                                    "qakmc",
                                    "pzjim",
                                    "xqycs",
                                    "beoax",
                                    "artrtnqxcr"
                                   };
                        sortList(listInput);
                        exitFlag = true;
                        break;
                    case 2:
                        Console.WriteLine("Write the unordered word:");
                        string word = Console.ReadLine();
                        sortWord(word);
                        exitFlag = true;
                        break;
                    default:
                        exitFlag = false;
                        break;

                }
            }
   
        }

        /// <summary>
        /// Sort the List
        /// </summary>
        /// <param name="listInput">Unordered List</param>
        private static void sortList(List<string> listInput)
        {
            SortWordsLogic objSortWords = new SortWordsLogic();
            List<string> orderedList = objSortWords.sortStrings(listInput);

            Console.WriteLine("* Unordered List");
            foreach (string strInput in listInput)
            {
                
                Console.WriteLine("   "+strInput);
            }

            Console.WriteLine("* Ordered List");
            foreach (string str in orderedList)
            {                
                Console.WriteLine("   "+str);
            }
            
            Console.ReadLine();
        }

        /// <summary>
        /// Sort the received string
        /// </summary>
        /// <param name="stringInput">Unordered Word</param>
        private static void sortWord(string stringInput)
        {
            SortWordsLogic objSortWords = new SortWordsLogic();
            Console.WriteLine($"   Unordered Word: {stringInput} \n   Ordered Word:{objSortWords.sortString(stringInput)}");
            Console.ReadLine();
        }


    }
}
