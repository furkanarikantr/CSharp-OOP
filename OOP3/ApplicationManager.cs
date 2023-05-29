using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //ICreditManager creditManager;
        //public ApplicationManager(ICreditManager _creditManager)
        //{
        //    creditManager = _creditManager;
        //}

        //Method Injection
        public void MakeApplication(ICreditManager creditManager, List<ILoggerManager> loggerManagers) 
        {
            //Başvuran Bilgilerini Değerlendirme
            creditManager.Calculate();
            foreach (var logger in loggerManagers)
            {
                logger.Log();
            }
        }

        public void MakeCreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
