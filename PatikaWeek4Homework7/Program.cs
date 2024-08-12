using PatikaWeek4Homework7.Concrete;
using System.Xml.Linq;


//BaseWorker dan miras alınarak oluşturulmuş classdan örnek oluşturuluyor.

SoftwareDeveloper softwareDeveloper = new SoftwareDeveloper()
{  
    Name = "Esma", 
    Surname = "Yılmaz",
    Department = "Yazılım Geliştirme"
};
softwareDeveloper.WorkerDuty();



 ProjectManager projectManager = new ProjectManager()
 {
     Name = "Hasan",
     Surname = "Çalış",
     Department= "Proje Yönetimi"
 };
projectManager.WorkerDuty();



SalesRepresentative salesRepresentative = new SalesRepresentative()
{
    Name = "Mehmet",
    Surname = "Kaya",
    Department = "Satış Temsilcisi"
};
salesRepresentative.WorkerDuty();
