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

namespace Unique_Column_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void dataGrid_CurrentCellValidating(object sender, Syncfusion.UI.Xaml.Grid.CurrentCellValidatingEventArgs e)
        {
            if (e.Column.MappingName == "OrderID")
            {
                for (int i = 0; i < dataGrid.View.Records.Count; i++)
                {
                    if ((this.dataGrid.View.Records[i].Data as OrderInfo).OrderID.ToString().Equals((e.NewValue.ToString())) && (e.NewValue.ToString() != e.OldValue.ToString()))
                    {
                        e.IsValid = false;
                        e.ErrorMessage = "Invalid Value";
                        break;
                    }
                }
            }
        }
    }
}
