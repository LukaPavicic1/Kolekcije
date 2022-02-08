using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolekcija_List
{
    public partial class Form1 : Form
    {
        List<Ucenik> ucenici = new List<Ucenik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            try
            {
                Ucenik ucenik = new Ucenik(txtIme.Text, txtPrezime.Text, cmbRazred.Text);
                ucenici.Add(ucenik);
                txtIme.Clear();
                txtPrezime.Clear();
                MessageBox.Show("Uspješan unos!",
                "Obavijest", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            catch (Exception greska)
            {

                MessageBox.Show("Pogrešan unos!\r\n" + greska.Message,
                "Greška", MessageBoxButtons.OK,
                MessageBoxIcon.Error); 
            }
        }

        private void btnPregled_Click(object sender, EventArgs e)
        {
            rtbIspis.Text = "Ime" + "\t\tPrezime" + "\t\tRazred\n\r";
            foreach (Ucenik ucenik in ucenici)
            {
                rtbIspis.AppendText(ucenik.ToString()); 
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {
            foreach (Ucenik ucenik in ucenici)
            {
                if (ucenik.Razred == "2.")
                {
                    ucenik.Razred = "3.";
                }  
            }
            rtbIspis.AppendText("-----Obrada-----" + "\r\n");
            foreach (Ucenik ucenik in ucenici)
            {
                rtbIspis.AppendText(ucenik.ToString() + "\r\n");
            }

        }
    }
}
