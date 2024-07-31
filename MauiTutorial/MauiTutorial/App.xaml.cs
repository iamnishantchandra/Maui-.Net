namespace MauiTutorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            var NavPage = new NavigationPage(new MainPage());
            NavPage.BarBackground = Colors.Green;
            NavPage.BarTextColor = Colors.White;
            //MainPage = NavPage;
            //MainPage = new FlyoutPageDemo();
            //MainPage = new TabbedPageDemo();
            //MainPage = new StackPageDemo();
            //MainPage = new GridPageDemo();
            //MainPage = new AbsoluteLayoutDemo();
            // Lact->5 -1 start 
            MainPage = new FlexLayoutDemo();
        }
    }
}
