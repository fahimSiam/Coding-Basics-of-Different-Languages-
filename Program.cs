using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string myName = "fahim siam";
              bool isMale = false;
              Console.WriteLine("Hello \n World!"); //next line e jete \n
              Console.WriteLine("this is "+ myName);
              Console.WriteLine(myName.Length);
              Console.WriteLine(myName.ToUpper());
              Console.WriteLine(myName.Contains("siam"));
              Console.WriteLine(myName.Substring(myName.IndexOf("a")));
              Console.Write("Enter your name: ");
              string name;
              string age;
              name=Console.ReadLine();
              Console.Write("Enter your age: ");
              age = Console.ReadLine();
              int intAge = Convert.ToInt32(age);
              Console.WriteLine("hello " + name);
              Console.WriteLine(name +" is "+intAge);
              double number = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine("number is " + number); 
  */
            //ARRAY
            /*  int[] arr = { 1, 2, 3, 4 };
              string[] friends;
              friends = new string[5];
              friends[0] = "jim";
              Console.WriteLine(friends[0]);

              //METHODS
              SayHi("jim");
              int age=Convert.ToInt32(ReturnAge());
              Console.WriteLine("returned age " + age);

          }
          static void SayHi(String name)
          {
              Console.WriteLine(name + " is the best");
          }
          static string ReturnAge()
          {
              return "40";
          }
            //loops and do loop
            CheckDayName(2);
            int i = 6;
            do //DO WHILE LOOP
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
            static void CheckDayName(int n) 
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("Saturday");
                    break;
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;

            }

            //TRY CATCH USE
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {

            }*/

            //class nd objects
            Movie book1 = new Movie("Harry Potter", "JK rowling", 7.8);
            Movie book2 = new Movie("Game of Thrones", "baje director", 6.9);

            /* book1.title = "Harry Potter";
             book1.director = "JK rowling";
             book1.rating = 400;*/
            // Console.WriteLine(book1.rating);
            // book1.print();
            Console.WriteLine(book1.Rating);
        }
    }
}