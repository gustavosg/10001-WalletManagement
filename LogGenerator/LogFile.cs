// ------------------------------------------------------------------------------------------------------------------------
// Sistema:     10001 - Wallet Management
// Descrição:   Sistema de Gerenciamento de Finanças
// ------------------------------------------------------------------------------------------------------------------------
// Pacote:      Log
// Descrição:   Biblioteca responsável por retornar a instância do objeto criado
// Autor:       Gustavo Souza Gonçalves
// Data:        22/12/2012
// ------------------------------------------------------------------------------------------------------------------------

#region References

using System;
using System.IO;
using System.Text;
using System.Web;

#endregion

namespace Library.Basis.LogGenerator
{
    public static class LogFile
    {
        #region Fields

        static FileInfo filename = new FileInfo(Directory.GetCurrentDirectory() + "\\Log\\arquivo.log");


        #endregion

        #region Methods

        private static Boolean FileExists()
        {
            if (!filename.Directory.Exists)
                filename.Directory.Create();
            if (!filename.Exists)
                filename.Create();

            if (filename.Exists)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Realiza leitura do log
        /// </summary>
        /// <returns>Conteúdo do log</returns>
        public static String LogReader()
        {
            String content = null;

            try
            {
                if (FileExists())
                {
                    StreamReader readFile = new StreamReader(filename.ToString(), Encoding.UTF8);
                    content = readFile.ReadToEnd().ToString();
                    readFile.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return content;
        }

        public static void LogWriter(String level, String message, String user = null)
        {
            String content = LogReader();
            DateTime data = DateTime.UtcNow.ToLocalTime();

            String logFormat = String.Empty;

            if (user == String.Empty || user == null)
                logFormat = level + " | " + data + " | " + message + ".";
            else
                logFormat = level + " | " + data + " | " + message + " | User: " + user + ".";

            StreamWriter writeFile = new StreamWriter(filename.ToString());
            writeFile.WriteLine(content + logFormat);

            writeFile.Flush();
            writeFile.Close();
        }

        #endregion
    }
}
