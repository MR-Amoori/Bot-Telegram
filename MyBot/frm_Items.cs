using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace MyBot
{
    public partial class frm_Items : Form
    {
        UnitOfWork unitOfWork;
        public frm_Items()
        {
            InitializeComponent();
            unitOfWork = new UnitOfWork();
        }

        private void frm_Items_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            dgvItems.DataSource = unitOfWork.TelegramDataBott.GetAllItems();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            string nameItem = dgvItems.CurrentRow.Cells[1].Value.ToString();
            int id = (int)dgvItems.CurrentRow.Cells[0].Value;

            if (dgvItems.CurrentRow != null)
            {
                if (MessageBox.Show($"از حذف {nameItem} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    unitOfWork.TelegramDataBott.DeleteItem(id);
                    unitOfWork.Save();
                    BindGrid();
                }
            }
        }

        private void btn_InsertItem_Click(object sender, EventArgs e)
        {
            unitOfWork.TelegramDataBott.InsertItem(new Items_TB() { ItemTitel = txtItemTitelForInsert.Text, ItemAmount = (int)txtAmountForInsert.Value });
            unitOfWork.Save();
            BindGrid();
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemTitelForUp.Text = dgvItems.CurrentRow.Cells[1].Value.ToString();
            txtAmountForUp.Value = (int)dgvItems.CurrentRow.Cells[2].Value;
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.CurrentRow.Cells[0].Value;
            bool iss = unitOfWork.TelegramDataBott.UpdateItem(new Items_TB() { ItemID = id, ItemTitel = txtItemTitelForUp.Text, ItemAmount = (int)txtAmountForUp.Value });
            unitOfWork.Save();
            BindGrid();
        }
    }
}
