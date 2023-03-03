namespace New_5_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите что-то");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep); // Передаем значение переменных в метод

            Console.WriteLine("Улучшенное эхо: ");
            Echo2(str, deep); // Передаем значение во второй метод

            Console.ReadKey();
        }

        static void Echo(string phrase, int deep) //Инициализируем метод, получаем значения переменных
        {
            Console.WriteLine(phrase); //Вывод на экран при каждом вызове метода

            if (deep > 1) //Работет до тех пор, пока deep больше 1
            {
                Echo(phrase, deep - 1); //Здесь метод вызывает сам себя, пока deep не будет равен 1
            }
        }
        static void Echo2(string saidworld, int deep) //Второй метод, для усовершениствования эха
        {
            var modif = saidworld;
            if (modif.Length > 2) //Условие работы: до тех пор, пока длина строки более 2 букв
            {
                modif = modif.Remove(0, 2); //Удаляет указанное количество символов (в данном случае 2) начиная с первого символа (0) строки

            }
            Console.WriteLine("..." + modif); //Выводим значение переменной modif с учетом удаленных символов
            
            if (deep > 1 && modif.Length > 1) //Условие вызова метода (Добавил доп условие, чтобы вызов прекращался сразу, как останется 1 символ)
            {
                Echo2(modif, deep - 1); //Здесь метод вызывает сам себя, пока deep не будет равен 1
            }

        }
    }
}