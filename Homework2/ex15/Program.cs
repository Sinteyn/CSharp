string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение"};

Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()!);

if (day == 6 || day == 7)
    Console.WriteLine(week[day-1] + " Выходной день");
else if (day > 0 && day < 6)
    Console.WriteLine(week[day-1] + " Будний день");
else
    Console.WriteLine("Неккоректый ввод");