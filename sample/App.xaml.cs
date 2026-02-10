namespace sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var navPage= new NavigationPage(new MainPage());
            navPage.BarBackgroundColor = Colors.LightBlue;
            navPage.BarTextColor = Colors.White;
            MainPage = new TabbedPageDemo();
        }
    }
}
