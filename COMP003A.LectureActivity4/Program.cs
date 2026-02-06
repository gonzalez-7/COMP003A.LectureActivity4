namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SECTION A = while Loop Practice");

            // This loop completes tasks 1-5
            int taskNumber = 1;

            while (taskNumber <= 5)
            {
                Console.WriteLine($"Task {taskNumber} completed");
                taskNumber++;
            }
            Console.WriteLine();

            Console.WriteLine("SECTION B - do-while Loop Practice");

            /*
            This do-while loop executes at least one time, the code inside the do block runs before the condition is checked
            */

            int attempt = 1;

            do
            {
                Console.WriteLine($"Attempt {attempt}");
                attempt++;
            } while (attempt <= 3);

            Console.WriteLine();

            Console.WriteLine("SECTION C - for Loop Practice");
            // Added a for loop because I know the exact number of steps from 1 to 4 
            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine($"Step {i}");
            }

            Console.WriteLine();

            Console.WriteLine("SECTION D - Loop Control (break and continue)");
            
            int number = 0;

            while (number <= 6)
            {
                number++;


                // continue is used to skip printing at number 4
                if (number == 4)
                {
                    continue;
                }

                // break is to stop the loop completely when it reaches number 6
                if (number == 6)
                {
                    break;
                }
                
                Console.WriteLine(number);
            }

            Console.WriteLine();


			/*
             * Which loop type was easiest for you to understand?
                The easiest loop to understand for me was the for loop
             * Which loop required the most careful tracing?
                I think that the loop that required the most careful tracing was the while loop
             * How did comments help you understand your loops?
                Comments helped me understand my loops and how they work, also what was their purpose.
             */
		}
	}
}
