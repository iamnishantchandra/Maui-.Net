namespace MauiTutorial
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //var NavPage = new NavigationPage(new MainPage());
            //NavPage.BarBackground = Colors.Green;
            //NavPage.BarTextColor = Colors.White;
            //MainPage = NavPage;
            //MainPage = new FlyoutPageDemo();
            //MainPage = new TabbedPageDemo();
            //MainPage = new StackPageDemo();
            //MainPage = new GridPageDemo();
            //MainPage = new AbsoluteLayoutDemo();
            //MainPage = new FlexLayoutDemo();
            //MainPage = new PresentationControl();
            //MainPage = new CommandDemo();
            //MainPage = new InputControls();
            //MainPage = new CollectionControl();
            // Lact->9 -1 start (0)
            MainPage = new ResourcesExample();
        }
    }
}
