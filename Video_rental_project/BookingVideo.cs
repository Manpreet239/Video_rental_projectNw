using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_project
{
    public class BookingVideo
    {
        public int RentID { get; set; }
        public int VideoID { get; set; }
        public int CustomerID { get; set; }
        public String IssueDate { get; set; }
        public String ReturnDate{ get; set; }




        //create the instance of the SQL Connection class
        SqlConnection conn;

        //write the connection sstring to assthe data form one for to the database 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=NewVideoRentalProject;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        SqlCommand cmd;

        //data reader is used to read thedata from the database table 
        SqlDataReader DReader;
        private int v1;
        private int v2;
        private string text;
        private string v3;

        public BookingVideo() {
                
        }
        public BookingVideo(int _rID,int _Vid,int Cid,String Issue,String Retrn) {
            RentID = _rID;
            VideoID = _Vid;
            CustomerID = Cid;
            IssueDate = Issue;
            ReturnDate = Retrn;
                
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


        public void BookVideo()
        {

            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("insert into BookingPannel(MovieID,CustomerID,IssueDate,ReturnDate) values(" + VideoID + "," + CustomerID+ ",'" + IssueDate + "','" + ReturnDate + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteBookVideo()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("delete from BookingPannel where BookingID=" + RentID + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ReturnVideo()
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("update BookingPannel set MovieID=" + VideoID + ",CustomerID=" + CustomerID+ ",IssueDate='" + IssueDate+ "',ReturnDate='" +ReturnDate + "' where BookingID=" + RentID + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
