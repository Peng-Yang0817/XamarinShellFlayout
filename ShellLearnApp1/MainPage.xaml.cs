using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ShellLearnApp1
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PhoneIcon_Clicked(object sender, EventArgs e)
        {
            // 調用系統撥號功能 Essentials
            PhoneDialer.Open("0987587987");
        }

        private async void AboutIcon_Clicked(object sender, EventArgs e)
        {
            // 調用瀏覽器功能 Browser
            await Browser.OpenAsync("https://www.pornhub.com/video/search?search=pronhub");
        }
    }
}
