// Задача 3 посложнее:
// Напишите класс BaseConverter для конвертации из градусов по Цельсию в
// Кельвины​, ​Фаренгейты​, и так далее. У метода должен быть метод convert, который
// и делает конвертацию.
// При запуске кода должна быть возможность ввести градусы Цельсия и выбора конвертации в Кельвины​ или ​Фаренгейты

Console.Write("Введите температуру в градусах Цельсия (°C): ");
double temperature = Convert.ToDouble(Console.ReadLine());
Console.Write("Конвертировать температуру в Кельвины[К] нажмите - 1 , в Фаренгейты[°F] нажмите - 2 : ");
int scale = Convert.ToInt32(Console.ReadLine());
BaseConverter TemperatureConverter = new BaseConverter();
TemperatureConverter.Convert(temperature, scale);
// Класс BaseConverter для конвертации из градусов по Цельсию Кельвины​, ​Фаренгейты.
public class BaseConverter
{
    public void Convert(double temperatureCelsius, int temperatureScale)
    {
        if (temperatureScale == 1) Console.Write($"Температура по шкале Цельсия {temperatureCelsius}°C равна температуре по шкале Кельвина {temperatureCelsius + 273.15}К");
        if (temperatureScale == 2) Console.Write($"Температура по шкале Цельсия {temperatureCelsius}°C равна температуре по шкале Фаренгейта {temperatureCelsius * 1.8 + 32} °F");
    }
}

