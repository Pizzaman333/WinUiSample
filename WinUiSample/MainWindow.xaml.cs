using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUiSample
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                button.Content = "You clicked me, why?";
                SpecialBoy.Fill = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 0, 0, 0)); // Custom color
            }
        }
    }
}
