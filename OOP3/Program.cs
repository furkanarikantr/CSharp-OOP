namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1

            //PersonalCreditManager personalCreditManager = new PersonalCreditManager();
            //personalCreditManager.Calculate();

            //VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //HousingCreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.Calculate();



            //Step 2

            //ICreditManager personalCreditManager = new PersonalCreditManager();
            //personalCreditManager.Calculate();

            //ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //ICreditManager housingCreditManager = new HousingCreditManager();
            //housingCreditManager.Calculate();



            //Step 3
            //ICreditManager personalCreditManager = new PersonalCreditManager();
            //ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //ICreditManager housingCreditManager = new HousingCreditManager();

            //ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(vehicleCreditManager);

            //List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager, housingCreditManager };
            //applicationManager.MakeCreditPreliminaryInformation(credits);

            //Step4
            ICreditManager personalCreditManager = new PersonalCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerManager databaseLogger = new DatabaseLoggerManager();
            ILoggerManager smsLogger = new SmsLoggerManager();
            ILoggerManager fileLogger = new FileLoggerManager();

            List<ILoggerManager> loggerManagers = new List<ILoggerManager>() { databaseLogger, smsLogger, fileLogger};

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(vehicleCreditManager, loggerManagers);

            List<ICreditManager> credits = new List<ICreditManager>() { personalCreditManager, housingCreditManager };
            applicationManager.MakeCreditPreliminaryInformation(credits);

        }
    }
}