using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using MedicalAndroid.Core;
using MedicalAndroid.Models;
using MedicalAndroid.Services;
using MvvmCross.Droid.Support.V4;

namespace MedicalAndroid.View
{
    [Activity(Label = "Widok wyników")]
    public class TestResoultView : MvxDialogFragment
    {
        public Patient Patient { get { return AppHelper.GetInstance.Patient; } }
        public MedicalTest MedicalTest { get { return AppHelper.GetInstance.MedicalTest; } }
        public TestResoult TestResoult { get; set; }
        public Doctor Doctor { get; set; }
        private GetClass instance;
        

        //protected override void OnCreate(Bundle bundle)
        //{
        //    base.OnCreate(bundle);

        //    SetContentView(Resource.Layout.TestResoultView);
        //}

        public TestResoultView()
        {
            instance = new GetClass();
            TestResoult = new TestResoult();
            Doctor = new Doctor();
            InitCommand();
            
        }

        public override Android.Views.View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Android.Views.View rootView = inflater.Inflate(Resource.Layout.TestResoultView, container, false);
            

            TextView patientNameText = (TextView)rootView.FindViewById(Resource.Id.patientNameText);
            patientNameText.Text = "Imię i nazwisko:";
            
            TextView patientName = (TextView)rootView.FindViewById(Resource.Id.patientName);
            patientName.Text = Patient.Name;

            TextView medicalTestTypeText = (TextView) rootView.FindViewById(Resource.Id.MedicalTestTypeText);
            medicalTestTypeText.Text = "Rodzaj badania:";

            TextView medicalTestType = (TextView) rootView.FindViewById(Resource.Id.medicalTestType);
            medicalTestType.Text = MedicalTest.MedicalTestTypes.ToString();

            TextView testDateText = (TextView) rootView.FindViewById(Resource.Id.testDateText);
            testDateText.Text = "Data badania:";

            TextView testDate = (TextView)rootView.FindViewById(Resource.Id.testDate);
            testDate.Text = MedicalTest.DateTime.ToString();

            TextView isPositiveText = (TextView) rootView.FindViewById(Resource.Id.isPositiveText);
            isPositiveText.Text = "Wynik badania:";

            TextView isPositive = (TextView)rootView.FindViewById(Resource.Id.isPositive);
            isPositive.Text = TestResoult.IspPositive == true ? "Pozytywny" : "Negatywny";

            TextView resultText = (TextView) rootView.FindViewById(Resource.Id.ResultText);
            resultText.Text = "Rezultat:";

            TextView result = (TextView)rootView.FindViewById(Resource.Id.Result);
            result.Text = TestResoult.Result;

            TextView testDescriptionText = (TextView)rootView.FindViewById(Resource.Id.TestDescriptionText);
            testDescriptionText.Text = "Rezultat:";

            TextView testDescription = (TextView)rootView.FindViewById(Resource.Id.TestDescription);
            testDescription.Text = TestResoult.TestDescription;

            TextView doctorNameText = (TextView)rootView.FindViewById(Resource.Id.DoctorNameText);
            doctorNameText.Text = "Rezultat:";

            TextView doctorName = (TextView)rootView.FindViewById(Resource.Id.DoctorName);
            doctorName.Text = Doctor.Name;

            return rootView;
        }

        private void InitCommand()
        {
            var testId = MedicalTest.Id;
            TestResoult = instance.GetTestResoult(testId);
            Doctor = instance.GetDoctor(TestResoult.DoctorId);
        }

    }
}