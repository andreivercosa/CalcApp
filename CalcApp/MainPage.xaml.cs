using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void calcular(object sender, EventArgs e)
        {

            int resutado = Convert.ToInt32(Num1.Text) + Convert.ToInt32(Num2.Text);
            texto.Text = "Resultado da soma: " + resutado;
        }
    }
}
