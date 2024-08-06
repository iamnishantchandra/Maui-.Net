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
            //MainPage = new FlexLayoutDemo();
            //MainPage = new PresentationControl();
            //MainPage = new CommandDemo();
            // Lact->7 -1 start (6)
            MainPage = new InputControls();
        }
    }
}
