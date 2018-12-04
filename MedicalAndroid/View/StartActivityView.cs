using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MvvmCross.Platforms.Android.Views;

namespace MedicalAndroid.View
{
    [MvxActivityPresentation]
    [Activity(Label = "View for StartActivity")]
    public class StartActivityView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.StartActivityView);
        }

        
    }
}