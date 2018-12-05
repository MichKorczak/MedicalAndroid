using MedicalAndroid.Models;

namespace MedicalAndroid.Core
{
    public class AppHelper
    {
        private static AppHelper instance;
        public static AppHelper GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppHelper();
                }

                return instance;
            }
        }

        public Patient Patient { get; set; }
        public MedicalTest MedicalTest { get; set; }
        public TestResoult TestResoult { get; set; }
    }
}