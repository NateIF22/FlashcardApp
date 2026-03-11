using FInalFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinalFormApp
{
    public partial class PracticeForm : Form
    {
        public PracticeForm(Deck DeckToPractice)
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // TODO: Figure out how to re enable the practice button on the deck control when the practice form is closed
            this.Close();
        }
    }
}
