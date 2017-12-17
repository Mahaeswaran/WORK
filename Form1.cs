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
using System.Data.OleDb;


namespace rssFeedCSharp
{
    public partial class Form1 : Form
    {

        //SqlConnection con = new SqlConnection("Data Source= C:/Users/Maha/Documents/Visual Studio 2013/Projects/rssFeedCSharp/rssFeedCSharp/D1.accdb;Persist Security Info=True");
        //''"Data Source=|DataDirectory|\D1.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234

        DataTable dt = new DataTable();
        //SqlDataReader dr;
        //SqlCommand cmd;
        public Form1()
        {
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Maha/Documents/Visual Studio 2013/Projects/rssFeedCSharp/rssFeedCSharp/D1.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234"))


            using (OleDbCommand cmd = new OleDbCommand("select * from rssTable", conn))
            {
                conn.Open();
                //SqlDataAdapter da = new SqlDataAdapter ;
                //DataTable dt = new DataTable();

                //da.Fill(dt);

                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                //string user_role = dt.Rows[0]["link"].ToString();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();

                //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                //{

                //    this.comboBox1.Items.Add(ds.Tables[0].Rows[i][0] + " " + ds.Tables[0].Rows[i][1] + " " + ds.Tables[0].Rows[i][2]);

                //}
                //if (reader.HasRows)
                //           {
                //               MessageBox.Show("EE");
                //           }
                //           else
                //               MessageBox.Show("QQ");
                //           }
                //           {
                //           }
                InitializeComponent();
                //con.Open();
                //cmd = new SqlCommand("select * from rssTable, con");
                //dr = cmd.ExecuteReader();


            }
        }
        String[,] rssData = null;


        private String[,] getRssData(String channel)
        {
            System.Net.WebRequest myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            System.IO.Stream rssStream = myResponse.GetResponseStream();
            System.Xml.XmlDocument rssDoc = new System.Xml.XmlDocument();

            rssDoc.Load(rssStream);

            System.Xml.XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            String[,] tempRssData = new String[100, 3];
            for (int i = 0; i < rssItems.Count; i++)
            {
                System.Xml.XmlNode rssNode;

                rssNode = rssItems.Item(i).SelectSingleNode("title");
                if (rssNode != null)
                {
                    tempRssData[i, 0] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 0] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("description");
                if (rssNode != null)
                {
                    tempRssData[i, 1] = rssNode.InnerText;

                }
                else
                {
                    tempRssData[i, 1] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("link");
                if (rssNode != null)
                {
                    tempRssData[i, 2] = rssNode.InnerText;

                }
                else
                {
                    tempRssData[i, 2] = "";
                }


            }
            return tempRssData;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string rssLink = comboBox1.SelectedValue.ToString();
            titleComboBox.Items.Clear();
            rssData = getRssData(rssLink);
            //rssData = getRssData(channelTextBox.Text);

            //string myString = ((ComboBoxItem)comboBox1.SelectedItem).Content.ToString();
            // rssData = getRssData(comboBox1.SelectedValue.ToString);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    titleComboBox.Items.Add(rssData[i, 0]);
                }
                titleComboBox.SelectedIndex = 0;
            }
        }

        private void titleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[titleComboBox.SelectedIndex, 1] != null) ;
            descriptionTextBox.Text = rssData[titleComboBox.SelectedIndex, 1];
            if (rssData[titleComboBox.SelectedIndex, 2] != null) ;
            linkLabel.Text = "GoTo: " + rssData[titleComboBox.SelectedIndex, 0];
        }
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Maha/Documents/Visual Studio 2013/Projects/rssFeedCSharp/rssFeedCSharp/D1.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234");
            connect.Open();
            OleDbCommand cmd = new OleDbCommand("select * from rssTable", connect);
            OleDbDataReader odr = null;
            odr = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(odr);
            comboBox1.DataSource = table;
            comboBox1.BindingContext = this.BindingContext;
            comboBox1.DisplayMember = "Course Number and Name";
            comboBox1.ValueMember = "link";
            connect.Close();

        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[titleComboBox.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(rssData[titleComboBox.SelectedIndex, 2]);
        }

        private void saveRssbutton_Click(object sender, EventArgs e)
        {
            string InsertSQL = channelTextBox.Text;
            using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Maha/Documents/Visual Studio 2013/Projects/rssFeedCSharp/rssFeedCSharp/D1.accdb;Persist Security Info=True;Jet OLEDB:Database Password=1234"))

            using (OleDbCommand cmd = new OleDbCommand("Insert Into rssTable (link) Values ('" + InsertSQL + "')", conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            this.Hide();
            var myForm = new Form1();
            myForm.Show();

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string rssLink = comboBox1.SelectedValue.ToString();
            titleComboBox.Items.Clear();
            rssData = getRssData(rssLink);
            //rssData = getRssData(channelTextBox.Text);

            //string myString = ((ComboBoxItem)comboBox1.SelectedItem).Content.ToString();
            // rssData = getRssData(comboBox1.SelectedValue.ToString);
            for (int i = 0; i < rssData.GetLength(0); i++)
            {
                if (rssData[i, 0] != null)
                {
                    titleComboBox.Items.Add(rssData[i, 0]);
                }
                titleComboBox.SelectedIndex = 0;
            }
        }


    }
}
