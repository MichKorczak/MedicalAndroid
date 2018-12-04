using MedicalAndroid.ViewModel;
using MvvmCross.IoC;
using MvvmCross.ViewModels;

namespace MedicalAndroid.Core
{
    class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            RegisterAppStart<StartActivityViewModel>();
        }
    }
}