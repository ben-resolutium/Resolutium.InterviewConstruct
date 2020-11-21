using Resolutium.FeatureFlags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolutium.InterviewConstructService
{
    public class ServiceAccess
    {

        //AppConfigFeatureFlagService ffs;
        public string SalesAccess(FeatureFlag featureFlags)
        {
            //var salesFlag = ffs.Get("Resolutium.Sales");
            Console.WriteLine($"Sales: {featureFlags.Value}");
            if (featureFlags.Key == "Resolutium.Sales" && featureFlags.Value == "Enabled")
            {
                return "You have access to the sales module.";
            }
            else
            {
                return "You don't have access to the sales module.";
            }
        }
        public string PurchaseAccess(FeatureFlag featureFlag)
        {
            //var purchasingFlag = featureFlags.Get("Resolutium.Sales");
            Console.WriteLine($"Purchasing: {featureFlag.Value}");
            if (featureFlag.Key == "Resolutium.Purchasing" && featureFlag.Value == "Enabled")
            {
                return "You have access to the purchasing module.";
            }
            else
            {
                return "You don't have access to the purchasing module.";
            }
        }
        public string ReportingAccess(FeatureFlag featureFlags)
        {
            //var reportingFlag = ffs.Get("Resolutium.Reporting");
            Console.WriteLine($"Reporting: {featureFlags.Value}");
            if (featureFlags.Key == "Resolutium.Reporting" && featureFlags.Value == "Enabled")
            {
                return "You have access to the reporting module.";
            }
            else
            {
                return "You don't have access to the reporting module.";
            }
        }
        public string AccountingAccess(FeatureFlag featureFlags)
        {
            //var accountingFlag = ffs.Get("Resolutium.Accounting");
            Console.WriteLine($"Accounting: {featureFlags.Value}");
            if (featureFlags.Key == "Resolutium.Accounting" && featureFlags.Value == "Enabled")
            {
                return "You have access to the accounting module.";
            }
            else
            {
                return "You don't have access to the accounting module.";
            }

        }

    }

}
