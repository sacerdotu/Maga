using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using iTextSharp.text;
using iTextSharp.text.pdf;
using log4net;
using log4net.Config;
using Font = iTextSharp.text.Font;
using FontFamily = iTextSharp.text.Font.FontFamily;

namespace SC.FANECOM.SRL
{
    public partial class MainForm : Form
    {
        AdjustProducts myForm = null;
        private readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        AutoCompleteStringCollection MyProductCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection SuppliersCollection = new AutoCompleteStringCollection();
        DataTable SuppliersDataTable = new DataTable();
        bool eventHookedUp = false;
        string ConnStr = ConfigurationManager.ConnectionStrings["BazaLuFane"].ConnectionString;
        private int _notaRec;
        private int _nrFact;
        private string _fileName;

        public MainForm()
        {
            log4net.Config.XmlConfigurator.Configure();
            this.log.Info("Begin to populate");
            try
            {
                InitializeComponent();
                PopulateProduseDatasource();
                PopulateFurnizoriDatasource();
                this.dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                this.dataGridView1.CellValidating += dataGridView1_CellValidating;
                this.dataGridView1.EditingControlShowing += dataGridView1_EditingControlShowing;
                PopulateControls();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            
        }
        private void PopulateProduseDatasource()
        {
            //string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
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
        
        private void PopulateFurnizoriDatasource()
        {
            SuppliersDataTable.Columns.Add("Nume");
            SuppliersDataTable.Columns.Add("CodFiscal");
            //string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(ConnStr))
            {
                OleDbCommand cmd = new OleDbCommand("SELECT Nume, CodFiscal FROM Furnizori", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SuppliersDataTable.Rows.Add(reader["Nume"].ToString(), reader["CodFiscal"].ToString());

                    SuppliersCollection.Add(reader.GetString(0));
                }
                con.Close();
            }
        }

        private string pattern = "^[0-9]{0,2}$";

        private void PopulateControls()
        {
            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            MyConn.Open();
            using (OleDbCommand dataCommand = MyConn.CreateCommand())
            {
                dataCommand.CommandText = string.Format("SELECT Top 1 Nota_Receptie,Nr_Factura FROM Config");
                OleDbDataReader rdr = dataCommand.ExecuteReader();
                if (rdr.Read())
                {
                    _notaRec = rdr.GetInt32(0);
                    _nrFact = rdr.GetInt32(1);
                    _notaRec += 1;
                    _nrFact += 1;
                    txtNotaReceptie.Text = _notaRec.ToString();
                    txtFactNum.Text = _nrFact.ToString();
                }
                rdr.Close();
            }
            MyConn.Close();
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= CheckKey;
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                TextBox prodCode = e.Control as TextBox;
                prodCode.CharacterCasing = CharacterCasing.Upper;
                prodCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                prodCode.AutoCompleteCustomSource = MyProductCollection;
                prodCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }

            if (dataGridView1.CurrentCell.ColumnIndex > 1)
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

        void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                //dataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
                //int indicator;
                //int newInteger;

                //if (e.ColumnIndex ==3)
                //{
                //    if (dataGridView1.Rows[e.RowIndex].IsNewRow) return;
                //    String data = e.FormattedValue.ToString();

                //    String validate = @"^[0-9].{0,2}$";
                //    Regex nameAlphabet = new Regex(validate);
                //    String nameGridView = data;
                //    if (!(nameAlphabet.IsMatch(nameGridView)))
                //    {
                //        e.Cancel = true;
                //        MessageBox.Show(@"eRROR");
                //    }
                //    else
                //        return;
                //}
            }

            // "^[0-9]{0,2}$";
        }


