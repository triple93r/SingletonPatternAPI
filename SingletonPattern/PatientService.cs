
using SingletonPattern.Data;

namespace SingletonPattern
{
    sealed class PatientService
    {
        public string Id { get; set; }

        private static PatientService _instance;
        private static readonly object _synclock = new object();

        public PatientService(){     }
        public static PatientService Instance(int id)
        {
            if (_instance == null)
            {
                lock (_synclock)
                {
                    if (_instance == null)
                    {
                        _instance = new PatientService();
                        _instance.Id = id.ToString() + " service created";
                    }
                }
            }
            return _instance;
        }
        public string method2()
        {
            return "Iammethod2";
        }
    }
    public class pservice2
    {
        public string method3()
        {
            return "method3";
        }
    }

    public class pservice3
    {
        pservice2 sp1 = new pservice2();
        PatientService obj = new PatientService();
        public void de()
        {
            //var x = sp1.method2();
            var y = sp1.method3();
            obj.method2();
        }
    }
}
