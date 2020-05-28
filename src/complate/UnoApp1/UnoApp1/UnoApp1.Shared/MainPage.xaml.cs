using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using UnoApp1.Shared;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UnoApp1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new MainPageViewModel();
            this.panel2.DataContext = new MainPageViewModeBindingBase();
            listView.DataContext = new[] { "草加せんべい", "越谷かもねぎ鍋", "深谷ネギ", "十万石まんじゅう", "くらづくり最中" };
#if __WASM__
           platform.Text = "WASM";
#endif
#if WINDOWS_UWP
           platform.Text = "UWP";
#endif
#if __ANDROID__
            platform.Text = "Android";
#endif
#if __IOS__
           platform.Text = "iOS";
#endif
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = $"{textBox1.Text}{textBox2.Text}";
        }

        private void listView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var value =  e.ClickedItem;

            this.Frame.Navigate(typeof(SecondPage), value);
        }
    }
}
