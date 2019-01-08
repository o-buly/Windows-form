using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter adptr;
        DataSet ds;
        DataTable table1;
        Label l1 = new Label();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDb();
        }

        private void RefreshDb()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-54R30KB\SQLEXPRESS;Initial Catalog=UsersDB;Integrated Security=True");
            adptr = new SqlDataAdapter("SELECT * FROM UsersTB ORDER BY Name", con);
            ds = new DataSet();

            adptr.Fill(ds, "T1");
            table1 = ds.Tables["T1"];
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Create Lable with possition

            Controls.Add(l1);
            l1.Location = new Point(50, 20);
            l1.Font = new Font(FontFamily.Families[0], 12);
            l1.Text = "Rows = " + table1.Rows.Count;
            lbl1.Text = "";

            foreach (DataRow row in table1.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    lbl1.Text += row["Id"] + ", " + row["Name"] + ", " + row["Family"] + "\r\n";
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = table1.NewRow();
            if (txbId.Text == "" || txbName.Text == "" || txbFamily.Text == "")
            {
                lblErr.Text = "EROR - You Can't Send Nothing";
            }
            else
            {
                dr["Id"] = int.Parse(txbId.Text);
                dr["Name"] = txbName.Text;
                dr["Family"] = txbFamily.Text;
                lblErr.Text = "success!!";
                table1.Rows.Add(dr);
                txbId.Text = "";
                txbName.Text = "";
                txbFamily.Text = "";
            }


        }

        private void btnUpdateDb_Click(object sender, EventArgs e)
        {
            new SqlCommandBuilder(adptr);
            adptr.Update(table1);
            //adptr.Update(ds,"T1");

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDb();
            txbId.Text = "";
            txbName.Text = "";
            txbFamily.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if (table1.Rows[i].RowState != DataRowState.Deleted)
                {
                    if (table1.Rows[i]["Id"].ToString() == txbId.Text)
                    {
                        table1.Rows[i].Delete();
                    }
                }
            }
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                if (table1.Rows[i]["Id"].ToString() == txbId.Text)
                {
                    table1.Rows[i]["Name"] = txbName.Text;
                    table1.Rows[i]["Family"] = txbFamily.Text;
                }
            }
        }
    }
}
