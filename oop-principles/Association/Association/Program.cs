using System;
using System.Collections.Generic;

namespace Association
{
    public class Manager
    {
        // create a Project object so the Manager class can access/modify the IsSuccess field.
        public Project _project;

        public Manager()
        {
            _project = new Project(this);
        }

        // Aggregation relationship - the manager is the owner of the workers/ the manager will have a list of workers
        public List<Worker> Workers = new List<Worker>();

        public int Salary = 100;

        public void Logon(SwipeCard obj)
        {
            obj.Swipe(this);
        }

        public string GetManagerName()
        {
            return "Teerapong";
        }

        // The project success depends on the manager performance
        public void HowIsTheManager(bool Good)
        {
            if (Good)
            {
                _project.IsSuccess = true;
            }
            else
            {
                _project.IsSuccess = false;
            }
        }
    }

    public class SwipeCard
    {
        // Swipe method uses Manager object
        public void Swipe(Manager obj)
        {
            Console.WriteLine("Successfully logged on.");

        }

        public string MakeofSwipeCard()
        {
            return "C001";
        }
    }

    // workers belong to the Manager
    public class Worker
    {
        public string WorkerName = "";
    }

    public class Project
    {
        private Manager _manager;

        public Project(Manager manager)
        {
            _manager = manager;
        }

        // the valuse of IsSuccess is passed/set by the HowIsTheManager method in the Manager class
        public bool IsSuccess
        {
            get { return IsSuccess; }
            set
            {
                IsSuccess = value;
                if (value)
                {
                    _manager.Salary++;

                }
                else
                {
                    _manager.Salary--;
                }
            }
        }

        public void GetProjectName()
        {
            Console.WriteLine("Project A");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            manager.HowIsTheManager(true);
            Console.WriteLine(manager.Salary);
            //manager.Logon(new SwipeCard());
            //manager.HowIsTheManager(true);

            var project = new Project(manager);
            project.GetProjectName();
            

            var card = new SwipeCard();

            var worker = new Worker();

            
            //project.IsSuccess();
        }
    }
}
