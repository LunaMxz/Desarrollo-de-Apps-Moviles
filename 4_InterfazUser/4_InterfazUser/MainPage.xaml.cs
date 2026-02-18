using System.Diagnostics;

namespace _4_InterfazUser;

public partial class MainPage : ContentPage
{
    int cuentaLabels = 0;
    public MainPage()
    {
        InitializeComponent();
    }
    void LoginButton_Clicked(object sender, EventArgs e)
    {
        Debug.WriteLine("Clicked !");
    }
    void Agrega_Clicked(object sender, EventArgs e)
    {
        cuentaLabels++;
        if((cuentaLabels % 5) == 0 )
        {
            DisplayAlert("Alerta", $"No seas abusivo, ya van {cuentaLabels}", "OK");
        }
        this.vsLay.Children.Add(new Label { Text = "Agregado" });
    }
}