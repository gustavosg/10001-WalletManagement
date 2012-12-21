using System;
using System.IO;
using System.Text;
using System.Web;

namespace Data.Util.LogGenerator
{
    public class LogFile : Singleton<LogFile>
    {
        #region Campos

        String filename = HttpContext.Current.Server.MapPath("~/Log/arquivo.log");

        #endregion

        private FileInfo LogOpener()
        {
            FileInfo file = new FileInfo(filename);
            file.Directory.Create();
            if (!File.Exists(filename))
                File.Create(filename);

            return file;
        }

        public String LogReader()
        {
            StreamReader readFile = new StreamReader(filename, Encoding.UTF8);
            String content = readFile.ReadToEnd().ToString();
            readFile.Close();

            return content;
        }

        public void LogWriter(String level, String message, String user)
        {
            String content = LogReader();
            DateTime data = DateTime.UtcNow.ToLocalTime();

            String logFormat = level + " | " + data + " | " + message + " | Usuário: " + user + ".";

            StreamWriter writeFile = new StreamWriter(filename);
            writeFile.WriteLine(content + logFormat);

            writeFile.Flush();
            writeFile.Close();

        }
    }
}
