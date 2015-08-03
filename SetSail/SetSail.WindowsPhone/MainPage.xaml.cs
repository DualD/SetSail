using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SetSail
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void WeatherButton_Click(object sender, RoutedEventArgs e)
        {
            WeatherCanvas.Visibility=Visibility.Visible;
            SeaCanvas.Visibility=Visibility.Collapsed;
            CourseCanvas.Visibility=Visibility.Collapsed;
        }

        private void SeaButton_Click(object sender, RoutedEventArgs e)
        {
            WeatherCanvas.Visibility = Visibility.Collapsed;
            SeaCanvas.Visibility = Visibility.Visible;
            CourseCanvas.Visibility = Visibility.Collapsed;
        }

        private void CourseButton_Click(object sender, RoutedEventArgs e)
        {
            WeatherCanvas.Visibility = Visibility.Collapsed;
            SeaCanvas.Visibility = Visibility.Collapsed;
            CourseCanvas.Visibility = Visibility.Visible;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<String> Locations = new List<string>();

            Locations.Add("Kattegat");
            Locations.Add("Sjælland");
            Locations.Add("Fyn");
            Locations.Add("Jylland");
        }

        private void ParametreBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<String> Parametres = new List<string>();

            Parametres.Add("Strøm");
            Parametres.Add("Vandstand");
            Parametres.Add("Bølgehøjde");
        }

        
    }
}
