namespace MyBot
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.swBtn_StartOrStop = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.txt_Token = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.lbl_Status = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.btn_About = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.progressBarItem1 = new DevComponents.DotNetBar.ProgressBarItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvReport = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ChatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SendVideoToChannel = new DevComponents.DotNetBar.ButtonX();
            this.btn_SendPhotoToChannel = new DevComponents.DotNetBar.ButtonX();
            this.btn_SendMessageToChannel = new DevComponents.DotNetBar.ButtonX();
            this.txt_Channel = new System.Windows.Forms.TextBox();
            this.btn_SendVideo = new DevComponents.DotNetBar.ButtonX();
            this.btn_SendPhoto = new DevComponents.DotNetBar.ButtonX();
            this.btn_DelPath = new System.Windows.Forms.Button();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.txt_FilePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Send = new DevComponents.DotNetBar.ButtonX();
            this.txt_Message = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_SendToChatId = new System.Windows.Forms.Button();
            this.txt_ChatId = new System.Windows.Forms.TextBox();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.swBtn_StartOrStop);
            this.groupPanel1.Controls.Add(this.txt_Token);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(595, 70);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "توکن ربات";
            // 
            // swBtn_StartOrStop
            // 
            // 
            // 
            // 
            this.swBtn_StartOrStop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.swBtn_StartOrStop.Location = new System.Drawing.Point(9, 13);
            this.swBtn_StartOrStop.Name = "swBtn_StartOrStop";
            this.swBtn_StartOrStop.Size = new System.Drawing.Size(66, 22);
            this.swBtn_StartOrStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.swBtn_StartOrStop.TabIndex = 0;
            this.swBtn_StartOrStop.ValueChanged += new System.EventHandler(this.swBtn_StartOrStop_ValueChanged);
            // 
            // txt_Token
            // 
            this.txt_Token.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt_Token.Border.Class = "TextBoxBorder";
            this.txt_Token.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Token.Location = new System.Drawing.Point(98, 14);
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.PreventEnterBeep = true;
            this.txt_Token.Size = new System.Drawing.Size(482, 21);
            this.txt_Token.TabIndex = 0;
            // 
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.DragDropSupport = true;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lbl_Status,
            this.labelItem1,
            this.btn_About,
            this.labelItem2,
            this.progressBarItem1});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 533);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(595, 22);
            this.metroStatusBar1.TabIndex = 1;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // lbl_Status
            // 
            this.lbl_Status.FontBold = true;
            this.lbl_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.SingleLineColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Status.Text = "Offline";
            this.lbl_Status.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelItem1
            // 
            this.labelItem1.FontBold = true;
            this.labelItem1.ForeColor = System.Drawing.Color.White;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "||";
            // 
            // btn_About
            // 
            this.btn_About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_About.HotForeColor = System.Drawing.Color.Black;
            this.btn_About.Name = "btn_About";
            this.btn_About.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btn_About.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F1);
            this.btn_About.Text = " <b>About</b> ";
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // labelItem2
            // 
            this.labelItem2.ForeColor = System.Drawing.Color.White;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "||";
            // 
            // progressBarItem1
            // 
            // 
            // 
            // 
            this.progressBarItem1.BackStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarItem1.ChunkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progressBarItem1.ChunkColor2 = System.Drawing.Color.Lime;
            this.progressBarItem1.ChunkGradientAngle = 0F;
            this.progressBarItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.progressBarItem1.Name = "progressBarItem1";
            this.progressBarItem1.RecentlyUsed = false;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.Controls.Add(this.dgvReport);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 67);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(595, 238);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 2;
            this.panelEx1.Text = "panelEx1";
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvReport.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChatId,
            this.UserName,
            this.FullName,
            this.Command,
            this.MessageId,
            this.Date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(595, 238);
            this.dgvReport.TabIndex = 0;
            // 
            // ChatId
            // 
            this.ChatId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChatId.HeaderText = "Chat ID";
            this.ChatId.Name = "ChatId";
            this.ChatId.ReadOnly = true;
            this.ChatId.Width = 69;
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UserName.HeaderText = "User Name";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 84;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 78;
            // 
            // Command
            // 
            this.Command.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            this.Command.ReadOnly = true;
            this.Command.Width = 79;
            // 
            // MessageId
            // 
            this.MessageId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MessageId.HeaderText = "Message ID";
            this.MessageId.Name = "MessageId";
            this.MessageId.ReadOnly = true;
            this.MessageId.Width = 88;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btn_SendVideo);
            this.groupBox1.Controls.Add(this.btn_SendPhoto);
            this.groupBox1.Controls.Add(this.btn_DelPath);
            this.groupBox1.Controls.Add(this.btn_SelectFile);
            this.groupBox1.Controls.Add(this.txt_FilePath);
            this.groupBox1.Controls.Add(this.btn_Send);
            this.groupBox1.Controls.Add(this.txt_Message);
            this.groupBox1.Location = new System.Drawing.Point(0, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(595, 216);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SendVideoToChannel);
            this.groupBox2.Controls.Add(this.btn_SendPhotoToChannel);
            this.groupBox2.Controls.Add(this.btn_SendMessageToChannel);
            this.groupBox2.Controls.Add(this.txt_Channel);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Channel";
            // 
            // btn_SendVideoToChannel
            // 
            this.btn_SendVideoToChannel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendVideoToChannel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendVideoToChannel.Enabled = false;
            this.btn_SendVideoToChannel.Location = new System.Drawing.Point(89, 20);
            this.btn_SendVideoToChannel.Name = "btn_SendVideoToChannel";
            this.btn_SendVideoToChannel.Size = new System.Drawing.Size(75, 21);
            this.btn_SendVideoToChannel.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btn_SendVideoToChannel.TabIndex = 1;
            this.btn_SendVideoToChannel.Text = "Video";
            this.btn_SendVideoToChannel.Click += new System.EventHandler(this.btn_SendVideoToChannel_Click);
            // 
            // btn_SendPhotoToChannel
            // 
            this.btn_SendPhotoToChannel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendPhotoToChannel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendPhotoToChannel.Enabled = false;
            this.btn_SendPhotoToChannel.Location = new System.Drawing.Point(8, 20);
            this.btn_SendPhotoToChannel.Name = "btn_SendPhotoToChannel";
            this.btn_SendPhotoToChannel.Size = new System.Drawing.Size(75, 21);
            this.btn_SendPhotoToChannel.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btn_SendPhotoToChannel.TabIndex = 1;
            this.btn_SendPhotoToChannel.Text = "Photo";
            this.btn_SendPhotoToChannel.Click += new System.EventHandler(this.btn_SendPhotoToChannel_Click);
            // 
            // btn_SendMessageToChannel
            // 
            this.btn_SendMessageToChannel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendMessageToChannel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendMessageToChannel.Enabled = false;
            this.btn_SendMessageToChannel.Location = new System.Drawing.Point(170, 20);
            this.btn_SendMessageToChannel.Name = "btn_SendMessageToChannel";
            this.btn_SendMessageToChannel.Size = new System.Drawing.Size(78, 21);
            this.btn_SendMessageToChannel.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.btn_SendMessageToChannel.TabIndex = 1;
            this.btn_SendMessageToChannel.Text = "Send Message";
            this.btn_SendMessageToChannel.Click += new System.EventHandler(this.btn_SendMessageToChannel_Click);
            // 
            // txt_Channel
            // 
            this.txt_Channel.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Channel.Enabled = false;
            this.txt_Channel.Location = new System.Drawing.Point(254, 20);
            this.txt_Channel.Name = "txt_Channel";
            this.txt_Channel.Size = new System.Drawing.Size(311, 21);
            this.txt_Channel.TabIndex = 0;
            // 
            // btn_SendVideo
            // 
            this.btn_SendVideo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendVideo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendVideo.Enabled = false;
            this.btn_SendVideo.Location = new System.Drawing.Point(101, 82);
            this.btn_SendVideo.Name = "btn_SendVideo";
            this.btn_SendVideo.Size = new System.Drawing.Size(88, 21);
            this.btn_SendVideo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SendVideo.TabIndex = 4;
            this.btn_SendVideo.Text = "Video";
            this.btn_SendVideo.Click += new System.EventHandler(this.btn_SendVideo_Click);
            // 
            // btn_SendPhoto
            // 
            this.btn_SendPhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SendPhoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SendPhoto.Enabled = false;
            this.btn_SendPhoto.Location = new System.Drawing.Point(7, 82);
            this.btn_SendPhoto.Name = "btn_SendPhoto";
            this.btn_SendPhoto.Size = new System.Drawing.Size(88, 21);
            this.btn_SendPhoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SendPhoto.TabIndex = 4;
            this.btn_SendPhoto.Text = "Photo";
            this.btn_SendPhoto.Click += new System.EventHandler(this.btn_SendPhoto_Click);
            // 
            // btn_DelPath
            // 
            this.btn_DelPath.Enabled = false;
            this.btn_DelPath.ForeColor = System.Drawing.Color.Red;
            this.btn_DelPath.Location = new System.Drawing.Point(195, 82);
            this.btn_DelPath.Name = "btn_DelPath";
            this.btn_DelPath.Size = new System.Drawing.Size(32, 21);
            this.btn_DelPath.TabIndex = 3;
            this.btn_DelPath.Text = "Del";
            this.btn_DelPath.UseVisualStyleBackColor = true;
            this.btn_DelPath.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.Enabled = false;
            this.btn_SelectFile.Location = new System.Drawing.Point(233, 82);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(27, 21);
            this.btn_SelectFile.TabIndex = 3;
            this.btn_SelectFile.Text = "...";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt_FilePath.Border.Class = "TextBoxBorder";
            this.txt_FilePath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_FilePath.Enabled = false;
            this.txt_FilePath.Location = new System.Drawing.Point(266, 82);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.PreventEnterBeep = true;
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(317, 21);
            this.txt_FilePath.TabIndex = 2;
            // 
            // btn_Send
            // 
            this.btn_Send.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Send.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Send.Enabled = false;
            this.btn_Send.Location = new System.Drawing.Point(7, 20);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btn_Send.Size = new System.Drawing.Size(88, 56);
            this.btn_Send.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Send Message";
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.txt_Message.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt_Message.Border.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor2;
            this.txt_Message.Border.Class = "TextBoxBorder";
            this.txt_Message.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Message.Enabled = false;
            this.txt_Message.Location = new System.Drawing.Point(101, 20);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.PreventEnterBeep = true;
            this.txt_Message.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Message.Size = new System.Drawing.Size(482, 56);
            this.txt_Message.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_ChatId);
            this.groupBox3.Controls.Add(this.btn_SendToChatId);
            this.groupBox3.Location = new System.Drawing.Point(12, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 42);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Privet";
            // 
            // btn_SendToChatId
            // 
            this.btn_SendToChatId.Enabled = false;
            this.btn_SendToChatId.Location = new System.Drawing.Point(6, 13);
            this.btn_SendToChatId.Name = "btn_SendToChatId";
            this.btn_SendToChatId.Size = new System.Drawing.Size(75, 21);
            this.btn_SendToChatId.TabIndex = 0;
            this.btn_SendToChatId.Text = "Send";
            this.btn_SendToChatId.UseVisualStyleBackColor = true;
            this.btn_SendToChatId.Click += new System.EventHandler(this.btn_SendToChatId_Click);
            // 
            // txt_ChatId
            // 
            this.txt_ChatId.BackColor = System.Drawing.SystemColors.Info;
            this.txt_ChatId.Enabled = false;
            this.txt_ChatId.Location = new System.Drawing.Point(87, 13);
            this.txt_ChatId.Name = "txt_ChatId";
            this.txt_ChatId.Size = new System.Drawing.Size(107, 21);
            this.txt_ChatId.TabIndex = 1;
            this.txt_ChatId.Text = "Chat ID";
            this.txt_ChatId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ChatId.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_ChatId_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(595, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.groupPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Token;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem lbl_Status;
        private DevComponents.DotNetBar.Controls.SwitchButton swBtn_StartOrStop;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonItem btn_About;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Message;
        private DevComponents.DotNetBar.ButtonX btn_Send;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_FilePath;
        private System.Windows.Forms.Button btn_SelectFile;
        private DevComponents.DotNetBar.ButtonX btn_SendVideo;
        private DevComponents.DotNetBar.ButtonX btn_SendPhoto;
        private System.Windows.Forms.Button btn_DelPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevComponents.DotNetBar.ButtonX btn_SendVideoToChannel;
        private DevComponents.DotNetBar.ButtonX btn_SendPhotoToChannel;
        private DevComponents.DotNetBar.ButtonX btn_SendMessageToChannel;
        private System.Windows.Forms.TextBox txt_Channel;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ProgressBarItem progressBarItem1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_ChatId;
        private System.Windows.Forms.Button btn_SendToChatId;
    }
}

