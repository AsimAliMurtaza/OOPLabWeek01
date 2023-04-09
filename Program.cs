using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*taskOne();*/
            /*taskTwo();*/
            /*taskThree();*/
            /*taskFour();*/
            /*taskFive();*/
            /*taskSix();*/
            /*taskSeven();*/
            /*taskEight();*/
            /*taskNine();*/
            /*taskTen();*/
            /*taskEleven();*/
            taskTwelve();
        }

        static void taskOne()
        {
            float len;
            float area;

            Console.Write("Enter length: ");
            len = float.Parse(Console.ReadLine());

            area = len * len;

            Console.WriteLine("Area of square is: {0} ", area);
            Console.ReadKey();
        }
        static void taskTwo()
        {
            int marks = 0;
            Console.Write("Enter number/marks: ");
            marks = int.Parse(Console.ReadLine());

            if (marks > 50)
            {
                Console.WriteLine("You are passed!");
            }
            else
            {
                Console.WriteLine("You are failed!");
            }
            Console.ReadKey();
        }
        static void taskThree()
        {
            string message = "Welcone, Jack!";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
        static void taskFour()
        {
            int sum = 0;
            int number;
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());

            while (number != -1)
            {
                sum += number;
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Sum is : {0}", sum);
            Console.ReadKey();
        }
        static void taskFive()
        {
            int number = 0;
            int sum = 0;

            do
            {
                Console.WriteLine("Enter numbers: ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            while (number != -1);
            sum += 1;
            Console.WriteLine("Sum is: {0}", sum);
            Console.ReadKey();

        }
        static void taskSix()
        {
            int[] numbers = new int[3];
            int largest = -1;


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter numbers: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("Largest Num is: {0}", largest);
            Console.Read();
        }
        static void taskSeven()
        {
            float lilyAge = 0;
            float toyPrice = 0;
            float machinePrice = 0;
            int money = 0;
            int sum = 0;
            int count = 0;
            float toysCount = 0;
            float toysMoney = 0;
            float totalMoney = 0;
            float moneyAfterDeduction = 0;

            Console.WriteLine("Enter lily age: ");
            lilyAge = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter machine price: ");
            machinePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter toy price: ");
            toyPrice = float.Parse(Console.ReadLine());

            for (int evenAge = 2; evenAge <= lilyAge; evenAge += 2)
            {
                money = 5 * evenAge;
                sum = sum + money;
                count++;
            }
            moneyAfterDeduction = sum - count;

            for (int oddAge = 1; oddAge <= lilyAge; oddAge += 2)
            {
                if (oddAge % 2 != 0)
                {
                    toysCount++;
                }
            }

            toysMoney = toysCount * toyPrice;

            totalMoney = toysMoney + moneyAfterDeduction;

            if (totalMoney > machinePrice)
            {
                Console.Write("YES ");
                Console.WriteLine(totalMoney - machinePrice);
            }
            else
            {
                Console.Write("No! ");
                Console.WriteLine(machinePrice - totalMoney);
            }
            Console.ReadKey();
        }
        static void taskEight()
        {
            int numOne = 0;
            int numTwo = 0;

            Console.WriteLine("Enter first number: ");
            numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is: {0}", addNumbers(numOne, numTwo));
        }
        static int addNumbers(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        static void taskNine()
        {
            string path = "D:\\UET BS-CS\\SEMESTER 02\\CS-162L Object Oriented Programming\\OOPWeek1\\file.txt";
            string line;

            if (File.Exists(path))
            {
                StreamReader dataFile = new StreamReader(path);
                while ((line = dataFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                dataFile.Close();
            }
            Console.Read();
        }
        static void taskTen()
        {
            string path = "D:\\UET BS-CS\\SEMESTER 02\\CS-162L Object Oriented Programming\\OOPWeek1\\file.txt";
            StreamWriter dataFile = new StreamWriter(path, true);

            dataFile.WriteLine("C# IS !AMAZING!!!");
            dataFile.Flush();
            dataFile.Close();
            Console.WriteLine("Data has been written!");
            Console.Read();
        }

        static void taskEleven()
        {
            string[] names = new string[5];
            string[] passwords = new string[5];

            int choice = menu();
            if (choice == 1)
            {
                signIn(names, passwords);
            }
            else if (choice == 2)
            {
                signUp(names, passwords);
            }
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. Sign In");
            Console.WriteLine("2. Sign Up");
            Console.WriteLine("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void signUp(string[] names, string[] passwords)
        {
            string name;
            string password;
            int userCount = 0;

            Console.Write("Enter username: ");
            name = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            names[userCount] = name;
            passwords[userCount] = password;
            userCount++;

            saveDataIntoFile(name, password);

        }
        static void saveDataIntoFile(string name, string password)
        {
            string path = "D:\\UET BS-CS\\SEMESTER 02\\CS-162L Object Oriented Programming\\OOPWeek1\\file.txt";
            StreamWriter dataFile = new StreamWriter(path, true);
            dataFile.WriteLine(name + "," + password);
            dataFile.Flush();
            dataFile.Close();
        }
        static void signIn(string[] names, string[] passwords)
        {
            readData(names, passwords);
            string name;
            string password;
            bool flag = false;

            Console.Write("Enter username: ");
            name = Console.ReadLine();
            Console.Write("Enter password: ");
            password = Console.ReadLine();

            for(int i =0; i<5; i++)
            {
                if(name == names[i] && password == passwords[i])
                {
                    Console.Write("Valid User!");
                    flag = true;
                    break;
                }
                else
                {
                    Console.Write("Invalid User!");
                    break;
                }

            }

        }
        static void readData(string[] names, string[] passwords)
        {
            string path = "D:\\UET BS-CS\\SEMESTER 02\\CS-162L Object Oriented Programming\\OOPWeek1\\file.txt";
            int userCount = 0;
            string record;

            if (File.Exists(path))
            {
                StreamReader dataFile = new StreamReader(path);
                while((record = dataFile.ReadLine()) != null) 
                {
                    names[userCount] = parseData(record, 1);
                    passwords[userCount] = parseData(record, 2);
                    userCount++;
                    if(userCount>=5)
                    {
                        break;
                    }
                }
                dataFile.Close();
            }
            else
            {
                Console.Write("User does not exist!");
            }
        }
        static string parseData(string record, int count) 
        {
            int commaCount = 1;
            string item = "";

            for(int i = 0; i < record.Length; i++)
            {
                if (record[i]==',')
                {
                    commaCount++;
                }
                else if(commaCount == count) 
                {
                    item = item + record[i];
                }
            }
            return item;
        }

        static void taskTwelve()
        {
            int price = 0;
            int order = 0;

            Console.Write("Enter num of min orders: ");
            order = int.Parse(Console.ReadLine());
            Console.Write("Enter num of min price: ");
            price = int.Parse(Console.ReadLine());
            readString(ref order, ref price);
            Console.ReadKey();
        }

        static void readString(ref int order, ref int price)
        {
            string path = "C:\\Users\\Asim Ali\\source\\repos\\ConsoleApp\\ConsoleApp\\file.txt";
            string name = "";
            int numOfOrders = 0;
            int orderCounter = 0;
            string orderPrices;
            string record = "";
;
            if (File.Exists(path))
            {
                StreamReader dataFile = new StreamReader(path);
                while ((record = dataFile.ReadLine()) != null)
                {
                    name = parseString(record, 1);
                    numOfOrders = int.Parse(parseString(record, 2));
                    orderPrices = parseOrderPrices(record);

                    for(int i = 1; i< numOfOrders; i++)
                    {
                        if(int.Parse(parseData(orderPrices, i)) > price)
                        {
                            orderCounter++;
                        }
                    }
                    if(orderCounter > order)
                    {
                        Console.WriteLine(name);
                    }
                }
                dataFile.Close();
            }
        }
        static string parseString(string record, int count)
        {
            int spaceCount = 1;
            string item = "";

            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ' ')
                {
                    spaceCount++;
                }
                else if (spaceCount == count)
                {
                    item = item + record[i];
                }
            }
            return item;
        }
        static string parseOrderPrices(string record)
        {
            int spaceCount = 1;
            string item = "";

            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ' ')
                {
                    spaceCount++;
                }
                else if (record[i] == ('[') || record[i] == (']'))
                {
                    continue;
                }
                else if (spaceCount == 3)
                {
                    item = item + record[i];

                }
            }
            return item;
        }
    }
}
