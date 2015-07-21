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

namespace CheapeesManagementApplication
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      DataView dv = new DataView();
      dv.Show();
      StatusView sv = new StatusView();
      sv.Show();
      OrderListView olv = new OrderListView();
      olv.Show();
      OrderView ov = new OrderView();
      ov.Show();
      this.Close();
    }
  }
}
