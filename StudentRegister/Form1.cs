using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;



namespace StudentRegister
{
   
    public partial class Form1 : Form
    {

        //Sql Server Connection 
        SqlConnection Connet = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDB;Integrated Security=True");
       
       
        public Form1()
        {
            InitializeComponent();

        }//Form1

        

        //insert Methord 
        private void InsertBT_Click(object sender, EventArgs e)
        {
            int S_ID = int.Parse(textBox1.Text);
          string S_Name = TBoxName.Text, S_Age = TBoxAge.Text, S_Grade = TBoxGrade.Text;
                Connet.Open();

            SqlCommand Cmd = new SqlCommand("exec Student_DBIn'" + S_ID + "', '" + S_Name + "','" + S_Age + "','" + S_Grade + "'", Connet);
            Cmd.ExecuteNonQuery();
            Connet.Close();
            MessageBox.Show("Succesfuly Insert !");
            ShowTableData();
        }//InsertBT_Click



        void ShowTableData()
        {
            SqlCommand Cm = new SqlCommand("exec Student_TBShow", Connet);
            SqlDataAdapter Sadapter = new SqlDataAdapter(Cm);
            DataTable DTable = new DataTable();
            Sadapter.Fill(DTable);
            dataGridView1.DataSource = DTable;
        }//Form1_Load

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowTableData();
        }//Form1_Load

        private void UpBT_Click(object sender, EventArgs e)
        {
            int S_ID = int.Parse(textBox1.Text);
            string S_Name = TBoxName.Text, S_Age = TBoxAge.Text, S_Grade = TBoxGrade.Text;
            Connet.Open();
            SqlCommand Cmd = new SqlCommand("exec Student_DBup'" + S_ID + "', '" + S_Name + "','" + S_Age + "','" + S_Grade + "'", Connet);
            Cmd.ExecuteNonQuery();
            Connet.Close();
            MessageBox.Show("Succesfuly Updated !");
            ShowTableData();

        }//UpBT_Click

        private void DeBT_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Conform Your Delete?", "Delete Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int S_ID = int.Parse(textBox1.Text);
                Connet.Open();
                SqlCommand Cmd = new SqlCommand("exec Student_DBde '" + S_ID + "'", Connet);
                Cmd.ExecuteNonQuery();
                Connet.Close();
                MessageBox.Show("Succesfuly Delete !");
                ShowTableData();
            }
           

        }//DeBT_Click

        private void SeBT_Click(object sender, EventArgs e)
        {

           int S_ID = int.Parse(textBox1.Text);
         
            SqlCommand Cmd = new SqlCommand("exec Student_DBse '" + S_ID + "'", Connet);

            SqlDataAdapter Sadapter = new SqlDataAdapter(Cmd);
            DataTable Dtable = new DataTable();
            Sadapter.Fill(Dtable);
            dataGridView1.DataSource = Dtable;

        }//SeBT_Click
    } //Form Class


}//namespace
