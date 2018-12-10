using Android.App;
using Android.OS;
using MedicalAndroid.Core;
using MvvmCross.Droid.Support.V4;

namespace MedicalAndroid.View
{
    [Activity]
    class AddNewPatientView : MvxFragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.AddNewPatientView);
            AppHelper.GetInstance.AppContext = ApplicationContext;
        }
    }
}