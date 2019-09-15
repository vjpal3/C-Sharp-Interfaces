using System.IO;


namespace Interfaces.Extensibility
{
    class FileLogger : ILogger
    {
        private readonly string path;
        public FileLogger (string path)
        {
            this.path = path;
        }

        public void LogError (string message)
        {
            Log(message, "Error");
        }
        public void LogInfo (string message)
        {
            Log(message, "Info");
        }

        private void Log (string message, string messageType)
        {
            // messageType can be an enumeration

            // 'using' block - Exception handler inserted by the compiler 
            // and external resources (that are not managed by CLR) are freed by calling Dispose() method 
            using (var streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
