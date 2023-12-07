using System.Diagnostics;

namespace Assignmnet_week6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question no. 1
            Car car = new Car("Toyota", 2023, 20.21f);
            car.PrintCarDetails();

            //Question no. 2
            BankAccount ba = new BankAccount( "ACN12345");
            ba.Deposit(1000);
            ba.Withdraw(500);
            ba.Display();

            //Question no. 3
            Rectangle rect = new Rectangle(2.25f, 3.35f);
            Console.WriteLine(rect.CalculateArea());

            //Question no. 4
            Circle cir = new Circle();
            Console.WriteLine(cir.CalculateArea(5));

            //Question no. 5
            Student stud = new Student("John Doe", 20, "Computer Science");
            stud.Introduce();

            //Question no. 6
            Stack<int> intStack = new Stack<int>();
            intStack.Push(5);
            intStack.Push(10);
            intStack.Push(15);

            intStack.Display_stack();

            int poppedItem = intStack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");
            intStack.Display_stack();

            Console.WriteLine(intStack.IsEmpty());
            Console.WriteLine(intStack.Peek());


            //Question no. 7
            Calender calender = new Calender();
            calender.PrintWeekdays();

            //Question no. 8
            Point2D pointA = new Point2D(1.0f, 2.0f);
            Point2D pointB = new Point2D(4.0f, 6.0f);

            float distance = DistanceCalculator.CalculateDistance(pointA, pointB);

            Console.WriteLine($"Distance between Point A and Point B: {distance}");



        }
    }
}