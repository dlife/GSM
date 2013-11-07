using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSM
{
    public partial class Main : Form
    {
        private Enquete EN = new Enquete();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnHoeveel_Click(object sender, EventArgs e)
        {
            int getal;
            string invoer = txtHoeveel.Text;
            if (!Int32.TryParse(invoer,out getal)){reset();return;}

            EN.Count = getal;
            Switch();

            this.AcceptButton = btnVraag;
        }

        private void btnEinde_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset()
        {
            Switch();
            lblWeergave.Text = "";
            txtHoeveel.Text = "";
            txtVraag.Text = "";
            this.AcceptButton = btnHoeveel;
            EN.Reset();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnVraag_Click(object sender, EventArgs e)
        {
            string invoer = txtVraag.Text.ToUpper();
            
            switch (invoer)
            {
                case "J": EN.Ja += 1; 
                    break;
                case "N": EN.Nee += 1;
                    break;
                case "O": EN.Onverschillig += 1;
                    break;
                default:
                    reset();
                    return;
            } 
                       
            lblWeergave.Text = EN.GeefWeer(); 
            txtVraag.Text = "";
            txtVraag.Focus();

            if (EN.IsBereikt())
            {
                btnVraag.Enabled = !btnVraag.Enabled;
                txtVraag.Enabled = !txtVraag.Enabled;
                return;
            }
        }

        private void Switch()
        {            
            txtVraag.Enabled = !txtVraag.Enabled;
            btnVraag.Enabled = !btnVraag.Enabled;
            txtHoeveel.Enabled = !txtHoeveel.Enabled;
            btnHoeveel.Enabled = !btnHoeveel.Enabled;
        }
    }
}
