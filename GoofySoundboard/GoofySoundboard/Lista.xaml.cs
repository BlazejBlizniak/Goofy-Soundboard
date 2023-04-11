using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace GoofySoundboard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public Lista()
        {
            InitializeComponent();
        }

        public void glowna(Object Sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
        public void Dzwiek1(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("laugh.mp3");
            player.Play();
        }

        public void Dzwiek2(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("boom.mp3");
            player.Play();
        }

        public void Dzwiek3(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("amogus.mp3");
            player.Play();
        }

        public void Dzwiek4(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("metalPipe.mp3");
            player.Play();
        }

        public void Dzwiek5(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("discord.mp3");
            player.Play();
        }

        public void Dzwiek6(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("aughhhhh.mp3");
            player.Play();
        }

        public void Dzwiek7(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("oof.mp3");
            player.Play();
        }

        public void Dzwiek8(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("X.mp3");
            player.Play();
        }

        public void Dzwiek9(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("guitar.mp3");
            player.Play();
        }

        public void Dzwiek10(Object Sender, EventArgs e)
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("hehehehaw.mp3");
            player.Play();
        }
    }
}