        void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            //(balance + deposit + withdrawal).ToString();
            var tva = 1.24;
            var adaos = 1.1;
            var cantitate = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Cantitate"].Value);
            var pret = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["PretFaraTva"].Value);
            if (sender is DataGridView)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 2)
                {
                    //double baseValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["PretFaraTva"].Value);
                    this.dataGridView1.Rows[e.RowIndex].Cells["PretDeVanzare"].Value = pret * tva * adaos;
                    this.dataGridView1.Rows[e.RowIndex].Cells["ValLaPretDeVanzare"].Value = pret * tva * adaos * cantitate;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'faneComDatabaseDataSet.Furnizori' table. You can move, or remove it, as needed.
            //this.furnizoriTableAdapter.Fill(this.faneComDatabaseDataSet.Furnizori);
            cmbFurnizor.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbFurnizor.DataSource = SuppliersDataTable;
            this.cmbFurnizor.DisplayMember = "Nume";
            this.cmbFurnizor.ValueMember = "CodFiscal";
            if (cmbFurnizor.SelectedValue != null)
                txtCodFiscal.Text = cmbFurnizor.SelectedValue.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFurnizor.SelectedValue != null)
                txtCodFiscal.Text = cmbFurnizor.SelectedValue.ToString();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            OleDbConnection MyConn = new OleDbConnection(ConnStr);
            MyConn.Open();

            using (OleDbCommand dataCommand = MyConn.CreateCommand())
            {
                dataCommand.CommandText = string.Format(string.Format("Update Config set Nota_Receptie = {0},Nr_Factura = {1}", _notaRec, _nrFact), MyConn);
                dataCommand.ExecuteNonQuery();
            }

            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            {
                var row = this.dataGridView1.Rows[i];
                var articol = row.Cells[0].Value;
                //var unitate = row.Cells[1].Value;
                var pretUnitar = row.Cells[3].Value;
                var cantitate = Convert.ToDouble(row.Cells[2].Value);
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
        }

        private PdfPCell GetHeaderCell(string text, int hasborder = 1, int hAlignment = 1)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, new Font(FontFamily.TIMES_ROMAN, 10.0f)));
            cell.Colspan = 1;
            cell.Border = hasborder;
            cell.HorizontalAlignment = hAlignment;
            return cell;
        }

        private PdfPCell GetNormalCell(string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, new Font(FontFamily.TIMES_ROMAN, 8.0f)));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.HorizontalAlignment = 1;
            cell.FixedHeight = 10f;
            return cell;
        }

        private PdfPCell GetNormalCellAdaos(string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, new Font(FontFamily.TIMES_ROMAN, 8.0f)));
            cell.Colspan = 1;
            cell.Border = 0;
            cell.HorizontalAlignment = 1;
            //cell.FixedHeight = 10f;
            return cell;
        }

        private PdfPCell GetHeaderCellAdaos(string text)
        {
            PdfPCell cell = new PdfPCell(new Phrase(text, new Font(FontFamily.TIMES_ROMAN, 10.0f)));
            cell.Colspan = 1;
            cell.Border = 0;
            cell.HorizontalAlignment = 1;
            return cell;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float[] adaosWidths;

            var contentTable = CreatePdfPTableHeader(out adaosWidths);
            //table.AddCell(GetHeaderCell("Adaos comercial"));
            PdfPTable cCell;

            var part2 = new PdfPTable(11);
            var rowCounter = 0;

            var headerTable = GetInvoiceDetails();
            var headTableTop = GetHeaderInvoiceDetails();
            var company = GetCompanyName();
            var footer = GetFooter();


            var invoicePath = ConfigurationManager.AppSettings["InvoicePath"];
            if (!CheckDirectory(invoicePath)) return;
            _fileName = invoicePath + "scFANECOMsrl_" + _notaRec + "_" + _nrFact + ".pdf";
            FileStream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            Document pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 10f, 10f, 0f);
            PdfWriter.GetInstance(pdfDoc, fs);
            pdfDoc.Open();
            pdfDoc.Add(headTableTop);
            pdfDoc.Add(company);
            pdfDoc.Add(headerTable);

            for (int i = 0; i < this.dataGridView1.RowCount - 1; i++)
            //for (int i = 0; i < 50; i++)
            {
                if (rowCounter == 25)
                {
                    pdfDoc.Add(contentTable);
                    pdfDoc.Add(footer);
                    pdfDoc.NewPage();
                    pdfDoc.Add(headTableTop);
                    pdfDoc.Add(company);
                    pdfDoc.Add(headerTable);


                    contentTable = CreatePdfPTableHeader(out adaosWidths);
                }
                var row = this.dataGridView1.Rows[i];
                contentTable.AddCell(GetNormalCell((i + 1).ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[0].Value == null ? " " : row.Cells[0].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[1].Value == null ? " " : row.Cells[1].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[2].Value == null ? " " : row.Cells[2].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[3].Value == null ? " " : row.Cells[3].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[4].Value == null ? " " : row.Cells[4].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[5].Value == null ? " " : row.Cells[5].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[6].Value == null ? " " : row.Cells[6].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[7].Value == null ? " " : row.Cells[7].Value.ToString()));
                contentTable.AddCell(GetNormalCell(row.Cells[8].Value == null ? " " : row.Cells[8].Value.ToString()));
                cCell = new PdfPTable(2);
                cCell.SetWidths(adaosWidths);
                cCell.AddCell(GetNormalCellAdaos(row.Cells[9].Value == null ? " " : row.Cells[9].Value.ToString()));
                cCell.AddCell(GetNormalCellAdaos(row.Cells[10].Value == null ? " " : row.Cells[10].Value.ToString()));
                contentTable.AddCell(cCell);
                rowCounter++;
            }


            pdfDoc.Add(contentTable);
            pdfDoc.Add(footer);
            pdfDoc.Close();

            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new PrinterSettings();
            if (DialogResult.OK == pd.ShowDialog(this))
            {
                Pdf.PrintPDFs(_fileName, pd.PrinterSettings.PrinterName);
            }


        }

        private PdfPTable GetHeaderInvoiceDetails()
        {
            PdfPTable headTableTop = new PdfPTable(5);
            //actual width of table in points
            headTableTop.TotalWidth = 400f;
            //fix the absolute width of the table
            headTableTop.LockedWidth = true;

            //relative col widths in proportions - 1/3 and 2/3
            float[] headerTopWidths = new float[] { 3f, 1f, 1f, 1f, 2f, };
            headTableTop.SetWidths(headerTopWidths);
            headTableTop.HorizontalAlignment = 1;
            //leave a gap before and after the table
            headTableTop.SpacingBefore = 10f;
            headTableTop.SpacingAfter = 10f;

            headTableTop.AddCell(GetHeaderCell("Nota de receptie nr.", 0));
            headTableTop.AddCell(GetHeaderCell(txtNotaReceptie.Text, 0));
            headTableTop.AddCell(GetHeaderCell("", 0));
            headTableTop.AddCell(GetHeaderCell("din", 0));
            headTableTop.AddCell(GetHeaderCell(dataNotaReceptie.Value.ToShortDateString(), 0));
            return headTableTop;
        }

        private PdfPTable GetInvoiceDetails()
        {
            PdfPTable headerTable = new PdfPTable(6);
            //actual width of table in points
            headerTable.TotalWidth = 800f;
            //fix the absolute width of the table
            headerTable.LockedWidth = true;

            //relative col widths in proportions - 1/3 and 2/3
            float[] headerWidths = new float[] { 1f, 1f, 1f, 1f, 1f, 1f };
            headerTable.SetWidths(headerWidths);
            headerTable.HorizontalAlignment = 0;
            //leave a gap before and after the table
            headerTable.SpacingBefore = 0f;
            headerTable.SpacingAfter = 10f;

            headerTable.AddCell(GetHeaderCell("DOCUMENT LIVRARE", 0));
            headerTable.AddCell(GetHeaderCell("NR", 0));
            headerTable.AddCell(GetHeaderCell("DATA", 0));
            headerTable.AddCell(GetHeaderCell("FURNIZORUL", 0));
            headerTable.AddCell(GetHeaderCell("COD FISCAL", 0));
            headerTable.AddCell(GetHeaderCell("ACHITAT CU", 0));

            headerTable.AddCell(GetHeaderCell(txtDocLivrare.Text, 0));
            headerTable.AddCell(GetHeaderCell(txtFactNum.Text, 0));
            headerTable.AddCell(GetHeaderCell(dataFactura.Value.ToShortDateString(), 0));
            headerTable.AddCell(GetHeaderCell(cmbFurnizor.Text, 0));
            headerTable.AddCell(GetHeaderCell(txtCodFiscal.Text, 0));
            headerTable.AddCell(GetHeaderCell(txtAchitatCu.Text, 0));
            return headerTable;
        }
        private PdfPTable GetCompanyName()
        {
            PdfPTable companyTable = new PdfPTable(1);
            //actual width of table in points
            companyTable.TotalWidth = 400f;
            //fix the absolute width of the table
            companyTable.LockedWidth = true;

            //relative col widths in proportions - 1/3 and 2/3
            float[] headerWidths = new float[] { 1f };
            companyTable.SetWidths(headerWidths);
            companyTable.HorizontalAlignment = 0;
            //leave a gap before and after the table
            companyTable.SpacingBefore = 0f;
            companyTable.SpacingAfter = 10f;

            companyTable.AddCell(GetHeaderCell("SC FANE COM SRL", 0, 0));
            return companyTable;
        }

        private PdfPTable GetFooter()
        {
            PdfPTable footerTable = new PdfPTable(1);
            //actual width of table in points
            footerTable.TotalWidth = 800f;
            //fix the absolute width of the table
            footerTable.LockedWidth = true;

            //relative col widths in proportions - 1/3 and 2/3
            float[] headerWidths = new float[] { 3f };
            footerTable.SetWidths(headerWidths);
            footerTable.HorizontalAlignment = 0;
            //leave a gap before and after the table
            footerTable.SpacingBefore = 15f;
            footerTable.SpacingAfter = 10f;

            footerTable.AddCell(GetHeaderCell("COMISIA DE RECEPTIE,		                                      " +
                                              "PATRON ADMINISTRATOR,	                                      " +
                                              "INTOCMIT,		                                         " +
                                              "GESTIONAR,", 0, 0));
            return footerTable;
        }
        private PdfPTable CreatePdfPTableHeader(out float[] adaosWidths)
        {
            PdfPTable contentTable = new PdfPTable(11);
            //actual width of table in points
            contentTable.TotalWidth = 800f;
            //fix the absolute width of the table
            contentTable.LockedWidth = true;

            //relative col widths in proportions - 1/3 and 2/3
            float[] widths = new float[] { 0.5f, 3f, 0.5f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1.5f };
            contentTable.SetWidths(widths);
            contentTable.HorizontalAlignment = 0;
            //leave a gap before and after the table
            //contentTable.SpacingBefore = 10f;
            //contentTable.SpacingAfter = 10f;

            contentTable.AddCell(GetHeaderCell("Nr. Crt"));
            contentTable.AddCell(GetHeaderCell("Denumirea"));
            contentTable.AddCell(GetHeaderCell("U/M"));
            contentTable.AddCell(GetHeaderCell("Cantitatea"));
            contentTable.AddCell(GetHeaderCell("Pret fara TVA"));
            contentTable.AddCell(GetHeaderCell("Valoare fara TVA"));
            contentTable.AddCell(GetHeaderCell("Valoare cu adaos"));
            contentTable.AddCell(GetHeaderCell("TVA deductibil"));
            contentTable.AddCell(GetHeaderCell("Pret de vanzare"));
            contentTable.AddCell(GetHeaderCell("Valoare la pret de vanzare"));
            PdfPTable adaos = new PdfPTable(2);
            adaosWidths = new float[] { 1f, 3f };
            adaos.SetWidths(adaosWidths);
            PdfPCell adaosHead = new PdfPCell(new Phrase("Adaos comercial", new Font(FontFamily.TIMES_ROMAN, 10.0f)));
            adaosHead.Colspan = 2;
            adaosHead.Border = 0;
            adaosHead.HorizontalAlignment = 1;
            adaos.AddCell(adaosHead);
            adaos.AddCell(GetHeaderCellAdaos("%"));
            adaos.AddCell(GetHeaderCellAdaos("Lei"));
            contentTable.AddCell(adaos);
            return contentTable;
        }

        private bool CheckDirectory(string invoicePath)
        {
            if (!Directory.Exists(invoicePath))
            {
                Directory.CreateDirectory(invoicePath);
            }
            return true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (myForm != null)
            {
                myForm.BringToFront();
            }
            else
            {
                myForm = new AdjustProducts();
                myForm.FormClosed += myForm_FormClosed;
                myForm.Show();
            }
        }

        void myForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            myForm = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            myForm = null;
        }
    }
}
