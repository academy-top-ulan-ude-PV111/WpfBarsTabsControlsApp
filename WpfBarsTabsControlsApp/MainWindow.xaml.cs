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

namespace WpfBarsTabsControlsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TabItem item = new();
            item.Header = "Навыки";
            tabs.Items.Add(item);

            MenuItem menuItem = new();
            StackPanel exitPanel = new();
            exitPanel.Orientation = Orientation.Horizontal;
            Ellipse circle = new Ellipse();
            circle.Width = 10;
            circle.Height = 10;
            circle.Fill = new SolidColorBrush(Colors.Blue);
            TextBlock text = new() { Text = "Exit" };

            exitPanel.Children.Add(circle);
            exitPanel.Children.Add(text);

            menuItem.Header = exitPanel;

            menuMain.Items.Add(menuItem);

            ContextMenu context = new ContextMenu();
            List<MenuItem> items = new();
            for(int i = 0; i < 4; i++)
            {
                items.Add(new MenuItem() { Header = "ITEM " + i.ToString() });
            }
            context.ItemsSource = items;

            tab2.ContextMenu = context;
        }
    }
}
