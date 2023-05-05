using DevExpress.Maui.Charts;



namespace MauiStocks
{
    public class ChartViewModel
    {
        public StockPrices StockPrices { get; }
        public DateTimeRange VisualRange { get; }

        public ChartViewModel()
        {
            StockPrices = StockData.GetStockPrices();
            VisualRange = new DateTimeRange()
            {
                VisualMin = new System.DateTime(2020, 04, 07),
                VisualMax = new System.DateTime(2020, 07, 07)
            };
        }
    }
}
