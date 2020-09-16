using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0916_1
{
    class Man
    {
        private string fName;

        public string FistName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string lName;

        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }

        public virtual void PrintInfo() //virtural사용을 통해 자식메서드에게 override권한 부여
        {
            Console.WriteLine("=======Man=======");
            Console.WriteLine("First Name : {0}", fName);
            Console.WriteLine("Last Name : {0}", lName);
            Console.WriteLine("=======Man=======");
        }

        public override string ToString()
        {
            return $"{fName} {lName}";
        }
    }

    class Employee : Man    //Man에서 상속 받음.
    {
        int employeeID;

        public Employee(int employeeID)
        {
            this.employeeID = employeeID;
        }

        public override void PrintInfo() //상속받은 메서드를 무시하고 자체적으로 사용할 떄 new사용 or Override사용(재정의)
        {
            Console.WriteLine("=======Employee=======");
            Console.WriteLine("Employee ID : {0}", employeeID);
            Console.WriteLine("First Name : {0}", this.FistName);
            Console.WriteLine("Last Name : {0}", this.LastName);
            Console.WriteLine("=======Employee=======");
        }

    }
        //부모가 virtual를 설정하지 못할 때 new사용
    class InheritTest
    {
        static void Main()
        {
            Man man = new Man();
            man.FistName = "류";
            man.LastName = "현진";
            man.PrintInfo();

            Employee emp1 = new Employee(2020005);
            emp1.FistName = "아";
            emp1.LastName = "이유";
            emp1.PrintInfo();

            Console.WriteLine(man.ToString());
        }
    }
}
