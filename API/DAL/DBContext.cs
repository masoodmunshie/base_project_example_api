﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using DAL.Models;
using Npgsql;

namespace DAL
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<user> users { get; set; }

        public string ReturnConnectionString()
        {
      
        }

        public NpgsqlConnection ReturnSQLConn()
        {

            
            NpgsqlConnection conn = new NpgsqlConnection(ReturnConnectionString());
             conn.Open();
            return conn;
         
        }


    
    }
}
