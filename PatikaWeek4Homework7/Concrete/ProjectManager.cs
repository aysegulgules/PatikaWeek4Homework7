﻿using PatikaWeek4Homework7.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4Homework7.Concrete
{
     class ProjectManager : BaseWorker
    {
        //Miras aldığı sınıfdaki absract metot
        public override void WorkerDuty()
        {
            Console.WriteLine($"\n {Name} {Surname} \n Proje yöneticisi olarak çalışıyorum.");
        }
    }
}
