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
    public partial class NoviStudent : Form
    {
        private Tim odabraniTim;
        private Student odabraniStudent;
        /// <summary>
        /// Konstruktor forme koji se poziva kada kreiramo novog studenta.
        /// </summary>
        public NoviStudent(Tim tim)
        {
            InitializeComponent();
            odabraniTim = tim;
        }

        public NoviStudent(Student student)
        {
            InitializeComponent();
            odabraniStudent = student;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb odustani.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviStudent_Load(object sender, EventArgs e)
        {
            txtIme.Focus();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            if (odabraniStudent != null)
            {
                using (var db = new EvidencijaStudenataEntities())
                {
                    db.Student.Attach(odabraniStudent);
                    odabraniStudent.Email = txtEmail.Text;
                    odabraniStudent.Ime = txtIme.Text;
                    odabraniStudent.Prezime = txtPrezime.Text;
                    odabraniStudent.Status = txtStatus.Text;
                    odabraniStudent.Napomena = txtNapomena.Text;
                    odabraniStudent.OdabraniModel = txtOdabraniModel.Text;
                    db.SaveChanges();
                }
            }
            else
            {
                using (var db = new EvidencijaStudenataEntities())
                {
                    db.Tim.Attach(odabraniTim);
                    Student student = new Student()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Napomena = txtNapomena.Text,
                        OdabraniModel = txtOdabraniModel.Text,
                        Email = txtEmail.Text,
                        Status = txtStatus.Text,
                        Tim = odabraniTim
                    };
                    db.Student.Add(student);
                    db.SaveChanges();
                }
                Close();
            }
        }
    }
}
