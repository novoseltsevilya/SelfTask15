using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();

            Console.WriteLine("Введите начальное значение:");
            int start = Convert.ToInt32(Console.ReadLine());
            arithProgression.SetStart(start);
            geomProgression.SetStart(start);

            Console.WriteLine("Введите шаг:");
            int step = Convert.ToInt32(Console.ReadLine());
            arithProgression.SetStep(step);
            geomProgression.SetStep(step);

            Console.WriteLine("\nАрифметическая прогрессия...\n");

            Console.WriteLine($"Начальное значение: {arithProgression.StartValue}.");
            Console.WriteLine($"Следующее значение: {arithProgression.GetNext()}.");
            Console.WriteLine($"Следующее значение: {arithProgression.GetNext()}.");
            Console.WriteLine($"Следующее значение: {arithProgression.GetNext()}.");

            Console.WriteLine("\nВозврат к начальному значению...\n");
            arithProgression.Reset();

            Console.WriteLine($"Начальное значение: {arithProgression.StartValue}.");
            Console.WriteLine($"Следующее значение: {arithProgression.GetNext()}.");
            Console.WriteLine($"Следующее значение: {arithProgression.GetNext()}.");

            Console.WriteLine("\nГеометрическая прогрессия...\n");

            Console.WriteLine($"Начальное значение: {geomProgression.StartValue}.");
            Console.WriteLine($"Следующее значение: {geomProgression.GetNext()}.");
            Console.WriteLine($"Следующее значение: {geomProgression.GetNext()}.");
            Console.WriteLine($"Следующее значение: {geomProgression.GetNext()}.");

            Console.WriteLine("\nВозврат к начальному значению...\n");
            geomProgression.Reset();

            Console.WriteLine($"Начальное значение: {geomProgression.StartValue}.");
            Console.WriteLine($"Следующее значение: {geomProgression.GetNext()}.");
            Console.WriteLine($"Следующее значение: {geomProgression.GetNext()}.");

            Console.WriteLine("\nДля выхода нажмите любую клавишу:");
            Console.ReadKey();
        }
    }
}