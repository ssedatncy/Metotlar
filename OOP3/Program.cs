// See https://aka.ms/new-console-template for more information


using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerSerice= new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ihtiyacKrediManager,databaseLoggerService);




List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);