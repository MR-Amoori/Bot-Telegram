namespace MyBot
{
    partial class frm_Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemTitel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemTitelForUp = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemTitelForInsert = new System.Windows.Forms.TextBox();
            this.btn_InsertItem = new System.Windows.Forms.Button();
            this.txtAmountForUp = new System.Windows.Forms.NumericUpDown();
            this.txtAmountForInsert = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountForUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountForInsert)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvItems);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Items";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemTitel,
            this.ItemAmount});
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Location = new System.Drawing.Point(3, 17);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(251, 202);
            this.dgvItems.TabIndex = 0;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "Column1";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
            // 
            // ItemTitel
            // 
            this.ItemTitel.DataPropertyName = "ItemTitel";
            this.ItemTitel.HeaderText = "Item Name";
            this.ItemTitel.Name = "ItemTitel";
            this.ItemTitel.ReadOnly = true;
            // 
            // ItemAmount
            // 
            this.ItemAmount.DataPropertyName = "ItemAmount";
            this.ItemAmount.HeaderText = "ItemAmount";
            this.ItemAmount.Name = "ItemAmount";
            this.ItemAmount.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAmountForUp);
            this.groupBox2.Controls.Add(this.btnUpdateItem);
            this.groupBox2.Controls.Add(this.txtItemTitelForUp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(275, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount:";
            // 
            // txtItemTitelForUp
            // 
            this.txtItemTitelForUp.Location = new System.Drawing.Point(60, 26);
            this.txtItemTitelForUp.Name = "txtItemTitelForUp";
            this.txtItemTitelForUp.Size = new System.Drawing.Size(176, 21);
            this.txtItemTitelForUp.TabIndex = 1;
            this.txtItemTitelForUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Enabled = false;
            this.btnUpdateItem.Location = new System.Drawing.Point(114, 80);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateItem.TabIndex = 2;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAmountForInsert);
            this.groupBox3.Controls.Add(this.btn_InsertItem);
            this.groupBox3.Controls.Add(this.txtItemTitelForInsert);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(272, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 105);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amount:";
            // 
            // txtItemTitelForInsert
            // 
            this.txtItemTitelForInsert.Location = new System.Drawing.Point(63, 20);
            this.txtItemTitelForInsert.Name = "txtItemTitelForInsert";
            this.txtItemTitelForInsert.Size = new System.Drawing.Size(176, 21);
            this.txtItemTitelForInsert.TabIndex = 1;
            this.txtItemTitelForInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_InsertItem
            // 
            this.btn_InsertItem.Location = new System.Drawing.Point(117, 74);
            this.btn_InsertItem.Name = "btn_InsertItem";
            this.btn_InsertItem.Size = new System.Drawing.Size(75, 23);
            this.btn_InsertItem.TabIndex = 2;
            this.btn_InsertItem.Text = "Insert";
            this.btn_InsertItem.UseVisualStyleBackColor = true;
            this.btn_InsertItem.Click += new System.EventHandler(this.btn_InsertItem_Click);
            // 
            // txtAmountForUp
            // 
            this.txtAmountForUp.Location = new System.Drawing.Point(60, 53);
            this.txtAmountForUp.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.txtAmountForUp.Name = "txtAmountForUp";
            this.txtAmountForUp.Size = new System.Drawing.Size(176, 21);
            this.txtAmountForUp.TabIndex = 3;
            this.txtAmountForUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmountForInsert
            // 
            this.txtAmountForInsert.Location = new System.Drawing.Point(63, 49);
            this.txtAmountForInsert.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.txtAmountForInsert.Name = "txtAmountForInsert";
            this.txtAmountForInsert.Size = new System.Drawing.Size(176, 21);
            this.txtAmountForInsert.TabIndex = 3;
            this.txtAmountForInsert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(15, 240);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(96, 240);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frm_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 271);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.frm_Items_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountForUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountForInsert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemTitel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtAmountForUp;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.TextBox txtItemTitelForUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown txtAmountForInsert;
        private System.Windows.Forms.Button btn_InsertItem;
        private System.Windows.Forms.TextBox txtItemTitelForInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnRefresh;
    }
}