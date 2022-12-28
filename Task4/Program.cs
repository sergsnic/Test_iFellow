// Задача 4 посложнее:
// Напишите метод, который будет вычислять угол между часовой и минутной стрелками часов. 
// На вход функции подаётся время в виде двух переменных: "hours" и "minutes".
// Расчет угла производить относительно реального поведения стрелок часов.
// 
// Пояснение к решению задачи. Принял часовую стрелку как начало отсчета(0°). 
// Из этого условия проводил расчет угла между стрелками.
// Если gradusHours > gradusMinute то (360 - gradusHours + gradusMinute).
// Если gradusHours <= gradusMinute то (gradusMinute - gradusHours). 
// Если принять за начало отсчета любую из стрелкок имеющую меньший угол, то расчет угла между стрелками 
// будет выглядеть следующим образом Math.Abs(gradusMinute - gradusHours).

Console.Write("Введите часы: ");
int hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минуты: ");
int minutes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Угол между часовой и минутной стрелкоой: {ClockAngle(hours, minutes)} °");
// Метод (ClockAngle), который вычисляет угол между часовой и минутной стрелками часов.
double ClockAngle(int hoursClock, int minuteClock)
{
    if (hours > 12) hours = hours - 12;
    double gradusHours = hoursClock * 30 + 0.5 * minuteClock;
    double gradusMinute = minuteClock * 6;
    if (gradusHours > gradusMinute) return (360 - gradusHours + gradusMinute);
    return (gradusMinute - gradusHours);
}
