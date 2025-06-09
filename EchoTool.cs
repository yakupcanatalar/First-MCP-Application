using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerToolType]
public static class EchoTool
{
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"Hello from C#: {message}";

    [McpServerTool, Description("Echoes in reverse the message sent by the client.")]
    public static string ReverseEcho(string message) => new string(message.Reverse().ToArray());

    [McpServerTool, Description("Counts the number of words in the input message.")]
    public static int WordCount(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            return 0;

        return message.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    [McpServerTool, Description("Returns information about the given date string (format: yyyy-MM-dd).")]
    public static string GetDateInfo(string dateString)
    {
        if (!DateTime.TryParse(dateString, out DateTime date))
            return "Invalid date format. Please use yyyy-MM-dd.";

        string dayOfWeek = date.DayOfWeek.ToString();
        bool isWeekend = (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday);

        return $"Day: {dayOfWeek}, IsWeekend: {isWeekend}";
    }

    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string TheBigBoss() => "The Big Boss says: Hello MCP. Keep up the good work!Boss name is YAKUP CAN ATALAR";
}
