using Android.App;
using Android.OS;
using Android.Widget;
using MedicalAndroid.Core;
using MvvmCross.Droid.Support.V4;


namespace MedicalAndroid.View
{
    [Activity]
    class EditPatientView : MvxFragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.EditPatientView);
            var changeDate = (Button)FindViewById(Resource.Id.changedDateButton);
            changeDate.Click += (sender, args) =>
            {
                ChangeDateFragment dateFragment = new ChangeDateFragment(AppHelper.GetInstance.EditPatient.DateOfBirth);

                dateFragment.Show(SupportFragmentManager, "");
            };
        }
    }
}