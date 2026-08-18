//Create a Program which checks the input from the usere is valid and desired by the user for the program or not
// And only then starts the program that calculates the area of a glass
using System;
using System.Threading.Channels;


class Measurements  // this is a class which is just for containing all the variables used inside the
                    //code in various places to keep them from losing or giving error
{
    public double length;
    public double breadth;
    public double glassArea;
    public bool isLength = false;
    public bool isBreadth = false;

}
class Caculator //Our main program
{
   static  Measurements m = new Measurements(); // calls Measurements class and creates all the variables in it static for Calculator class
    static void UserInput() //method to get input from the user
    {
        string lenghtString, breadthString; // local variables only used here no need to have them in Measurments


        while (!m.isLength) // starting the loop for getting length input
        {

            Console.Write("Give me length :");
            lenghtString = Console.ReadLine();

            if (double.TryParse(lenghtString, out double _numb0)) // converts the string we got from ReadLine to correct data type for calculation
            {
                m.length = _numb0; //sets the value with valid data type to our value
                m.isLength = true; //to stop the loop
            }
            else
            {
                Console.WriteLine("Are You sure?");

            }
        }

        while (!m.isBreadth) // starting the loop for getting breadth input
        {
            Console.Write("Give me breadth:");
            breadthString = Console.ReadLine();

            if (double.TryParse(breadthString, out double _numb1)) // converts the string we got from ReadLine to correct data type for calculation
            {
                m.breadth = _numb1;//sets the value with valid data type to our value
                m.isBreadth = true;//to stop the loop
            }
            else
            {
                Console.WriteLine("Are you sure");
            }
        }
    }
    static void Main() // this method tells the entry point for the compiler to execute
    {
        UserInput(); // calls our UserInput method
        bool IsValid = false;//initiates the variable for starting and ending loop
        while (!IsValid)//loop starts here
        {

            Console.WriteLine($"Given lenght and breadth are {m.length} and {m.breadth} respectively ");//tells the given value form UserInput for user to crosscheck
            Console.Write("Wanna change?:(Yes/No)");//asks user if the input is what they desired
            string a = Console.ReadLine();//gets input from user
            if (!string.IsNullOrEmpty(a) && a.Equals("yes"))//checks if  user wants to change
            {

                Console.Write("What do you want to chage:(length/breadth)"); // asks user what is to be changed
                string b = Console.ReadLine(); //gets input from the user
                if (!string.IsNullOrEmpty(b) && b.Equals("length")) // if length the length loop is triggered
                {
                    m.isLength = false;
                    UserInput();

                }
                else if (!string.IsNullOrEmpty(b) && b.Equals("breadth")) //if breadth the breadth loop is triggered
                {
                    m.isBreadth = false;
                    UserInput();

                }
                else
                {
                    Console.WriteLine("Please put valid input."); // if value of input is invalid
                }
            }
            else
            {
                IsValid = true; // if the answer is no from the user that means calcualtion for area can be executed
            }
        }
        m.glassArea = m.length * m.breadth; //area calculation
        Console.WriteLine($"So the area you want is :{m.glassArea}"); // final output to user
    }
}
