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
    public partial class VWelcome : Form
    {
        public VWelcome()
        {
            InitializeComponent();
        }

        public TextBox GetTextBoxUsername()
        {
            return this.textBoxUsername;
        }

        public TextBox GetTextBoxPassword()
        {
            return this.textBoxPassword;
        }

        public Button GetButtonLogin()
        {
            return this.buttonLogin;
        }

        private void linkLabelContinueVizitator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show another form.
            this.Hide();
            CVizitator cVizitator = new CVizitator();
            cVizitator.GetVVizitator().Show();
            linkLabelContinueVizitator.LinkVisited = true;
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Hide();
            VSignup signup = new VSignup();
            signup.ShowDialog();

        }
    }
}
