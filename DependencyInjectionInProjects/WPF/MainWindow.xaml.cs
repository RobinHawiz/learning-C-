using DIDemoLib;
using Microsoft.Extensions.Configuration;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMessages messages, IConfiguration config)
        {
            InitializeComponent();
            helloText.Text = messages.SayHello();
            configText.Text = config.GetValue<string>("test");
            goodbyeText.Text = messages.SayGoodbye();
        }
    }
}