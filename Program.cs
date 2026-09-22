int dayNumber = 5;

switch (dayNumber) {
    case 5 or 6 or 7: Console.WriteLine("Выходной"); break;
    default: Console.WriteLine("Будний"); break;
}

int score = 78;
switch (score) { 
    case >= 0 and < 40:
         Console.WriteLine("Неудовлетворительно");
         break;
    case >= 40 and < 60:
        Console.WriteLine("Удовлетворительно");
        break;
    case >= 60 and < 80:
        break;
    case >= 80 and <= 100:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Некорректный балл");
        break;
}

int temperature = 22;
string result = temperature switch {
    >= 35 => "Очень жарко",
    >= 25 => "Жарко",
    >= 15 => "Комфортно",
    >= 0 => "Прохладно",
    _ => "Мороз"
};
Console.WriteLine(result);

string role = "teacher";
string result = role switch {
    "admin" => "Полный доступ",
    "teacher" => "Доступ преподователя",
    not "admin" => "Ограниченный доступ"
};

Console.WriteLine(result);

int age = 20;
bool hasTicket = true;
switch (age) {
    case >= 18 when hasTicket: 
        Console.WriteLine("Вход разрешён");
        break;
    case >= 18:
        Console.WriteLine("Нет билета");
        break;
    default:
        Console.WriteLine("Возраст не подходит");
        break;
}

int level = 2;
switch (level) {
    case 1:
        Console.WriteLine("Начальный уровень");
        break;
    case 2:
        Console.WriteLine("Средний уровень");
        goto case 1;
    case 3:
        Console.WriteLine("Продвинутый уровень");
        break;
}


int dayNumber = 6;
switch (dayNumber) {
    case 1 or 2 or 3 or 4 or 5: Console.WriteLine("Будний"); break;
    default: Console.WriteLine("Выходной"); break;
}

int month = 5;
string season = month switch {
    12 or 1 or 2 => "Зима",
    3 or 4 or 5 => "Весна",
    6 or 7 or 8 => "Лто",
    9 or 10 or 11 => "Осень",
    _ => "Неверный месяц"
};
Console.WriteLine(season);

string day = "суббота";
string schedule = day switch {
    "понедельник" or "вторник" or "среда" or "четверг" or "пятница" => "9:00-21:00",
    "суббота" => "10:00-20:00",
    "воскресенье" => "10:00-18:00",
    _ => "День не распознан"
};
Console.WriteLine(schedule);

string transport = "метро";
string type = transport switch {
    "автобус" => "Наземный транспорт",
    "метро" => "Подземный транспорт",
    "такси" => "Индивидуальный транспорт",
    _ => "Неизвестный транспорт",
};
Console.WriteLine(type);


