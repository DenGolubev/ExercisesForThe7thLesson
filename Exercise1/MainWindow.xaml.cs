using System.Windows;

namespace Exercise1
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string a = tBox1.Text;
            ACoder coder = new ACoder();
            tBox2.Text = coder.Encode(a);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            string a = tBox1.Text;
            ACoder coder = new ACoder();
            tBox2.Text = coder.Decode(a);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string a = tBox1.Text;
            BCoder coder = new BCoder();
            tBox2.Text = coder.Encode(a);
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            string a = tBox1.Text;
            BCoder coder = new BCoder();
            tBox2.Text = coder.Decode(a);
        }
    }
}
