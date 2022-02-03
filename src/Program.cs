using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise
{
    /// <summary>Contains utilities to read CSV files</summary>
    public static class Csv
    {
        /// <summary>Reads a meter data CSV file as a list of meter data rows</summary>
        public static List<MeterData> ReadMeterData(string fileName)
        {
            // TODO
            var data = new List<MeterData>();
            return data;
        }
    }

    /// <summary>Contains utilities to process and manipulate meter data</summary>
    public static class Data
    {
        /// <summary>Returns the total consumption in the given year for the provided list of meter data</summary>
        public static double TotalConsumptionInYear(List<MeterData> meterData, int year)
        {
            // TODO
            return 0.0;
        }

        /// <summary>
        /// Returns a the total day/night consumption from the list of meter data.
        /// Day consumption is Monday - Friday, between 07:00 - 22:59 (local time)
        /// Energy consumption during the 'night' is everything that is not 'day'
        /// </summary>
        public static (double day, double night) DayAndNightConsumption(List<MeterData> meterData)
        {
            var totalDayConsumption = 0.0;
            var totalNightConsumption = 0.0;
            // TODO
            return (totalDayConsumption, totalNightConsumption);
        }

        /// <summary>Groups the input meter data into data points representing the total consumption per month</summary>
        public static List<MeterData> GroupByMonth(List<MeterData> meterData)
        {
            // TODO
            return new List<MeterData>();
        }

        /// <summary>
        /// Returns the max demand from the input meter data for the given year and month.
        /// HINT: use the read frequency of the given datapoints
        /// HINT: peak demand is in kW, while consumption is in kWh
        /// </summary>
        public static double? MaxDemandInYearAndMonth(List<MeterData> meterData, int year, int month)
        {
            // TODO
            return null;
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            var firstFile = Csv.ReadMeterData(".\\Meterdata\\97_871687120050649109.csv");
            var secondFile = Csv.ReadMeterData(".\\Meterdata\\5864_871687120053521396.csv");
            Console.WriteLine($"First file contains {firstFile.Count} data points");
            Console.WriteLine($"Second file contains {secondFile.Count} data points");
        }
    }
}
