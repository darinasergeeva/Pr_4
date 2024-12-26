using Microsoft.EntityFrameworkCore;
using Pr_4.Models;

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
            this.dataGridViewTypes.DataSource = this.db.Partners.Local.OrderBy(o=>o.NamePartner).ToList();
            dataGridViewTypes.Columns["Id"].Visible = false;
            dataGridViewTypes.Columns["IdPartnerType"].Visible = false;
            dataGridViewTypes.Columns["IdPartnerTypeNavigation"].Visible = false;
            dataGridViewTypes.Columns["PartnersProducts"].Visible = false;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
