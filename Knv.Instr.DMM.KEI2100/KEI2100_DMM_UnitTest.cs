﻿
namespace Knv.Instr.PSU.RMX4104
{
    using Knv.Instr.DMM.KEI2100;
    using NUnit.Framework;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    internal class KEI2100_DMM_UnitTest
    {
        string VISA_NAME = "KEI2100";

        [Test]
        public void Identify()
        {
            using (var dmm = new KEI2100(VISA_NAME, isSim: false))
            {
                try
                {
                    var resp = dmm.Identify();
                    Assert.IsTrue(resp.Contains("KEITHLEY INSTRUMENTS INC."));
                    Assert.IsTrue(resp.Contains("MODEL 2100"));
                }
                finally
                {
                    dmm.LogSave(Constants.LogRootDirecotry, $"{MethodBase.GetCurrentMethod().DeclaringType.Name}_{MethodBase.GetCurrentMethod().Name}");
                }
            
            }
        }

        [Test]
        public void MeasureVoltSmallestRange()
        {
            using (var dmm = new KEI2100(VISA_NAME, isSim: false))
            {
                var resp = dmm.Identify();
                Assert.IsTrue(resp.Contains("KEITHLEY INSTRUMENTS INC."));

                dmm.Config("DCV", range: 0.1);
                var measValue = dmm.Read();
                Assert.IsTrue(-0.5 < measValue && measValue < 0.5);

            }
        }

        [Test]
        public void WriteTestToDiaplay()
        {
            using (var dmm = new KEI2100(VISA_NAME, isSim: false))
            {
                try
                {
                    var resp = dmm.Identify();
                    Assert.IsTrue(resp.Contains("KEITHLEY INSTRUMENTS INC."));

                    for (int i = 0; i < 100; i++)
                    {
                        dmm.WriteTextToDisplay($"MIKI TE FASZ {i}");
                        Thread.Sleep(20);
                    }
                }
                finally
                {
                    dmm.LogSave(Constants.LogRootDirecotry, $"{MethodBase.GetCurrentMethod().DeclaringType.Name}_{MethodBase.GetCurrentMethod().Name}");
                }

            }
        }
    }
}
