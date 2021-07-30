using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeiroApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"Você clicou {count} vezes.";
        }

        private async void ZerarContador_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Confirmação", "Deseja realmente zerar o Contador?", "Yep", "No, no, no"))
            {
                count = 0;
                await DisplayAlert("Mensagem", "Contador foi zerado!", "Ok");
                btnCliqueAqui.Text = "Clique Aqui";
            }
        }
    }
}
