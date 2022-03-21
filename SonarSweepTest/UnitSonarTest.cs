using NUnit.Framework;

namespace SonarSweepTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Sonar_Sweep.CalculateRate.GetAllDepths();
            Sonar_Sweep.CalculateMovment.GetAllDepths();
            Sonar_Sweep.Depth.GetAllDepths();
        }

        #region Day01
        [Test]
        public void TestGetIncreasedDepth()
        {
            var result = Sonar_Sweep.Depth.GetIncreasedDepth();
            Assert.AreEqual(result, 1553);
        }

        [Test]
        public void TestCountThreeIncreasedMeasurementDepth()
        {
            var result = Sonar_Sweep.Depth.CountThreeIncreasedMeasurementDepth();
            Assert.AreEqual(result, 1597);
        }
        #endregion

        #region Day02
        [Test]
        public void TestCalculateSubmarinDepth()
        {
            var result = Sonar_Sweep.CalculateMovment.CalculateSubmarinDepth();
            Assert.AreEqual(result, 1936494);
        }

        [Test]
        public void TestCalculateSubmarinDepthsWithAim()
        {
            var result = Sonar_Sweep.CalculateMovment.CalculateSubmarinDepthsWithAim();
            Assert.AreEqual(result, 1997106066);
        }
        #endregion



        #region Day03
        [Test]
        public void TestCalculatePowerConsumption()
        {
            var result = Sonar_Sweep.CalculateRate.CalculatePowerConsumption();
            Assert.AreEqual(result, 3429254);
        }

        [Test]
        public void TestCalculateLifeSupportRating()
        {
            var result = Sonar_Sweep.CalculateRate.CalculateLifeSupportRating();
            Assert.AreEqual(result, 148225);
        }
        #endregion
    }
}