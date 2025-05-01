using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        foreach (UIElement el in MainRoot.Children)
        {
            if (el is Button)
            {
                ((Button)el).Click += Button_Click;
            }
        }
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string str = (string)((Button)e.OriginalSource).Content;
        if (str == "AC")
            Input.Text = "";
        else if (str == "=")
        {
            string value = new DataTable().Compute(Input.Text, null).ToString();
            Input.Text = value;
        }
        else
            Input.Text += str;
    }
}