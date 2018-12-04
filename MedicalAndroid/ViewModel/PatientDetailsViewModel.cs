using System;
using MedicalAndroid.Core;
using MedicalAndroid.Models;
using MedicalAndroid.Services;
using MvvmCross.ViewModels;

namespace MedicalAndroid.ViewModel
{
    class PatientDetailsViewModel : MvxViewModel
    {
        public MvxObservableCollection<MedicalTest> MedicalTestList { get; set; }
        public Patient ChosenOne { get { return AppHelper.GetInstance.Patient; } }
        public MedicalTest SelectedTest { get { return AppHelper.GetInstance.MedicalTest; } set { AppHelper.GetInstance.MedicalTest = value; } }
        private GetClass instanceGetClass;

        public PatientDetailsViewModel()
        { 
            instanceGetClass = new GetClass();
            MedicalTestList = new MvxObservableCollection<MedicalTest>();
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
    }
}