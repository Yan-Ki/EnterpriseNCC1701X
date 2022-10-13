using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            
            MainContext mainContext = new MainContext();

            ProductRepository productRepository = new ProductRepository(mainContext);
            ComponentRepository componentRepository = new ComponentRepository(mainContext);
            ComponentOrderRepository componentOrderRepository = new ComponentOrderRepository(mainContext);

            MainWindow window = new MainWindow();


            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel(productRepository, componentRepository, componentOrderRepository, mainContext);
         
           // MainWindow window = new MainWindow();
            window.DataContext = mainWindowViewModel;
            window.Show();
            //window.ListBoxTable.ItemsSource=mainWindowViewModel.Products;


        }


        private static void InitializeDB()
        {
            using (MainContext dbContext = new MainContext())
            {

                Product product1 = dbContext.Products.Add(new Product() { Name = "Корпус" });
                Product product2 = dbContext.Products.Add(new Product() { Name = "Варп-двигатель" });
                Product product3 = dbContext.Products.Add(new Product() { Name = "Фазовые излучатели" });
                Product product4 = dbContext.Products.Add(new Product() { Name = "Щиты защиты" });
                Product product5 = dbContext.Products.Add(new Product() { Name = "Система навигации" });
                dbContext.SaveChanges();
             
                Component component1 = dbContext.Components.Add(new Component() { Name = "Швеллер" });
                Component component2 = dbContext.Components.Add(new Component() { Name = "Лист 09Г2С 20" });
                Component component3 = dbContext.Components.Add(new Component() { Name = "Лист 12Х18Н10Т 8" });
                Component component4 = dbContext.Components.Add(new Component() { Name = "Двутавр 20" });
                Component component5 = dbContext.Components.Add(new Component() { Name = "Пруток 15" });
                Component component6 = dbContext.Components.Add(new Component() { Name = "Кабель силовой" });
                Component component7 = dbContext.Components.Add(new Component() { Name = "Шкафы силовые" });
                Component component8 = dbContext.Components.Add(new Component() { Name = "Блоки предохранителей" });
                Component component9 = dbContext.Components.Add(new Component() { Name = "Вентили запорные" });
                Component component10 = dbContext.Components.Add(new Component() { Name = "Подшипники" });
                dbContext.SaveChanges();



                ComponentOrder comp1 = new ComponentOrder() { Code = "Швеллер 20У 12м", Price = 23690, DataPrice = "23.08.2089" };
                ComponentOrder comp2 = new ComponentOrder() { Code = "Лист 09Г2С 20х6000х6000", Price = 12900, DataPrice = "25.08.2089" };
                ComponentOrder comp3 = new ComponentOrder() { Code = "Лист 12Х18Н10Т 8х6000х6000", Price = 23690, DataPrice = "23.08.2089" };
                ComponentOrder comp4 = new ComponentOrder() { Code = "Двутавр 20 12м", Price = 15450, DataPrice = "25.08.2089" };
                ComponentOrder comp5 = new ComponentOrder() { Code = "Пруток 15х6000", Price = 31580, DataPrice = "26.08.2089" };
                ComponentOrder comp6 = new ComponentOrder() { Code = "Кабель силовой 20м", Price = 23690, DataPrice = "23.08.2089" };
                ComponentOrder comp7 = new ComponentOrder() { Code = "Шкафы силовые", Price = 160567, DataPrice = "13.09.2089" };
                ComponentOrder comp8 = new ComponentOrder() { Code = "Блоки предохранителей", Price = 180990, DataPrice = "17.10.2089" };
                ComponentOrder comp9 = new ComponentOrder() { Code = "Вентили запорные", Price = 260895, DataPrice = "06.10.2089" };
                ComponentOrder comp10 = new ComponentOrder() { Code = "Подшипники", Price = 670857, DataPrice = "21.10.2089" };
                dbContext.SaveChanges();

                component1.Order = comp1;
                component2.Order = comp2;
                component3.Order = comp3;
                component4.Order = comp4;
                component5.Order = comp5;
                component6.Order = comp6;
                component7.Order = comp7;
                component8.Order = comp8;
                component9.Order = comp9;
                component10.Order = comp10;
                dbContext.SaveChanges();

                product1.Components.Add(component1);
                product1.Components.Add(component2);
                product1.Components.Add(component3);
                product1.Components.Add(component4);

                product2.Components.Add(component5);
                product2.Components.Add(component9);
                product2.Components.Add(component10);

                product3.Components.Add(component7);
                product3.Components.Add(component3);

                product4.Components.Add(component3);
                product4.Components.Add(component6);
                product4.Components.Add(component7);

                product5.Components.Add(component6);
                product5.Components.Add(component7);
                product5.Components.Add(component8);
                dbContext.SaveChanges();

            }
        }
 
    }
}
