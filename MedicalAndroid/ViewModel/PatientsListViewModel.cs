using System;
using MedicalAndroid.Core;
using MedicalAndroid.Models;
using MedicalAndroid.Services;
using MedicalAndroid.View;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MedicalAndroid.ViewModel
{
    class PatientsListViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService mvxNavigationService;
        public MvxObservableCollection<Patient> PatientsList { get; set; }
        public Patient SelectedPatient { get { return AppHelper.GetInstance.Patient; } set { AppHelper.GetInstance.Patient = value; GoToPatientPage(); } }

        private GetClass instance;

        public PatientsListViewModel(IMvxNavigationService service)
        {
            mvxNavigationService = service;
            instance = new GetClass();
            PatientsList = new MvxObservableCollection<Patient>();
            InitialCommand();
        }

        private void InitialCommand()
        {
            PatientsList = instance.GetPatientList();
        }

        private void GoToPatientPage()
        {
            try
            {
                mvxNavigationService.Navigate<PatientDetailsViewModel>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }
    }
}