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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            PrikaziTim();
            PrikaziStudente(dgvTimovi.CurrentRow.DataBoundItem as Tim);
        }

        private void PrikaziTim()
        {
            List<Tim> ListaTimova;
            using (var db = new EvidencijaStudenataEntities())
            {
                var tims = (from t in db.Tim
                               //where t.OznakaTima.Contains("a")
                               select t).ToList<Tim>();
                ListaTimova = tims;
                //ListaTimova = db.Tim.ToList();
            }
            dgvTimovi.DataSource = ListaTimova;
            dgvTimovi.Columns[5].Visible = false;
        }

        private void PrikaziStudente(Tim tim)
        {
            //List<Student> ListaStudenata;
            using (var db = new EvidencijaStudenataEntities())
            {
                var students = (from s in db.Student
                                where s.TimId == tim.Id
                                select s).ToList<Student>();
                dgvStudenti.DataSource = students;
            }
            //dgvStudenti.DataSource = ListaStudenata;
            dgvStudenti.Columns[7].Visible = false;
            dgvStudenti.Columns[8].Visible = false;
        }

        private void dgvTimovi_SelectionChanged(object sender, EventArgs e)
        {
            Tim odabraniTim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
            if (odabraniTim != null)
            {
                PrikaziStudente(odabraniTim);
            }
        }

        private void btnNoviTim_Click(object sender, EventArgs e)
        {
            NoviTim noviTim = new NoviTim();
            noviTim.ShowDialog();
            PrikaziTim();
        }

        private void btnIzmijeniTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.CurrentRow != null)
            {
                Tim odabraniTim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
                if (odabraniTim != null)
                {
                    NoviTim noviTim = new NoviTim(odabraniTim);
                    noviTim.ShowDialog();
                    PrikaziTim();
                }
            }
        }

        private void btnObrisiTim_Click(object sender, EventArgs e)
        {
            if (dgvTimovi.CurrentRow != null)
            {
                Tim odabraniTim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
                if (odabraniTim != null)
                {
                    using (var db = new EvidencijaStudenataEntities())
                    {
                        db.Tim.Attach(odabraniTim);
                        //var timZaBrisanje = (from t in db.Tim
                          //                   where t.Id == odabraniTim.Id
                            //                 select t).First<Tim>();
                        if (odabraniTim.Student.Count == 0)
                        {
                            //db.Tim.Remove(timZaBrisanje);
                            db.Tim.Remove(odabraniTim);
                            db.SaveChanges();
                        }
                        PrikaziTim();
                    }
                }
            }
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudenti.CurrentRow != null)
            {
                Tim odabraniTim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
                if (odabraniTim != null)
                {
                    NoviStudent noviStudent = new NoviStudent(odabraniTim);
                    noviStudent.ShowDialog();
                    PrikaziStudente(odabraniTim);
                }
            }
        }

        private void btnIzmijeniStudenta_Click(object sender, EventArgs e)
        {
            if (dgvStudenti.CurrentRow != null)
            {
                Tim odabraniTim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
                if (odabraniTim != null)
                {
                    Student odabraniStudent = dgvStudenti.CurrentRow.DataBoundItem as Student;
                    NoviStudent noviStudent = new NoviStudent(odabraniStudent);
                    noviStudent.ShowDialog();
                    PrikaziStudente(odabraniTim);
                }
            }
        }

        private void btnObrisiStudenta_Click(object sender, EventArgs e)
        {
            if (dgvStudenti.CurrentRow != null)
            {
                Tim odabraniTim = dgvTimovi.CurrentRow.DataBoundItem as Tim;
                if (odabraniTim != null)
                {
                    Student odabraniStudent = dgvStudenti.CurrentRow.DataBoundItem as Student;
                    if (odabraniStudent != null)
                    {
                        using (var db = new EvidencijaStudenataEntities())
                        {
                            db.Student.Attach(odabraniStudent);
                            db.Student.Remove(odabraniStudent);
                            db.SaveChanges();
                        }
                        PrikaziStudente(odabraniTim);
                    }
                }
            }
        }
    }
}
