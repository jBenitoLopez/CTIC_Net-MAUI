namespace _3_1__App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
        MainPage = new ContentPage()
		{
			Content = new Label() { Text="Hola Mundo"}
		};
	}
}
