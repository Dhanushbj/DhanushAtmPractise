using System;

namespace DemoApp1
{

    class AgeException : ApplicationException
    {
        string s;
        public AgeException(string str)
        {
            s = str + " is Invalid Age .Age should be 20 to 60";
        }
        public override string ToString()
        {
            return s;
        }
    }
    /*abstract class Example
    {


        /non-abstract function
        public void fun1()
        {
            Console.WriteLine(" Fun1 from Abstract class");
        }
        //abstarct method
        public abstract void fun2();
    }
    class Derived1 : Example
    {
        public override void fun2()
        {
            Console.WriteLine("Fun2 from Abstract implementation given in derived class ");
        }
        public void ff()
        {
            Console.WriteLine(" FF from Derived Class");
        }
    }
    /*class Abstract_Class
    {
        static void Main()
        {
            Derived1 obj = new Derived1();
            obj.fun1();
            obj.fun2();
            obj.ff();
        }*/

    /*
    class One
{
    public void aa()
    {
        Console.WriteLine("i am from aa");

    }
}
class Two : One
{
    public void bb()
    {
        Console.WriteLine("i am from bb");
    }
}


/*class Calculator
{
    //declaring the member variable
    int a, b, result;
public void getNumbers()
    {
        Console.WriteLine("enter value of a and b");
        a = Convert.ToInt32(Console.ReadLine());
        b= Convert.ToInt32(Console.ReadLine());

    }
    //declaring the member function
    public void Addition()
    {
        result = a + b;
        Console.WriteLine("addition of three numbers are " + result);
    }

}*/
    class Program
    {
        class Custome_exception2
        {
            static void Main(string[] args)
            {
                try
                {
                    string age;
                    age = Console.ReadLine();
                    int n = int.Parse(age);
                    if (n < 20 || n > 60)
                    {
                        throw new AgeException(age);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                /*int age;
                Console.WriteLine(" Enter the Age should between 18 to 70");
                age = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (age < 18 || age >= 70)
                    {
                        throw new Exception("Age should be 18 - 70");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                /*static void Main(string[] args)
                {
                    int x, y, z;
                    try
                    {
                        Console.WriteLine("Enter the 2 integer valeus");
                        x = int.Parse(Console.ReadLine());
                        y = int.Parse(Console.ReadLine());
                        z = x / y;
                        Console.WriteLine("  x  /y =" + z);
                    }
                    catch (DivideByZeroException e1)
                    {
                        Console.WriteLine(" DivideByZero Exception : " + e1.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(" Gerenal Exception Occured : \n " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("End of the Program");
                    }
                    Console.ReadKey();
                }

                /*Two obj = new Two();
                obj.aa();
                obj.bb();*/



                /*Sample sample = new Sample();
                Sample sample1 = new Sample("harry");*/

                /*Calculator calculator = new Calculator();
                calculator.getNumbers();
                calculator.Addition();*/

                /*int empId = 101;
                string empName = "harry";
                char gender = 'm';
                DateTime doj= Convert.ToDateTime("2008 - 08 - 08");
                double salary = 200000;

                Console.WriteLine($" Employee id={empId}\n empName={empName}\n gender={gender}\n date of joining={doj}\n salary={salary}");

                Console.WriteLine("enter the employee id,name,gender,doj,salary");
                empId = Convert.ToInt32(Console.ReadLine());
                empName = Console.ReadLine();
                gender = Convert.ToChar(Console.ReadLine());
                doj=Convert.ToDateTime(Console.ReadLine());
                salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("employee deatils are");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($" Employee id={empId}\n empName={empName}\n gender={gender}\n date of joining={doj}\n salary={salary}");
                */
                /* int a, b,c;
                 a = 100;
                 b = 22;
                 c= a * b;

                 Console.WriteLine($"result={c}");*/
                /*int a = 5, b = 3;
                if (a > b)
                {
                    Console.WriteLine("if its working");

                }
                else
                {
                    Console.WriteLine("else is working");
                }*/


            }
        }
    }
}
   
