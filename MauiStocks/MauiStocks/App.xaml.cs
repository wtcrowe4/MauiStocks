using MauiStocks.Views;


namespace MauiStocks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Routing.RegisterRoute(typeof(ChartPage).Name, typeof(ChartPage));
            
            MainPage = new MainPage();
        }
    }
}