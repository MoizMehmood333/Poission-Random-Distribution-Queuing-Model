using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models.Cache;
using WpfApp1.ViewModels;

namespace WpfApp1.Screens
{
    /// <summary>
    /// Interaction logic for Simulation.xaml
    /// </summary>
    public partial class Simulation : UserControl
    {
        public Simulation()
        {
            InitializeComponent();

        }

        private void BtnPerformSimulationClicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArrivalRate.Text) || string.IsNullOrWhiteSpace(txtServiceRate.Text))
            {
                MessageBox.Show("Enter All the values");
                return;
            }
            if (Cache.GetCache.LstWorkingSimulation.Count == 0) {
                MessageBox.Show("Click Simulation First!\nThen Click Resutls");
                return;
            }
            Simulating.simultate(Convert.ToDouble(txtArrivalRate.Text), Convert.ToDouble(txtServiceRate.Text));
            Main.Content = new Screens.PerformSimulation();

        }

        private void BtnCheckSimulationWorkingClicked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArrivalRate.Text) || string.IsNullOrWhiteSpace(txtServiceRate.Text)) {
                MessageBox.Show("Enter All the values");
                return;
            }
            Cache.GetCache.LstWorkingSimulation.Clear();
            Working.SimulationWorkingCode(Convert.ToDouble(txtArrivalRate.Text) , Convert.ToDouble(txtServiceRate.Text));
            Main.Content = new Screens.SimulationWorking();
        }
    }
}
