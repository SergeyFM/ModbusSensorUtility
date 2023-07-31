namespace ModbusSensorUtility.Log;
public sealed class LogService {

    private static readonly Lazy<LogService> lazy = new(() => new LogService());

    public static LogService Instance => lazy.Value;

    private LogService() { }

    public void Log(string message) {

        string stamp = DateTime.Now.ToString("yyyyMMdd-HH:mm:ss:ffff");
        Console.WriteLine($"{stamp} message");

    }

}
