using FAXM.Controller;
using FAXM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FAXM
{
    public partial class MainPage : ContentPage
    {
        UserController ctrl = new UserController();
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var isUservalid = !string.IsNullOrEmpty(txtUser.Text);
            var isPasswordvalid = !string.IsNullOrEmpty(txtPassword.Text);
            if (isUservalid && isPasswordvalid)
            {
                User user = new User();
                user.Username = txtUser.Text;
                user.Pass = txtPassword.Text;
                bool response = ctrl.Login(user);
                if (response)
                    Navigation.PushAsync(new HomePage());
                else
                {
                    DisplayAlert("Alert", "Error al iniciar sesion", "Cancelar");
                }
            }
            else
            {
                DisplayAlert("Alert", "Error al iniciar sesion", "Cancelar");
            }
        }
    }
}
