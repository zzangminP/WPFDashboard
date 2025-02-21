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

        private readonly IDatabase<WorldPopulation?>? _database;

        [ObservableProperty]
        private IEnumerable<string?>? _countryName;

        [ObservableProperty]
        private IEnumerable<WorldPopulation> _worldPopulations;


        public DataViewModel(IDateTime dateTime, IDatabase<WorldPopulation> database)
        {
            this._iDatetime = dateTime;
            this._database = database;            
        }



        [ObservableProperty]
        private IEnumerable<DataColor> _colors;


        
        public void OnNavigatedTo()
        {
            if (!_isInitialized)
                InitializeViewModelASync();
        }


        public void OnNavigatedFrom() { }


        private async Task InitializeViewModelASync()
        {
            this.WorldPopulations = await Task.Run(() => this._database?.Get());

            if (this.WorldPopulations != null)
            {
                this.CountryName = this.WorldPopulations.Select( c => c.CountryName).ToList();
            }


            _isInitialized = true;

        }
    }
}
