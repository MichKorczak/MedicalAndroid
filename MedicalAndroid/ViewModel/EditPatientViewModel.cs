using MedicalAndroid.Core;
using MedicalAndroid.Models;
using MedicalAndroid.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MedicalAndroid.ViewModel
{
    class EditPatientViewModel : MvxViewModel
    {
        public Patient ChangedModel
        {
            get { return AppHelper.GetInstance.EditPatient; }
            set { AppHelper.GetInstance.EditPatient = value; }
        }

        // public string DateText { get { return ChangedModel.DateOfBirth.ToShortDateString(); } }
        private IMvxNavigationService navigate;

        private IMvxCommand saveCommand;
        public IMvxCommand SaveCommand => saveCommand ?? (saveCommand = new MvxCommand(SaveChanges));

        private GetClass instance;

        public EditPatientViewModel(IMvxNavigationService navigate)
        {
            this.navigate = navigate;
            instance = new GetClass();
            InitCommand();
        }

        private void InitCommand()
        {
            ChangedModel = new Patient();
            ChangedModel.Id = AppHelper.GetInstance.Patient.Id;
            ChangedModel.Name = AppHelper.GetInstance.Patient.Name;
            ChangedModel.DateOfBirth = AppHelper.GetInstance.Patient.DateOfBirth;
            ChangedModel.Pesel = AppHelper.GetInstance.Patient.Pesel;
        }

        public void SaveChanges()
        {
            AppHelper.GetInstance.Patient = ChangedModel;
            instance.EditPatient(ChangedModel);
            navigate.Navigate<PatientDetailsViewModel>();
        }
    }
}