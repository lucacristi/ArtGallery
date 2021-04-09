﻿using ArtGallery.Model;
using ArtGallery.Model.Persistenta;
using ArtGallery.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtGallery.Controller
{
    class CAngajat
    {
        private readonly Dictionary<string, int> indecsiGrid;

        private string username;
        private VAngajat vAngajat;
        private PersistentaOperaArta persistentaOperaArta;

        public CAngajat()
        {
            indecsiGrid = initializareIndecsi();
            vAngajat = new VAngajat();
            persistentaOperaArta = new PersistentaOperaArta();
            gestionareEvenimente();
        }

        public CAngajat(string username)
        {
            indecsiGrid = initializareIndecsi();
            this.username = username;
            vAngajat = new VAngajat();
            persistentaOperaArta = new PersistentaOperaArta();
            gestionareEvenimente();
        }

        public VAngajat GetVAngajat()
        {
            return vAngajat;
        }

        private void gestionareEvenimente()
        {
            setUsername();

            vAngajat.GetButtonLogout().Click += new EventHandler(logout);
            vAngajat.GetButtonRefresh().Click += new EventHandler(refresh);
            vAngajat.GetButtonCautare().Click += new EventHandler(cautare);

            vAngajat.GetComboBoxTipOpera().SelectedIndexChanged += new EventHandler(selectieTipOpera);

            vAngajat.GetButtonAdauga().Click += new EventHandler(adaugare);
            vAngajat.GetButtonEditeaza().Click += new EventHandler(editare);
            vAngajat.GetButtonSterge().Click += new EventHandler(stergere);
            vAngajat.GetDataGridViewOpere().SelectionChanged += new EventHandler(selectieInGrid);
        }

        private void setUsername()
        {
            vAngajat.GetUsernameLabel().Text = "username: " + username;
        }

        private void logout(object sender, EventArgs e)
        {
            MessageBox.Show("Log out reusit!");
            vAngajat.Hide();
            CWelcome cWelcome = new CWelcome();
            cWelcome.GetVWelcome().Show();
        }

        private void refresh(object sender, EventArgs e)
        {
            List<OperaArta> lista = persistentaOperaArta.ListareOpere();
            vAngajat.GetDataGridViewOpere().Rows.Clear();
            if (lista != null)
            {
                foreach (OperaArta opera in lista)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(vAngajat.GetDataGridViewOpere());
                    rand.Cells[indecsiGrid["TitluOpera"]].Value = opera.GetTitlu();
                    rand.Cells[indecsiGrid["NumeArtist"]].Value = opera.GetNumeArtist();
                    rand.Cells[indecsiGrid["AnRealizare"]].Value = opera.GetAnRealizare();
                    if(opera is Tablou)
                    {
                        rand.Cells[indecsiGrid["TipOpera"]].Value = "tablou";
                        rand.Cells[indecsiGrid["GenPictura"]].Value = ((Tablou)opera).GetGenPictura();
                        rand.Cells[indecsiGrid["TehnicaTablou"]].Value = ((Tablou)opera).GetTehnica();
                    }
                    else if(opera is Sculptura)
                    {
                        rand.Cells[indecsiGrid["TipOpera"]].Value = "sculptura";
                        rand.Cells[indecsiGrid["TipSculptura"]].Value = ((Sculptura)opera).GetTip();
                    }
                    else
                    {
                        rand.Cells[indecsiGrid["TipOpera"]].Value = "operaDeArta";
                    }
                    vAngajat.GetDataGridViewOpere().Rows.Add(rand);
                }
            }
        }

        private void cautare(object sender, EventArgs e)
        {
            int index = vAngajat.GetComboBoxCriteriu().SelectedIndex;
            string informatie = vAngajat.GetTextInformatie().Text;

            if (informatie.Length > 0)
            {
                if (index == 0)
                    cautareDupaNumeArtist(informatie);
                else
                    cautareDupaTipOpera(informatie);
            }
            else
            {
                MessageBox.Show("Nu s-a introdus informatia cautata!");
            }
        }


        private void selectieTipOpera(object sender, EventArgs e)
        {
            int index = vAngajat.GetComboBoxTipOpera().SelectedIndex;
            if (index == 0)
            {
                vAngajat.GetLabelGenTip().Visible = false;
                vAngajat.GetTextGenTip().Visible = false;
                vAngajat.GetLabelTehnica().Visible = false;
                vAngajat.GetTextTehnica().Visible = false;
            }
            if (index == 1)
            {
                vAngajat.GetLabelGenTip().Text = "Gen Pictura";
                vAngajat.GetLabelGenTip().Visible = true;
                vAngajat.GetTextGenTip().Visible = true;
                vAngajat.GetLabelTehnica().Visible = true;
                vAngajat.GetTextTehnica().Visible = true;
            }
            if (index == 2)
            {
                vAngajat.GetLabelGenTip().Text = "Tip Sculptura";
                vAngajat.GetLabelGenTip().Visible = true;
                vAngajat.GetTextGenTip().Visible = true;
                vAngajat.GetLabelTehnica().Visible = false;
                vAngajat.GetTextTehnica().Visible = false;
            }
        }
        private void adaugare(object sender, EventArgs e)
        {
            int indexTipOpera = vAngajat.GetComboBoxTipOpera().SelectedIndex;

            string titlu = vAngajat.GetTextTitlu().Text;
            string numeArtist = vAngajat.GetTextNumeArtist().Text;
            int anRealizare = Int32.MinValue;

            try
            {
                anRealizare = Convert.ToInt32(vAngajat.GetTextAnRealizare().Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nu s-a introdus un an valid!");
                return;
            }


            if (titlu.Length > 0 && numeArtist.Length > 0 && anRealizare != Int32.MinValue)
            {
                if (persistentaOperaArta.CautaOpera(titlu) != null)
                {
                    MessageBox.Show("Exista deja o opera cu titlul \"" + titlu + "\"");
                }
                else
                {
                    if (indexTipOpera == 0)
                    {
                        OperaArta operaArta = new OperaArta(titlu, numeArtist, anRealizare);
                        if (persistentaOperaArta.AdaugareOperaArta(operaArta))
                            MessageBox.Show("Adaugare incheiata cu succes!");
                        else
                        {
                            MessageBox.Show("Nu s-a realizat adaugare in fisier!");
                        }
                    }
                    if (indexTipOpera == 1)
                    {
                        string genPictura = vAngajat.GetTextGenTip().Text;
                        string tehnica = vAngajat.GetTextTehnica().Text;
                        if (genPictura.Length > 0 && tehnica.Length > 0)
                        {
                            OperaArta operaArta = new Tablou(titlu, numeArtist, anRealizare, genPictura, tehnica);
                            if (persistentaOperaArta.AdaugareOperaArta(operaArta))
                                MessageBox.Show("Adaugare incheiata cu succes!");
                            else
                            {
                                MessageBox.Show("Nu s-a realizat adaugare in fisier!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu s-a introdus genul picturii sau tehnica!");
                        }
                    }
                    if (indexTipOpera == 2)
                    {
                        string tipSculptura = vAngajat.GetTextGenTip().Text;
                        if (tipSculptura.Length > 0)
                        {
                            OperaArta operaArta = new Sculptura(titlu, numeArtist, anRealizare, tipSculptura);
                            if (persistentaOperaArta.AdaugareOperaArta(operaArta))
                                MessageBox.Show("Adaugare incheiata cu succes!");
                            else
                            {
                                MessageBox.Show("Nu s-a realizat adaugare in fisier!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu s-a introdus tipul sculpturii!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nu s-a introdus titlu sau numele artistului!");
            }

        }
        private void editare(object sender, EventArgs e)
        {
            if (vAngajat.GetDataGridViewOpere().SelectedRows.Count == 0)
            {
                MessageBox.Show("Nu exista nicio opera selectata pentru a fi actualizata");
            }
            else
            {
                string titluOperaSelectat = (string)vAngajat.GetDataGridViewOpere().SelectedRows[0].Cells[indecsiGrid["TitluOpera"]].Value;

                int indexTipOpera = vAngajat.GetComboBoxTipOpera().SelectedIndex;
                string titlu = vAngajat.GetTextTitlu().Text;
                string numeArtist = vAngajat.GetTextNumeArtist().Text;
                int anRealizare = Int32.MinValue;

                try
                {
                    anRealizare = Convert.ToInt32(vAngajat.GetTextAnRealizare().Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nu s-a introdus un an valid!");
                    return;
                }


                if (titlu.Length > 0 && numeArtist.Length > 0 && anRealizare != Int32.MinValue)
                {
                    if (persistentaOperaArta.CautaOpera(titluOperaSelectat) == null)
                    {
                        MessageBox.Show("Nu exista o opera cu titlul \"" + titlu + "\"");
                    }
                    else
                    {
                        if (indexTipOpera == 0)
                        {
                            OperaArta operaArta = new OperaArta(titlu, numeArtist, anRealizare);
                            if (persistentaOperaArta.ActualizareOperaArta(titluOperaSelectat, operaArta))
                                MessageBox.Show("Actualizare incheiata cu succes!");
                            else
                            {
                                MessageBox.Show("Nu s-a realizat actualizarea fisierului!");
                            }
                        }
                        if (indexTipOpera == 1)
                        {
                            string genPictura = vAngajat.GetTextGenTip().Text;
                            string tehnica = vAngajat.GetTextTehnica().Text;
                            if (genPictura.Length > 0 && tehnica.Length > 0)
                            {
                                OperaArta operaArta = new Tablou(titlu, numeArtist, anRealizare, genPictura, tehnica);
                                if (persistentaOperaArta.ActualizareOperaArta(titluOperaSelectat, operaArta))
                                    MessageBox.Show("Actualizare incheiata cu succes!");
                                else
                                {
                                    MessageBox.Show("Nu s-a realizat actualizarea fisierului!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a introdus genul picturii sau tehnica!");
                            }
                        }
                        if (indexTipOpera == 2)
                        {
                            string tipSculptura = vAngajat.GetTextGenTip().Text;
                            if (tipSculptura.Length > 0)
                            {
                                OperaArta operaArta = new Sculptura(titlu, numeArtist, anRealizare, tipSculptura);
                                if (persistentaOperaArta.ActualizareOperaArta(titluOperaSelectat, operaArta))
                                    MessageBox.Show("Actualizare incheiata cu succes!");
                                else
                                {
                                    MessageBox.Show("Nu s-a realizat actualizarea fisierului!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu s-a introdus tipul sculpturii!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nu s-a introdus titlu sau numele artistului!");
                }
            }
        }
        private void stergere(object sender, EventArgs e)
        {
        }
        private void selectieInGrid(object sender, EventArgs e)
        {
            if (this.vAngajat.GetDataGridViewOpere().SelectedRows.Count == 0)
            {
                vAngajat.GetTextTitlu().Text = "";
                vAngajat.GetTextNumeArtist().Text = "";
                vAngajat.GetTextAnRealizare().Text = "";
            }
            else
            {
                string titlu = (string)vAngajat.GetDataGridViewOpere().SelectedRows[0].Cells[indecsiGrid["TitluOpera"]].Value;
                string numeArtist = (string)vAngajat.GetDataGridViewOpere().SelectedRows[0].Cells[indecsiGrid["NumeArtist"]].Value;
                int anRealizare = (int)vAngajat.GetDataGridViewOpere().SelectedRows[0].Cells[indecsiGrid["AnRealizare"]].Value;

                vAngajat.GetTextTitlu().Text = titlu;
                vAngajat.GetTextNumeArtist().Text = numeArtist;
                vAngajat.GetTextAnRealizare().Text = anRealizare.ToString();
            }
        }

        private void cautareDupaNumeArtist(string informatie)
        {
            List<OperaArta> opere = persistentaOperaArta.FiltrareOpereArtist(informatie);
            this.vAngajat.GetDataGridViewOpere().Rows.Clear();
            if (opere != null)
            {
                foreach (OperaArta opera in opere)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(vAngajat.GetDataGridViewOpere());
                    rand.Cells[indecsiGrid["TitluOpera"]].Value = opera.GetTitlu();
                    rand.Cells[indecsiGrid["NumeArtist"]].Value = opera.GetNumeArtist();
                    rand.Cells[indecsiGrid["AnRealizare"]].Value = opera.GetAnRealizare();
                    vAngajat.GetDataGridViewOpere().Rows.Add(rand);
                }
            }
            else
            {
                MessageBox.Show("Nu s-a gasit nicio opera!");
            }
        }
        private void cautareDupaTipOpera(string informatie)
        {
            List<OperaArta> opere = persistentaOperaArta.FiltrareOpereTip(informatie);
            this.vAngajat.GetDataGridViewOpere().Rows.Clear();
            if (opere != null)
            {
                foreach (OperaArta opera in opere)
                {
                    DataGridViewRow rand = new DataGridViewRow();
                    rand.CreateCells(vAngajat.GetDataGridViewOpere());
                    rand.Cells[indecsiGrid["TitluOpera"]].Value = opera.GetTitlu();
                    rand.Cells[indecsiGrid["NumeArtist"]].Value = opera.GetNumeArtist();
                    rand.Cells[indecsiGrid["AnRealizare"]].Value = opera.GetAnRealizare();
                    vAngajat.GetDataGridViewOpere().Rows.Add(rand);
                }
            }
            else
            {
                MessageBox.Show("Nu s-a gasit nicio opera!");
            }
        }

        private Dictionary<string, int> initializareIndecsi()
        {
            return new Dictionary<string, int>
            {
                ["TipOpera"] = 0,
                ["TitluOpera"] = 1,
                ["NumeArtist"] = 2,
                ["AnRealizare"] = 3,
                ["GenPictura"] = 4,
                ["TehnicaTablou"] = 5,
                ["TipSculptura"] = 6
            };
        }
    }
}
