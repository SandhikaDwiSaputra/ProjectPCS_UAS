﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMasterMerk;

namespace ProjectPCSuas
{
    public partial class BrowseMerk : Form
    {
        private MasterMerk merk;
        private List<MasterMerk> merkList;

        public BrowseMerk()
        {
            InitializeComponent();
        }

        private void m_merkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_merkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.project_UASDataSet);

        }

        private void BrowseMerk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_UASDataSet.m_merk' table. You can move, or remove it, as needed.
            if (iDComboBox.SelectedIndex != -1)
            {
                this.GetMerkData();
            }
            this.m_merkTableAdapter.Fill(this.project_UASDataSet.m_merk);

        }

        private void GetMerkData()
        {
            int merkID=1;
            if (iDComboBox.SelectedIndex != -1)
            {
                merkID = (int)iDComboBox.SelectedValue;
            }
            try
            {
                merkList = ClassMerk.getByMerkID(merkID);
                if (merkList.Count > 0)
                {
                    MasterMerk masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                    }
                    m_merkDataGridView.DataSource = merkList;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void iDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GetMerkData();
        }
    }
}