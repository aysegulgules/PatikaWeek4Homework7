using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework7.Abstract
{
    //abstract class tanımlanıyor. 
    abstract class BaseWorker
    {
        public  string Name { get; set; }
        public  string Surname { get; set; }
        public string Department { get; set; }

        public abstract void WorkerDuty();//abstract metod 
       
       

    }
}
