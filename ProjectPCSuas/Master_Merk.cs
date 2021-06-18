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
    public partial class Master_Merk : Form
    {
        public Master_Merk()
        {
            InitializeComponent();
        }

        private void MasterMerk_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<MasterMerk> merkList;
            try
            {
                merkList = ClassMerk.get();
                if (merkList.Count > 0)
                {
                    MasterMerk masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                        listView1.Items.Add(masterMerk.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_desc);
                    }
                }
                else
                {
                    //MessageBox.Show("All invoices are paid in full.",
                    //    "No Balance Due");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<MasterMerk> merkList;
            String desc = TBcari.Text;
            try
            {
                merkList = ClassMerk.getByMerkDesc(desc);
                if (merkList.Count > 0)
                {
                    MasterMerk masterMerk;
                    for (int i = 0; i < merkList.Count; i++)
                    {
                        masterMerk = merkList[i];
                        listView1.Items.Add(masterMerk.Id.ToString());
                        listView1.Items[i].SubItems.Add(masterMerk.Merk_desc);
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                this.Close();
            }
        }
    }
}
