﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPHDotNetCore.WinFormsAppSqlInjection
{
    internal static class ConnectionStrings
    {

        public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "DESKTOP-SOD2VVR", //servername
            InitialCatalog = "TPHDotNetCore", //databasename
            UserID = "sa",
            Password = "sa@123",
            TrustServerCertificate = true,

        };
    }
}
