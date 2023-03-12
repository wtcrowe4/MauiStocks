using System.Diagnostics;

namespace MauiStocks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex) 
            {
                if (ex.InnerException != null)
                {
                    string error = ex.InnerException.Message;
                    Debug.WriteLine(error);
                }
            }
            
        }

        
    }
}