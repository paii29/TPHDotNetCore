﻿// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TPHDotNetCore.ConsoleApp;


Console.WriteLine("Hello, World!");

//nuget package(sqlclient) for database
//F10 => 
//F11 => into the used class


//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

//stringBuilder.DataSource = "DESKTOP-SOD2VVR"; //servername
//stringBuilder.InitialCatalog = "TPHDotNetCore"; //databasename

//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";

//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);


//connection.Open();
//Console.WriteLine("Connection Open");

//string query = "select * from Tbl_Blog";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);

//connection.Close();
//Console.WriteLine("Connection Close");

////dataset => datatable
////datatable => datarow
////datarow => datacolumn

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Blog ID =>" + dr["BlogID"]);
//    Console.WriteLine("Blog Title =>" + dr["BlogTitle"]);
//    Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
//    Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
//    Console.WriteLine("--------------------------");
//}


//Ado.net Read

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();

////adoDotNetExample.Read();

////adoDotNetExample.Create("title", "author", "content");

////adoDotNetExample.Update(7, "test title", "test author", "text content");

////adoDotNetExample.Delete(3);

//adoDotNetExample.edit(3);
//adoDotNetExample.edit(6);


//DapperExample dapperExample = new DapperExample();
//dapperExample.Run();

EFCoreExample eFCoreExample = new EFCoreExample();
eFCoreExample.Run();

Console.ReadKey(); // press any key to exit the program