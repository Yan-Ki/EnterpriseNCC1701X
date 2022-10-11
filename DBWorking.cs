using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace EnterpriseNCC1701X
{
   public class DBWorking
    {
        SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder()
        {
            DataSource = @" (localdb)\MSSQLLocalDb",
            InitialCatalog = "NCC1701XDB",
            IntegratedSecurity = true,
            Pooling = false
        };

        
       


    }
} 
