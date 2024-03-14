namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /* Slutsatser från test med ExamineList:
         * Svar på fråga 2:
         * Listans kapacitet ökar när det är nödvändigt för att lägga till vad som ska läggas till.
         * 
         * Svar på fråga 3:
         * Kapaciteten verkar fördubblas varje gång.
         * 
         * Svar på fråga 4:
         * Jag föreställer mig att det finns någon slags kostnad förknippad med ökningsprocessen själv som man försöker undvika genom att inte utöka kapaciteten för ofta. Om det faktiskt rör sig om en underliggande array måste rimligen en ny array skapas, och materialet kopieras över från den gamla, vilket skulle kunna ta en stund.
         * 
         * Svar på fråga 5:
         * Nej, kapaciteten minskas inte automatiskt när element tas bort. (Men jag ser att det finns gränssnittsfunktioner för det.)
         * 
         * Svar på fråga 6:
         * Frånsett kostnaden för att sätta upp en ny metodinstans för varje interaktion med listan (som jag verkligen hoppas är försumbar under något så när normala förhållanden) ser jag inga fördelar med en array framför en lista med en explicit satt Capacity.
         * Om vi däremot ska jämföra en array med en lista som tillåtes att sätta sin kapacitet efter bästa förstånd så erbjuder ju arrayen den fördelen att man bara behöver konstruera arrayen en gång, förutsatt att man faktiskt vet tillräckligt mycket om vad man ska ha arrayen till för att sätta dess storlek över huvud taget, vilket ju är en förutsättning för att alls kunna använda en array.
         * Så, fördelarna överväger när antalet element i listan/arrayen blir stort.
         * 
         * Men, som sagt, kapaciteten kan sättas explicit.
        */
        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            bool done = false;
            do
            {
                string input = Console.ReadLine() ?? throw new Exception("The input stream seems to have closed.");
                if (string.IsNullOrEmpty(input))
                    done = true;
                else
                {
                    char nav = input[0];
                    string value = input.Substring(1);
                    switch (nav)
                    {
                        case '+':
                            theList.Add(value);
                            break;
                        case '-':
                            theList.Remove(value);
                            break;
                        default:
                            Console.WriteLine("Please only enter texts beginning with \"+\" or \"-\", or an empty string to return to the main menu.");
                            break;
                    }
                    Console.WriteLine($"Kapacitet: {theList.Capacity}{Environment.NewLine}Innehåll: {theList.Count}");
                }
            } while (!done);

        }


        /* Slutsatser från test med ExamineQueue:
         * Resultaten överensstämmer med förutsägelserna i README. 
         */
        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue<string> theQueue = new Queue<string>();
            bool done = false;
            do
            {
                string input = Console.ReadLine() ?? throw new Exception("The input stream seems to have closed.");
                if (string.IsNullOrEmpty(input))
                    done = true;
                else
                {
                    char nav = input[0];
                    string value = input.Substring(1);
                    switch (nav)
                    {
                        case '+':
                            theQueue.Enqueue(value);
                            break;
                        case '-':
                            if (value.Length > 0)
                                Console.WriteLine("Ignoring everything after \"-\"");
                            string? removed;
                            if (theQueue.TryDequeue(out removed))
                                Console.WriteLine(removed);
                            else
                                Console.WriteLine("Nothing to dequeue");
                            break;
                        default:
                            Console.WriteLine("Please only enter texts beginning with \"+\" or \"-\", or an empty string to return to the main menu.");
                            break;
                    }
                    Console.WriteLine($"Köns längd: {theQueue.Count}");
                }
            } while (!done);

        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

