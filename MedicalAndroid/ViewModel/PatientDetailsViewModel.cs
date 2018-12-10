using System;

using MedicalAndroid.Core;
using MedicalAndroid.Models;
using MedicalAndroid.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MedicalAndroid.ViewModel
{
    class PatientDetailsViewModel : MvxViewModel
    {
        public MvxObservableCollection<MedicalTest> MedicalTestList { get; set; }
        public Patient ChosenOne { get { return AppHelper.GetInstance.Patient; } }
        public MedicalTest SelectedTest { get { return AppHelper.GetInstance.MedicalTest; } set { AppHelper.GetInstance.MedicalTest = value; } }
        public string PatientBirthday { get; set; }

        private IMvxCommand editCommand;
        public IMvxCommand EditCommand => editCommand ?? (editCommand = new MvxCommand(GoToEditView));

        private IMvxCommand listViewCommand;
        public IMvxCommand ListViewCommand => listViewCommand ?? (listViewCommand = new MvxCommand(GoToPatientListView));

        private GetClass instanceGetClass;
        private readonly IMvxNavigationService navigationService;

        public PatientDetailsViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
            instanceGetClass = new GetClass();
            MedicalTestList = new MvxObservableCollection<MedicalTest>();
            PatientBirthday = ChosenOne.DateOfBirth.ToShortDateString();
            InitCommand();
        }

        private void InitCommand()
        {
            try
            {
                MedicalTestList = instanceGetClass.GetPatientMedicalTests(ChosenOne.Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void GoToEditView() => navigationService.Navigate<EditPatientViewModel>();

        private void GoToPatientListView() => navigationService.Navigate<PatientsListViewModel>();

        private void GetMedicalResoultView()
        {
            //navigationService.Navigate<TestResoultView>();
        }
    }
}