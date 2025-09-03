//using System;

//class Program
//{
//    static void Main()
//    {

//        AnotherMain();
//        //Ask the user for a number from 1-7
//        //Console.Write("Enter a number (1-7): ");
//        //int dayNumber = Convert.ToInt32(Console.ReadLine());
//        //string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
//        //switch (dayNumber) {
//        //    case 1:
//        //        Console.WriteLine("Monday");
//        //        break;
//        //    case 2:
//        //        Console.WriteLine("Tuesday");
//        //        break;
//        //    case 3:
//        //        Console.WriteLine("Wednesday");
//        //        break;
//        //    case 4:
//        //        Console.WriteLine("Thursday");
//        //        break;
//        //    case 5:
//        //        Console.WriteLine("Friday");
//        //        break;
//        //    case 6:
//        //        Console.WriteLine("Saturday");
//        //        break;
//        //    case 7:
//        //        Console.WriteLine("Sunday");
//        //        break;
//        //    default:
//        //        Console.WriteLine("Invalid number! Please enter a number between 1 and 7.");
//        //        break;
//        //}

//        //if (dayNumber >= 1 && dayNumber <= 7)
//        //{
//        //    Console.WriteLine(days[dayNumber - 1]);
//        //}
//        //else
//        //{
//        //    Console.WriteLine("Invalid number! Enter 1-7.");
//        //}


//        //for (int i = 0; i < days.Length; i++)
//        //{
//        //    Console.WriteLine($"{i+1}: {days[i]}");
//        //}

//        //Console.WriteLine("Hello, World!");
//        //int age = 20;
//        //double height = 5.9;
//        //string name = "Alex";
//        //bool isStudent = true;

//        //Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}, Is Student: {isStudent}");

//        //Console.WriteLine("What is your name?");
//        //string userName = Console.ReadLine();

//        ////Conversion
//        //Console.Write("Enter year level: ");
//        //int yearLevel = Convert.ToInt32(Console.ReadLine());
//        //Console.WriteLine($"Hey there, {userName}! You are in year level {yearLevel}");


//        //string grade = "B"; // Switch is like multiple if-else statements
//        //switch (grade)
//        //{
//        //    case "A":
//        //        Console.WriteLine("Excellent!");
//        //        break;
//        //    case "B":
//        //        Console.WriteLine("Well done!");
//        //        break;
//        //    case "C":
//        //        Console.WriteLine("Good!");
//        //        break;
//        //    default:
//        //        Console.WriteLine("Invalid grade");
//        //        break;
//        //}

//        ////Collections and arrays
//        //string[] fruits = { "Apple", "Banana", "Cherry" };

//        //foreach (string fruit in fruits)
//        //{
//        //    Console.WriteLine(fruit);
//        //}



//        //METHODS AND FUNCTIONS
//    }

//    static void PrintName(string name)
//    {
//        Console.WriteLine($"Name: {name}");
//    }

//    //Wgat is static? Static means that the method belongs to the class itself rather than an instance of the class.
//    //So when you call a static method, you don't need to create an object of the class first.
//    //It's syntax will be: ClassName.MethodName(parameters)
//    /*
//       Example:
//        Class Dog {
            
//            static void Bark() {
//                Console.WriteLine("Woof!");
//            }
//        }

//        Another class
//        Class Program {
//            static void Main() {
//                Dog.Bark(); // No need to create an instance of Dog
//            }
//        }
//     */


//    //REFATORING DAYS CODE

//    //add static so that it can be called in static methods
//    static string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//    static void AnotherMain() {
//        Console.WriteLine("Input a number from 1-7:");
//        int dayNum = Convert.ToInt32(Console.ReadLine());

//        string dayName = GetDayName(dayNum);
//        Console.WriteLine($"Day {dayNum} is {dayName}");

//        PrintAllDays();
//    }

//    static string GetDayName(int dayNum)
//    {
//        if (dayNum >= 1 && dayNum <= 7)
//        {
//           return days[dayNum - 1];
//        }
//        else { 
//            return null;
//        }
//    }

//    static void PrintAllDays()
//    {
//        for (int i = 0; i < days.Length; i++)
//        {
//            Console.WriteLine($"{i + 1}: {days[i]}");
//        }
//    }
//}


