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
        }

        public string DateText { get { return AppHelper.GetInstance.EditPatient.DateOfBirth.ToShortDateString(); } }
        private IMvxNavigationService navigate;

        private IMvxCommand saveCommand;
        public IMvxCommand SaveCommand => saveCommand ?? (saveCommand = new MvxCommand(SaveChanges));

        private GetClass instance;

        public EditPatientViewModel(IMvxNavigationService navigate)
        {
            this.navigate = navigate;
            instance = new GetClass();
            AppHelper.GetInstance.EditPatient = AppHelper.GetInstance.Patient;
        }

        public void SaveChanges()
        {
            AppHelper.GetInstance.Patient = ChangedModel;
            instance.EditPatient(ChangedModel);
            navigate.Navigate<PatientDetailsViewModel>();
        }
    }
}