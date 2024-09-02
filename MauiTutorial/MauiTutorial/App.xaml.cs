using MauiTutorial.MVVM.Views;

namespace MauiTutorial
{
    public partial class App : Application
    {
        public App()
        {
            //13 lact-> MVVM

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
            //MainPage = new ResourcesExample();
            //MainPage = new DataBinding();
            //MainPage = new ModesExample();
            //MainPage = new INotifyChanged();
            //MainPage = new ProductPage();
            //MainPage = new BindCollectionView();//14
            //MainPage = new ConverterExample();//15
            //MainPage = new CommandExample();//16//AddINotifyPropertyChangedInterface 17
            //MainPage = new NavigationPage(new FirstPage());//18 
            //MainPage = new ClothPage_o();//19 //Collection View  DataTemplate Grid
            MainPage = new ClothPage();//20,21// ResourceDictionary -> Selector Class ResourceDictionary-> Condition Based Row Design //22-> Refresh and Paging

            //Lact->22 -1 S (0)

        }
    }
}
