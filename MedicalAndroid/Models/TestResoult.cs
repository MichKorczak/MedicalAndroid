using System.ComponentModel;
using System.Runtime.CompilerServices;
using MedicalAndroid.Annotations;

namespace MedicalAndroid.Models
{
    public class TestResoult : INotifyPropertyChanged
    {
        private int id;
        public int Id { get { return id; } set { id = value; OnPropertyChanged("Id"); } }

        private int medicalTestId;
        public int MedicalTestId { get { return medicalTestId; } set { medicalTestId = value; OnPropertyChanged("MedicalTestId"); } }

        private int doctorId;
        public int DoctorId { get { return doctorId; } set { doctorId = value; OnPropertyChanged("DoctorId"); } }

        private string testDescription = "Badanie zostanie wykonane w podany terminie";
        public string TestDescription { get { return testDescription; } set { testDescription = value; OnPropertyChanged("TestDescription"); } }

        private bool isPositive;
        public bool IspPositive { get { return isPositive; } set { isPositive = value; OnPropertyChanged("IspPositive"); } }

        private string result;
        public string Result { get { return result; } set { result = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}