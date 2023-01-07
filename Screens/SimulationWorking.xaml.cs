using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Models.Cache;
using WpfApp1.Models.Repository;

namespace WpfApp1.Screens
{
    /// <summary>
    /// Interaction logic for SimulationWorking.xaml
    /// </summary>
    public partial class SimulationWorking : UserControl
    {
        public Cache m_cacheInstance = Cache.GetCache;
        public List<WorkingOfSimulation> LstWorkingOfSimulation { get; set; }
        public SimulationWorking()
        {
            InitializeComponent();
            LstWorkingOfSimulation = m_cacheInstance.LstWorkingSimulation;
            DataContext = this;
        }
    }
}
