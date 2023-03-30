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

        public void Cos(Object Sender, EventArgs e)
        {
            var rand = new Random();
            var a = rand.Next(1, 10);

            if(a == 1)
            {
                Navigation.PushAsync(new cos());
            }
        }

        public void wyjdz(Object Sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
