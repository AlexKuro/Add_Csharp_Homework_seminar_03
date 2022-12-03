namespace Additional_tasks;
class Program
{
    static void Main(string[] args)
    {
        //Дополнительные задачи по С#

        void TaskAdd1() //Задача 1
        {
            /* Задача 1. Рассчитать значение y при заданном x по формуле 
            у = sin^2x если х > 0, в противном случае  y = 1-2 sin x^2 
            sin^2x =  1 - cos2x/2       */
            Console.WriteLine("     - Задача 1 -");
            Console.WriteLine("     Рассчитать значение y при заданном x по формуле");
            Console.WriteLine("у = sin^2x если х > 0, в противном случае  y = 1-2 sin x^2");
            Console.Write("Введите число:-> ");
            double x = Convert.ToDouble(Console.ReadLine());
            double radian = x * Math.PI / 180; //нахождения радиана
            double y = 0;
            if (x > 0) y = Math.Sin(radian) * Math.Sin(radian);
            else y = 1 - 2 * Math.Sin(radian * radian);
            Console.WriteLine("Ответ у = " + Math.Round(y, 2));

        }

        void TaskAdd2() //Задача 2
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
            Console.WriteLine();
        }

        void TaskAdd3() //Задача 3
        {
            /* Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.*/


            Console.WriteLine("- Задача 3 -");
            Console.WriteLine("Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.");
            Console.Write("Введите трёхзначное число:-> ");

            int container = Convert.ToInt32(Console.ReadLine());
            int number = Math.Abs(container);
            bool result = false;
            int index = 2;
            int[] arrayDigit = new int[3];
            if (number > 99 && number < 1000)
            {
                while (number > 0)
                {
                    arrayDigit[index] = number % 10;
                    number /= 10;
                    index = index - 1;
                }
                if (arrayDigit[0] == 4 | arrayDigit[0] == 7) result = true;
                if (arrayDigit[1] == 4 | arrayDigit[1] == 7) result = true;
                if (arrayDigit[2] == 4 | arrayDigit[2] == 7) result = true;

                if (result) Console.WriteLine($"В трёхзначном числе {container} есть цифра 4 или 7.");
                else Console.WriteLine($"В трёхзначном числе {container} НЕТ цифр 4 или 7.");
            }
            else
            {
                Console.WriteLine($"Ввод неверный. Число {container} не трехзначное.");
            }

        }

        void TaskAdd4() //Задача 4
        {
            /* Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10. */
            Console.WriteLine("   - Задача 4 -");
            Console.WriteLine("Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.");
            Console.Write("Вот мой массив: ");
            int[] arrayN = new int[10];
            int index = 1;
            for (int i = 0; i < arrayN.Length; i++)
            {
                arrayN[i] = index;
                index++;
            }
            PrintArray(arrayN);
        }

        //-------------Задачи повышенной сложности ------------

        void TaskDifficult1() //Задача 1*
        {
            /*Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
            Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.*/

            Console.WriteLine("- Задача 1* -");
            Console.Write("Введите номер четверти:-> ");
            int number = Convert.ToInt32(Console.ReadLine());
            int rangeXmin = 0;
            int rangeXmax = 0;
            int rangeYmin = 0;
            int rangeYmax = 0;

            if (number == 1) //Диапазон возможных координат точек от x > 0 и у > 0
            {
                rangeXmin = 0;
                rangeXmax = 10;
                rangeYmin = 0;
                rangeYmax = 10;
                FunctionBlockTaskDifficult_1(rangeXmin, rangeXmax, rangeYmin, rangeYmax);
            }
            else if (number == 2) //Диапазон возможных координат точек от x < 0 и у > 0 
            {
                rangeXmin = -10;
                rangeXmax = 0;
                rangeYmin = 0;
                rangeYmax = 10;
                FunctionBlockTaskDifficult_1(rangeXmin, rangeXmax, rangeYmin, rangeYmax);
            }
            else if (number == 3) //Диапазон возможных координат точек от x < 0 и у < 0 
            {
                rangeXmin = -10;
                rangeXmax = 0;
                rangeYmin = -10;
                rangeYmax = 0;
                FunctionBlockTaskDifficult_1(rangeXmin, rangeXmax, rangeYmin, rangeYmax);
            }
            else if (number == 4) //Диапазон возможных координат точек от x > 0 и у < 0  
            {
                rangeXmin = 0;
                rangeXmax = 10;
                rangeYmin = -10;
                rangeYmax = 0;
                FunctionBlockTaskDifficult_1(rangeXmin, rangeXmax, rangeYmin, rangeYmax);
            }
            else
            {
                Console.WriteLine("Ввод неверный!");
            }
        }

