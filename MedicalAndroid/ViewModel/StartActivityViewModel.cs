using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace MedicalAndroid.ViewModel
{
    public class StartActivityViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService mvxNavigationService;

        private IMvxCommand patientListCommand;
        public IMvxCommand PatientsListCommand => patientListCommand ?? (patientListCommand = new MvxCommand(NextPage));

        public StartActivityViewModel(IMvxNavigationService mvxNavigationService)
        {
            this.mvxNavigationService = mvxNavigationService;
        }

        private void NextPage()
        {
            mvxNavigationService.Navigate<PatientsListViewModel>();
        }
    }
}