using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoofySoundboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class cos : ContentPage
    {
        public cos()
        {
            InitializeComponent();
        }
        public async Task x()
        {
            await Task.Delay(1000);
            System.Environment.Exit(0);
        }
        public void xx(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("soc.mp3");
            x();
            player.Play();
        }
    }
}