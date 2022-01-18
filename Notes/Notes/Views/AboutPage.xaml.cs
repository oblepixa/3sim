using Notes.Models;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Launcher.OpenAsync("https://translated.turbopages.org/proxy_u/en-ru.ru.5b7de23c-61e68208-3015a547-74722d776562/https/en.wikipedia.org/wiki/Note-taking");
        }

    }
}