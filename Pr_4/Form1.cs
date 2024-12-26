using Microsoft.EntityFrameworkCore;
using Pr_4.Models;
using System.ComponentModel;

namespace Pr_4
{
    public partial class Form1 : Form
    {
        private PartnersContext db;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new PartnersContext();
            this.db.Partners.Load();
            this.dataGridViewTypes.DataSource = this.db.Partners.Local.OrderBy(o => o.NamePartner).ToList();
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["IdPartnerType"].Visible = false;
            dataGridViewTypes.Columns["IdPartnerTypeNavigation"].Visible = false;
            dataGridViewTypes.Columns["PartnersProducts"].Visible = false;

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd= new FormAdd();
            DialogResult result = formAdd.ShowDialog(this);

            if (result == DialogResult.Cancel) 
                return;

            Partner partner=new Partner();
            partner.NamePartner = formAdd.textBoxName.Text;

            Partner partner2 = new Partner();
            partner.LegalAddress = formAdd.textBoxLegalAddress.Text;

            Partner partner3 = new Partner();
            partner.Tin = formAdd.textBoxTin.Text;

            Partner partner4 = new Partner();
            partner.NameOfDirector = formAdd.textBoxNameOfDirector.Text;

            Partner partner5 = new Partner();
            partner.Telephone = formAdd.textBoxTelephone.Text;

            Partner partner6 = new Partner();
            partner.Email = formAdd.textBoxEmail.Text;

            //Partner partner7 = new Partner();
            //partner.Rating = formAdd.textBoxRating.Text;


            db.Partners.Add(partner);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
        }
    }
}
