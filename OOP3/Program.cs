using System;
using System.Collections.Generic;
namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            DemandCreditManager demandCreditManager = new DemandCreditManager();
            VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Appeal(vehicleCreditManager,databaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {demandCreditManager,vehicleCreditManager};

            //applicationManager.DoPreInfo(credits);

            
            
        }
    }
}
