namespace NetworkDetector
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();


            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                StatusImage.Source = "cat.png";
                StatusLabel.Text = "No Internet Connection";
                StatusLabel.TextColor = Colors.Red;
            }
            else
            {
                StatusImage.Source = "dog.png";
                StatusLabel.Text = "Connected to internet";
                StatusLabel.TextColor = Colors.Green;
            }
        }
    }
}