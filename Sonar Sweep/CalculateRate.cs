using Grpc.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sonar_Sweep
{
    public class CalculateRate
    {
        public static List<string> binaryData = new List<string>();
        static int binaryLenght = 0;
        public static void ThirdDayMethods()
        {
            GetAllDepths();
            CalculatePowerConsumption();
            CalculateLifeSupportRating();
            Console.ReadLine();
        }

     
        //read all depths from text file to a list.
        public static void GetAllDepths()
        {
            binaryData = File.ReadAllLines(@"E:\Mahsa\Day03.txt")
              .Select(x => x).ToList();
        }

        #region Part 1
        public static int CalculatePowerConsumption()
        {
            binaryLenght = binaryData[0].Length;

            var gammaRate = new string(Enumerable.Range(0, binaryLenght)
           .Select(i => binaryData.Count(c => c[i] == '1') >
                        binaryData.Count(c => c[i] == '0') ? '1' : '0')
           .ToArray());

            var epsilonRate = new string(gammaRate.Select(x => x == '1' ? '0' : '1')
                .ToArray());

            var powerConsumption = Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2);
            Console.WriteLine("The PowerConsumption value is : " + powerConsumption);
            return powerConsumption;


        }
        #endregion

        #region Part2
        public static int CalculateLifeSupportRating()
        {
            var oxygenGeneratorRating = GetOxygenGeneratorRating();
            var co2ScrubberRating = GetCo2ScrubberRating();

            var lifeSupportRating = oxygenGeneratorRating * co2ScrubberRating;
            Console.WriteLine($"The LifeSupportRating is : {lifeSupportRating}");
            return lifeSupportRating;
        }
        public static int GetOxygenGeneratorRating()
        {
            var numbers = binaryData.ToList();

            for (var i = 0; i < binaryLenght; i++)
            {
                var mostCommonValue = numbers.Count(c => c[i] == '1') >= numbers.Count(c => c[i] == '0') ? '1' : '0';

                numbers.RemoveAll(x => x[i] != mostCommonValue);

                if (numbers.Count == 1) break;
            }
            return Convert.ToInt32(numbers.First(), 2);
        }
        public static int GetCo2ScrubberRating()
        {
            var numbers = binaryData.ToList();

            for (var i = 0; i < binaryLenght; i++)
            {
                var leastCommonValue = numbers.Count(c => c[i] == '1') < numbers.Count(c => c[i] == '0') ? '1' : '0';

                numbers.RemoveAll(x => x[i] != leastCommonValue);

                if (numbers.Count == 1) break;
            }
            return Convert.ToInt32(numbers.First(), 2);
        }
        #endregion

  
    }
}
