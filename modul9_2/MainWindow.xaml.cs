using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MousePos
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            var pos = e.GetPosition(this);

            Canvas.SetLeft(label1, pos.X + 10);
            Canvas.SetTop(label1, pos.Y + 10);

            label1.Content = $"{pos.X:0} , {pos.Y:0}";
        }

        private void Window_MouseEnter(object sender, MouseEventArgs e)
        {
            label1.Visibility = Visibility.Visible;
        }

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            label1.Visibility = Visibility.Hidden;
        }
    }
}