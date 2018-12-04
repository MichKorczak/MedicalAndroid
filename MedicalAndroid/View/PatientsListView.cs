using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;

namespace MedicalAndroid.View
{
    [Activity(Label = "Lista pacjętów")]
    class PatientsListView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.PatientsListView);
        }
    }
}