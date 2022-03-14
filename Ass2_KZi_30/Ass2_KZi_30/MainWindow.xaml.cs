using Ass2_KZi_30.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Ass2_KZi_30
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TimeSpan currentTime = new TimeSpan(0, 0, 0);
        List<LapInfo_KZi_30> listOfLaps = new List<LapInfo_KZi_30>();

        public MainWindow()
        {
            InitializeComponent();
            stopwatchTimer.Interval = new TimeSpan(0, 0, 1);
            interfaceTimer.Tick += updateInterface;
            stopwatchTimer.Tick += updateTimer;
            setupDataGrid();
        }
        DispatcherTimer interfaceTimer = new DispatcherTimer();
        DispatcherTimer stopwatchTimer = new DispatcherTimer();
        bool timerRunning = false;
        bool interfaceUpdating = false;
        private void setupDataGrid()
        {
            lapTimeDisplay.IsReadOnly = true;
            lapTimeDisplay.ItemsSource = this.listOfLaps;
 
        }
        public void toggleInterface()
        {
            if(interfaceUpdating)
            {
                interfaceTimer.Stop();
                interfaceUpdating = false;

            }
            else
            {
                interfaceTimer.Start();
                interfaceUpdating = true;
               
            }
        }
        public void getLap()
        {
            /*string currentT = currentTime.TotalMilliseconds.ToString("mm\\:ss\\:mss");*/

            if (timerRunning)
            {
                
               /*listOfLaps.Add(new LapInfo_KZi_30(currentT))*/
            }
            else
            {
                stopwatchTimer.Start();
                timerRunning = true;
            }
        }
        
        private void updateInterface(object sender, EventArgs e)
        {
            clockDisplay.Content = currentTime.ToString("mm\\:ss\\:mss");
        }
        private void updateTimer(object sender,EventArgs e)
        {
            currentTime = currentTime.Add(new TimeSpan (0,0,0,1,0));
        }
        private void getLapTime(object sender, RoutedEventArgs e)
        {
            toggleInterface();
            getLap();
        }
        public void resetTimer(object sender, RoutedEventArgs e)
        {
            currentTime = new TimeSpan(0, 0, 0);
            clockDisplay.Content = currentTime.ToString("mm\\:ss\\:mss");
        }
    }
}
