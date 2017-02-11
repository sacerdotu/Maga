namespace DMC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitateMasura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretFaraTva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValFaraTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValCuAdaos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVADeductibil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PretDeVanzare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValLaPretDeVanzare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdaosComProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdaosComLei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFirma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNotaRec = new System.Windows.Forms.Label();
            this.dataNotaReceptie = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDocLivrare = new System.Windows.Forms.TextBox();
            this.txtFactNum = new System.Windows.Forms.TextBox();
            this.txtNotaReceptie = new System.Windows.Forms.TextBox();
            this.dataFactura = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodFiscal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAchitatCu = new System.Windows.Forms.TextBox();
            this.cmbFurnizor = new System.Windows.Forms.ComboBox();
            this.furnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.faneComDatabaseDataSet = new DMC.DMCDatabaseDataSet();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.furnizoriTableAdapter = new DMC.FaneComDatabaseDataSetTableAdapters.FurnizoriTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faneComDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 17;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblFirma, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNotaRec, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataNotaReceptie, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDocLivrare, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFactNum, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtNotaReceptie, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataFactura, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCodFiscal, 10, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 12, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAchitatCu, 12, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbFurnizor, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdauga, 12, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 11, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 9, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 524);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Denumire,
            this.UnitateMasura,
            this.Cantitate,
            this.PretFaraTva,
            this.ValFaraTVA,
            this.ValCuAdaos,
            this.TVADeductibil,
            this.PretDeVanzare,
            this.ValLaPretDeVanzare,
            this.AdaosComProc,
            this.AdaosComLei});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 14);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(23, 106);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(762, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // Denumire
            // 
            this.Denumire.HeaderText = "Denumire";
            this.Denumire.Name = "Denumire";
            this.Denumire.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Denumire.Width = 190;
            // 
            // UnitateMasura
            // 
            this.UnitateMasura.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.UnitateMasura.HeaderText = "U/M";
            this.UnitateMasura.Items.AddRange(new object[] {
            "BUC",
            "MP",
            "MC"});
            this.UnitateMasura.Name = "UnitateMasura";
            this.UnitateMasura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitateMasura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.UnitateMasura.Width = 55;
            // 
            // Cantitate
            // 
            this.Cantitate.HeaderText = "Cantitate";
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Width = 50;
            // 
            // PretFaraTva
            // 
            this.PretFaraTva.HeaderText = "Pret fara TVA";
            this.PretFaraTva.Name = "PretFaraTva";
            this.PretFaraTva.Width = 50;
            // 
            // ValFaraTVA
            // 
            this.ValFaraTVA.HeaderText = "Valoare fara TVA";
            this.ValFaraTVA.Name = "ValFaraTVA";
            this.ValFaraTVA.Width = 50;
            // 
            // ValCuAdaos
            // 
            this.ValCuAdaos.HeaderText = "Valoare cu adaos";
            this.ValCuAdaos.Name = "ValCuAdaos";
            this.ValCuAdaos.Width = 50;
            // 
            // TVADeductibil
            // 
            this.TVADeductibil.HeaderText = "TVA Deductibil";
            this.TVADeductibil.Name = "TVADeductibil";
            this.TVADeductibil.Width = 60;
            // 
            // PretDeVanzare
            // 
            this.PretDeVanzare.HeaderText = "Pret de vanzare";
            this.PretDeVanzare.Name = "PretDeVanzare";
            this.PretDeVanzare.Width = 50;
            // 
            // ValLaPretDeVanzare
            // 
            this.ValLaPretDeVanzare.HeaderText = "Valoare la pret de vanzare";
            this.ValLaPretDeVanzare.Name = "ValLaPretDeVanzare";
            this.ValLaPretDeVanzare.Width = 50;
            // 
            // AdaosComProc
            // 
            this.AdaosComProc.HeaderText = "Adaos comercial %";
            this.AdaosComProc.Name = "AdaosComProc";
            this.AdaosComProc.Width = 60;
            // 
            // AdaosComLei
            // 
            this.AdaosComLei.HeaderText = "Adaos Comercial Lei";
            this.AdaosComLei.Name = "AdaosComLei";
            this.AdaosComLei.Width = 55;
            // 
            // lblFirma
            // 
            this.lblFirma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFirma.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblFirma, 4);
            this.lblFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirma.Location = new System.Drawing.Point(23, 23);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(167, 36);
            this.lblFirma.TabIndex = 5;
            this.lblFirma.Text = "SC DMC MAT CONSTRUCT SRL-D";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 3);
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DOCUMENT LIVRARE";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "din";
            // 
            // lblNotaRec
            // 
            this.lblNotaRec.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNotaRec.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNotaRec, 3);
            this.lblNotaRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaRec.Location = new System.Drawing.Point(154, 0);
            this.lblNotaRec.Name = "lblNotaRec";
            this.lblNotaRec.Size = new System.Drawing.Size(113, 23);
            this.lblNotaRec.TabIndex = 1;
            this.lblNotaRec.Text = "Nota de receptie nr.";
            // 
            // dataNotaReceptie
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dataNotaReceptie, 2);
            this.dataNotaReceptie.Location = new System.Drawing.Point(544, 3);
            this.dataNotaReceptie.Name = "dataNotaReceptie";
            this.dataNotaReceptie.Size = new System.Drawing.Size(116, 20);
            this.dataNotaReceptie.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "NR";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label4, 3);
            this.label4.Location = new System.Drawing.Point(257, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DATA";
            // 
            // txtDocLivrare
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDocLivrare, 3);
            this.txtDocLivrare.Location = new System.Drawing.Point(23, 79);
            this.txtDocLivrare.Name = "txtDocLivrare";
            this.txtDocLivrare.Size = new System.Drawing.Size(118, 20);
            this.txtDocLivrare.TabIndex = 12;
            this.txtDocLivrare.Text = "FACTURA";
            // 
            // txtFactNum
            // 
            this.txtFactNum.Location = new System.Drawing.Point(154, 79);
            this.txtFactNum.Name = "txtFactNum";
            this.txtFactNum.Size = new System.Drawing.Size(58, 20);
            this.txtFactNum.TabIndex = 13;
            // 
            // txtNotaReceptie
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtNotaReceptie, 3);
            this.txtNotaReceptie.Location = new System.Drawing.Point(274, 3);
            this.txtNotaReceptie.Name = "txtNotaReceptie";
            this.txtNotaReceptie.Size = new System.Drawing.Size(99, 20);
            this.txtNotaReceptie.TabIndex = 2;
            // 
            // dataFactura
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dataFactura, 3);
            this.dataFactura.CustomFormat = "MMMM dd yyyy";
            this.dataFactura.Location = new System.Drawing.Point(218, 79);
            this.dataFactura.Name = "dataFactura";
            this.dataFactura.Size = new System.Drawing.Size(115, 20);
            this.dataFactura.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "FURNIZORUL";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label6, 2);
            this.label6.Location = new System.Drawing.Point(509, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "COD FISCAL";
            // 
            // txtCodFiscal
            // 
            this.txtCodFiscal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtCodFiscal, 2);
            this.txtCodFiscal.Location = new System.Drawing.Point(509, 79);
            this.txtCodFiscal.Name = "txtCodFiscal";
            this.txtCodFiscal.Size = new System.Drawing.Size(146, 20);
            this.txtCodFiscal.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label7, 2);
            this.label7.Location = new System.Drawing.Point(661, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ACHITAT CU";
            // 
            // txtAchitatCu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtAchitatCu, 2);
            this.txtAchitatCu.Location = new System.Drawing.Point(661, 79);
            this.txtAchitatCu.Name = "txtAchitatCu";
            this.txtAchitatCu.Size = new System.Drawing.Size(116, 20);
            this.txtAchitatCu.TabIndex = 17;
            this.txtAchitatCu.Text = "NUMERAR";
            // 
            // cmbFurnizor
            // 
            this.cmbFurnizor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFurnizor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbFurnizor, 2);
            this.cmbFurnizor.DataSource = this.furnizoriBindingSource;
            this.cmbFurnizor.DisplayMember = "Nume";
            this.cmbFurnizor.FormattingEnabled = true;
            this.cmbFurnizor.Location = new System.Drawing.Point(339, 79);
            this.cmbFurnizor.Name = "cmbFurnizor";
            this.cmbFurnizor.Size = new System.Drawing.Size(164, 21);
            this.cmbFurnizor.TabIndex = 18;
            this.cmbFurnizor.ValueMember = "CodFiscal";
            this.cmbFurnizor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // furnizoriBindingSource
            // 
            this.furnizoriBindingSource.DataMember = "Furnizori";
            this.furnizoriBindingSource.DataSource = this.faneComDatabaseDataSet;
            // 
            // faneComDatabaseDataSet
            // 
            this.faneComDatabaseDataSet.DataSetName = "FaneComDatabaseDataSet";
            this.faneComDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdauga
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAdauga, 2);
            this.btnAdauga.Location = new System.Drawing.Point(661, 484);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(116, 37);
            this.btnAdauga.TabIndex = 19;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(544, 484);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Tipareste";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(422, 484);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Ajusteaza";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // furnizoriTableAdapter
            // 
            this.furnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "SC.FANECOM.SRL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.furnizoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faneComDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNotaRec;
        private System.Windows.Forms.TextBox txtNotaReceptie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataNotaReceptie;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocLivrare;
        private System.Windows.Forms.TextBox txtFactNum;
        private System.Windows.Forms.DateTimePicker dataFactura;
        private System.Windows.Forms.TextBox txtCodFiscal;
        private System.Windows.Forms.TextBox txtAchitatCu;
        private System.Windows.Forms.ComboBox cmbFurnizor;
        private DMCDatabaseDataSet faneComDatabaseDataSet;
        private System.Windows.Forms.BindingSource furnizoriBindingSource;
        private FaneComDatabaseDataSetTableAdapters.FurnizoriTableAdapter furnizoriTableAdapter;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denumire;
        private System.Windows.Forms.DataGridViewComboBoxColumn UnitateMasura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretFaraTva;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValFaraTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValCuAdaos;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVADeductibil;
        private System.Windows.Forms.DataGridViewTextBoxColumn PretDeVanzare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValLaPretDeVanzare;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdaosComProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdaosComLei;
    }
}

