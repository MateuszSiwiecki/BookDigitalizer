using MvvmCross.IoC;
using MvvmCross.ViewModels;
using BookDigitalizer.Core.ViewModels.Home;

namespace BookDigitalizer.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
            
        }
    }
}
