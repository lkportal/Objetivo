using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MetasObjetivos.bd {
    internal class BDSQLServer {

        private static string urlConnection = @"Server=DESKTOP-7KUBS2C\SQLEXPRESS;Database=OBJETIVOS_METAS;Trusted_Connection=True;";



        public static SqlConnection Connection() {
            SqlConnection conn = new SqlConnection(urlConnection);  
            try {
                conn.Open();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Conection");
            } 
            return conn;
        }

        public static SqlConnection Desconnection() {
            SqlConnection conn = new SqlConnection(urlConnection);
            try {
                conn.Close();
            }catch(Exception ex) {
                MessageBox.Show(ex.Message, "Desconnection");
            }
            return conn;
        }
      


    }
}
