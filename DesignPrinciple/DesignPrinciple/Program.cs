using DesignPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple
{
 
    public class ContractEmployee : Employee

    {

        public int ID { get; set; }



        public string Name { get; set; }

        public ContractEmployee()

        { }



        public ContractEmployee(int id, string name)

        {

            this.ID = id;

            this.Name = name;

        }



        public decimal GetMinimumSalary()

        {

            return 5000;

        }



        public override string ToString()

        {

            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);

        }
        class Program

        {

            static void Main(string[] args)

            {

                List<Employee> employees = new List<Employee>();

                employees.Add(new PermanentEmployee(1, "John"));

                employees.Add(new TemporaryEmployee(2, "Jason"));

                //Un Comment to see the error

                //employees.Add(new ContractEmployee(3, "Mike"));

                foreach (var employee in employees)

                {

                    Console.WriteLine(string.Format("Employee {0} Bonus: {1} MinSalary: {2}",

                    employee.ToString(),

                    employee.CalculateBonus(100000).ToString(),

                    employee.GetMinimumSalary().ToString()));

                }



                Console.WriteLine();



                List<Employee> employeesOnly = new List<Employee>();



                employeesOnly.Add(new PermanentEmployee(1, "John"));

                employeesOnly.Add(new TemporaryEmployee(2, "Jason"));

                employeesOnly.Add(new ContractEmployee(3, "Mike"));



                foreach (var employee in employeesOnly)

                {

                    Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",

                    employee.ToString(),

                    employee.GetMinimumSalary().ToString()));

                }

                Console.ReadLine();

            }

        }

    }

    internal class TemporaryEmployee : Employee
    {
        private int v1;
        private string v2;

        public TemporaryEmployee(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    internal class PermanentEmployee : Employee
    {
        private int v1;
        private string v2;

        public PermanentEmployee(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    public class Employee
    {
        internal object CalculateBonus(int v)
        {
            throw new NotImplementedException();
        }

        internal object GetMinimumSalary()
        {
            throw new NotImplementedException();
        }
    }



    /* public class Invoice

{

    public virtual double GetInvoiceDiscount(double amount)

    {

        return amount - 10;

    }

}

public class FinalInvoice : Invoice

{

    public override double GetInvoiceDiscount(double amount)

    {

        return base.GetInvoiceDiscount(amount) - 50;

    }

}

public class ProposedInvoice : Invoice

{

    public override double GetInvoiceDiscount(double amount)

    {

        return base.GetInvoiceDiscount(amount) - 40;

    }

}

public class RecurringInvoice : Invoice

{

    public override double GetInvoiceDiscount(double amount)

    {

        return base.GetInvoiceDiscount(amount) - 30;

    }

}

}*/
    /*class Program
    {
        static void Main(string[] args)

        {*/

    /*Invoice FInvoice = new FinalInvoice();

    Invoice PInvoice = new ProposedInvoice();

    Invoice RInvoice = new RecurringInvoice();

    double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);

    double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);

    double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);*/



}
    