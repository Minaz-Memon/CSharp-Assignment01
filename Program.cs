using System;

namespace Employee
{
    
    public class Employee
    {
        //Defining delegate
        public delegate string EmployeeEventHandler(object sender, EventArgs args);
        //Defining Event based on delegate
        public event EmployeeEventHandler EmpEvent;
        //Properties
        private int Id { get; set; }
        private string Name { get; set; }
        private string DepartmentName { get; set; }

        //Constructor
        public Employee(int Id, string Name, string DepartmentName)
        {
            this.Id = Id;
            this.Name = Name;
            this.DepartmentName = DepartmentName;
        }

        //Method to get ID
        public int GetId()
        {
            return this.Id;
        }
        //Method to get Name
        public string GetName()
        {
            return this.Name;
        }
        //Method to get Department Name
        public string GetDepartmentName()
        {
            return this.DepartmentName;
        }

        //Method to get ID
        public void GetId(int id)
        {
            this.Id = id;
        }
        //Method to get Name
        public void GetName(string name)
        {
            this.Name = name;
        }
        //Method to get Department Name
        public void GetDepartmentName(string depName)
        {
            this.DepartmentName = depName;
        }

        //Main Program
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            var Messageprint= new Messageprint();
            Employee.EmpEvent += Messageprint.OnEmpEvent;

            Console.WriteLine("Enter Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee's Department Name: ");
            string depname = Console.ReadLine();

            Employee emp = new Employee(id, name, depname);

            Console.WriteLine("Emp Id : " + emp.GetId());
            Console.WriteLine("Emp Name : " + emp.GetName());
            Console.WriteLine("Emp Dep Name : " + emp.GetDepartmentName());
            OnEmpEvent(); //raise an event

        }
        
        public void OnEmpEvent(object sender,EventArgs e)
        {
            if(EmpEvent != null)
              EmpEvent(this, EventArgs.Empty);
        }
        public class Messageprint
        {
            public void OnEmpEvent(object sender,EventArgs e)
            {
                System.Console.WriteLine("A Method is called");
            }
        }
    }

}
