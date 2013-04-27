using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ZumoFakeTweet.Models;
using Windows.Networking.PushNotifications;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ZumoFakeTweet
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private IMobileServiceTable<FakeTweetMessage> fakeTweetMessages = App.MobileService.GetTable<FakeTweetMessage>();
        private IMobileServiceTable<ChannelSub> channelSubs = App.MobileService.GetTable<ChannelSub>();

        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void SendMessageButton_Click(object sender, RoutedEventArgs e)
        {
            await fakeTweetMessages.InsertAsync(new FakeTweetMessage
                {
                    MyId = MyIdTextBox.Text,
                    FakeTweetText = FakeTweetTextBox.Text,
                    ToId = ToIdTextBox.Text
                });
        }

        private async void SubscribeButton_Click(object sender, RoutedEventArgs e)
        {
            await channelSubs.InsertAsync(new ChannelSub
            {
                MyId = MyIdTextBox.Text,
                AcceptBroadcast = AcceptBroadcastCheckBox.IsChecked.Value,
                Channel = App.CurrentChannel.Uri
            });
        }
    }
}
