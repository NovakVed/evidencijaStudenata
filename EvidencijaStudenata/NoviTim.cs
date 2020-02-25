using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidencijaStudenata
{
    public partial class NoviTim : Form
    {
        /// <summary>
        /// Konstruktor forme koji pozivam kada kreiram novi tim.
        /// </summary>
        public NoviTim()
        {
            InitializeComponent();
        }

        private Tim odabraniTim;

        public NoviTim(Tim tim)
        {
            InitializeComponent();
            odabraniTim = tim;
        }

        private void NoviTim_Load(object sender, EventArgs e)
        {
            if (odabraniTim != null)
            {
                txtId.Text = odabraniTim.Id.ToString();
                txtNapomena.Text = odabraniTim.Napomena;
                txtNazivProjekta.Text = odabraniTim.NazivProjekta;
                txtOpisProjekta.Text = odabraniTim.OpisProjekta;
                txtOznakaTima.Text = odabraniTim.OznakaTima;
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            if (odabraniTim != null)
            {
                using (var db = new EvidencijaStudenataEntities())
                {
                    db.Tim.Attach(odabraniTim);
                    odabraniTim.Napomena = txtNapomena.Text;
                    odabraniTim.NazivProjekta = txtNazivProjekta.Text;
                    odabraniTim.OpisProjekta = txtOpisProjekta.Text;
                    odabraniTim.OznakaTima = txtOznakaTima.Text;
                    db.SaveChanges();
                }
                Close();
            }
            else
            {
                using (var db = new EvidencijaStudenataEntities())
                {
                    Tim tim = new Tim()
                    {
                        Napomena = txtNapomena.Text,
                        NazivProjekta = txtNazivProjekta.Text,
                        OpisProjekta = txtOpisProjekta.Text,
                        OznakaTima = txtOznakaTima.Text
                    };

                    db.Tim.Add(tim);
                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}
