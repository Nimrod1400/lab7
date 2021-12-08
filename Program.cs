using System;


namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            Commander commander = new Commander();

            byte allEmployees = 28; // кол-во всех сотрудников            
            for (byte i = 0; i < allEmployees; i++)
            {
                byte num = (byte) r.Next(0, 2);
                if (num == 0)
                {
                    Cashier person = new Cashier() { 
                        FirstName = RandomFirstName(r),
                        LastName = RandomLastName(r), 
                        Qualification = RandomQ(r) };
                    commander.AllEmployees.Add(person);
                }
                else
                {
                    Loader person = new Loader() { 
                        FirstName = RandomFirstName(r),
                        LastName = RandomLastName(r)};
                    commander.AllEmployees.Add(person);
                }
            } // создан список всех сотрудников Командора
            
            byte tommorowAtWork = 7; // кол-во сотрудников, которые пойдут завтра на работу
            byte[] indexes = new byte[tommorowAtWork];
            for (byte i=0; i<tommorowAtWork; i++)
            {
                byte index = (byte)r.Next(0, allEmployees);
                if (!IsElementInArray(indexes, index))
                {
                    indexes[i] = index;
                }
            }
            
            foreach(byte i in indexes)
            {
                commander.TommorowAtWork.Add(commander.AllEmployees[i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Вот список сотрудников, которые выйдут завтра на работу: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            commander.PrintTeam();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Для всех кассиров нашего магазина были напечатаны следующие бейджики:");
            Console.ForegroundColor = ConsoleColor.Blue;
            commander.PrintBadgeForAllCashiers();
            Console.ReadKey();
        }

        static string RandomFirstName(Random r)
        {
            string[] namesList = { "Кирилл", "Александр", "Вячеслав",
                "Алексей", "Никита", "Владислав", "Дмитрий", "Эдуард", 
            "Мастурбек", "Мамба", "Олабама", "Ярополк", "Святослав", 
            "Федор", "Иван", "Андрей"};
            return namesList[r.Next(0, namesList.Length)];
        }

        static string RandomLastName(Random r)
        {
            string[] namesList = { "Скворцов", "Хохлов", "Русичев",
                "Воробьев", "Страстной", "Ион", "Атридиенко", "Жесткий",
            "Чучмеков", "Джонсон", "Идейный", "Узунов", "Чернышевский",
            "Годунов", "Чердынцев", "Мужицкий", "Мармеладов", "Лыков", 
            "Христов", "Дурачков", "Молодчиков", "Сяоми"};
            return namesList[r.Next(0, namesList.Length)];
        }

        static string RandomQ(Random r)
        {
            string[] qs = { "стажер", "кассир", "старший кассир" };
            return qs[r.Next(0, qs.Length)];
        }

        static bool IsElementInArray(byte[] array, byte element)
        {
            bool res = false;
            foreach (int e in array)
            {
                if (e == element)
                {
                    res = true;
                }
            }
            return res;
        }
    }
}
