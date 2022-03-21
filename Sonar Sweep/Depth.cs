using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sonar_Sweep
{
    public class Depth
    {
        public static List<int> depthsList = new List<int>();


        public static void FirstDayMethods()
        {
            GetAllDepths();
            GetIncreasedDepth();
            CountThreeIncreasedMeasurementDepth();
            Console.ReadLine();
        }

        //read all depths from text file to a list.
        public static void GetAllDepths()
        {
            depthsList = File.ReadAllLines(@"E:\input.txt").Select(x => int.Parse(x)).ToList();
        }

        #region Prat1

        //Calculate How Many Times Depths Had Been Increased!
        public static int GetIncreasedDepth()
        {
            int counter = 0;

            for (int i = 1; i < depthsList.Count(); i++)
            {
                if (depthsList[i] > depthsList[i - 1])
                {
                    counter++;
                }

            }

            Console.WriteLine(counter + " Times height has been increased!");
            return counter;
        }

        #endregion


        #region Prat2

        public static int CountThreeIncreasedMeasurementDepth()
        {
            int previousSum = 0;
            int sum = 0;
            int measurementCounter = 0;

            for (int i = 3; i < depthsList.Count(); i++)
            {
                previousSum = GetSum(i - 1);
                sum = GetSum(i);

                if (sum > previousSum)
                {
                    measurementCounter++;
                }
            }

            Console.WriteLine(measurementCounter + " Times height has been increased!");
            return measurementCounter;
        }

        private static int GetSum(int index)
        {
            int sum = 0;
            for (var j = index; j >= index - 2; j--)
            {
                sum += depthsList[j];
            }
            return sum;
        }
        #endregion

    }
}
