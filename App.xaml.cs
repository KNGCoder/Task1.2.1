using System.Windows;
using Task1._2.View;

namespace Task1._2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new LoginWindow().Show();
        }
    }
}
