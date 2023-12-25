namespace EnginGL
{
    partial class EnginGL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnginGL));
            this.minmizedPB = new System.Windows.Forms.PictureBox();
            this.closePB = new System.Windows.Forms.PictureBox();
            this.titleBar_panel = new System.Windows.Forms.Panel();
            this.icon_PB = new System.Windows.Forms.PictureBox();
            this.NameLB = new System.Windows.Forms.Label();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.main_panel = new System.Windows.Forms.Panel();
            this.image_panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.img_PB = new System.Windows.Forms.PictureBox();
            this.imgBox_LB = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.sideBar_panel = new System.Windows.Forms.Panel();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.selectSavFolder_BTN = new System.Windows.Forms.Button();
            this.selectImage_LB = new System.Windows.Forms.Label();
            this.glEnd = new System.Windows.Forms.Button();
            this.selectImgSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.glBegin_LB = new System.Windows.Forms.Label();
            this.GlBegin_CB = new MetroFramework.Controls.MetroComboBox();
            this.glEndSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.saveLoc_LB = new System.Windows.Forms.Label();
            this.penColor_CB = new MetroFramework.Controls.MetroComboBox();
            this.saveFolderPath_TB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.blue_CB = new MetroFramework.Controls.MetroComboBox();
            this.green_CB = new MetroFramework.Controls.MetroComboBox();
            this.red_CB = new MetroFramework.Controls.MetroComboBox();
            this.selectPathSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.penColorSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.menu_panel = new System.Windows.Forms.Panel();
            this.menu_PB = new System.Windows.Forms.PictureBox();
            this.menu_LB = new System.Windows.Forms.Label();
            this.Color_panel = new System.Windows.Forms.Panel();
            this.Color_LB = new System.Windows.Forms.Label();
            this.RGB_Value_LB = new System.Windows.Forms.Label();
            this.penColor_LB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minmizedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).BeginInit();
            this.titleBar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_PB)).BeginInit();
            this.main_panel.SuspendLayout();
            this.image_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.sideBar_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // minmizedPB
            // 
            this.minmizedPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minmizedPB.BackColor = System.Drawing.Color.Transparent;
            this.minmizedPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minmizedPB.Image = ((System.Drawing.Image)(resources.GetObject("minmizedPB.Image")));
            this.minmizedPB.Location = new System.Drawing.Point(848, 0);
            this.minmizedPB.Name = "minmizedPB";
            this.minmizedPB.Size = new System.Drawing.Size(26, 26);
            this.minmizedPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minmizedPB.TabIndex = 21;
            this.minmizedPB.TabStop = false;
            this.minmizedPB.Click += new System.EventHandler(this.minmizedPB_Click);
            // 
            // closePB
            // 
            this.closePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePB.BackColor = System.Drawing.Color.Transparent;
            this.closePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePB.Image = ((System.Drawing.Image)(resources.GetObject("closePB.Image")));
            this.closePB.Location = new System.Drawing.Point(872, 0);
            this.closePB.Name = "closePB";
            this.closePB.Size = new System.Drawing.Size(26, 26);
            this.closePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePB.TabIndex = 19;
            this.closePB.TabStop = false;
            this.closePB.Click += new System.EventHandler(this.closePB_Click);
            // 
            // titleBar_panel
            // 
            this.titleBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.titleBar_panel.Controls.Add(this.icon_PB);
            this.titleBar_panel.Controls.Add(this.NameLB);
            this.titleBar_panel.Controls.Add(this.closePB);
            this.titleBar_panel.Controls.Add(this.minmizedPB);
            this.titleBar_panel.Location = new System.Drawing.Point(-1, 0);
            this.titleBar_panel.Name = "titleBar_panel";
            this.titleBar_panel.Size = new System.Drawing.Size(901, 30);
            this.titleBar_panel.TabIndex = 22;
            // 
            // icon_PB
            // 
            this.icon_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon_PB.BackgroundImage")));
            this.icon_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon_PB.Location = new System.Drawing.Point(389, 3);
            this.icon_PB.Name = "icon_PB";
            this.icon_PB.Size = new System.Drawing.Size(31, 24);
            this.icon_PB.TabIndex = 85;
            this.icon_PB.TabStop = false;
            // 
            // NameLB
            // 
            this.NameLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLB.ForeColor = System.Drawing.Color.Gainsboro;
            this.NameLB.Location = new System.Drawing.Point(416, 6);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(69, 19);
            this.NameLB.TabIndex = 22;
            this.NameLB.Text = "EnginGL";
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this.titleBar_panel;
            this.DragControl.Vertical = true;
            // 
            // main_panel
            // 
            this.main_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_panel.Controls.Add(this.image_panel);
            this.main_panel.Controls.Add(this.sideBar_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main_panel.Location = new System.Drawing.Point(0, 29);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(900, 519);
            this.main_panel.TabIndex = 23;
            // 
            // image_panel
            // 
            this.image_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.image_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.image_panel.Controls.Add(this.panel1);
            this.image_panel.Controls.Add(this.imgBox);
            this.image_panel.Location = new System.Drawing.Point(4, 5);
            this.image_panel.Name = "image_panel";
            this.image_panel.Size = new System.Drawing.Size(640, 507);
            this.image_panel.TabIndex = 82;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.img_PB);
            this.panel1.Controls.Add(this.imgBox_LB);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 30);
            this.panel1.TabIndex = 84;
            // 
            // img_PB
            // 
            this.img_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_PB.BackgroundImage")));
            this.img_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_PB.Location = new System.Drawing.Point(264, 2);
            this.img_PB.Name = "img_PB";
            this.img_PB.Size = new System.Drawing.Size(31, 24);
            this.img_PB.TabIndex = 86;
            this.img_PB.TabStop = false;
            // 
            // imgBox_LB
            // 
            this.imgBox_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgBox_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.imgBox_LB.Location = new System.Drawing.Point(291, 5);
            this.imgBox_LB.Name = "imgBox_LB";
            this.imgBox_LB.Size = new System.Drawing.Size(84, 19);
            this.imgBox_LB.TabIndex = 23;
            this.imgBox_LB.Text = "Image Box";
            // 
            // imgBox
            // 
            this.imgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBox.Location = new System.Drawing.Point(-1, 26);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(640, 480);
            this.imgBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox.TabIndex = 83;
            this.imgBox.TabStop = false;
            this.imgBox.Paint += new System.Windows.Forms.PaintEventHandler(this.imgBox_Paint);
            this.imgBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgBox_MouseClick);
            // 
            // sideBar_panel
            // 
            this.sideBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.sideBar_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sideBar_panel.Controls.Add(this.btnSelectImg);
            this.sideBar_panel.Controls.Add(this.selectSavFolder_BTN);
            this.sideBar_panel.Controls.Add(this.selectImage_LB);
            this.sideBar_panel.Controls.Add(this.glEnd);
            this.sideBar_panel.Controls.Add(this.selectImgSeparator);
            this.sideBar_panel.Controls.Add(this.glBegin_LB);
            this.sideBar_panel.Controls.Add(this.GlBegin_CB);
            this.sideBar_panel.Controls.Add(this.glEndSeparator);
            this.sideBar_panel.Controls.Add(this.saveLoc_LB);
            this.sideBar_panel.Controls.Add(this.penColor_CB);
            this.sideBar_panel.Controls.Add(this.saveFolderPath_TB);
            this.sideBar_panel.Controls.Add(this.blue_CB);
            this.sideBar_panel.Controls.Add(this.green_CB);
            this.sideBar_panel.Controls.Add(this.red_CB);
            this.sideBar_panel.Controls.Add(this.selectPathSeparator);
            this.sideBar_panel.Controls.Add(this.penColorSeparator);
            this.sideBar_panel.Controls.Add(this.menu_panel);
            this.sideBar_panel.Controls.Add(this.Color_panel);
            this.sideBar_panel.Controls.Add(this.Color_LB);
            this.sideBar_panel.Controls.Add(this.RGB_Value_LB);
            this.sideBar_panel.Controls.Add(this.penColor_LB);
            this.sideBar_panel.Location = new System.Drawing.Point(648, 5);
            this.sideBar_panel.Name = "sideBar_panel";
            this.sideBar_panel.Size = new System.Drawing.Size(246, 507);
            this.sideBar_panel.TabIndex = 81;
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.btnSelectImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSelectImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectImg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.btnSelectImg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.btnSelectImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(146)))), ((int)(((byte)(196)))));
            this.btnSelectImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectImg.ForeColor = System.Drawing.Color.White;
            this.btnSelectImg.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectImg.Image")));
            this.btnSelectImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectImg.Location = new System.Drawing.Point(9, 467);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectImg.Size = new System.Drawing.Size(224, 30);
            this.btnSelectImg.TabIndex = 85;
            this.btnSelectImg.Text = "Select Image";
            this.btnSelectImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectImg.UseVisualStyleBackColor = false;
            this.btnSelectImg.EnabledChanged += new System.EventHandler(this.btnSelectImg_EnabledChanged);
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // selectSavFolder_BTN
            // 
            this.selectSavFolder_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.selectSavFolder_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectSavFolder_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectSavFolder_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.selectSavFolder_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.selectSavFolder_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(146)))), ((int)(((byte)(196)))));
            this.selectSavFolder_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectSavFolder_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.selectSavFolder_BTN.ForeColor = System.Drawing.Color.White;
            this.selectSavFolder_BTN.Image = ((System.Drawing.Image)(resources.GetObject("selectSavFolder_BTN.Image")));
            this.selectSavFolder_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectSavFolder_BTN.Location = new System.Drawing.Point(9, 402);
            this.selectSavFolder_BTN.Name = "selectSavFolder_BTN";
            this.selectSavFolder_BTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectSavFolder_BTN.Size = new System.Drawing.Size(224, 30);
            this.selectSavFolder_BTN.TabIndex = 87;
            this.selectSavFolder_BTN.Text = "Select Save Path";
            this.selectSavFolder_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectSavFolder_BTN.UseVisualStyleBackColor = false;
            this.selectSavFolder_BTN.EnabledChanged += new System.EventHandler(this.selectSavFolder_BTN_EnabledChanged);
            this.selectSavFolder_BTN.Click += new System.EventHandler(this.selectSavFolder_BTN_Click);
            // 
            // selectImage_LB
            // 
            this.selectImage_LB.AutoSize = true;
            this.selectImage_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImage_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.selectImage_LB.Location = new System.Drawing.Point(7, 445);
            this.selectImage_LB.Name = "selectImage_LB";
            this.selectImage_LB.Size = new System.Drawing.Size(104, 17);
            this.selectImage_LB.TabIndex = 86;
            this.selectImage_LB.Text = "Select an Image";
            // 
            // glEnd
            // 
            this.glEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.glEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.glEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.glEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(214)))));
            this.glEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(146)))), ((int)(((byte)(196)))));
            this.glEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.glEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.glEnd.ForeColor = System.Drawing.Color.White;
            this.glEnd.Image = ((System.Drawing.Image)(resources.GetObject("glEnd.Image")));
            this.glEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.glEnd.Location = new System.Drawing.Point(9, 299);
            this.glEnd.Name = "glEnd";
            this.glEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.glEnd.Size = new System.Drawing.Size(224, 30);
            this.glEnd.TabIndex = 86;
            this.glEnd.Text = "GL End";
            this.glEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.glEnd.UseVisualStyleBackColor = false;
            this.glEnd.EnabledChanged += new System.EventHandler(this.glEnd_EnabledChanged);
            this.glEnd.Click += new System.EventHandler(this.glEnd_Click);
            // 
            // selectImgSeparator
            // 
            this.selectImgSeparator.BackColor = System.Drawing.Color.Transparent;
            this.selectImgSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.selectImgSeparator.LineThickness = 1;
            this.selectImgSeparator.Location = new System.Drawing.Point(8, 433);
            this.selectImgSeparator.Name = "selectImgSeparator";
            this.selectImgSeparator.Size = new System.Drawing.Size(228, 15);
            this.selectImgSeparator.TabIndex = 85;
            this.selectImgSeparator.Transparency = 255;
            this.selectImgSeparator.Vertical = false;
            // 
            // glBegin_LB
            // 
            this.glBegin_LB.AutoSize = true;
            this.glBegin_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.glBegin_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.glBegin_LB.Location = new System.Drawing.Point(5, 241);
            this.glBegin_LB.Name = "glBegin_LB";
            this.glBegin_LB.Size = new System.Drawing.Size(100, 17);
            this.glBegin_LB.TabIndex = 83;
            this.glBegin_LB.Text = "Select GL Begin";
            // 
            // GlBegin_CB
            // 
            this.GlBegin_CB.DropDownHeight = 255;
            this.GlBegin_CB.FormattingEnabled = true;
            this.GlBegin_CB.IntegralHeight = false;
            this.GlBegin_CB.ItemHeight = 23;
            this.GlBegin_CB.Items.AddRange(new object[] {
            "GL_LINE_STRIP",
            "GL_POINTS",
            "GL_POLYGON"});
            this.GlBegin_CB.Location = new System.Drawing.Point(9, 263);
            this.GlBegin_CB.Name = "GlBegin_CB";
            this.GlBegin_CB.Size = new System.Drawing.Size(224, 29);
            this.GlBegin_CB.TabIndex = 82;
            this.GlBegin_CB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GlBegin_CB.UseSelectable = true;
            this.GlBegin_CB.SelectedIndexChanged += new System.EventHandler(this.GlBegin_CB_SelectedIndexChanged);
            // 
            // glEndSeparator
            // 
            this.glEndSeparator.BackColor = System.Drawing.Color.Transparent;
            this.glEndSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.glEndSeparator.LineThickness = 1;
            this.glEndSeparator.Location = new System.Drawing.Point(7, 228);
            this.glEndSeparator.Name = "glEndSeparator";
            this.glEndSeparator.Size = new System.Drawing.Size(228, 15);
            this.glEndSeparator.TabIndex = 81;
            this.glEndSeparator.Transparency = 255;
            this.glEndSeparator.Vertical = false;
            // 
            // saveLoc_LB
            // 
            this.saveLoc_LB.AutoSize = true;
            this.saveLoc_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveLoc_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.saveLoc_LB.Location = new System.Drawing.Point(5, 344);
            this.saveLoc_LB.Name = "saveLoc_LB";
            this.saveLoc_LB.Size = new System.Drawing.Size(233, 17);
            this.saveLoc_LB.TabIndex = 34;
            this.saveLoc_LB.Text = "Select Location Where Code File Save";
            // 
            // penColor_CB
            // 
            this.penColor_CB.DropDownHeight = 255;
            this.penColor_CB.FormattingEnabled = true;
            this.penColor_CB.IntegralHeight = false;
            this.penColor_CB.ItemHeight = 23;
            this.penColor_CB.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Green",
            "orange",
            "Purple",
            "Red",
            "White",
            "Yellow"});
            this.penColor_CB.Location = new System.Drawing.Point(75, 40);
            this.penColor_CB.Name = "penColor_CB";
            this.penColor_CB.Size = new System.Drawing.Size(158, 29);
            this.penColor_CB.TabIndex = 33;
            this.penColor_CB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.penColor_CB.UseSelectable = true;
            // 
            // saveFolderPath_TB
            // 
            this.saveFolderPath_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveFolderPath_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveFolderPath_TB.BorderColorFocused = System.Drawing.Color.LightGray;
            this.saveFolderPath_TB.BorderColorIdle = System.Drawing.Color.DimGray;
            this.saveFolderPath_TB.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.saveFolderPath_TB.BorderThickness = 1;
            this.saveFolderPath_TB.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.saveFolderPath_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.saveFolderPath_TB.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.saveFolderPath_TB.ForeColor = System.Drawing.Color.LightGray;
            this.saveFolderPath_TB.isPassword = false;
            this.saveFolderPath_TB.Location = new System.Drawing.Point(8, 366);
            this.saveFolderPath_TB.Margin = new System.Windows.Forms.Padding(4);
            this.saveFolderPath_TB.MaxLength = 32767;
            this.saveFolderPath_TB.Name = "saveFolderPath_TB";
            this.saveFolderPath_TB.Size = new System.Drawing.Size(225, 30);
            this.saveFolderPath_TB.TabIndex = 80;
            this.saveFolderPath_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // blue_CB
            // 
            this.blue_CB.DropDownHeight = 255;
            this.blue_CB.FormattingEnabled = true;
            this.blue_CB.IntegralHeight = false;
            this.blue_CB.ItemHeight = 23;
            this.blue_CB.Location = new System.Drawing.Point(179, 88);
            this.blue_CB.Name = "blue_CB";
            this.blue_CB.Size = new System.Drawing.Size(53, 29);
            this.blue_CB.TabIndex = 32;
            this.blue_CB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.blue_CB.UseSelectable = true;
            this.blue_CB.SelectedIndexChanged += new System.EventHandler(this.blue_CB_SelectedIndexChanged);
            // 
            // green_CB
            // 
            this.green_CB.DropDownHeight = 255;
            this.green_CB.FormattingEnabled = true;
            this.green_CB.IntegralHeight = false;
            this.green_CB.ItemHeight = 23;
            this.green_CB.Location = new System.Drawing.Point(127, 88);
            this.green_CB.Name = "green_CB";
            this.green_CB.Size = new System.Drawing.Size(53, 29);
            this.green_CB.TabIndex = 30;
            this.green_CB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.green_CB.UseSelectable = true;
            this.green_CB.SelectedIndexChanged += new System.EventHandler(this.green_CB_SelectedIndexChanged);
            // 
            // red_CB
            // 
            this.red_CB.DropDownHeight = 255;
            this.red_CB.FormattingEnabled = true;
            this.red_CB.IntegralHeight = false;
            this.red_CB.ItemHeight = 23;
            this.red_CB.Location = new System.Drawing.Point(75, 88);
            this.red_CB.Name = "red_CB";
            this.red_CB.Size = new System.Drawing.Size(53, 29);
            this.red_CB.TabIndex = 29;
            this.red_CB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.red_CB.UseSelectable = true;
            this.red_CB.SelectedIndexChanged += new System.EventHandler(this.red_CB_SelectedIndexChanged);
            // 
            // selectPathSeparator
            // 
            this.selectPathSeparator.BackColor = System.Drawing.Color.Transparent;
            this.selectPathSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.selectPathSeparator.LineThickness = 1;
            this.selectPathSeparator.Location = new System.Drawing.Point(7, 330);
            this.selectPathSeparator.Name = "selectPathSeparator";
            this.selectPathSeparator.Size = new System.Drawing.Size(228, 15);
            this.selectPathSeparator.TabIndex = 27;
            this.selectPathSeparator.Transparency = 255;
            this.selectPathSeparator.Vertical = false;
            // 
            // penColorSeparator
            // 
            this.penColorSeparator.BackColor = System.Drawing.Color.Transparent;
            this.penColorSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.penColorSeparator.LineThickness = 1;
            this.penColorSeparator.Location = new System.Drawing.Point(7, 72);
            this.penColorSeparator.Name = "penColorSeparator";
            this.penColorSeparator.Size = new System.Drawing.Size(228, 15);
            this.penColorSeparator.TabIndex = 26;
            this.penColorSeparator.Transparency = 255;
            this.penColorSeparator.Vertical = false;
            // 
            // menu_panel
            // 
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.menu_panel.Controls.Add(this.menu_PB);
            this.menu_panel.Controls.Add(this.menu_LB);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(244, 29);
            this.menu_panel.TabIndex = 24;
            // 
            // menu_PB
            // 
            this.menu_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_PB.BackgroundImage")));
            this.menu_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menu_PB.Location = new System.Drawing.Point(84, 2);
            this.menu_PB.Name = "menu_PB";
            this.menu_PB.Size = new System.Drawing.Size(31, 24);
            this.menu_PB.TabIndex = 87;
            this.menu_PB.TabStop = false;
            // 
            // menu_LB
            // 
            this.menu_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.menu_LB.Location = new System.Drawing.Point(111, 4);
            this.menu_LB.Name = "menu_LB";
            this.menu_LB.Size = new System.Drawing.Size(45, 19);
            this.menu_LB.TabIndex = 23;
            this.menu_LB.Text = "Menu";
            // 
            // Color_panel
            // 
            this.Color_panel.BackColor = System.Drawing.Color.White;
            this.Color_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_panel.ForeColor = System.Drawing.Color.White;
            this.Color_panel.Location = new System.Drawing.Point(75, 122);
            this.Color_panel.Name = "Color_panel";
            this.Color_panel.Size = new System.Drawing.Size(157, 100);
            this.Color_panel.TabIndex = 23;
            // 
            // Color_LB
            // 
            this.Color_LB.AutoSize = true;
            this.Color_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.Color_LB.Location = new System.Drawing.Point(5, 160);
            this.Color_LB.Name = "Color_LB";
            this.Color_LB.Size = new System.Drawing.Size(59, 17);
            this.Color_LB.TabIndex = 18;
            this.Color_LB.Text = "GL Color";
            // 
            // RGB_Value_LB
            // 
            this.RGB_Value_LB.AutoSize = true;
            this.RGB_Value_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RGB_Value_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.RGB_Value_LB.Location = new System.Drawing.Point(5, 96);
            this.RGB_Value_LB.Name = "RGB_Value_LB";
            this.RGB_Value_LB.Size = new System.Drawing.Size(69, 17);
            this.RGB_Value_LB.TabIndex = 19;
            this.RGB_Value_LB.Text = "RGB Value";
            // 
            // penColor_LB
            // 
            this.penColor_LB.AutoSize = true;
            this.penColor_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penColor_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.penColor_LB.Location = new System.Drawing.Point(5, 45);
            this.penColor_LB.Name = "penColor_LB";
            this.penColor_LB.Size = new System.Drawing.Size(67, 17);
            this.penColor_LB.TabIndex = 17;
            this.penColor_LB.Text = "Pen Color";
            // 
            // EnginGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(900, 548);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.titleBar_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnginGL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnginGL";
            ((System.ComponentModel.ISupportInitialize)(this.minmizedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).EndInit();
            this.titleBar_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icon_PB)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.image_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.sideBar_panel.ResumeLayout(false);
            this.sideBar_panel.PerformLayout();
            this.menu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox minmizedPB;
        private System.Windows.Forms.PictureBox closePB;
        private System.Windows.Forms.Panel titleBar_panel;
        private System.Windows.Forms.Label NameLB;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel sideBar_panel;
        private System.Windows.Forms.Panel Color_panel;
        private System.Windows.Forms.Label Color_LB;
        private System.Windows.Forms.Label RGB_Value_LB;
        private System.Windows.Forms.Label penColor_LB;
        private Bunifu.Framework.UI.BunifuMetroTextbox saveFolderPath_TB;
        private System.Windows.Forms.Panel menu_panel;
        private System.Windows.Forms.Label menu_LB;
        private System.Windows.Forms.Panel image_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label imgBox_LB;
        private System.Windows.Forms.PictureBox imgBox;
        private Bunifu.Framework.UI.BunifuSeparator penColorSeparator;
        private Bunifu.Framework.UI.BunifuSeparator selectPathSeparator;
        private MetroFramework.Controls.MetroComboBox red_CB;
        private MetroFramework.Controls.MetroComboBox green_CB;
        private MetroFramework.Controls.MetroComboBox blue_CB;
        private MetroFramework.Controls.MetroComboBox penColor_CB;
        private System.Windows.Forms.Label saveLoc_LB;
        private MetroFramework.Controls.MetroComboBox GlBegin_CB;
        private Bunifu.Framework.UI.BunifuSeparator glEndSeparator;
        private System.Windows.Forms.Label glBegin_LB;
        private Bunifu.Framework.UI.BunifuSeparator selectImgSeparator;
        private System.Windows.Forms.Label selectImage_LB;
        private System.Windows.Forms.PictureBox icon_PB;
        private System.Windows.Forms.PictureBox img_PB;
        private System.Windows.Forms.PictureBox menu_PB;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.Button glEnd;
        private System.Windows.Forms.Button selectSavFolder_BTN;
    }
}

