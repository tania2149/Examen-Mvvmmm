using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Examen_Mvvm.ViewModels;


namespace Examen_Mvvm.Views

{

    public partial class MainPage : ContentPage

    {

        public MainPage(MainViewModel viewModel)

        {

            InitializeComponent();

            BindingContext = viewModel;

        }


        private async void CalculateButton_Clicked(object sender, EventArgs e)

        {

            try

            {

                ((MainViewModel)BindingContext).Calculate();

            }

            catch (Exception ex)

            {

                await DisplayAlert("Error", ex.Message, "OK");

            }

        }


        private void ClearButton_Clicked(object sender, EventArgs e)

        {

            ((MainViewModel)