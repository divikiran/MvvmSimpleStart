using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmSample
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel VM
        {
            get;
            set;
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = VM = new MainViewModel();
            VM.Name = "Canbera";

        }

        protected override void OnAppearing()
        {
            VM.Name = "Syndey";
            base.OnAppearing();
        }
    }
}
