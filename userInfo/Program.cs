namespace userInfo;

class Program
{
    static void Main(string[] args)
    {
    //  ლექციაზე დაწერილი კოდის ტესტინგი
            bool isMain = true;
            int myNum = 20;
            string myName = "Lilith";
            Console.WriteLine(isMain);
            Console.WriteLine(myNum);
            Console.WriteLine(myName);

            string mytext = "enter your name: "; // Create informative text

            string name; // Assign the type

            Console.WriteLine(mytext);// Print the info text
            name = Console.ReadLine(); // Let the user enter the text
            Console.WriteLine("user Name: " + name); // Print the entered text

            int dayOfWeek = 1;

            string dayText = "Today's ";

            switch (dayOfWeek)
            {
                case 0:
                    dayText += "Monday";
                    break;

                case 1:
                    dayText += "Tuesday";
                    break;

                case 2:
                    dayText += "Wednesday";
                    break;

                default:
                    dayText = "not found";
                    break;
            }

            Console.WriteLine(dayText);

        // Task 1 code
       
        Console.WriteLine("Enter the first number:"); //მომხმარებელი შეიყვანს პირველ რიცხვს 
        int firstNumber = int.Parse(Console.ReadLine()); //წაიკითხავს მომხმარებლის inputს და გადიყვანს სტრინგს მთელ რიცხვად

        Console.WriteLine("Enter the second number:");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the operator (+, -, *, /):");
        char operation = char.Parse(Console.ReadLine());

        int result = 0;

        switch (operation)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            case '/':
            // შეამოწმებს თუ მეორე რიცხვი ნული არ არის არ შეასულოს გაყოფა
                if (secondNumber != 0)
                    result = firstNumber / secondNumber;
                else
                {
                    Console.WriteLine("Cannot be divided by zero");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }
        // calculated result
        Console.WriteLine("Result: " + result);
    
    }
}
