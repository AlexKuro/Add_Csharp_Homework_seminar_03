namespace Additional_tasks;
class Program
{
    static void Main(string[] args)
    {
        //Дополнительные задачи по С#

        void TaskAdd_1()
        {
            /* Задача 1. Рассчитать значение y при заданном x по формуле 
            у = sin^2x если х > 0, в противном случае  y = 1-2 sin x^2 
            sin^2x =  1 - cos2x/2       */
            Console.WriteLine(" - Задача 1 -");
            Console.Write("Введите число:-> ");
            double x = Convert.ToDouble(Console.ReadLine());
            double radian = x * Math.PI / 180; //нахождения радиана
            double y = 0;
            if (x > 0) y = Math.Sin(radian) * Math.Sin(radian);
            else y = 1 - 2 * Math.Sin(radian * radian);
            Console.WriteLine("Ответ у = " + Math.Round(y, 2));

        }

        void TaskAdd_2()
        {
            /* Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр. */


            Console.WriteLine("- Задача 2 -");
            Console.Write("Введите трёхзначное число:-> ");

            int container = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(container);
            int sum = 0;
            if (number > 99 && number < 1000)
            {
                while (number > 0)
                {
                    sum = sum + number % 10;
                    number /= 10;
                }
                if (sum % 3 == 0)
                {
                    Console.WriteLine($"Cуммa цифр в числе {container} -> {sum}  - кратна трём.");
                }
                else
                {
                    Console.WriteLine($"Cуммa цифр в числе {container} -> {sum} - НE кратна трём.");
                }
            }
            else
            {
                Console.WriteLine($"Ввод неверный. Число {container} не трехзначное.");
            }
;
            Console.WriteLine();
        }
        
        //TaskAdd_1();
        //TaskAdd_2();


    }
}
