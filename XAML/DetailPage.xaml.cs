using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XAML.ViewModels;

namespace XAML
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private DetailPageViewModel detailViewModel;

        public DetailPage()
        {
            InitializeComponent();
        }

        public DetailPage(DetailPageViewModel detailViewModel)
        {
            this.detailViewModel = detailViewModel;
        }
    }
}