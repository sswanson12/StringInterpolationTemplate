using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number03()
    {
        var answer = $"Day {_date.Now:dd} of {_date.Now:MMMM}, {_date.Now:yyyy}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var answer = $"Year: {_date.Now:yyyy}, Month: {_date.Now:MM}, Day: {_date.Now:dd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var answer = $"{_date.Now.DayOfWeek, 10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var answer = $"{$"{_date.Now.ToShortTimeString()}", 10}{_date.Now.DayOfWeek, 10}";

        Console.WriteLine(answer);
        return answer;
    }

    public string Number07()
    {
        var answer = $"h:{11}, m:{_date.Now.Minute:00}, s:{_date.Now.Second}";

        Console.WriteLine(answer);
        return answer;
    }

    public string Number08()
    {
        var answer = $"{_date.Now.Year}.{_date.Now.Month:00}.{_date.Now.Day}.11.{_date.Now.Minute:00}.{_date.Now.Second}";

        Console.WriteLine(answer);
        return answer;
    }

    public string Number09()
    {
        var answer = $"{Math.PI:C}";

        Console.WriteLine(answer);
        return answer;
    }

    public string Number10()
    {
        var answer = $"     {Math.PI:F3}";

        Console.WriteLine(answer);
        return answer;
    }
}
