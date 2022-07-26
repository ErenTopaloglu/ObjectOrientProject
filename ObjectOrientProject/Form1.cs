using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace ObjectOrientProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List<EntityPerconel> Perlist = LogicPerconel.LogicLayerPerconelList();
            dataGridView1.DataSource = Perlist;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntityPerconel ent = new EntityPerconel();
            ent.Name1 = TxtName.Text;
            ent.Surname1 = TxtSurname.Text;
            ent.Salary1 = short.Parse(TxtSalary.Text);
            ent.Duty1 = TxtDuty.Text;
            ent.City1 = TxtCity.Text;
            LogicPerconel.LogicLayerPerconelAdd(ent);
            MessageBox.Show("Perconel has been added", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EntityPerconel ent = new EntityPerconel();
            ent.ID1 = int.Parse(TxtID.Text);
            LogicPerconel.LogicLayerPerconelDelete(ent.ID1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtDuty.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtSalary.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtCity.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            EntityPerconel ent = new EntityPerconel();
            ent.ID1=int.Parse(TxtID.Text);
            ent.Name1 = TxtName.Text;
            ent.Surname1 = TxtSurname.Text;
            ent.Duty1 = TxtDuty.Text;
            ent.Salary1 = short.Parse(TxtSalary.Text);
            ent.City1 = TxtCity.Text;
            LogicPerconel.LogicLayerPerconelUpdate(ent);

        }
    }
}
