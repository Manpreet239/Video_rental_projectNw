using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_rental_project
{
    public partial class Form1 : Form
    {
        public CustomerPannel customer = new CustomerPannel();
        public VideoPannel video = new VideoPannel();
        public BookingVideo BookingVideo = new BookingVideo();
        int BookID = 0, task = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text.ToString().Equals("") && txtAddress.Text.ToString().Equals("") && txtPhone.Text.ToString().Equals("") && txtCountry.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all values ");
            }
            else {
                customer = new CustomerPannel(1,txtName.Text,txtAddress.Text,txtPhone.Text,txtCountry.Text);
                // pass the record to insert 
                customer.AddCustomer();
                MessageBox.Show("Customer Record is stored ");
            }
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCountry.Text = "";
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text.ToString().Equals("")) {
                MessageBox.Show("You must have to select the ID ");
            }
            else {
                //        
                customer = new CustomerPannel(Convert.ToInt32(txtMovieID.Text), txtName.Text, txtAddress.Text, txtPhone.Text, txtCountry.Text);
                // pass the record to insert 
                customer.DeleteCustomer();
                MessageBox.Show("Customer Record is Deleted  ");
            }
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCountry.Text = "";
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (txtMovieID.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must have to select the ID ");
            }
            else
            {
                //        
                customer = new CustomerPannel(Convert.ToInt32(txtMovieID.Text), txtName.Text, txtAddress.Text, txtPhone.Text, txtCountry.Text);
                // pass the record to insert 
                customer.UpdateCustomer();
                MessageBox.Show("Customer Record is Deleted  ");
            }

            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCountry.Text = "";
        }

        private void vd_ad_Click(object sender, EventArgs e)
        {
            if (vd_Name.Text.ToString().Equals("") && vd_Plot.Text.ToString().Equals("") && Vd_Genre.Text.ToString().Equals("") && Vd_Year.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all values ");
            }
            else { 
            video = new VideoPannel(1, vd_Name.Text, vd_Plot.Text, Vd_Genre.Text, Convert.ToInt32(Vd_Year.Text), Convert.ToInt32(Vd_Copies.Text), Convert.ToInt32(Vd_Price.Text));
            video.AddVideo();
            MessageBox.Show("Video record is saved ");
            vd_Name.Text = "";
            vd_Plot.Text = "";
            Vd_Genre.Text = "";
            Vd_Year.Text = "";
            Vd_Copies.Text = "";
            Vd_Price.Text = "";
        }
        }

        private void Vd_Update_Click(object sender, EventArgs e)
        {
            if (vd_Name.Text.ToString().Equals("") && vd_Plot.Text.ToString().Equals("") && Vd_Genre.Text.ToString().Equals("") && Vd_Year.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all values ");
            }
            else
            {
                video = new VideoPannel(Convert.ToInt32(txtMovieID.Text), vd_Name.Text, vd_Plot.Text, Vd_Genre.Text, Convert.ToInt32(Vd_Year.Text), Convert.ToInt32(Vd_Copies.Text), Convert.ToInt32(Vd_Price.Text));
                video.UpdateVideo();
                MessageBox.Show("Video record is Updated ");
                txtMovieID.Text = "";
                vd_Name.Text = "";
                vd_Plot.Text = "";
                Vd_Genre.Text = "";
                Vd_Year.Text = "";
                Vd_Copies.Text = "";
                Vd_Price.Text = "";
            }
        }

        // deleting
        private void Vd_Delete_Click(object sender, EventArgs e)
        {
            if (vd_Name.Text.ToString().Equals("") && vd_Plot.Text.ToString().Equals("") && Vd_Genre.Text.ToString().Equals("") && Vd_Year.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all values ");
            }
            else
            {
                video = new VideoPannel(Convert.ToInt32(txtMovieID.Text), vd_Name.Text, vd_Plot.Text, Vd_Genre.Text, Convert.ToInt32(Vd_Year.Text), Convert.ToInt32(Vd_Copies.Text), Convert.ToInt32(Vd_Price.Text));
                video.DeleteVideo();
                MessageBox.Show("Video record is deleted ");
                txtMovieID.Text = "";
                vd_Name.Text = "";
                vd_Plot.Text = "";
                Vd_Genre.Text = "";
                Vd_Year.Text = "";
                Vd_Copies.Text = "";
                Vd_Price.Text = "";
            }
        }

        // booking Video
        private void button11_Click(object sender, EventArgs e)
        {
            BookingVideo = new BookingVideo(1,Convert.ToInt32(txtMovieID.Text),Convert.ToInt32(txtCustomerID.Text),dtpIssue.Text,"Book");
            BookingVideo.BookVideo();
            MessageBox.Show("Video is issed on rent ");
            txtMovieID.Text = "";
            vd_Name.Text = "";
            vd_Plot.Text = "";
            Vd_Genre.Text = "";
            Vd_Year.Text = "";
            Vd_Copies.Text = "";
            Vd_Price.Text = "";
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCountry.Text = "";

        }

        // video Delete
        private void btnRentalDelete_Click(object sender, EventArgs e)
        {

            BookingVideo = new BookingVideo(BookID, Convert.ToInt32(txtMovieID.Text), Convert.ToInt32(txtCustomerID.Text), dtpIssue.Text, "Book");
            BookingVideo.DeleteBookVideo();
            MessageBox.Show("Video is issed on rent ");
            txtMovieID.Text = "";
            vd_Name.Text = "";
            vd_Plot.Text = "";
            Vd_Genre.Text = "";
            Vd_Year.Text = "";
            Vd_Copies.Text = "";
            Vd_Price.Text = "";
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCountry.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {



            BookingVideo = new BookingVideo(BookID, Convert.ToInt32(txtMovieID.Text), Convert.ToInt32(txtCustomerID.Text), dtpIssue.Text, "Book");


            // movie Cost 
            DataTable tbl = new DataTable();
            tbl = new DataTable();
            tbl = BookingVideo.CmdRecord("select * from VideoPannel where VideoID=" + Convert.ToInt32(txtMovieID.Text) + "");
            int Cost = Convert.ToInt32(tbl.Rows[0]["Price"].ToString());



            DateTime current_date = DateTime.Now;

            //date converersion
            DateTime prev_date = Convert.ToDateTime(dtpIssue.Text);


            String Daysdiff = (current_date - prev_date).TotalDays.ToString();


            //date calculater
            Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));


            int Bill = Cost * Convert.ToInt32(DaysInterval);



            BookingVideo.ReturnVideo();
            MessageBox.Show("Thanks for the using you need to pay $"+Bill);
            txtMovieID.Text = "";
            vd_Name.Text = "";
            vd_Plot.Text = "";
            Vd_Genre.Text = "";
            Vd_Year.Text = "";
            Vd_Copies.Text = "";
            Vd_Price.Text = "";
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCountry.Text = "";
        }

        private void rental_Click(object sender, EventArgs e)
        {
            task = 1;
            BookingVideo = new BookingVideo(1, 1, 1, "ok", "Book");
            DataTable tbl = new DataTable();
            tbl = BookingVideo.CmdRecord("select * from BookingPannel");
            ViewData.DataSource=tbl;

            txtMovieID.Text = "";
            vd_Name.Text = "";
            vd_Plot.Text = "";
            Vd_Genre.Text = "";
            Vd_Year.Text = "";
            Vd_Copies.Text = "";
            Vd_Price.Text = "";
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCountry.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task = 2;
            BookingVideo = new BookingVideo(1, 1, 1, "ok", "Book");
            DataTable tbl = new DataTable();
            tbl = BookingVideo.CmdRecord("select * from VideoPannel");
            ViewData.DataSource = tbl;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            task = 3;
            BookingVideo = new BookingVideo(1,1,1,"ok","Book");
            DataTable tbl = new DataTable();
            tbl = BookingVideo.CmdRecord("select * from CustomerPannel");
            ViewData.DataSource = tbl;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //compare the booking and fetch the most viewed movie
            DataTable tblData = new DataTable();
            BookingVideo booking = new BookingVideo(1, 1, 1, "1", "1");

            tblData = booking.CmdRecord("select * from CustomerPannel");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = booking.CmdRecord("select * from BookingPannel where CustomerID='" + tblData.Rows[x]["CustomerID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Cusotmer is " + Title);

        }

        private void Vd_Year_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(Vd_Year.Text);
                int cost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    cost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    cost = 5;
                }

                Vd_Price.Text = "" + cost;
            }
            catch (Exception ex)
            {

            }

        }

        private void ViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (task == 1) {
                BookID =Convert.ToInt32( ViewData.CurrentRow.Cells[0].Value.ToString());


                txtMovieID.Text = ViewData.CurrentRow.Cells[1].Value.ToString();
                txtCustomerID.Text = ViewData.CurrentRow.Cells[2].Value.ToString();
                dtpIssue.Text = ViewData.CurrentRow.Cells[3].Value.ToString();


            } else if (task == 2) {
                txtMovieID.Text = ViewData.CurrentRow.Cells[0].Value.ToString();
                vd_Name.Text= ViewData.CurrentRow.Cells[1].Value.ToString();
                vd_Plot.Text = ViewData.CurrentRow.Cells[2].Value.ToString();
                Vd_Genre.Text = ViewData.CurrentRow.Cells[3].Value.ToString();
                Vd_Year.Text = ViewData.CurrentRow.Cells[4].Value.ToString();
                Vd_Copies.Text = ViewData.CurrentRow.Cells[5].Value.ToString();
                Vd_Price.Text = ViewData.CurrentRow.Cells[6].Value.ToString();




            }
            else if (task == 3){
                txtCustomerID.Text= ViewData.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = ViewData.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = ViewData.CurrentRow.Cells[2].Value.ToString();
                txtPhone.Text = ViewData.CurrentRow.Cells[3].Value.ToString();
                txtCountry.Text = ViewData.CurrentRow.Cells[4].Value.ToString();

            }

            task = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //compare the booking and fetch the most viewed movie
            DataTable tblData = new DataTable();
            BookingVideo booking = new BookingVideo(1, 1, 1, "1", "1");

            tblData = booking.CmdRecord("select * from VideoPannel");
            int x = 0, y = 0, cunt = 0;
            String Title = "";
            for (x = 0; x < tblData.Rows.Count; x++)
            {
                DataTable tblData1 = new DataTable();
                tblData1 = booking.CmdRecord("select * from BookingPannel where MovieID='" + tblData.Rows[x]["VideoID"].ToString() + "'");

                if (tblData1.Rows.Count > cunt)
                {
                    Title = tblData.Rows[x]["Name"].ToString();
                    cunt = tblData1.Rows.Count;
                }

            }

            MessageBox.Show("Best Video is " + Title);

        }
    }
}
