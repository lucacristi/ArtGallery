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

        public LinkLabel GetLinkLabelContinuaCaVizitator()
        {
            return this.linkLabelContinueVizitator;
        }

        public LinkLabel GetLinkLabelSignUp()
        {
            return this.linkLabelSignUp;
        }
    }
}
