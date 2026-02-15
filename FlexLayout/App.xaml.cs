namespace FlexLayout
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new FlexLayout();

            //MainPage = new NavigationPage(new FlexLayout_2());

        }
    }
}
