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

        private void button1_Click(object sender, EventArgs e)
        {
            unitOfWork.TelegramDataBott.InsertItem(new Items_TB() { ItemTitel = txtItemTitelForInsert.Text, ItemAmount = (int)txtAmountForInsert.Value });
            unitOfWork.Save();
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
            string nameItem = dgvItems.CurrentRow.Cells[1].ToString();
            int id = (int)dgvItems.CurrentRow.Cells[0].Value;

            if (dgvItems.CurrentRow!=null)
            {
                if (MessageBox.Show($"از حذف {nameItem} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                {
                    unitOfWork.TelegramDataBott.DeleteItem(id);
                    unitOfWork.Save();
                    BindGrid();
                } 
            }
        }
    }
}
