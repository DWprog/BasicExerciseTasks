using System.Collections.Generic;
using System.Linq;

namespace BasicExerciseTasks.Tasks
{
    public class TaskFunctions
    {
        public static double[] ArrayWithoutDuplicate(double[] arrayDuplicate)
        {
            List<double> numbers = arrayDuplicate.ToList();
            numbers.Sort();

            double current = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (current == numbers[i])
                {
                    numbers.RemoveAt(i);
                    i--;
                }
                else
                {
                    current = numbers[i];
                }
            }

            return numbers.ToArray();
        }
    }
}
