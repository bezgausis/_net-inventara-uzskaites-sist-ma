using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms;
using System.Data.OleDb;

namespace wfp_2prd
{
    public partial class Form1 : Form
    {
        SortableBindingList<Datorklase> inventars = new SortableBindingList<Datorklase>();

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventarsDataSet.inventars' table. You can move, or remove it, as needed.
            this.inventarsTableAdapter.Fill(this.inventarsDataSet.inventars);
           
             int i, loop = 100;
            for (i = 0; i < loop; i++)
            {
                Datorklase rec1 = new Datorklase();
                rec1.kods = "kods" + i;
                rec1.nosaukums = "nos" + i;
                rec1.inventara_nr =  i;
                rec1.uzskaites_val = i;
                rec1.iegades_val =   i;
                // klases 1 ierakta pievienošana sarakstam
                inventars.Add(rec1);
            }       
           


            dataGridView1.DataSource = inventars;
            dataGridView1.Update();
            //button1.Enabled = false;

        }
        //defensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensive
        public class Datorklase // klase datorklases inventāra parametru ievadei
        {
            public string kods
            {
                get;
                set;
            }
            public string nosaukums
            {
                get;
                set;
            }
            public int inventara_nr
            {
                get;
                set;
            }
            public double uzskaites_val
            {
                get;
                set;
            }
            public double iegades_val
            {
                get;
                set;
            }

            public Datorklase() { }

            public Datorklase(string kods, string nosaukums, int inventara_nr, double uzskaites_val, double iegades_val)
            {
                this.kods = kods;
                this.nosaukums = nosaukums;
                this.inventara_nr = inventara_nr;
                this.uzskaites_val = uzskaites_val;
                this.iegades_val = iegades_val;
            }
        }







