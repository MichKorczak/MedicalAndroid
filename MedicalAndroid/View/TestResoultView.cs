using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;

namespace MedicalAndroid.View
{
    [Activity(Label = "Widok wyników")]
    public class TestResoultView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.TestResoultView);
        }
    }
}