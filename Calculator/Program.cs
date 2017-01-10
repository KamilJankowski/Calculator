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
        public string str;


        //ask about value
        public void get_val()
        {
            Console.WriteLine("Please enter value: ");
            str = Console.ReadLine();
        }

        //read value from output and convert string to int32
        public double read_val(double val)
        {
            return val;
        }

    }

    //operations like add, substract, multiple, divide
    class operation
    {
        private double ab;
        public double add(double a, double b)
        {
            ab = a + b;
            return ab;

        }

        public double substract(double a, double b)
        {
            ab = a - b;
            return ab;
        }

        public double multiple(double a, double b)
        {
            ab = a * b;
            return ab;
        }

        public double divide(double a, double b)
        {
            ab = a / b;
            return ab;
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

            //set value
            double num, b, c, r, val;
            operation o = new operation();

            first_val fval = new first_val();
            fval.get_val();

            //test and read value 

            while (!(double.TryParse(fval.str, out num)))
            {
                Console.WriteLine("This is not a number. Please try again.");
                fval.get_val();

            }
            if (double.TryParse(fval.str, out num))
            {
                Console.WriteLine("This is a number.");
                val = Convert.ToDouble(fval.str);
                b = fval.read_val(val);
                Console.WriteLine("Return: {0}", b);
                //display operation options
                Console.WriteLine("Select operation from the following options: ");
                Console.WriteLine("1) ADD ");
                Console.WriteLine("2) SUBSTRACT ");
                Console.WriteLine("3) MULTIPLE ");
                Console.WriteLine("4) DEVIDE ");
                char oper = Convert.ToChar(Console.ReadLine());

                if ((oper == '1') || (oper == '2') || (oper == '3') || (oper == '4'))
                {
                    Console.WriteLine("Good choice");
                }

                while ((oper != '1') && (oper != '2') && (oper != '3') && (oper != '4'))
                {

                    Console.WriteLine("No operation. Please select operation from 1 - 4.");
                    Console.WriteLine();
                    Console.WriteLine("Select operation from the following options: ");
                    Console.WriteLine("1) ADD ");
                    Console.WriteLine("2) SUBSTRACT ");
                    Console.WriteLine("3) MULTIPLE ");
                    Console.WriteLine("4) DEVIDE ");

                    oper = Convert.ToChar(Console.ReadLine());
                    if ((oper == '1') || (oper == '2') || (oper == '3') || (oper == '4'))
                    {
                        Console.WriteLine("Good");
                    }

                }



                //set another value
                fval.get_val();
                while (!(double.TryParse(fval.str, out num)))
                {
                    Console.WriteLine("This is not a number. Please try again.");
                    fval.get_val();

                }
                if (double.TryParse(fval.str, out num))
                {
                    Console.WriteLine("This is a number.");
                    val = Convert.ToDouble(fval.str);
                    c = fval.read_val(val);
                    Console.WriteLine("Return: {0}", c);



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

                        if ((oper == '1') || (oper == '2') || (oper == '3') || (oper == '4'))
                        {
                            Console.WriteLine("Good choice");
                        }

                        while ((oper != '1') && (oper != '2') && (oper != '3') && (oper != '4'))
                        {

                            Console.WriteLine("No operation. Please select operation from 1 - 4.");
                            Console.WriteLine();
                            Console.WriteLine("Select operation from the following options: ");
                            Console.WriteLine("1) ADD ");
                            Console.WriteLine("2) SUBSTRACT ");
                            Console.WriteLine("3) MULTIPLE ");
                            Console.WriteLine("4) DEVIDE ");

                            oper = Convert.ToChar(Console.ReadLine());
                            if ((oper == '1') || (oper == '2') || (oper == '3') || (oper == '4'))
                            {
                                Console.WriteLine("Good");
                            }

                        }
                        fval.get_val();
                        while (!(double.TryParse(fval.str, out num)))
                        {
                            Console.WriteLine("This is not a number. Please try again.");
                            fval.get_val();

                        }
                        if (double.TryParse(fval.str, out num))
                        {
                            Console.WriteLine("This is a number.");
                            val = Convert.ToDouble(fval.str);
                            c = fval.read_val(val);
                            //select and run operation
                            switch (oper)
                            {
                                case '1':


                                    
                                    r = o.new_add(c);
                                    Console.WriteLine("Operation ADD Return: {0}", r);
                                    break;
                                case '2':
                                    
                                    
                                    r = o.new_substract(c);
                                    Console.WriteLine("Operation SUBSTRACT: {0}", r);
                                    break;
                                case '3':
                                   
                                    r = o.new_multiple(c);
                                    Console.WriteLine("Operation MULTIPLE: {0}", r);
                                    break;
                                case '4':
                                    
                                    r = o.new_divide(c);
                                    Console.WriteLine("Operation DIVIDE: {0}", r);
                                    break;
                            }
                            Console.WriteLine("Do you want to contine? (y/n): ");
                            oper_again = Convert.ToChar(Console.ReadLine());


                        }
                    }

                    while ((oper_again != 'n') && (oper_again != 'y'))
                    {
                        Console.WriteLine("Wrong data. Please choose yes or no.");
                        Console.WriteLine("Do you want to contine? (y/n): ");
                        oper_again = Convert.ToChar(Console.ReadLine());
                    }
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

                        if ((oper == '1') || (oper == '2') || (oper == '3') || (oper == '4'))
                        {
                            Console.WriteLine("Good choice");
                        }

                        while ((oper != '1') && (oper != '2') && (oper != '3') && (oper != '4'))
                        {

                            Console.WriteLine("No operation. Please select operation from 1 - 4.");
                            Console.WriteLine();
                            Console.WriteLine("Select operation from the following options: ");
                            Console.WriteLine("1) ADD ");
                            Console.WriteLine("2) SUBSTRACT ");
                            Console.WriteLine("3) MULTIPLE ");
                            Console.WriteLine("4) DEVIDE ");

                            oper = Convert.ToChar(Console.ReadLine());
                            if ((oper == '1') || (oper == '2') || (oper == '3') || (oper == '4'))
                            {
                                Console.WriteLine("Good");
                            }

                        }

                        fval.get_val();
                        while (!(double.TryParse(fval.str, out num)))
                        {
                            Console.WriteLine("This is not a number. Please try again.");
                            fval.get_val();

                        }
                        if (double.TryParse(fval.str, out num))
                        {
                            Console.WriteLine("This is a number.");
                            val = Convert.ToDouble(fval.str);
                            c = fval.read_val(val);
                            //select and run operation
                            switch (oper)
                            {
                                case '1':

                                    r = o.new_add(c);
                                    Console.WriteLine("Operation ADD Return: {0}", r);
                                    break;
                                case '2':

                                    r = o.new_substract(c);
                                    Console.WriteLine("Operation SUBSTRACT: {0}", r);
                                    break;
                                case '3':

                                    r = o.new_multiple(c);
                                    Console.WriteLine("Operation MULTIPLE: {0}", r);
                                    break;
                                case '4':

                                    r = o.new_divide(c);
                                    Console.WriteLine("Operation DIVIDE: {0}", r);
                                    break;
                            }
                            Console.WriteLine("Do you want to contine? (y/n): ");
                            oper_again = Convert.ToChar(Console.ReadLine());


                        }
                    }

                    //terminate program
                    if (oper_again == 'n')
                    {
                        Console.WriteLine("Thank you. God Bye.");
                    }
                }


            }

                    Console.ReadKey();
                
            }

        }
    }

