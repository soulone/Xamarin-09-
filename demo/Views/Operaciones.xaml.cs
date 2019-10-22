using System;
using System.Collections.Generic;
using demo.ViewModels;
using Xamarin.Forms;

namespace demo.Views
{
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
            this.BindingContext = new OperacionesViewModel();
        }
    }
}
