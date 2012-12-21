// ------------------------------------------------------------------------------------------------------------------------
// Sistema: 10001 - Wallet Management
// Descrição: Sistema de Gerenciamento de Finanças
// ------------------------------------------------------------------------------------------------------------------------
// Pacote: Singleton
// Descrição: Biblioteca responsável por retornar a instância do objeto criado
// Autor: Gustavo Souza Gonçalves
// Data: 20/12/2012
// ------------------------------------------------------------------------------------------------------------------------

#region References

using System;
using System.Reflection;

#endregion

namespace Lib.Singleton
{
    public sealed class Singleton<T> where T : class
    {
        #region Fields

        public static T instance;
        public static object singletonLock = new object();

        #endregion

        #region Methods

        public static T GetSingleton()
        {
            if (instance == null)
            {
                lock (singletonLock)
                {
                    if (instance == null)
                    {
                        Type t = typeof(T);

                        ConstructorInfo[] ctors = t.GetConstructors();
                        if (ctors.Length > 0)
                            instance = (T)Activator.CreateInstance(t, true);
                    }
                }
            }
            return instance;
        }

        #endregion
    }
}
