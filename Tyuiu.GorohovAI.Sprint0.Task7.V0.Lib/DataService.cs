
namespace Tyuiu.GorohovAI.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArray(int[] numOne, int[] numTwo)
        {
            int[] res = new int[5];
            for (var i = 0; i < res.Length; i++)
            {
                res[i] = numOne[i] + numTwo[i];
            }
            return res;
        }
    }
}
