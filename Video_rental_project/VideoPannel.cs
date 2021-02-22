using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_project
{
   public class VideoPannel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String plot { get; set; }
        public String genre { get; set; }
        public int year { get; set; }
        public int cost { get; set; }
        public int copies { get; set; }



        //create the instance of the SQL Connection class
        SqlConnection conn;

        //write the connection sstring to assthe data form one for to the database 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=NewVideoRentalProject;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        SqlCommand cmd;

        //data reader is used to read thedata from the database table 
        SqlDataReader DReader;


        public VideoPannel() {

        }

        public VideoPannel(int _id, String _Name,String _Plot,String _Genre,int _Year, int _Copies,int _Cost ) {
            ID = _id;
            Name = _Name;
            plot = _Plot;
            genre = _Genre;
            year = _Year;
            copies = _Copies;
            cost = _Cost;
        }

        // this method is used to search the record from the data base and then pass the whole record to the query using where clause of the sql
        public DataTable CmdRecord(String qry)
        {
            DataTable tbl = new DataTable();

            conn = new SqlConnection(conStr);

            conn.Open();

            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }


        public void AddVideo()
        {

            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("insert into VideoPannel(Name,Plot,Genre,Year,Copies,Price) values('" + Name + "','" + plot + "','" + genre + "'," + year + ","+cost+","+copies+")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteVideo()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("delete from VideoPannel where VideoID=" + ID + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateVideo()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("update VideoPannel set Name='" + Name + "',Plot='" + plot + "',Genre='" + genre + "',Year=" + year + ",copies="+copies+",Price="+cost+" where VideoID=" + ID + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
