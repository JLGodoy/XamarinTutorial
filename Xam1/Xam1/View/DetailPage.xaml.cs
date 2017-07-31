using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xam1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        void goBack(object sender, System.EventArgs e)
        {
            this.Navigation.PushModalAsync(new SpeakersPage());
        }

        Speaker item2;
        public DetailPage(Speaker item)
        {
            item2 = item;
            InitializeComponent();
            BindingContext = item;
            ButtonWebsite.Clicked += ButtonWebsite_Clicked;
        }

        private void ButtonWebsite_Clicked(object sender, EventArgs e)
        {
            if (item2.Website.StartsWith("http"))
                Device.OpenUri(new Uri(item2.Website));
        }


    }
}