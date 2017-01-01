using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    //class value
    class first_val
    {
        private double number;

        //ask about value
        public void get_val()
        {
            Console.WriteLine("Please enter value: ");
        }

        //read value from output and convert string to int32
        public double read_val(double val)
        {
            number = Convert.ToDouble(Console.ReadLine());

            val = number;

            return val;
        }
    }

    //operations like add, substract, multiple, divide
    class operation
    {
        private double ab;
        public double add(double a,double b)
        {
             ab = a + b;
            return ab;
            
        }

        public double substract(double a, double b)
        {
            ab = a - b;
            return  ab;
        }

        public double multiple(double a, double b)
        {
            ab = a * b;
            return ab;
        }

        public double divide(double a, double b)
        {
            ab = a / b;
            return  ab;
        }

        public double new_add(double b)
        {
            ab = ab + b;
            return ab;
            
        }

        public double new_substract(double b)
        {
            ab = ab - b;
            return ab;

        }

        public double new_multiple(double b)
        {
            ab = ab * b;
            return ab;

        }
        public double new_divide(double b)
        {
            ab = ab / b;
            return ab;

        }


    }

   



    class Program
    {
        
        static void Main(string[] args)
        {
            double a = 0;
             
            //welcome string declaration
            string welcome = "Welcome to Simple Calculator - created by Kamil Jankowski";

            //display character '-' to separate welcome and program content  
            for (double i = 0; i < welcome.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("");
            Console.WriteLine(welcome);


            //display character '-' to separate welcome and program content    
            for (double i = 0; i < welcome.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            //set value
            first_val fval = new first_val();
            fval.get_val();
            double b = fval.read_val(a);

            Console.WriteLine("Return: {0}", b);

            //display operation options
            Console.WriteLine("Select operation from the following options: ");
            Console.WriteLine("1) ADD ");
            Console.WriteLine("2) SUBSTRACT ");
            Console.WriteLine("3) MULTIPLE ");
            Console.WriteLine("4) DEVIDE ");
            char oper = Convert.ToChar(Console.ReadLine());

            //set another value
            fval.get_val();
            double c = fval.read_val(a);

            Console.WriteLine("Return: {0}", c);

            operation o = new operation();

            double r;

            //select and run operation
            switch (oper)
            {
                case '1':
                     r = o.add(b, c);
                    Console.WriteLine("Operation ADD Return: {0}", r);
                    break;
                case '2':
                     r = o.substract(b, c);
                    Console.WriteLine("Operation SUBSTRACT: {0}", r);
                    break;
                case '3':
                     r = o.multiple(b, c);
                    Console.WriteLine("Operation MULTIPLE: {0}", r);
                    break;
                case '4':
                     r = o.divide(b, c);
                    Console.WriteLine("Operation DIVIDE: {0}", r);
                    break;
            }

            Console.WriteLine("Do you want to contine? (y/n): ");
            char oper_again = Convert.ToChar(Console.ReadLine());

           //if true then continue to ask about operation and value
            while (oper_again == 'y')
            {
                    //display operation options
                    Console.WriteLine("Select operation from the following options: ");
                    Console.WriteLine("1) ADD ");
                    Console.WriteLine("2) SUBSTRACT ");
                    Console.WriteLine("3) MULTIPLE ");
                    Console.WriteLine("4) DIVIDE ");
                    oper = Convert.ToChar(Console.ReadLine());
                    //select and run operation
                    switch (oper)
                    {
                        case '1':
                            fval.get_val();
                             c = fval.read_val(a);
                             r = o.new_add(c);
                            Console.WriteLine("Operation ADD Return: {0}", r);
                            break;
                        case '2':
                            fval.get_val();
                            c = fval.read_val(a);
                            r = o.new_substract(c);
                            Console.WriteLine("Operation SUBSTRACT: {0}", r);
                            break;
                        case '3':
                            fval.get_val();
                            c = fval.read_val(a);
                             r= o.new_multiple(c);
                            Console.WriteLine("Operation MULTIPLE: {0}", r);
                            break;
                        case '4':
                            fval.get_val();
                            c = fval.read_val(a);
                             r = o.new_divide(c);
                            Console.WriteLine("Operation DIVIDE: {0}", r);
                            break;
                    }
                    Console.WriteLine("Do you want to contine? (y/n): ");
                    oper_again = Convert.ToChar(Console.ReadLine());
                    
                
            }
            //terminate program
            if (oper_again == 'n')
            {
                Console.WriteLine("Thank you. God Bye.");
            }

            Console.ReadKey();
        }
    }
    
}
