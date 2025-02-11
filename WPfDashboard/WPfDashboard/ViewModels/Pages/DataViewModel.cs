using System.Windows.Media;
using Wpf.Ui.Controls;
using WPfDashboard.Interfaces;
using WPfDashboard.Models;

namespace WPfDashboard.ViewModels.Pages
{
    public partial class DataViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;


        private readonly IDateTime _iDatetime;

        public DataViewModel(IDateTime dateTime)
        {
            this._iDatetime = dateTime;            
            
        }



        [ObservableProperty]
        private IEnumerable<DataColor> _colors;


        
        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModel();
        }


        public void OnNavigatedFrom() { }
          

        private void InitializeViewModel()
        {
            /*
            var random = new Random();
            var colorCollection = new List<DataColor>();

            for (int i = 0; i < 8192; i++)
                colorCollection.Add(
                    new DataColor
                    {
                        Color = new SolidColorBrush(
                            Color.FromArgb(
                                (byte)200,
                                (byte)random.Next(0, 250),
                                (byte)random.Next(0, 250),
                                (byte)random.Next(0, 250)
                            )
                        )
                    }
                );

            Colors = colorCollection;
                                      */
            _isInitialized = true;
        } 
    }
}
