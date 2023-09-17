using SingletonPattern.Models;

namespace SingletonPattern.Extras
{
    public class PatientSingleton
    {
        static List<Patient> Patients = null;
        public PatientSingleton()
        {
            Patients = new List<Patient>();
        }

        static void xMain()
        {
            //SingletonClass.GetPatients();
            SingletonClass obj = new SingletonClass();
            obj = null;
        }
    }

    sealed class SingletonClass
    {
        private static List<Patient> patient_s = null;

        private static IEnumerable<Patient> GetPatients()
        {
            if (patient_s == null)
            {
                patient_s = new List<Patient>();
            }
            return patient_s;
        }

        public static void RefreshPatients()
        {
            lock (patient_s)
            {
                patient_s = new List<Patient>();
            }
        }

    }
}
