using System;
namespace project
{
    class Program
    {
        static int roomNumber = 1; // От куда начинаем игру
        static bool Vopros = false; //Задача
        static bool zadaha = false;  // Выполнения задачи
        static string name = ""; // Имя гг
        static void Main(string[] args)
        {
            seve();
            Start(); // Выбор имени 
            Introduction(); // Предыстория



            while (true)
            {
                if (roomNumber == 1) ActionStarship(); //Класс
                else if (roomNumber == 2) ActionTemple(); //Препод
                else if (roomNumber == 3) Level1(); //Комп
                else if (roomNumber == 4) Level2(); //Хакер
                else if (roomNumber == 5) seve(); //Хакер
            }
        }

        static void ActionStarship() //Класс (1)
        {
            Console.Clear();
            Console.WriteLine("*Вы стоите по середине класса*");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nЧто сделать: ");
            Console.WriteLine("1. Подойти к преподу");
            Console.WriteLine("2. Пойти за компьютер");
            Console.WriteLine("3. Сохранить игру ");
            Console.ResetColor();
            int option;
            if (zadaha)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("4. Сдать задание и выйти");
                Console.ResetColor();
                option = GetIntInRange(4);
            }
            else option = GetIntInRange(3);

            if (option == 1)
            {
                Console.WriteLine("*Ты подходишь к преподователю*");
                Console.ReadLine();
                roomNumber = 2;
            }
            else if (option == 2)
            {
                Console.WriteLine("*Ты подходишь к компьютеру*");
                Console.ReadLine();
                CheckVopros();
            }
            else if (option == 3)
            {
                seve1();
            }
            else if (option == 4)
            {
                exit();
            }
        }
        static void ActionTemple() // Преподователь (2)
        {
            Console.Clear();
            Console.WriteLine("*Вы не уверена подошли к преподователю*");
            Console.ReadLine();
            Console.WriteLine("Здраствуйте Евгений Сергеевич");
            Console.WriteLine("\n Что сделать: ");
            Console.WriteLine("1. Отойти от препода  ");
            Console.WriteLine("2. Узнать задачу на урок ");
            Console.WriteLine("3.");
            int option = GetIntInRange(3);
            if (option == 1)
            {
                Console.WriteLine("Вернуться обратно в класс");
                roomNumber = 1;
            }
            else if (option == 2)
            {
                VoprosPrepoda();
                Console.WriteLine("*Вы узнали задачу на урок*");
                Console.ReadLine();
                Vopros = true;
            }
            else
            {
                Console.WriteLine("");
                CheckVopros();

            }
        }
        static void CheckVopros() //Проверка чтобы подойти к компу
        {
            Console.WriteLine("*Вы подходите к компьютеру*");
            Console.ReadLine();
            Console.WriteLine("Узнать бы задачу у преподавателя ....");
            if (!Vopros)
            {
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("");
                roomNumber = 3;
            }
        }
        static void Level1() // Работа с компьютером (3)
        {
            Console.Clear();
            Console.WriteLine("");
            int option;
            Console.WriteLine("\n Что сделать: ");
            Console.WriteLine("1. Вернуться в класс");
            if (!zadaha)
            {
                Console.WriteLine("2. Сделать задание");
                option = GetIntInRange(2);
            }
            else option = GetIntInRange(1);

            if (option == 1)
            {
                Console.WriteLine("Возращаемся в класс....");
                roomNumber = 1;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                zadaha = true;
            }
        }
        static void Level2() //развязка с хакером (4)
        {

        }

        static void VoprosPrepoda()
        {
            Console.Clear();
            Console.WriteLine("*Вы долго слушаете преподавателя*");
            Console.ReadLine();
            Console.WriteLine($"{name} - Да все понятно! ");
            Console.ReadLine();
        }
        static void exit() // конец игры
        {
            Console.Clear();
            string centerText = "";
            int centerX = (Console.WindowWidth / 3) - (centerText.Length / 3);
            int centerY = (Console.WindowHeight / 10) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ИГРА ЗАКОНЧИНА");
            Console.ReadLine();
            Console.ResetColor();
            Console.WriteLine("Вы сделала задание.");
            Console.ReadLine();
            Console.WriteLine("А что если тут есть что-то еще ?");
            Console.ReadLine();
            System.Environment.Exit(0);
        }
        static void Introduction() // предыстория 
        {
            string centerText = "";
            int centerX = (Console.WindowWidth / 3) - (centerText.Length / 3);
            int centerY = (Console.WindowHeight / 10) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            Console.WriteLine("#Добро пожаловать в игру#");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n \n для продолжения повествования нажимайте : 'Enter'");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine($"*{name} бежит по коридору в класс*");
            Console.ReadLine();
            Console.WriteLine($"{name} - Черт надоже было проспать!");
            Console.ReadLine();
            Console.WriteLine("*Вы добегаете до двери класса*");
            Console.ReadLine();
            Console.WriteLine($"{name} - Если не ошибаюсь сегодня мы програмируем на C#.");
            Console.ReadLine();
            Console.WriteLine("*Вы стоите у двери и не уверено её открываете*");
            Console.ReadLine();
            Console.WriteLine("*Перед вами компьютерный класс с вашими одногруппниками*");
            Console.ReadLine();
            Console.WriteLine("*По всей видимости вы не один такой опаздун*");
            Console.ReadLine();
            Console.WriteLine($"{name} (про себя) - Так до узнать задание и сесть за свободное место.");
            Console.ReadLine();

        }
        static void Start() // Имя для ГГ
        {
            if (name == "")
            {
                string centerText = "";
                int centerX = (Console.WindowWidth / 3) - (centerText.Length / 3);
                int centerY = (Console.WindowHeight / 10) - 1;
                Console.SetCursorPosition(centerX, centerY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Как будут звать вашего персонажа ? ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Для потверждение нажмите 'Enter'");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Имя персонажа: ");
                int tPos = Console.CursorTop;
                int lPos = Console.CursorLeft;
                name = Console.ReadLine();
                Console.ResetColor();
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Вы выбрали имя : {name}");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Для потверждение нажмите 'Enter'");
                Console.ResetColor();
                Console.ReadLine();

                Console.Clear();
            }
            else
            {

            }
        }
        static int GetIntInRange(int optionsNumber) // проверка что мы пишем только нужные числа
        {
            string input = Console.ReadLine();
            int number = -1;
            bool isConverted = int.TryParse(input, out number);
            bool isInRange = number >= 1 && number <= optionsNumber;

            while (!isConverted || !isInRange)
            {

                Console.WriteLine("Неверная опция! ");
                input = Console.ReadLine();
                isConverted = int.TryParse(input, out number);
                isInRange = number >= 1 && number <= optionsNumber;
            }

            return number;

        }

        static void seve()
        {
                Console.WriteLine("Работа с сохранениями");
                Console.ReadLine();
                File.AppendAllText(@".\file.txt", name); // Сохраняем эту строку в файл
                name = File.ReadAllText(@".\file.txt"); // Считываем весь текст из файла
        }
        static void seve1()
        {
            Console.WriteLine("Работа с сохранениями");
            Console.ReadLine();
            File.AppendAllText(@".\file.txt", name); // Сохраняем эту строку в файл
            name = File.ReadAllText(@".\file.txt"); // Считываем весь текст из файла
        }
    }
}