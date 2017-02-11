using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMC
{
    public partial class AdjustProducts : Form
    {
        string ConnStr = ConfigurationManager.ConnectionStrings["BazaLuDMC"].ConnectionString;
        AutoCompleteStringCollection MyProductCollection = new AutoCompleteStringCollection();
        public AdjustProducts()
        {
            InitializeComponent();
            PopulateAutocompleteDatasource();
            this.grdRemoveProducts.EditingControlShowing += dataGridView1_EditingControlShowing;
        }

        private void PopulateAutocompleteDatasource()
        {
            using (OleDbConnection con = new OleDbConnection(ConnStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT Articol FROM Produse", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MyProductCollection.Add(reader.GetString(0));
                }
                con.Close();
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= CheckKey;
            if (grdRemoveProducts.CurrentCell.ColumnIndex == 0)
            {
                TextBox prodCode = e.Control as TextBox;
                prodCode.CharacterCasing = CharacterCasing.Upper;

                prodCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                prodCode.AutoCompleteCustomSource = MyProductCollection;
                prodCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                
            }

            if (grdRemoveProducts.CurrentCell.ColumnIndex >= 1)
            {
                e.Control.KeyPress += CheckKey;
            }
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {

                if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            MyConn.Open();
            for (int i = 0; i < this.grdRemoveProducts.RowCount - 1; i++)
            //for (int i = 0; i < 50; i++)
            {
                var row = this.grdRemoveProducts.Rows[i];
                var articol = row.Cells[0].Value;
                var cantitate = row.Cells[1].Value;
                var pretUnitar = Convert.ToDouble(row.Cells[2].Value);
                using (OleDbCommand dataCommand = MyConn.CreateCommand())
                {
                    dataCommand.CommandText = string.Format("SELECT Top 1 ID FROM Produse WHERE Produse.Articol = '{0}' AND PretUnitar={1}", articol, pretUnitar);
                    OleDbDataReader rdr = dataCommand.ExecuteReader();
                    if (rdr.Read())
                    {
                        var id = rdr.GetInt32(0);
                        OleDbCommand CmdSql = new OleDbCommand(string.Format("Update [Produse] set Cantitate = Cantitate + {0} where ID={1}", cantitate, id), MyConn);
                        CmdSql.ExecuteNonQuery();
                    }
                    else
                    {
                        OleDbCommand CmdSql = new OleDbCommand(string.Format("Insert into [Produse] (Articol, PretUnitar, Cantitate) VALUES ('{0}', {1}, {2})", articol, pretUnitar, cantitate), MyConn);
                        CmdSql.ExecuteNonQuery();
                    }
                    rdr.Close();
                }
            }
            MyConn.Close();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            MyConn.Open();
            for (int i = 0; i < this.grdRemoveProducts.RowCount - 1; i++)
            //for (int i = 0; i < 50; i++)
            {
                var row = this.grdRemoveProducts.Rows[i];
                var articol = row.Cells[0].Value;
                var cantitate = row.Cells[1].Value;
                var pretUnitar = Convert.ToDouble(row.Cells[2].Value);
                using (OleDbCommand dataCommand = MyConn.CreateCommand())
                {
                    dataCommand.CommandText = string.Format("SELECT Top 1 ID FROM Produse WHERE Produse.Articol = '{0}' AND PretUnitar={1}", articol, pretUnitar);
                    OleDbDataReader rdr = dataCommand.ExecuteReader();
                    if (rdr.Read())
                    {
                        var id = rdr.GetInt32(0);
                        OleDbCommand CmdSql = new OleDbCommand(string.Format("Update [Produse] set Cantitate = Cantitate - {0} where ID={1}", cantitate, id), MyConn);
                        CmdSql.ExecuteNonQuery();
                    }
                    else
                    {
                        OleDbCommand CmdSql = new OleDbCommand(string.Format("Insert into [Produse] (Articol, PretUnitar, Cantitate) VALUES ('{0}', {1}, {2})", articol, pretUnitar, 0-Convert.ToDouble(cantitate)), MyConn);
                        CmdSql.ExecuteNonQuery();
                    }
                    rdr.Close();
                }
            }
            MyConn.Close();
            button1.Enabled = false;
        }
    }
}
