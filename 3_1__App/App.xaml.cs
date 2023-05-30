namespace _3_1__App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
        MainPage = new ContentPage()
		{
			#if ANDROID
				Content = new Label() { Text = new NameDevice().GetName() }
			#elif WINDOWS

			#elif IOS

			#endif
		};
	}
}
