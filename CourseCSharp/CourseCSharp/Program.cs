using CourseCSharp.Fundamentals;

namespace CourseCSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var central = new ExerciseCenter(new Dictionary<string, Action>()
            {
                { "First Program - Fundamentals", FirstProgram.Executar } 
            });

            central.SelectAndExecute();
        }
    }
}

