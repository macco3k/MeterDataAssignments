using NUnit.Framework;
using Exercise;
using System.Collections.Generic;
using System;

namespace Tests
{
    public class MeterDataTests
    {
        [Test]
        public void TotalConsumptionInYearWorks()
        {
            var inputData = new List<MeterData>
            {
                new MeterData
                {
                    ImportCode = "IrrelevantImportCode",
                    Value = 20.0,
                    Timestamp = new DateTime(2020, 01, 01)
                },
                new MeterData
                {
                    ImportCode = "IrrelevantImportCode",
                    Value = 25.0,
                    Timestamp = new DateTime(2020, 02, 01)
                }
            };

            var consumptionIn2020 = Data.TotalConsumptionInYear(inputData, 2020);
            Assert.AreEqual(45.0, consumptionIn2020, "The consumption should be correct");

            var consumptionIn2021 = Data.TotalConsumptionInYear(inputData, 2021);
            Assert.AreEqual(0.0, consumptionIn2021, "Consumption should be zero in 2021");
        }
    }
}