using DALL_E.Views;

namespace DALL_E
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DashBoardview();
        }
    }
}
