﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicariOtomasyon.DataAccess.Concrete
{
    public class SqlBaglantisi
    {
        public SqlConnection BaglantiDondur()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-SL1S3RQ\SQLEXPRESS;Initial Catalog=DboTicariOtomasyon;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
