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

namespace miniCarDealership
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddToList(AddDummySpare());
        }

        private spareManager AddDummySpare()
        {
            spareManager obj1 = new spareManager(1, "Wheel");
            return obj1;
        }

        private void AddToList(spareManager inObj)
        {
            this.myListView.Items.Add(inObj.Name);
            myListView.ItemsSource = null;
        }
    }
}
