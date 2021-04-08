using ArtGallery.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery.View
{
    public partial class VSignup : Form
    {
        public VSignup()
        {
            InitializeComponent();
        }

        public TextBox GetTextUsername()
        {
            return this.textBoxUsername;
        }

        public TextBox GetTextPassword()
        {
            return this.textBoxPassword;
        }

        public Button GetButtonSignup()
        {
            return this.button1;
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CWelcome cWelcome = new CWelcome();
            cWelcome.GetVWelcome().Show();
        }
    }
}
