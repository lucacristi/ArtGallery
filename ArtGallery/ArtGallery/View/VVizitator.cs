using ArtGallery.Controller;
using ArtGallery.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery
{
    public partial class VVizitator : Form
    {
        public VVizitator()
        {
            InitializeComponent();
            this.dataGridView1.AllowUserToAddRows = false;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                this.dataGridView1.Columns[i].ReadOnly = true;
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

        public Button GetButtonBack()
        {
            return this.buttonBack;
        }

        public Button GetButtonAutentificare()
        {
            return this.buttonAutentificare;
        }
    }
}
