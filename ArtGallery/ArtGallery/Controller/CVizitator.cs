using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtGallery.View;
using ArtGallery.Model;
using ArtGallery.Model.Persistenta;
using System.Windows.Forms;

namespace ArtGallery.Controller
{
    class CVizitator
    {
        private VVizitator vVizitator;
        private VWelcome vWelcome;
        private PersistentaOperaArta pOpera;

        public CVizitator()
        {
            this.vVizitator = new VVizitator();
            this.vWelcome = new VWelcome();
            this.pOpera = new PersistentaOperaArta();
            this.GestionareEvenimente();
        }

        public VVizitator GetVVizitator()
        {
            return vVizitator;
        }

        public VWelcome GetVWelcome()
        {
            return vWelcome;
        }
        private void GestionareEvenimente()
        {
            this.vVizitator.GetButtonRefresh().Click += new EventHandler(refresh);
            this.vVizitator.GetButtonCautare().Click += new EventHandler(cautare);
            //this.vVizitator.GetDataGridViewOpere().Click += new EventHandler(selectie);

        }

       
        private void refresh(object sender, EventArgs e)
        {
            List<OperaArta> lista = this.pOpera.ListareOpere();
            this.vVizitator.GetDataGridViewOpere().Rows.Clear();
            if (lista != null)
            {
                foreach (OperaArta opera in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.vVizitator.GetDataGridViewOpere());
                    rand.Cells[0].Value = opera.GetTitlu();
                    rand.Cells[1].Value = opera.GetNumeArtist();
                    rand.Cells[2].Value = opera.GetAnRealizare();
                    this.vVizitator.GetDataGridViewOpere().Rows.Add(rand);
                }
            }
        }

        private void cautare(object sender, EventArgs e)
        {
            int index = this.vVizitator.GetComboBoxCriteriu().SelectedIndex;
            if (index >= 0)
            {
                string informatie = this.vVizitator.GetTextInformatie().Text;
                if (informatie.Length > 0)
                {
                    if (index == 0)
                        this.cautareDupaNumeArtist(informatie);
                    else
                        this.cautareDupaTipOpera(informatie);
                    
                }
                else
                    MessageBox.Show("Nu s-a introdus informatia cautata!");
            }
            else
            {
                MessageBox.Show("Nu s-a selectat niciun un criteriu de filtrare!");
            }
        }

        private void cautareDupaNumeArtist(string informatie)
        {
            List<OperaArta> opere = this.pOpera.FiltrareOpereArtist(informatie);
            this.vVizitator.GetDataGridViewOpere().Rows.Clear();
            if (opere != null)
            {
                foreach (OperaArta opera in opere)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.vVizitator.GetDataGridViewOpere());
                    rand.Cells[0].Value = opera.GetTitlu();
                    rand.Cells[1].Value = opera.GetNumeArtist();
                    rand.Cells[2].Value = opera.GetAnRealizare();
                    this.vVizitator.GetDataGridViewOpere().Rows.Add(rand);
                }                
            }
            else
            {
                MessageBox.Show("Nu s-a gasit nicio opera!");
            }
        }
        private void cautareDupaTipOpera(string informatie)
        {
            List<OperaArta> opere = this.pOpera.FiltrareOpereTip(informatie);
            this.vVizitator.GetDataGridViewOpere().Rows.Clear();
            if (opere != null)
            {
                foreach (OperaArta opera in opere)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(this.vVizitator.GetDataGridViewOpere());
                    rand.Cells[0].Value = opera.GetTitlu();
                    rand.Cells[1].Value = opera.GetNumeArtist();
                    rand.Cells[2].Value = opera.GetAnRealizare();
                    this.vVizitator.GetDataGridViewOpere().Rows.Add(rand);
                }               
            }
            else
            {
                MessageBox.Show("Nu s-a gasit nicio opera!");
            }
        }
    }
}
