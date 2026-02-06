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
                Console.WriteLine("$Task {taskNumber} completed");
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


        }
    }
}
