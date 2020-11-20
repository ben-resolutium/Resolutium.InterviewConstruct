using Resolutium.FeatureFlags;
using System;

namespace FeatureFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            var ffs = new AppConfigFeatureFlagService();

            var salesFlag = ffs.Get("Resolutium.Sales");
            Console.WriteLine($"Sales: {salesFlag.Value}");
            if (salesFlag.Value == "Enabled")
            {
                Console.WriteLine("You have access to the sales module.");
            }
            else
            {
                Console.WriteLine("You don't have access to the sales module.");
            }

            var purchasingFlag = ffs.Get("Resolutium.Sales");
            Console.WriteLine($"Purchasing: {purchasingFlag.Value}");
            if (purchasingFlag.Value == "Enabled")
            {
                Console.WriteLine("You have access to the purchasing module.");
            }
            else
            {
                Console.WriteLine("You don't have access to the purchasing module.");
            }

            var accountingFlag = ffs.Get("Resolutium.Accounting");
            Console.WriteLine($"Accounting: {accountingFlag.Value}");
            if (accountingFlag.Value == "Enabled")
            {
                Console.WriteLine("You have access to the accounting module");
            }
            else
            {
                Console.WriteLine("You don't have access to the accounting module.");
            }

            var reportingFlag = ffs.Get("Resolutium.Reporting");
            Console.WriteLine($"Reporting: {reportingFlag.Value}");
            if (reportingFlag.Value == "Enabled")
            {
                Console.WriteLine("You have access to the reporting module.");
            }
            else
            {
                Console.WriteLine("You don't have access to the reporting module.");
            }

            Console.ReadLine();
        }
    }
}
