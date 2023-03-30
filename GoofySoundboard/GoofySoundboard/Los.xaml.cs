using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoofySoundboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Los : ContentPage
    {
        public Los()
        {
            InitializeComponent();
        }

        private void Losoj(object sender, EventArgs args)
        {
            string[] tab =
            {
                  "amogus.mp3",
                  "aughhhhh.mp3",
                  "boom.mp3",
                  "discord.mp3",
                  "guitar.mp3",
                  "hehehehaw.mp3",
                  "laugh.mp3",
                  "metalPipe.mp3",
                  "oof.mp3",
                  "X.mp3"
             };
            var rand = new Random();
            var a = rand.Next(0, 10);
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load(tab[a]);
            player.Play();
        }

        public void glowna(Object Sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

    }
}