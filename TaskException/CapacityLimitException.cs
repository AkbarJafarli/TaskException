namespace TaskException
{
    public class CapacityLimitException:Exception
    {
        public CapacityLimitException() { }
        public CapacityLimitException(string message) : base(message) { }
        public CapacityLimitException(string message,Exception innerException):base(message, innerException) { }
    }
}
