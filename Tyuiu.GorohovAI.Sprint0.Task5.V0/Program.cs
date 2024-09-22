using Tyuiu.GorohovAI.Sprint0.Task5.V0.Lib;
namespace Tyuiu.GorohovAI.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Горохов Александр Иванович | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Оператор if - полная и короткая форма записи                            *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #0                                                            *");
            Console.WriteLine("* Выполнил: Горохов Александр Иванович | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу на, которая запрашивает целые значения с клавиатуры и *");
            Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
            Console.WriteLine("*и.                                                                       *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            Console.WriteLine("A+B = " + DataService.Addition(1, 5));
            Console.WriteLine("A-B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A*B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A-B = " + DataService.Subtraction(5, 0));
            Console.ReadKey();
        }
    }
}