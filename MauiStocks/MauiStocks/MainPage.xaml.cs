using System.Diagnostics;

namespace MauiStocks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            if (StockData.GetStockPrices() == null)
                Debugger.Break();
            InitializeComponent();
        }

        
    }
}