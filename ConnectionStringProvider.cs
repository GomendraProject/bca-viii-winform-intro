using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class ConnectionStringProvider
    {
        public static string GetConnectionString() => "Server=localhost;Database=test_bca_viii;Uid=root;Pwd=admin;";
    }
}
