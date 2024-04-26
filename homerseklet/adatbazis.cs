using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace homerseklet
{
    internal class adatbazis
    {
        const string server = "SERVER=linsql.verebely.dc;DATABASE=diak36;UID=diak36;PASSWORD=BXGERT;";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public adatbazis(string querry) 
        {
            con = new MySqlConnection(server);
            con.Open();
            cmd = new MySqlCommand(querry, con);
            dr = cmd.ExecuteReader();
        }

        public void Close() 
        {
            con.Close();
        }

        ~adatbazis()  //destruktor
        {
            con.Close();
        }
    }
}
