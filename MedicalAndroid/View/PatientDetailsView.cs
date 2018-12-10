using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Support.V4;

namespace MedicalAndroid.View
{
    [Activity(Label = "Widok pacjęta")]
    class PatientDetailsView : MvxFragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.PatientDetailsView);
            var listItem = (ListView)FindViewById(Resource.Id.MedicalResoultsListView);
            listItem.ItemClick += (sender, args) =>
            {
                TestResoultView resoultView = new TestResoultView();
                
                resoultView.Show(SupportFragmentManager, "");
            };
        }
    }
}