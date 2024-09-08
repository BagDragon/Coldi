using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coldi.res.Control
{
    static class ConnectDB
    {      
        public static NpgsqlConnection connection() 
        {
            string vStrConnection = "Server= localhost; port= 5432; user id= postgres; password= 93538565; database= UserBD;";

            NpgsqlConnection vCon = new NpgsqlConnection();
            vCon.ConnectionString = vStrConnection;//connect 

            if (vCon.State == ConnectionState.Closed)
            {
                vCon.Open();
            }         
            return vCon;          
        }
    }
}
