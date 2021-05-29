using DirencNetClone.Services;
using DirencNetClone.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DirencNetClone.ViewModels
{
   public class LoginViewModel :BaseViewModel
    {
        private string _UserEMail;
        public string UserEmail
        {
            set
            {
                this._UserEMail = value;
                OnPropertyChanged();
            }
            get
            {
                return this._UserEMail;
            }

        }

        private string _Password;
        public string Password
        {
            set
            {
                this._Password = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Password;
            }

        }



        private bool _IsBussy;
        public bool IsBussy
        {
            set
            {
                this._IsBussy = value;
                OnPropertyChanged();
            }
            get
            {
                return this._IsBussy;
            }

        }

        private bool _Result;
        public bool Result
        {
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
            get
            {
                return this._Result;
            }

        }
        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }


        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());

        }
        private async Task RegisterCommandAsync()
        {
            if (IsBussy)
                return;

            try
            {
                IsBussy = true;
                var userService = new UserService();
                Result = await userService.RegisterUser(UserEmail, Password);
                if (Result)

                    await Application.Current.MainPage.DisplayAlert("Başarılı", "Üye Kaydedildi", "OK");


                else

                    await Application.Current.MainPage.DisplayAlert("Error", "Geçersiz Kullanıcı Adı veya Şifre", "OK");

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
            finally
            {
                IsBussy = false;
            }
        }



        private async Task LoginCommandAsync()
        {
            if (IsBussy)
                return;
            try
            {
                IsBussy = true;
                var userService = new UserService();
                Result = await userService.LoginUser(UserEmail, Password);
                if (Result)
                {
                    Preferences.Set("UserEmail", UserEmail);
                    await Application.Current.MainPage.Navigation.PushModalAsync(new ProductsView());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Geçersiz Kullanıcı Adı veya Şifre", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
            finally
            {
                IsBussy = false;
            }
        }
    }
}
