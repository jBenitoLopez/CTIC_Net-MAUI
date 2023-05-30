namespace _3_5__ciclo_de_vida;

public partial class App : Application
{

    public App()
    {
        System.Diagnostics.Debug.WriteLine("BEFORE InitializeComponent");
        InitializeComponent();

        var boton = new Button();
        boton.Text = "Generar nueva Ventana";
        boton.Clicked += (s,a) => { 
            var ventana = new Window(new ContentPage());
            ventana.Created += (s, a) => System.Diagnostics.Debug.WriteLine(nameof(ventana.Created));
            ventana.Activated += (s, a) => System.Diagnostics.Debug.WriteLine(nameof(ventana.Activated));
            ventana.Deactivated += (s, a) => System.Diagnostics.Debug.WriteLine(nameof(ventana.Deactivated));
            OpenWindow(ventana);
        };

        System.Diagnostics.Debug.WriteLine("AFTER InitializeComponent");

        //MainPage = new AppShell();
        MainPage = new ContentPage() { 
            Content = boton
        };
    }

    protected override void OnResume()
    {
        System.Diagnostics.Debug.WriteLine(">> OnResume");
        base.OnResume();
    }

    protected override void OnStart()
    {
        System.Diagnostics.Debug.WriteLine(">> OnStart");
        base.OnStart();
    }

    protected override void OnSleep()
    {
        System.Diagnostics.Debug.WriteLine(">> OnSleep");
        base.OnSleep();
    }
    protected override Window CreateWindow(IActivationState activationState)
    {
        System.Diagnostics.Debug.WriteLine(">>> CreateWindow <<<");
        var ventana = base.CreateWindow(activationState);
        ventana.Created += Venta_Created;
        ventana.Activated += Venta_Activated;
        ventana.Deactivated += Venta_Desactivated;

        return ventana;
    }

    private void Venta_Created (object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("--> Venta_Created");
    }

    private void Venta_Activated(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("--> Venta_Activated");
    }

    private void Venta_Desactivated(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("--> Venta_Desactivated");
    }
}
