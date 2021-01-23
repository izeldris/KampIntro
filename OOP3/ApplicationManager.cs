using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void Appeal(ICreditManager creditManager, ILoggerService loggerService)
        {
            //asdasdasd
            //asdasdasdasd

            creditManager.DoSomething();
            loggerService.Log();
        }
        public void DoPreInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.DoSomething();
            }
        }
    }
}
