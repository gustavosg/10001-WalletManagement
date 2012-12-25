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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace Library.Basis.LogGenerator
{
    public static class Log
    {
        #region Fields

        #endregion

        #region Methods

        /// <summary>
        /// Generates log with Info type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        public static void Info(String origin, String description)
        {
            LogFile.LogWriter("INFO", origin + " | " + description);
        }

        /// <summary>
        /// Generates log with Info type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        /// <param name="user">Current user</param>
        public static void Info(String origin, String description, String user)
        {
            LogFile.LogWriter("INFO", origin + " | " + description, user);
        }

        /// <summary>
        /// Generates log with Warn type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        public static void Warn(String origin, String description)
        {
            LogFile.LogWriter("WARN", origin + " | " + description);
        }

        /// <summary>
        /// Generates log with Warn type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        /// <param name="user">Current user</param>
        public static void Warn(String origin, String description, String user)
        {
            LogFile.LogWriter("WARN", origin + " | " + description, user);
        }

        /// <summary>
        /// Generates log with Error type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        public static void Error(String origin, String description)
        {
            LogFile.LogWriter("ERROR", origin + " | " + description);
        }

        /// <summary>
        /// Generates log with Error type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        /// <param name="user">Current user</param>
        public static void Error(String origin, String description, String user)
        {
            LogFile.LogWriter("ERROR", origin + " | " + description, user);
        }

        /// <summary>
        /// Generates log with Fatal type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        public static void Fatal(String origin, String description)
        {
            LogFile.LogWriter("FATAL", origin + " | " + description);
        }

        /// <summary>
        /// Generates log with Fatal type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        /// <param name="user">Current user</param>
        public static void Fatal(String origin, String description, String user)
        {
            LogFile.LogWriter("FATAL", origin + " | " + description, user);
        }

        /// <summary>
        /// Generates log with Debug type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        public static void Debug(String origin, String description)
        {
            LogFile.LogWriter("DEBUG", origin + " | " + description);
        }

        /// <summary>
        /// Generates log with Debug type
        /// </summary>
        /// <param name="origin">Origin type of info</param>
        /// <param name="description">Description of info</param>
        /// <param name="user">Current user</param>
        public static void Debug(String origin, String description, String user)
        {
            LogFile.LogWriter("DEBUG", origin + " | " + description, user);
        }

        #endregion
    }
}
