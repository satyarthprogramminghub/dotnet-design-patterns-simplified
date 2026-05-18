namespace DIContainerSingleton.Logger
{
    public class LoggerService : ILoggerService
    {
        public Guid InstanceId { get; } = Guid.NewGuid();

        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}] [Instance: {InstanceId.ToString()[..8]}] {message}");
        }
    }
}
