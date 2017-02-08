using System;
using System.Windows.Forms;
using Controller;
using Controller.Interfaces;

namespace SC.FANECOM.SRL
{
    public partial class AdjustProductsForm : Form, IAdjustProductForm
    {
        AdjustProductFormController _controller;
        public AdjustProductsForm()
        {
            InitializeComponent();
            _controller = new AdjustProductFormController(this);
            this.grdRemoveProducts.EditingControlShowing += GrdRemoveProducts_EditingControlShowing;
            this.btnAdauga.Click += BtnAdauga_Click;
            this.btnSterge.Click += BtnSterge_Click;
        }

        private void GrdRemoveProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (_controller != null)
                _controller.DataGridView1_EditingControlShowing(sender, e);
        }

        private void BtnSterge_Click(object sender, EventArgs e)
        {
            if (_controller != null)
                _controller.OnBtnStergeClick(sender,e);
        }

        private void BtnAdauga_Click(object sender, EventArgs e)
        {
            if (_controller != null)
                _controller.OnBtnAdaugaClick(sender.e);
        }        
        
        public int GetGridSelectedColumnIndex()
        {
            return grdRemoveProducts.CurrentCell.ColumnIndex;
        } 
        public void SetBtnAdaugaEnabled(bool enable)
        {
            btnAdauga.Enabled = enable;
        }
        public void SetBtnStergeEnabled(bool enable)
        {
            btnSterge.Enabled = enable;
        }
    }
}
