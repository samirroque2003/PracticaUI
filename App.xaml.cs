namespace PracticaUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        // Define aquí tu página inicial de manera limpia
        return new Window(new CalculadoraIMC());
    }
}