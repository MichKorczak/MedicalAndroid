using System;
using Android.Widget;
using MedicalAndroid.Core;
using MedicalAndroid.Models;
using MedicalAndroid.Services;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MedicalAndroid.ViewModel
{
    class AddNewPatientViewModel : MvxViewModel
    {
        public Patient NewOne { get; set; }
        public GetClass Instance;

        private IMvxCommand saveButton;
        public IMvxCommand SaveButton => saveButton ?? (saveButton = new MvxCommand(SaveNewPatient));

        private IMvxNavigationService service;

        public AddNewPatientViewModel(IMvxNavigationService service)
        {
            this.service = service;
            NewOne = new Patient();
            Instance = new GetClass();
        }

        public void SaveNewPatient()
        {
            SetDateOfBirth(NewOne.Pesel);
        }

        private void SetDateOfBirth(string newOnePesel)
        {
            int year = 0;
            int mouth = 0;
            int day = 0;

            char[] peselNumbersLetter = newOnePesel.ToCharArray();
            int[] peselNumbers = new int[11];
            int i = 0;

            try
            {
                foreach (var number in peselNumbersLetter)
                {
                    if (number == '0')
                        peselNumbers[i] = 0;
                    if (number == '1')
                        peselNumbers[i] = 1;
                    if (number == '2')
                        peselNumbers[i] = 2;
                    if (number == '3')
                        peselNumbers[i] = 3;
                    if (number == '4')
                        peselNumbers[i] = 4;
                    if (number == '5')
                        peselNumbers[i] = 5;
                    if (number == '6')
                        peselNumbers[i] = 6;
                    if (number == '7')
                        peselNumbers[i] = 7;
                    if (number == '8')
                        peselNumbers[i] = 8;
                    if (number == '9')
                        peselNumbers[i] = 9;

                    i++;
                }


                if (peselNumbers[2] == 0 || peselNumbers[2] == 1)
                {
                    year = 19 * 100 + peselNumbers[0] * 10 + peselNumbers[1];
                    mouth = peselNumbers[2] * 10 + peselNumbers[3];
                    day = peselNumbers[4] * 10 + peselNumbers[5];
                }

                if (peselNumbers[2] == 2 || peselNumbers[2] == 3)
                {
                    year = 20 * 100 + peselNumbers[0] * 10 + peselNumbers[1];
                    mouth = peselNumbers[2] * 10 + peselNumbers[3] - 20;
                    day = peselNumbers[4] * 10 + peselNumbers[5];
                }

                NewOne.DateOfBirth = new DateTime(year, mouth, day);
                Instance.AddPatient(NewOne);

                service.Navigate<PatientsListViewModel>();
            }

            catch (Exception)
            {
                if (AppHelper.GetInstance.AppContext != null)
                {
                    Toast.MakeText(AppHelper.GetInstance.AppContext, "Błędny pesel", ToastLength.Long).Show();
                }   
            }            
        }
    }
}