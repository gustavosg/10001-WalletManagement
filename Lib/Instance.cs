// --------------------------------------------------------------------------------------------
//
//
//
// --------------------------------------------------------------------------------------------
//
//
//
//
// --------------------------------------------------------------------------------------------


namespace Lib.Singleton
{
    public sealed class Singleton
    {
        private static readonly object singletonLock = new object();
        private static Singleton singleton;

        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (singleton == null)
                lock (singletonLock)
                    if (singleton == null)
                        singleton = new Singleton();

            return singleton;
        }

    }
}
