using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BlankApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
          //  GMWV1.NavigateToString("http://www.cnn.com");
            try
            {
                string url = "http://www.malpaistech.com";
                Uri targetUri = new Uri(url);
                GMWV1.Navigate(targetUri);
                //yes!
                //yes again
            }
            catch (FormatException myE)
            {
                // Bad address
                GMWV1.NavigateToString(String.Format("<h1>Address is invalid, try again.  Details --> {0}.</h1>", myE.Message));
            }
        }

        private void GMWV1_LoadCompleted(object sender, NavigationEventArgs e)
        {
            
        }
    }
}
