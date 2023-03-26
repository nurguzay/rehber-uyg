using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace YigitAku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int sonuc = PersonelDAL.PersonelKontrol(txtAra.Text);
            List<string> personeller = new List<string>((IEnumerable<string>)PersonelDAL.PersonelList());

            if (sonuc == 0)
            {
                dataGridView1.DataSource = personeller;
            }
            else
            {
                MessageBox.Show("BU İSİMDE BİR PERSONEL YOK");
            }
        }

        private void btnAra_Click_1(object sender, EventArgs e)
        {

        }
    }
}
