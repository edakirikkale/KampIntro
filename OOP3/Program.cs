using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        private static IKrediManager ihtiyacKrediManager;

        static void Main(string[] args)
        {
            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasıtKrediManager,fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasıtKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