        void TaskDifficult2() //Задача 2*
        {
            /* Задача 2*. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD? */

            Console.WriteLine("- Задача 2* -");
            Random rand = new Random();
            int xA, yA, xB, yB, xC, yC, xD, yD;

            int rangMin = -10;
            int rangMax = 10;
            xA = rand.Next(rangMin, rangMax);
            yA = rand.Next(rangMin, rangMax);
            xB = rand.Next(rangMin, rangMax);
            yB = rand.Next(rangMin, rangMax);
            xC = rand.Next(rangMin, rangMax);
            yC = rand.Next(rangMin, rangMax);
            xD = rand.Next(rangMin, rangMax);
            yD = rand.Next(rangMin, rangMax);
            Console.WriteLine($"Даны 4 точки ->  a({xA}, {yA})  b({xB}, {yB})  c({xC}, {yC})  d({xD}, {yD})");
            Console.WriteLine("Пересекаются ли вектора AB и CD?");
            double[] array = new double[3];

            TaskDifficult_2_1(array, xA, yA, xB, yB, xC, yC, xD, yD);

            if (array[2] == -1) Console.WriteLine("Нет, вектора AB и CD не пересекаются.");
            else Console.WriteLine($"Да, вектора AB и CD пересекаются в точке F({array[0]}, {array[1]}).");

        }

        void TaskDifficult3() //Задача 3*
        {
            /*  Задача 3. Найти в какой четверти лежит точка пересечения из задачи 2 (если вектора пересекаются).*/

            Console.WriteLine("- Задача 3* -");
            Console.WriteLine("Найти в какой четверти лежит точка пересечения из задачи 2*");
            Random rand = new Random();
            int xA, yA, xB, yB, xC, yC, xD, yD;
            int rangMin = -10;
            int rangMax = 10;
            xA = rand.Next(rangMin, rangMax);
            yA = rand.Next(rangMin, rangMax);
            xB = rand.Next(rangMin, rangMax);
            yB = rand.Next(rangMin, rangMax);
            xC = rand.Next(rangMin, rangMax);
            yC = rand.Next(rangMin, rangMax);
            xD = rand.Next(rangMin, rangMax);
            yD = rand.Next(rangMin, rangMax);
            Console.WriteLine($"Даны 4 точки ->  a({xA}, {yA})  b({xB}, {yB})  c({xC}, {yC})  d({xD}, {yD})");
            Console.WriteLine("Пересекаются ли вектора AB и CD?");
            double[] array = new double[3];
            TaskDifficult_2_1(array, xA, yA, xB, yB, xC, yC, xD, yD);

            bool result = false;
            if (array[2] == -1) Console.WriteLine("Вектора из задачи 2* не пересекаются!");
            else result = true;

            if (result)
            {
                if (array[0] > 0 && array[1] > 0)
                {
                    Console.Write($"Вектора AB и CD из задачи пересекаются в точке F({array[0]}, {array[1]}).");
                    Console.WriteLine(" - 1-я четверть");
                }
                else if (array[0] < 0 && array[1] > 0)
                {
                    Console.Write($"Вектора AB и CD из задачи пересекаются в точке F({array[0]}, {array[1]}).");
                    Console.WriteLine(" - 2-я четверть");
                }
                else if (array[0] < 0 && array[1] < 0)
                {
                    Console.Write($"Вектора AB и CD из задачи пересекаются в точке F({array[0]}, {array[1]}).");
                    Console.WriteLine(" - 3-я четверть");
                }
                else if (array[0] > 0 && array[1] < 0)
                {
                    Console.Write($"Вектора AB и CD из задачи пересекаются в точке F({array[0]}, {array[1]}).");
                    Console.WriteLine(" - 4-я четверть");
                }
                else
                {
                    Console.WriteLine("Точка лежит на координатной прямой");
                }
            }



        }



