using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoTrongHao
{
    class KNCSDL
    {

        SqlConnection sqlketnoi;
        SqlCommand sqllenh;
        public KNCSDL()
        {
            sqlketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source=.;Initial Catalog=data;Integrated Security=True";
            sqlketnoi.ConnectionString = chuoiketnoi;
            sqllenh = new SqlCommand();
        }
        public bool Moketnoi()
        {
            try
            {
                sqlketnoi.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Dongketnoi()
        {
            sqlketnoi.Close();
        }
        public bool CapnhatCSDL(string str)
        {
            try
            {
                this.Moketnoi();
                sqllenh.Connection = sqlketnoi;
                sqllenh.CommandText = str;
                sqllenh.ExecuteNonQuery();
                this.Dongketnoi();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LayBang(string str)
        {
            this.Moketnoi();
            SqlDataAdapter bodocghi = new SqlDataAdapter(str, sqlketnoi);
            DataTable bang = new DataTable();
            bodocghi.Fill(bang);
            this.Dongketnoi();
            return bang;
        }
       
    }
}
