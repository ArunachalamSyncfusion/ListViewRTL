namespace ListViewRTL
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Profile");
            list.Add("Inbox");
            list.Add("Outbox");
            list.Add("Sent");
            list.Add("Draft");
            listView.ItemsSource = list;
        }
    }

}
