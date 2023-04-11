using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoofySoundboard
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void lista(Object Sender, EventArgs e)
        {
            Navigation.PushAsync(new Lista());
        }

        public void los(Object Sender, EventArgs e)
        {
            Navigation.PushAsync(new Los());
        }

        int a = 0;
        public void Cos(Object Sender, EventArgs e)
        {
            a++;
            if(a == 10)
            {
                Navigation.PushAsync(new cos());
                a= 0;
            }
        }

        public void wyjdz(Object Sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
