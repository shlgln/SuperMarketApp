using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class ListOfRenge
    {
        public void ExtendedListOfRange()
        {
            string input = "1-2,4-8,6-10";
            List<string[]> Ranges = ExtendedRangh(RemoveSpace(input));
            for (int i = 0; i < Ranges.Count; i++)
            {
                string[] newArray = Ranges[i];
                foreach (var item in newArray)
                {
                    string[] LatestList = item.Split('-');
                    Console.WriteLine(LatestList[0] + " " + LatestList[1]);
                }
            }
            Console.ReadLine();
        }

        private List<string[]> ExtendedRangh(string input)
        {
            string[] anArray = input.Split(',');
            List<string[]> listArray = new List<string[]>();
            for (int i = 0; i < anArray.Length; i++)
            {
                listArray.Add(anArray[i].Split(' '));
            }
            return listArray;
        }

        private string RemoveSpace(string input)
        {
            return input.Replace(" ", "");
        }

    }
}
