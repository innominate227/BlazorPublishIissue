using NLog;

namespace ClassLibrary4dot8
{
    public class Class1
    {

        public string Method()
        {
            var logInfo = new LogEventInfo(LogLevel.Info, "Test", "Test From Class Library using dotnet 4.8");
            return logInfo.Message;
        }

    }
}
