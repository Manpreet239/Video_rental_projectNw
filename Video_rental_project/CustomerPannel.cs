using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_rental_project
{
    public class CustomerPannel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }

        public String Phone { get; set; }
        public String Country { get; set; }


        //create the instance of the SQL Connection class
        SqlConnection conn;

        //write the connection sstring to assthe data form one for to the database 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=NewVideoRentalProject;Integrated Security=True";

        //command are use to excute the command of isnert , delete , update
        SqlCommand cmd;

        //data reader is used to read thedata from the database table 
        SqlDataReader DReader;

        //default constructor 
      public  CustomerPannel() {
                
        }
        //parameterized cinstructor 
        public CustomerPannel(int _id,String _Name,String _Address,String _Phone,String _Country) {
            ID = _id;
            Name = _Name;
            Address = _Address;
            Phone = _Phone;
            Country = _Country;
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


        public void AddCustomer() {

            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("insert into CustomerPannel(Name,Address,Phone,Country) values('"+Name+"','"+Address+"','"+Phone+"','"+Country+"')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void DeleteCustomer()
        {

            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("delete from CustomerPannel where CustomerID="+ID+"", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void UpdateCustomer()
        {

            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand("update CustomerPannel set Name='"+Name+"',Address='"+Address+"',Phone='"+Phone+"',Country='"+Country+ "' where CustomerID=" + ID + "", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}