        private void button2_Click(object sender, EventArgs e)
        {
            dzestInv();
        }
        //metode izdzēš elementu no datagridview1 un inventars saraksta pie kura ir kursors
        private void dzestInv()
        {
            if (inventars.Count > 0)
                inventars.RemoveAt(dataGridView1.CurrentCell.RowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {

           
        }
        // metode pievieno jaunu datorklases objektu
        private void pievienotInv()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" )
                MessageBox.Show("savadi validas vertības!!!");

            else
            {
                Datorklase rec1 = new Datorklase();
                rec1.kods = textBox1.Text;
                rec1.nosaukums = textBox2.Text;
                rec1.inventara_nr = int.Parse(textBox3.Text);
                rec1.uzskaites_val = double.Parse(textBox4.Text);
                rec1.iegades_val = double.Parse(textBox5.Text);
                // klases 1 ierakta pievienošana sarakstam
                if (validet(rec1.uzskaites_val, rec1.iegades_val))
                {
                    inventars.Add(rec1);
                    textBox1.Text = "";
                    textBox2.Items.Add((textBox2.Text));
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
            }
           
           
           // button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //defensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensivedefensive
            //poga pievienot tiek aktivizeta tikai tad ja visi texta lauki ir aizpildiiti
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pievienotDB();
            inventarsTableAdapter.Fill(inventarsDataSet.inventars);
        }

        private void pievienotDB()
        {
            // inventars.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            if (dataGridView1.SelectedRows.Count != 0)
            {



                OleDbConnection connect = new OleDbConnection();
                connect.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\inventars.mdb"; //sitais strings md jasuuta
                connect.Open();
                MessageBox.Show("ir savienojums");

                string cmd1 = "INSERT INTO inventars (kods, nosaukums, inventara_nr, uzskaites_val, iegades_val) VALUES(@kods, @nosaukums, @inventara_nr, @uzskaites_val, @iegades_val)"; //get the existence of the record as count 
                OleDbCommand cmd = new OleDbCommand(cmd1, connect);

                if (connect.State == ConnectionState.Open)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {

                        string value1 = row.Cells[0].Value.ToString();Console.WriteLine(value1);
                        string value2 = row.Cells[1].Value.ToString();
                        string value3 = row.Cells[2].Value.ToString();
                        string value4 = row.Cells[3].Value.ToString();
                        string value5 = row.Cells[4].Value.ToString();

                       

                        if (connect.State == ConnectionState.Open)
                        {
                            cmd.Parameters.Add("@kods", OleDbType.Char).Value = value1;
                            cmd.Parameters.Add("@nosaukums", OleDbType.Char).Value = value2;
                            cmd.Parameters.Add("@inventara_nr", OleDbType.Numeric, 100).Value = value3;
                            cmd.Parameters.Add("@uzskaites_val", OleDbType.Numeric, 100).Value = value4;
                            cmd.Parameters.Add("@iegades_val", OleDbType.Numeric, 100).Value = value5;
                            
                        }
                        try
                        {
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();


                        }
                        catch (Exception ex)
                        {
                        }

                    }
                  
                    try
                    {
                        this.Validate();
                        this.inventarsBindingSource.EndEdit();
                        this.inventarsTableAdapter.Update(inventarsDataSet);
                        MessageBox.Show("Update successful");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Update failed");
                    }


                    connect.Close();
                }

            }
            inventarsTableAdapter.Fill(inventarsDataSet.inventars);
        }

        private void pievienotRAM()
        {
            // inventars.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            if (dataGridView2.SelectedRows.Count != 0)
            {

                OleDbConnection connect = new OleDbConnection();
                connect.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\inventars.mdb"; //sitais strings md jasuuta
                connect.Open();
                MessageBox.Show("ir savienojums");

                // OleDbCommand cmd = new OleDbCommand("SELECT kods, nosaukums, inventara_nr, uzskaites_val, iegades_val FROM inventars WHERE )", connect);

                if (connect.State == ConnectionState.Open)
                {
                    foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                    {

                        string value1 = row.Cells[0].Value.ToString();
                        string value2 = row.Cells[1].Value.ToString();
                        string value3 = row.Cells[2].Value.ToString();
                        string value4 = row.Cells[3].Value.ToString();
                        string value5 = row.Cells[4].Value.ToString();

                        string cmdStr = "SELECT COUNT(*) from inventars WHERE kods='"+value1+"'"; //get the existence of the record as count 

                        OleDbCommand cmd2 = new OleDbCommand(cmdStr, connect);

                        int count = (int)cmd2.ExecuteScalar();

                        //record already exist
                        Form1.Datorklase rec1 = new Form1.Datorklase();
                        rec1.kods = value1;
                        rec1.nosaukums = value2;
                        rec1.inventara_nr = int.Parse(value3);
                        rec1.uzskaites_val = double.Parse(value4);
                        rec1.iegades_val = double.Parse(value5);
                        inventars.Add(rec1);
                        // klases 1 ierakta pievienošana sarakstam
/*
                        if (count == 1)
                        {
                            
                            if (!inventars.Contains(rec1))
                                inventars.Add(rec1);
                            else MessageBox.Show("ieraksts iekš RAM: "
                                   + rec1.kods + "\t" +
                                    rec1.nosaukums + "\t" +
                                    rec1.inventara_nr + "\t" +
                                    rec1.uzskaites_val + "\t" +
                                    rec1.iegades_val + "\t" + " jau eksistē"
                                );
                        }

                        if (count == 0) MessageBox.Show("ieraksts iekš db: "
                                   + rec1.kods + "\t" +
                                    rec1.nosaukums + "\t" +
                                    rec1.inventara_nr + "\t" +
                                    rec1.uzskaites_val + "\t" +
                                    rec1.iegades_val + "\t" + " ir dzēsts"
                                );

*/

                    }
                    dataGridView1.Update();
                    connect.Close();
                }

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pievienotInv();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pievienotRAM();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pievienotInv();
        }

        private bool validet(double n, double g)
        {

            if (n < 0) //if user input is negative
            {
                MessageBox.Show("nevar būt negativs");
                return false;
            }
                if (g < 0) //if user input is negative
            {
                MessageBox.Show("nevar būt negativs");
                return false;
            }
            if (n > g) //if user input is negative
            {
                MessageBox.Show("nevar būt uzskaites vertība lielāka par iegādes (izņemot vīnu,viskiju :D)");
                return false;
            }

            return true;
           
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
           // if (tabControl1.SelectedTab.Text == "RAM") { button5.Enabled = false; button3.Enabled = true; }
           // if (tabControl1.SelectedTab.Text == "DB") { button3.Enabled = false; button5.Enabled = true; }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pievienotRAM();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pievienotDB();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            dzestInv();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
            var uzsk = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            var iega = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
           

            if (Double.Parse(uzsk) <= Double.Parse(iega))
            {
                //Your logic should be here..
            }
            else
            {
                MessageBox.Show("nevar būt uzskaites vertība lielāka par iegādes (izņemot vīnu,viskiju :D)");
                dataGridView1.Rows[e.RowIndex].Cells[3].Value = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                
                e.Cancel = true;
            }
        }
    }
}
