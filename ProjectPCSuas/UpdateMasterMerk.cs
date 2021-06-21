using System;
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
    public partial class UpdateMasterMerk : Form
    {
        public UpdateMasterMerk()
        {
            InitializeComponent();
        }

        public int id2;
        public string desc;
        private void UpdateMasterMerk_Load(object sender, EventArgs e)
        {
            iDTextBox.Text = id2 + "";
            mERK_DESCTextBox.Text = desc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(iDTextBox.Text);
            try
            {
                if (!(ClassMerk.updateMerk(ID, mERK_DESCTextBox.Text.ToString())))
                {
                    MessageBox.Show("Another user has updated or deleted " +
                        "that vendor.", "Database Error");
                }
                else
                {
                    MessageBox.Show("Berhasil");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
