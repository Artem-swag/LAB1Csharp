using System;

namespace Lab_01_C__
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            while (true)
            {
                Console.Clear();
                Menu();

                int choice = ReadInt("Ваш выбор: ");
                Console.WriteLine();

                if (!HandleChoice(p, choice))
                    break;

                Console.WriteLine();
                Console.WriteLine("Нажмите Enter, чтобы вернуться в меню...");
                Console.ReadLine();
            }
        }

        private static void Menu()
        {
            Console.WriteLine("        ЛАБОРАТОРНАЯ РАБОТА 1");
            Console.WriteLine(" 1. Дробная часть");
            Console.WriteLine(" 2. Букву в число");
            Console.WriteLine(" 3. Двузначное");
            Console.WriteLine(" 4. Диапазон");
            Console.WriteLine(" 5. Равенство");
            Console.WriteLine(" 6. Модуль числа");
            Console.WriteLine(" 7. Тридцать пять");
            Console.WriteLine(" 8. Тройной максимум");
            Console.WriteLine(" 9. Двойная сумма");
            Console.WriteLine("10. День недели");
            Console.WriteLine("11. Числа подряд");
            Console.WriteLine("12. Чётные числа");
            Console.WriteLine("13. Длина числа");
            Console.WriteLine("14. Квадрат");
            Console.WriteLine("15. Правый треугольник");
            Console.WriteLine("16. Поиск первого значения");
            Console.WriteLine("17. Поиск максимального по модулю");
            Console.WriteLine("18. Добавление массива в массив");
            Console.WriteLine("19. Возвратный реверс");
            Console.WriteLine("20. Все вхождения");
            Console.WriteLine(" 0. Выход");
        }

        private static bool HandleChoice(Program p, int choice)
        {
            switch (choice)
            {
                case 1: RunFraction(p); break;
                case 2: RunCharToNum(p); break;
                case 3: RunIs2Digits(p); break;
                case 4: RunIsInRange(p); break;
                case 5: RunIsEqual(p); break;
                case 6: RunAbs(p); break;
                case 7: RunIs35(p); break;
                case 8: RunMax3(p); break;
                case 9: RunSum2(p); break;
                case 10: RunDay(p); break;
                case 11: RunListNums(p); break;
                case 12: RunChet(p); break;
                case 13: RunNumLen(p); break;
                case 14: RunSquare(p); break;
                case 15: RunRightTriangle(p); break;
                case 16: RunFindFirst(p); break;
                case 17: RunMaxAbs(p); break;
                case 18: RunAdd(p); break;
                case 19: RunReverseBack(p); break;
                case 20: RunFindAll(p); break;
                case 0:
                    Console.WriteLine("До свидания!");
                    return false;
                default:
                    Console.WriteLine("Нет такого пункта. Попробуйте снова.");
                    break;
            }

            return true;
        }

        private static void RunFraction(Program p)
        {
            Console.WriteLine(" Дробная часть ");
            double x = ReadDouble("Введите число (например, 5,25): ");
            Console.WriteLine($"Результат: {p.fraction(x)}");
        }

        private static void RunCharToNum(Program p)
        {
            Console.WriteLine(" Символ в число ");
            char x = ReadDigit("Введите цифру 0-9: ");
            Console.WriteLine($"Результат: {p.charToNum(x)}");
        }

        private static void RunIs2Digits(Program p)
        {
            Console.WriteLine(" Двузначное ");
            int x = ReadInt("Введите число: ");
            Console.WriteLine($"Результат: {p.is2Digits(x)}");
        }

        private static void RunIsInRange(Program p)
        {
            Console.WriteLine(" Диапазон ");
            int a = ReadInt("Граница a: ");
            int b = ReadInt("Граница b: ");
            int num = ReadInt("Число num: ");
            Console.WriteLine($"Результат: {p.isInRange(a, b, num)}");
        }

        private static void RunIsEqual(Program p)
        {
            Console.WriteLine(" Равенство ");
            int a = ReadInt("a = ");
            int b = ReadInt("b = ");
            int c = ReadInt("c = ");
            Console.WriteLine($"Результат: {p.isEqual(a, b, c)}");
        }

        private static void RunAbs(Program p)
        {
            Console.WriteLine(" Модуль числа ");
            int x = ReadInt("Введите число: ");
            Console.WriteLine($"Результат: {p.abs(x)}");
        }

        private static void RunIs35(Program p)
        {
            Console.WriteLine(" Тридцать пять ");
            int x = ReadInt("Введите число: ");
            Console.WriteLine($"Результат: {p.is35(x)}");
        }

        private static void RunMax3(Program p)
        {
            Console.WriteLine(" Максимум из трёх ");
            int a = ReadInt("a = ");
            int b = ReadInt("b = ");
            int c = ReadInt("c = ");
            Console.WriteLine($"Результат: {p.max3(a, b, c)}");
        }

        private static void RunSum2(Program p)
        {
            Console.WriteLine(" Двойная сумма ");
            int x = ReadInt("x = ");
            int y = ReadInt("y = ");
            Console.WriteLine($"Результат: {p.sum2(x, y)}");
        }

        private static void RunDay(Program p)
        {
            Console.WriteLine(" День недели ");
            int x = ReadInt("Введите число от 1 до 7: ");
            Console.WriteLine($"Результат: {p.day(x)}");
        }

        private static void RunListNums(Program p)
        {
            Console.WriteLine(" Числа подряд ");
            int x = ReadInt("Введите x: ");
            Console.WriteLine($"Результат: {p.listNums(x)}");
        }

        private static void RunChet(Program p)
        {
            Console.WriteLine(" Чётные числа ");
            int x = ReadInt("Введите x: ");
            Console.WriteLine($"Результат: {p.chet(x)}");
        }

        private static void RunNumLen(Program p)
        {
            Console.WriteLine(" Длина числа ");
            long x = ReadLong("Введите число: ");
            Console.WriteLine($"Результат: {p.numLen(x)}");
        }

        private static void RunSquare(Program p)
        {
            Console.WriteLine(" Квадрат ");
            int x = ReadInt("Введите размер x: ");
            Console.WriteLine("Результат:");
            p.square(x);
        }

        private static void RunRightTriangle(Program p)
        {
            Console.WriteLine(" Правый треугольник ");
            int x = ReadInt("Введите высоту x: ");
            Console.WriteLine("Результат:");
            p.rightTriangle(x);
        }

        private static void RunFindFirst(Program p)
        {
            Console.WriteLine(" Поиск первого значения ");
            int[] arr = ReadIntArray("Введите элементы массива:");
            int x = ReadInt("Искомое x: ");
            Console.WriteLine($"Индекс: {p.findFirst(arr, x)}");
        }

        private static void RunMaxAbs(Program p)
        {
            Console.WriteLine(" Максимум по модулю ");
            int[] arr = ReadIntArray("Введите элементы массива:");
            Console.WriteLine($"Результат: {p.maxAbs(arr)}");
        }

        private static void RunAdd(Program p)
        {
            Console.WriteLine(" Добавление массива в массив ");
            int[] arr = ReadIntArray("Исходный массив arr:");
            int[] ins = ReadIntArray("Вставляемый массив ins:");
            int pos = ReadInt("Позиция pos: ");
            int[] result = p.add(arr, ins, pos);
            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
        }

        private static void RunReverseBack(Program p)
        {
            Console.WriteLine(" Возвратный реверс ");
            int[] arr = ReadIntArray("Введите элементы массива:");
            int[] result = p.reverseBack(arr);
            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
        }

        private static void RunFindAll(Program p)
        {
            Console.WriteLine(" Все вхождения ");
            int[] arr = ReadIntArray("Введите элементы массива:");
            int x = ReadInt("Искомое x: ");
            int[] result = p.findAll(arr, x);
            Console.WriteLine($"Результат: [{string.Join(", ", result)}]");
        }

        public double fraction(double x)
        {
            int c = (int)x;
            x = x - c;
            return x;
        }

        public int charToNum(char x)
        {
            return (int)x - 48;
        }

        public bool is2Digits(int x)
        {
            return (1 <= x / 10 && x / 10 <= 9) ||
                   (x / 10 <= -1 && x / 10 >= -9);
        }

        public bool isInRange(int a, int b, int num)
        {
            return (num >= b && num <= a) || (num >= a && num <= b);
        }

        public bool isEqual(int a, int b, int c)
        {
            return a == b && b == c;
        }

        public int abs(int x)
        {
            if (x >= 0)
                return x;
            else
                return x * (-1);
        }

        public bool is35(int x)
        {
            return ((x % 5 == 0) && (x % 3 != 0)) ||
                   ((x % 3 == 0) && (x % 5 != 0));
        }

        public int max3(int x, int y, int z)
        {
            int max = x;

            if (y >= max)
                max = y;

            if (z >= max)
                max = z;

            return max;
        }

        public int sum2(int x, int y)
        {
            if ((x + y >= 10) && (x + y <= 19))
                return 20;

            return x + y;
        }

        public string day(int x)
        {
            switch (x)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "Это не день недели";
            }
        }

        public string listNums(int x)
        {
            string result = "0";

            for (int i = 1; i <= x; i++)
                result = $"{result} {i}";

            return result;
        }

        public string chet(int x)
        {
            string result = "0";
            int a = 2;

            while (a <= x)
            {
                result = $"{result} {a}";
                a = a + 2;
            }

            return result;
        }

        public int numLen(long x)
        {
            if (x == 0)
                return 1;

            if (x < 0)
                x = -x;

            int count = 0;

            while (x > 0)
            {
                count++;
                x = x / 10;
            }

            return count;
        }

        public void square(int x)
        {
            for (int i = 0; i < x; i++)
            {
                string line = "";

                for (int j = 0; j < x; j++)
                    line = line + "*";

                Console.WriteLine(line);
            }
        }

        public void rightTriangle(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                string line = "";

                for (int j = 0; j < x - i; j++)
                    line = line + " ";

                for (int j = 0; j < i; j++)
                    line = line + "*";

                Console.WriteLine(line);
            }
        }

        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }

            return -1;
        }

        public int maxAbs(int[] arr)
        {
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if ((long)arr[i] * arr[i] > (long)max * max)
                    max = arr[i];
            }

            return max;
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] result = new int[arr.Length + ins.Length];

            for (int i = 0; i < pos; i++)
                result[i] = arr[i];

            for (int i = 0; i < ins.Length; i++)
                result[pos + i] = ins[i];

            int j = pos + ins.Length;

            for (int i = pos; i < arr.Length; i++)
            {
                result[j] = arr[i];
                j++;
            }

            return result;
        }

        public int[] reverseBack(int[] arr)
        {
            int[] result = new int[arr.Length];
            int j = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result[j] = arr[i];
                j++;
            }

            return result;
        }

        public int[] findAll(int[] arr, int x)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    count++;
            }

            int[] result = new int[count];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    result[j] = i;
                    j++;
                }
            }

            return result;
        }

        private static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                int value;

                if (int.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }

        private static long ReadLong(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                long value;

                if (long.TryParse(Console.ReadLine(), out value))
                    return value;

                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }

        private static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string line = Console.ReadLine();

                if (line == null)
                {
                    Console.WriteLine("Ошибка! Введите число (например, 5,25).");
                    continue;
                }

                line = line.Replace('.', ',');   // точка → запятая
                double value;

                if (double.TryParse(line, out value))
                    return value;

                Console.WriteLine("Ошибка! Введите число (например, 5,25).");
            }
        }

        private static char ReadDigit(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string line = Console.ReadLine();

                if (line != null && line.Length == 1 && line[0] >= '0' && line[0] <= '9')
                    return line[0];

                Console.WriteLine("Ошибка! Введите одну цифру 0-9.");
            }
        }

        private static int[] ReadIntArray(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                Console.Write(" (числа через пробел)\n> ");

                string line = Console.ReadLine();

                if (line == null || line == "")
                {
                    Console.WriteLine("Ошибка! Введите хотя бы одно число.");
                    continue;
                }

                string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] arr = new int[parts.Length];
                bool ok = true;

                for (int i = 0; i < parts.Length; i++)
                {
                    if (!int.TryParse(parts[i], out arr[i]))
                    {
                        Console.WriteLine($"Ошибка! '{parts[i]}' — не целое число.");
                        ok = false;
                        break;
                    }
                }

                if (ok)
                    return arr;
            }
        }
    }
}