using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using EnterpriseNCC1701X.Domain;
using EnterpriseNCC1701X.EntityAccess;
using EnterpriseNCC1701X.PresentationLogic;

namespace EnterpriseNCC1701X
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //InitializeDB();
            //ComponentRepository componentRepository = new ComponentRepository(); 
            MainContext mainContext = new MainContext();
            ProductRepository productlRepository = new ProductRepository(mainContext);
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel(productlRepository);
            MainWindow window = new MainWindow();
            window.DataContext = mainWindowViewModel;
            window.Show();
        }


        private static void InitializeDB()
        {
            using (MainContext dbContext = new MainContext())
            {

                //Component component1 = dbContext.Components.Add(new Component() { Name = "sdfsdf" });

                Product product1 = dbContext.Products.Add(new Product() { Name = "sdfsdf" });
                //Product product2 = dbContext.Products.Add(new Product() { Name = "Варп-двигатель" });
                //Product product3 = dbContext.Products.Add(new Product() { Name = "Фазовые излучатели" });
                //Product product4 = dbContext.Products.Add(new Product() { Name = "Щиты зажиты" });
                //Product product5 = dbContext.Products.Add(new Product() { Name = "Система навигации" });
                dbContext.SaveChanges();
             
                //Component component1 = dbContext.Components.Add(new Component() { Name = "Component1" });
                //Component component2 = dbContext.Components.Add(new Component() { Name = "Component2" });
                //Component component3 = dbContext.Components.Add(new Component() { Name = "Component3" });
                //Component component4 = dbContext.Components.Add(new Component() { Name = "Component4" });
                //dbContext.SaveChanges();

                //material1.Components.Add(component1);
                //material1.Components.Add(component2);
                //material1.Components.Add(component3);

                //material2.Components.Add(component1);
                //material2.Components.Add(component2);

                //material3.Components.Add(component3);
                //material3.Components.Add(component4);

                //material4.Components.Add(component1);
                //material4.Components.Add(component4);
                //dbContext.SaveChanges();
            }
        }



    }
}
