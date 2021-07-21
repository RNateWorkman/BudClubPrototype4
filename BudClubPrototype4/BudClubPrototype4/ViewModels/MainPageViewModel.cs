using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.ComponentModel;
using Xamarin.Forms;

namespace BudClubPrototype4
{
    class MainPageViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public MainPageViewModel()
        {
            OpenQRReaderCommand = new Command(async () =>
            {
                var qrVM = new ViewModels.QRReaderPageViewModel();

                var qrPage = new Views.QRReaderPage();

                qrPage.BindingContext = qrVM;

                await Application.Current.MainPage.Navigation.PushAsync(qrPage);
            });

            OpenPhoneNumberPageCommand = new Command(async () =>
            {
                var phoneVM = new ViewModels.PhoneNumberPageViewModel();

                var phonePage = new Views.PhoneNumberPage();

                await Application.Current.MainPage.Navigation.PushAsync(phonePage);
            });

        }
             public Command OpenQRReaderCommand { get; }
             public Command OpenPhoneNumberPageCommand { get; }

    }

}



