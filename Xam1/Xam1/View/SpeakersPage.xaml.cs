using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xam1.ViewModel;
using Xam1.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xam1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeakersPage : ContentPage
    {
        SpeakersViewModel vm;
        public SpeakersPage()
        {
            InitializeComponent();
            vm = new SpeakersViewModel();
            BindingContext = vm;
            ListViewSpeakers.ItemSelected += ListViewSpeakers_ItemSelected;
        }

        private async void ListViewSpeakers_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var speaker = e.SelectedItem as Speaker;

            if(speaker == null)
            {
                return;
            }

            await this.Navigation.PushModalAsync(new DetailPage(speaker));
            ListViewSpeakers.SelectedItem = null;
        }
    }
}