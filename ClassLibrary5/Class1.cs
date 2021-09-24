using NLog;

namespace ClassLibrary5
{
    public class Class1
    {

        public string Method()
        {
            var logInfo = new LogEventInfo(LogLevel.Info, "Test", "Test From Class Library using dotnet 5.0");
            return logInfo.Message;
        }
    }
}
