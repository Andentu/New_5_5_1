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
    }
}