        void TaskDifficult5() //Задача 5*
        {
            /*  Задача 5. На вход подаётся число n > 4, указывающее длину пароля. 
              Создайте метод, генерирующий пароль заданной длины. \
              В пароле обязательно использовать цифру, букву и специальный знак.*/
            Console.WriteLine("          - Задача 5* -");
            Console.WriteLine("        Генератор паролей");
            Console.Write("Введите длину пароля, больше 4:-> ");
            int passwordLength = Convert.ToInt32(Console.ReadLine());
            string[] conteiner = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
            "A", "B", "C", "D", "E", "F", "G", "H", "I","K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
            "!", "@", "#", "$", "%", "&", "*", "_", "-", "?", "~", "!", "@", "#", "$", "%", "&", "*", "_", "-", "?", "~"};
            string password = "";
            Random rand = new Random();
            int index = 0;
            if (passwordLength > 4)
            {
                Console.WriteLine("Ваши сгенерированные пароли:");
                for (int i = 0; i < 4; i++)
                {
                    for (index = 0; index < passwordLength; index++)
                    {
                        password = password + conteiner[rand.Next(0, conteiner.Length)];
                    }
                    index = 0;
                    Console.Write("            ");
                    Console.WriteLine(password);
                    password = "";
                }

            }
            else Console.Write("Неверный ввод длины пароля!");
        }

        void TaskDifficult7() //Задача 7*
        {
            /*   Задача 7. Массив из ста элементов заполняется случайными числами от 1 до 100. 
            Удалить из массива все элементы, содержащие цифру 3. 
            Вывести в консоль новый массив и количество удалённых элементов.*/
            int length = 10;
            int[] numbers = new int[length];
            FillArray(numbers, 0, 11);
            PrintArray(numbers);
            int numberDigits = 0;
            int container = 0;

            for (int i = 0; i < length; i++) if (numbers[i] == 3) numberDigits++; //нахождения количества троек в массиве

            for (int i = 0; i < length; i++)
            {
                if (numbers[i] == 3)
                {
                    for (int j = i; j < length - 1; j++)
                    {
                        container = numbers[j + 1];
                        numbers[j] = container;
                    }
                }
            }

            int size = length - numberDigits;
            int[] resultNum = new int[size];

            for (int i = 0; i < size; i++) resultNum[i] = numbers[i];

            Console.WriteLine();
            PrintArray(resultNum);
            Console.WriteLine();
            Console.WriteLine("Количество удалённых элементов -> " + numberDigits);

        }

        void TaskDifficult8() //Задача 8*
        {
            //Задача 8. Напишите программу, который выводит на консоль таблицу умножения от 1 до n, 
            //где n задаётся случайно от 2 до 100.

            Random rand = new Random();
            int number = rand.Next(1, 101);
            Console.WriteLine("     - - Задача 8* - -");
            Console.WriteLine($"Таблица умножения от 1 до {number}");
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine($"\t{i} * {j} = {i * j} ");
                }
                Console.WriteLine();
            }

        }

        void TaskDifficult_2_1(double[] arrayCord, int x1, int y1, int x2, int y2, int x11, int y11, int x22, int y22) //Метод для задачи 2 (повышенной сложности)
        {
            /* Задача 2*. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD? */
            /*  Уравнение прямой отрезка AB: 
                         y=K1*x+b1
                Уравнение прямой отрезка CD: 
                         y=K2*x+b2
                Все точки:
                a(x1, y1) и b(x2, y2), 
                c(x11, y11) и d(x22, y22).
                Возможная точка пересечения F(x,y).
            */

            double k1 = 0;
            double k2 = 0;
            double b1 = 0;
            double b2 = 0;

            if ((y2 - y1) == 0 | (x2 - x1) == 0) k1 = 0;
            else k1 = (y2 - y1) / (x2 - x1);

            if ((y22 - y11) == 0 | (x22 - x11) == 0) k2 = 0;
            else k2 = (y22 - y11) / (x22 - x11);

            b1 = y1 - (k1 * x1);
            b2 = y11 - (k2 * x11);


            //double x = Math.Round((b2 - b1) / (k1 - k2), 1);
            //y = k1 * x + b1, y = k2 * x + b2; 

            Console.WriteLine($"Уравнение прямой AB y = {k1} x + ({b1}) ");
            Console.WriteLine($"Уравнение прямой CD y = {k2} x + ({b2}) ");

            // x = b2-b1 / k1-k2
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            double yF = k2 * x + b2;

            if (y == yF)
            {
                arrayCord[0] = Math.Round(x, 0);
                arrayCord[1] = Math.Round(y, 0);
            }
            else arrayCord[2] = -1;
        }

        void PrintArray(int[] pArray) // печать массива
        {
            for (int i = 0; i < pArray.Length; i++) Console.Write($" {pArray[i]}");
        }

        void PrintArrayStr(string[] pArray) // печать массива
        {
            for (int i = 0; i < pArray.Length; i++) Console.Write($" {pArray[i]}");
        }

        void FillArray(int[] numbers, int minValue = 0, int maxValue = 9) //метод заполнения массива случайными числами
        {
            maxValue++;
            Random rand = new Random();
            int length = numbers.Length;
            for (int i = 0; i < length; i++)
            {
                numbers[i] = rand.Next(minValue, maxValue);
            }
        }

        void FunctionBlockTaskDifficult_1(int xMin, int xMax, int yMin, int yMax) //Метод для задачи 1 (повышенной сложности)
        {

            Random rand = new Random();
            int xA, yA, xB, yB, xC, yC;
            double result_1, result_2, result_3;

            xA = rand.Next(xMin, xMax);
            yA = rand.Next(yMin, yMax);
            xB = rand.Next(xMin, xMax);
            yB = rand.Next(yMin, yMax);
            xC = rand.Next(xMin, xMax);
            yC = rand.Next(yMin, yMax);
            Console.WriteLine($"3 случайные точки -> A({xA}, {yA}), B({xB}, {yB}), C({xC}, {yC}), ");

            result_1 = Math.Round(Math.Sqrt(Math.Pow(xA - 0, 2) + Math.Pow(yA - 0, 2)), 2);
            result_2 = Math.Round(Math.Sqrt(Math.Pow(xB - 0, 2) + Math.Pow(yB - 0, 2)), 2);
            result_3 = Math.Round(Math.Sqrt(Math.Pow(xC - 0, 2) + Math.Pow(yC - 0, 2)), 2);

            double minDistance = result_1;
            string point = "A";
            if (result_2 < minDistance)
            {
                minDistance = result_2;
                point = "B";
            }
            if (result_3 < minDistance)
            {
                minDistance = result_3;
                point = "C";
            }
            Console.WriteLine($"Оптимальный маршрут для торгового менеджера до точки - - {point}.");
            Console.WriteLine();
            Console.WriteLine($"pасстояние от центра координат: A -> {Convert.ToInt32(result_1)}.");
            Console.WriteLine($"pасстояние от центра координат: B -> {Convert.ToInt32(result_2)}.");
            Console.WriteLine($"pасстояние от центра координат: C -> {Convert.ToInt32(result_3)}.");
        }

        //TaskAdd1();       // Задача 1
        //TaskAdd2();       // Задача 2
        //TaskAdd3();       // Задача 3
        //TaskAdd4();       // Задача 4
        //TaskDifficult1(); // Задача 1*
        //TaskDifficult2(); // Задача 2*
        //TaskDifficult3(); // Задача 3*

        //TaskDifficult5(); // Задача 5*
        //TaskDifficult7(); // Задача 7*
        //TaskDifficult8(); // Задача 8*

    }
}
