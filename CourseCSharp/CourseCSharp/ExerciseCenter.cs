namespace CourseCSharp
{
    public class ExerciseCenter
    {
        Dictionary<string, Action> _execicises;

        public ExerciseCenter(Dictionary<string, Action> execicises)
        {
            _execicises = execicises;
        }

        public void SelectAndExecute()
        {
            int i = 1;
            
            foreach (KeyValuePair<string, Action> entry in _execicises)
            {
                Console.WriteLine("{0}) {1}", i, entry.Key);
                i++;
            }

            Console.Write("Enter the number (or empty for the last one)?");

            int.TryParse(Console.ReadLine(), out int num);
            bool validNum = num > 0 && num < _execicises.Count;
            num = validNum? num - 1 : _execicises.Count - 1;

            string exerciseName = _execicises.ElementAt(num).Key;

            Console.Write("\nExecutando exercício ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(exerciseName);
            Console.ResetColor();

            Console.WriteLine(String.Concat(Enumerable.Repeat("=", exerciseName.Length + 21)) + "\n");

            Action execute = _execicises.ElementAt(num).Value;

            try
            {
                execute();
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ocorreu um erro: {0}", ex.Message);
                Console.ResetColor();

                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
