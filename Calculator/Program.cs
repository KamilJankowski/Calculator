using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class first_val
    {
        private int number;

        public void get_val()
        {
            Console.WriteLine("Please enter value: ");
        }

        public int read_val(int val)
        {
            number = Convert.ToInt32(Console.ReadLine());

            val = number;

            return val;
        }
    }

    class operation
    {
        public int ab;
        public int add(int a,int b)
        {
             ab = a + b;
            return ab;
            
        }

        public int substract(int a, int b)
        {
            ab = a - b;
            return  ab;
        }

        public int multiple(int a, int b)
        {
            ab = a * b;
            return ab;
        }

        public int devide(int a, int b)
        {
            ab = a / b;
            return  ab;
        }

        public int new_add(int b)
        {
            ab = ab + b;
            return ab;
            
        }

        public int new_substract(int b)
        {
            ab = ab - b;
            return ab;

        }

        public int new_multiple(int b)
        {
            ab = ab * b;
            return ab;

        }
        public int new_devide(int b)
        {
            ab = ab / b;
            return ab;

        }


    }

   



    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 0;
             
        //welcome string declaration
        string welcome = "Welcome to Simple Calculator - created by Kamil Jankowski";

            //display character '-' to separate welcome and program content  
            for (int i = 0; i < welcome.Length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("");
            Console.WriteLine(welcome);


            //display character '-' to separate welcome and program content    
            for (int i = 0; i < welcome.Length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
            Console.WriteLine("");


            first_val fval = new first_val();

            fval.get_val();
                        
            int b = fval.read_val(a);

            Console.WriteLine("Return: {0}", b);

            Console.WriteLine("Select operation from the following options: ");
            Console.WriteLine("1) ADD ");
            Console.WriteLine("2) SUBSTARCT ");
            Console.WriteLine("3) MULTIPLE ");
            Console.WriteLine("4) DEVIDE ");
            char oper = Convert.ToChar(Console.ReadLine());

            fval.get_val();
            int c = fval.read_val(a);

            Console.WriteLine("Return: {0}", c);

            operation o = new operation();

            int r;

            switch (oper)
            {
                case '1':
                     r = o.add(b, c);
                    Console.WriteLine("Operation ADD Return: {0}", r);
                    break;
                case '2':
                     r = o.substract(b, c);
                    Console.WriteLine("Operation SUBSTARCT: {0}", r);
                    break;
                case '3':
                     r = o.multiple(b, c);
                    Console.WriteLine("Operation MULTIPLE: {0}", r);
                    break;
                case '4':
                     r = o.devide(b, c);
                    Console.WriteLine("Operation DEVIDE: {0}", r);
                    break;
            }

            Console.WriteLine("Do you want to contine? (y/n): ");
            char oper_again = Convert.ToChar(Console.ReadLine());

           


            while (oper_again == 'y')
            {
                
                

                    Console.WriteLine("Select operation from the following options: ");
                    Console.WriteLine("1) ADD ");
                    Console.WriteLine("2) SUBSTARCT ");
                    Console.WriteLine("3) MULTIPLE ");
                    Console.WriteLine("4) DEVIDE ");
                    oper = Convert.ToChar(Console.ReadLine());
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
                            Console.WriteLine("Operation SUBSTARCT: {0}", r);
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
                             r = o.new_devide(c);
                            Console.WriteLine("Operation DEVIDE: {0}", r);
                            break;
                    }
                    Console.WriteLine("Do you want to contine? (y/n): ");
                    oper_again = Convert.ToChar(Console.ReadLine());
                    
                
            }
            if (oper_again == 'n')
            {
                Console.WriteLine("Thank you. God Bye.");
            }

            Console.ReadKey();
        }
    }
    
}
