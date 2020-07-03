using Xamarin.Forms;

[assembly: ExportFont("OpenSans-Regular.ttf", Alias = "Regular")]
[assembly: ExportFont("OpenSans-SemiBold.ttf", Alias = "SemiBold")]
[assembly: ExportFont("Font Awesome 5 Free-Regular-400.otf", Alias = "FAR")]

namespace Pizza
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
