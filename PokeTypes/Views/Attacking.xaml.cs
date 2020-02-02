using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PokeTypes.Views
{
    public partial class Attacking : ContentPage
    {
        public Attacking()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                string a = picker.Items[picker.SelectedIndex];
                string d = picker2.Items[picker2.SelectedIndex];
                btn.Text = Types.GetEffectiveness(a, d).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                btn.Text = "idiot";
            }
            
        }

    }
}
