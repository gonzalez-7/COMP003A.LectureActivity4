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
        }
    }
}
