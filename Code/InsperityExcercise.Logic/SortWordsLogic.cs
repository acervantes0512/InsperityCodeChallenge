using System;
using System.Collections.Generic;
using System.Linq;

namespace InsperityExcercise.Logic
{
    public class SortWordsLogic
    {
        /// <summary>
        /// Sort each of the input string
        /// </summary>
        /// <param name="listInputs">Unordered string list</param>
        public List<string> sortStrings(List<string> listInputs)
        {
            List<string> orderedList = new List<string>();
            foreach (string str in listInputs)
            {
                orderedList.Add(sortStringbyFrequency(str));
            }

            return orderedList;
        }

        public string sortString(string inputString)
        {
           return sortStringbyFrequency(inputString);
        }

        /// <summary>
        /// sort the input string
        /// </summary>
        /// <param name="str">unordered input string </param>
        /// <returns></returns>
        private static string sortStringbyFrequency(string str)
        {
            {
                // I used dictionaries to make access to records faster
                Dictionary<char, int> listChars = new Dictionary<char, int>();

                char[] characters = str.ToCharArray();

                foreach (char id in characters)
                {
                    if (listChars.ContainsKey(id))
                        listChars[id] = listChars[id] + 1;
                    else
                        listChars.Add(id, 1);
                }

                // The list is sorted here
                var orderedList = from x in listChars
                                  orderby x.Value descending,
                                  x.Key ascending
                                  select x;

                return buildOrderedString(orderedList);

            }
        }

        /// <summary>
        /// Build the new ordered character string
        /// </summary>
        /// <param name="orderedList">Ordered Frequency List</param>
        /// <returns></returns>
        private static string buildOrderedString(IEnumerable<KeyValuePair<char, int>> orderedList)
        {
            string newString = "";

            foreach (var val in orderedList)
            {

                for (int i = 0; i < val.Value; i++)
                {
                    newString += val.Key;
                }
            }
            return newString;
        }
    }
}
