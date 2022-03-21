using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Sonar_Sweep
{
    public class CalculateMovment
    {
        public static List<(string direction, int value)> depthsList = new List<(string, int)>();
        private enum Direction
        {
            forward,
            up,
            down
        }

        public static void SecondDayMethods()
        {
            GetAllDepths();
            CalculateSubmarinDepth();
            CalculateSubmarinDepthsWithAim();
            Console.ReadLine();
        }

        //read all depths from text file to a list.
        public static void GetAllDepths()
        {
            depthsList = File.ReadAllLines(@"E:\Mahsa\Day02.txt")
              .Select(x => x.Split())
              .Select(x => (x[0], int.Parse(x[1]))).ToList();
        }

        #region Part 1
        public static int CalculateSubmarinDepth()
        {
            int horizental = 0;
            int depth = 0;

            foreach (var (dir, val) in depthsList)
            {
                switch (dir)
                {
                    case "forward":
                        horizental += val;
                        break;
                    case "up":
                        depth -= val;
                        break;
                    case "down":
                        depth += val;
                        break;
                    default:
                        throw new Exception("The input is not correct");
                }
            }

            int finalDepth = horizental * depth;
            Console.WriteLine("FinalDepth is : " + finalDepth);
            return finalDepth;
        }
        #endregion



        #region Part 2
        public static int CalculateSubmarinDepthsWithAim()
        {
            int horizentalPosition = 0;
            int depth = 0;
            int aim = 0;

            foreach (var (dir, val) in depthsList)
            {

                switch (dir)
                {
                    case "forward":
                        {
                            horizentalPosition += val;
                            depth += aim * val;
                            break;
                        }
                    case "up":
                        aim -= val;
                        break;
                    case "down":
                        aim += val;
                        break;
                    default:
                        throw new Exception("The input is not correct");
                }
            }

            int finalDepth = depth * horizentalPosition;
            Console.WriteLine("FinalDepth is : " + finalDepth);
            return finalDepth;
        }
    }
    #endregion
}

