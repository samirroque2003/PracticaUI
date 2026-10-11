namespace PracticaUI;

public partial class CalculadoraIMC : ContentPage
{
    public CalculadoraIMC()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Valida números válidos y que el peso y altura sean mayores a 0
        if (!double.TryParse(txtPeso.Text, out double peso) || peso <= 0
            || !double.TryParse(txtAltura.Text, out double altura) || altura <= 0)
        {
            await DisplayAlert("Error", "Por favor ingrese valores numéricos válidos mayores que 0.", "OK");
            return;
        }

        // Fórmula del IMC
        double imc = peso / (altura * altura);

        // Formato con 1 decimal
        lblValorIMC.Text = imc.ToString("F1");

        // Clasificación y colores
        if (imc < 18.5)
        {
            lblDiagnostico.Text = "Bajo Peso";
            lblDiagnostico.TextColor = Colors.DarkOrange;
            brResultado.BackgroundColor = Color.FromArgb("#0B8711");
            brResultado.Stroke = Colors.Orange;
        }
        else if (imc <= 24.9)
        {
            lblDiagnostico.Text = "Peso normal";
            lblDiagnostico.TextColor = Colors.DarkOrange;
            brResultado.BackgroundColor = Color.FromArgb("#0B8711");
            brResultado.Stroke = Colors.Orange;
        }
        else if (imc <= 29.9)
        {
            lblDiagnostico.Text = "Sobre Peso";
            lblDiagnostico.TextColor = Colors.DarkOrange;
            brResultado.BackgroundColor = Color.FromArgb("#FF4853");
            brResultado.Stroke = Colors.Orange;
        }
        else
        {
            lblDiagnostico.Text = "Obesidad";
            lblDiagnostico.TextColor = Colors.DarkOrange;
            brResultado.BackgroundColor = Color.FromArgb("#FF0015");
            brResultado.Stroke = Colors.Orange;
        }

        brResultado.IsVisible = true;
    }
}