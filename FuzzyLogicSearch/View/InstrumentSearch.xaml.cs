using FuzzyLogicSearch.ViewModel;
using System.Windows;
using MahApps.Metro.Controls;

namespace FuzzyLogicSearch
{
    /// <summary>
    /// Interaction logic for InstrumentSearch.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InstrumentSearchViewModel viewModel = new InstrumentSearchViewModel();            

            this.DataContext = viewModel;
            InitializeComponent();
        }
    }
}
