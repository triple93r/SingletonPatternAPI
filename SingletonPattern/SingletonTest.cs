using Microsoft.Extensions.Logging;

namespace SingletonPattern
{
    public class SingletonTest
    {
        private static SingletonTest _instance;
        private static readonly object _instanceLock = new object();
        private SingletonTest()
        {

        }
        public static SingletonTest Instance()
        {
            if( _instance == null )
            {
                lock ( _instanceLock )
                {
                    if( _instance == null )
                    {
                        _instance = new SingletonTest();
                    }
                }
            }
            return _instance;
        }
    }
}
