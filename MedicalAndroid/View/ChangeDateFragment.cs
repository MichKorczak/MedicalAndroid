using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MedicalAndroid.Core;
using MvvmCross.Droid.Support.V4;

namespace MedicalAndroid.View
{
    [Activity(Label = "Zmiana daty")]
    class ChangeDateFragment : MvxDialogFragment
    {
        public DateTime DateTime { get; set; }

        public ChangeDateFragment(DateTime dateTime)
        {
            DateTime = dateTime;
        }

        public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Android.Views.View rootView = inflater.Inflate(Resource.Layout.ChangeDateFragment, container, false);

            DatePicker changeDate = (DatePicker) rootView.FindViewById(Resource.Id.medicalTestDate);
            changeDate.DateTime = DateTime;

            var saveButton = rootView.FindViewById<Button>(Resource.Id.saveDateChanges);
            saveButton.Click += (sender, args) =>
            {
                AppHelper.GetInstance.EditPatient.DateOfBirth = changeDate.DateTime;
                Dismiss();
            };

            return rootView;
        }
    }
}