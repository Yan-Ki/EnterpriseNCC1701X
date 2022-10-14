using EnterpriseNCC1701X.EntityAccess;
using EnterpriseNCC1701X.PresentationLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EnterpriseNCC1701X
{
    /// <summary>
    /// Логика взаимодействия для WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {
        public WindowLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Start("Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog=NCC1701XDB;Integrated Security=True;Pooling=False"); 
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            App.Start($"Data Source=(localdb)\\MSSQLLocalDb;Initial Catalog={NameDB};User ID={Login};Password={Password};Pooling=False");
            this.Close();
        }
    }
}
