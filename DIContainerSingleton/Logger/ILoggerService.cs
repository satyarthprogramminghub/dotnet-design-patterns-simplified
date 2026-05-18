namespace DIContainerSingleton.Logger
{
    public interface ILoggerService
    {
        void Log(string message);
        Guid InstanceId { get; }   // To prove it's singleton
    }
}
