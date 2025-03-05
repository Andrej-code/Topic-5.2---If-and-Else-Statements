
namespace Topic_5._2___If_and_Else_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1 - Multiple Choice");
            Console.WriteLine();
            string choice, question2, question4, answer2, answer4;
            int question3, answer3;


            Console.Write("What is the worst weapon in Call of Duty World at War Zombies?");
            Console.WriteLine();
            Console.Write(" A - Knife");
            Console.Write(" B - Spring Filed");
            Console.Write(" C - M1911");
            Console.Write(" D - Kar98k");
            Console.WriteLine();
            choice = Console.ReadLine();
            if (choice == "A")
            {
                Console.WriteLine("No, that is not the worst weapon in World at War Zombies.");
            }
            else if (choice == "B")
            {
                Console.WriteLine("Close but it's the sceond worst weapon in World at War Zombies.");
            }
            else if (choice == "C")
            {
                Console.WriteLine("Yes, the M1911 is the worst weapon in World at War Zombies.");
            }

            else if (choice == "D")
            {
                Console.WriteLine("No, that is not the worst weapon in World at War Zombies.");
            }
            else
            {
                Console.WriteLine("You have made an invalid selection.");
            }
            Console.WriteLine();


            Console.Write("In Call of Duty Zombies which introduce us to the first four main charaters (Tank Dempsey, Nikolia Beilski, Takeo Masaki, Edward Richtofin)? ");
            question2 = Console.ReadLine().ToLower();
            Console.WriteLine();
            answer2 = "shi no numa";
            if (question2 == answer2)
            {
                Console.Write("Correct!," + answer2 + " introduce us to the first four main charaters");
            }
            else
            {
                Console.Write("You're Wrong!, better luck next time");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("How many maps in total are in the oringal storie line? ");
            int.TryParse(Console.ReadLine(), out question3);
            answer3 = 17;
            Console.WriteLine();
            if (question3 == answer3)
            {
                Console.Write("Correct!, there are in total " + answer3 + " in the oringal story line");
            }
            else
            {
                Console.Write("You're Worng!, better luck next time.");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Call of Duty Zombies fell off when it first release True or False? ");
            question4 = Console.ReadLine().ToLower();
            answer4 = "false";
            Console.WriteLine();
            if (question4 == answer4)
            {
                Console.Write("Correct!, " + answer4 + " It didn't fell of at first cause it was never seen before in video games.");
            }
            else
            {
                Console.Write("You're Wrong!");
            }
            Console.WriteLine();
        }
    }
}
