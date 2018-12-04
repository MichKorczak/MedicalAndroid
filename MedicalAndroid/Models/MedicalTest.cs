using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MedicalAndroid.Annotations;
using MedicalAndroid.Models.Enums;

namespace MedicalAndroid.Models
{
    public class MedicalTest : INotifyPropertyChanged
    {
        private int id;
        public int Id { get { return id; } set{ id = value; OnPropertyChanged("Id"); } }

        private int patientId;
        public int PatientId { get { return patientId; } set { patientId = value; OnPropertyChanged("PatientId"); } }

        private int testResoultId;
        public int TestResoultId { get { return testResoultId; } set { testResoultId = value; OnPropertyChanged("TestResoultId"); } }

        private MedicalTestTypes medicalTestTypes;
        public MedicalTestTypes MedicalTestTypes { get{ return medicalTestTypes; } set { medicalTestTypes = value; OnPropertyChanged("MedicalTestTypes"); } }

        private DateTime dateTime = DateTime.Today;
        public DateTime DateTime { get { return dateTime; } set { dateTime = value; OnPropertyChanged("DateTime"); } }

        private bool isDone = false;
        public bool IsDone { get { return isDone; } set { isDone = value; OnPropertyChanged("IsDone"); } }

        public bool isDelete = false;
        public bool IsDelete { get { return isDelete; } set { isDelete = value; OnPropertyChanged("IsDelete"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}