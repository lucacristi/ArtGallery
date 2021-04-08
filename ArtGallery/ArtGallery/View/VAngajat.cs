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
    public partial class VAngajat : Form
    {
        public VAngajat()
        {
            InitializeComponent();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].ReadOnly = true;
        }

        public Label GetUsernameLabel()
        {
            return this.labelDisplayUsername;
        }

        public ComboBox GetComboBoxCriteriu()
        {
            return this.comboBoxCriteriu;
        }

        public TextBox GetTextInformatie()
        {
            return this.textBoxInformatieCautata;
        }

        public Button GetButtonCautare()
        {
            return this.buttonCauta;
        }

        public Button GetButtonRefresh()
        {
            return this.buttonRefresh;
        }

        public DataGridView GetDataGridViewOpere()
        {
            return this.dataGridView1;
        }

        public Button GetButtonAdauga()
        {
            return this.buttonAdauga;
        }

        public Button GetButtonEditeaza()
        {
            return this.buttonEdit;
        }

        public Button GetButtonSterge()
        {
            return this.buttonSterge;
        }

        public ComboBox GetComboBoxTipOpera()
        {
            return this.comboBoxTipOpera;
        }

        public TextBox GetTextTitlu()
        {
            return this.textBoxTitlu;
        }

        public TextBox GetTextNumeArtist()
        {
            return this.textBoxNumeArtist;
        }

        public TextBox GetTextAnRealizare()
        {
            return this.textBoxAnRealizare;
        }

        public Label GetLabelGenTip()
        {
            return this.labelGen_Tip;
        }

        public TextBox GetTextGenTip()
        {
            return this.textBoxGen_Tip;
        }

        public Label GetLabelTehnica()
        {
            return this.labelTehnica;
        }

        public TextBox GetTextTehnica()
        {
            return this.textBoxTehnica;
        }

        public Button GetButtonLogout()
        {
            return this.buttonLogout;
        }
    }
}
