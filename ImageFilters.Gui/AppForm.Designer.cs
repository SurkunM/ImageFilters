namespace ImagesFilters
{
    partial class AppForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppForm));
            panelApp = new Panel();
            toolStripButtons = new Panel();
            radioButtonNoise = new RadioButton();
            radioButtonCancel = new RadioButton();
            radioButtonSharpen = new RadioButton();
            radioButton4 = new RadioButton();
            radioButtonAqua = new RadioButton();
            radioButtonBlackAndWhite = new RadioButton();
            radioButtonBlur = new RadioButton();
            pictureBoxOriginalImage = new PictureBox();
            pictureBoxResultImage = new PictureBox();
            menuStrip = new MenuStrip();
            stripMenuFilesItem = new ToolStripMenuItem();
            toolStripMenuOpen = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuDeleteImage = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            toolStripMenuSave = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            предварительныйпросмотрToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripMenuExit = new ToolStripMenuItem();
            stripMenuToolItem = new ToolStripMenuItem();
            toolStripMenuBlur = new ToolStripMenuItem();
            toolStripMenuBlackAndWhite = new ToolStripMenuItem();
            toolStripMenuAqua = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripMenuCancel = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            параметрыToolStripMenuItem = new ToolStripMenuItem();
            panelApp.SuspendLayout();
            toolStripButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultImage).BeginInit();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelApp
            // 
            panelApp.BackColor = SystemColors.ActiveBorder;
            panelApp.Controls.Add(toolStripButtons);
            panelApp.Controls.Add(pictureBoxOriginalImage);
            panelApp.Controls.Add(pictureBoxResultImage);
            panelApp.Controls.Add(menuStrip);
            panelApp.Dock = DockStyle.Fill;
            panelApp.Location = new Point(0, 0);
            panelApp.Name = "panelApp";
            panelApp.Padding = new Padding(0, 0, 0, 10);
            panelApp.Size = new Size(1134, 611);
            panelApp.TabIndex = 0;
            // 
            // toolStripButtons
            // 
            toolStripButtons.BackColor = SystemColors.MenuBar;
            toolStripButtons.Controls.Add(radioButtonNoise);
            toolStripButtons.Controls.Add(radioButtonCancel);
            toolStripButtons.Controls.Add(radioButtonSharpen);
            toolStripButtons.Controls.Add(radioButton4);
            toolStripButtons.Controls.Add(radioButtonAqua);
            toolStripButtons.Controls.Add(radioButtonBlackAndWhite);
            toolStripButtons.Controls.Add(radioButtonBlur);
            toolStripButtons.Enabled = false;
            toolStripButtons.Location = new Point(0, 24);
            toolStripButtons.Margin = new Padding(0);
            toolStripButtons.Name = "toolStripButtons";
            toolStripButtons.Padding = new Padding(5);
            toolStripButtons.Size = new Size(362, 74);
            toolStripButtons.TabIndex = 9;
            toolStripButtons.Visible = false;
            // 
            // radioButtonNoise
            // 
            radioButtonNoise.Appearance = Appearance.Button;
            radioButtonNoise.AutoSize = true;
            radioButtonNoise.CheckAlign = ContentAlignment.TopCenter;
            radioButtonNoise.Location = new Point(174, 39);
            radioButtonNoise.Name = "radioButtonNoise";
            radioButtonNoise.Size = new Size(43, 25);
            radioButtonNoise.TabIndex = 14;
            radioButtonNoise.Text = "Шум";
            radioButtonNoise.UseVisualStyleBackColor = true;
            radioButtonNoise.Click += ButtonClick_Noise;
            // 
            // radioButtonCancel
            // 
            radioButtonCancel.Appearance = Appearance.Button;
            radioButtonCancel.AutoSize = true;
            radioButtonCancel.CheckAlign = ContentAlignment.TopCenter;
            radioButtonCancel.Location = new Point(281, 8);
            radioButtonCancel.Name = "radioButtonCancel";
            radioButtonCancel.Size = new Size(70, 25);
            radioButtonCancel.TabIndex = 13;
            radioButtonCancel.Text = "Сбросить";
            radioButtonCancel.UseVisualStyleBackColor = true;
            radioButtonCancel.Click += ButtonClick_Cancel;
            // 
            // radioButtonSharpen
            // 
            radioButtonSharpen.Appearance = Appearance.Button;
            radioButtonSharpen.AutoSize = true;
            radioButtonSharpen.CheckAlign = ContentAlignment.TopCenter;
            radioButtonSharpen.Location = new Point(8, 39);
            radioButtonSharpen.Name = "radioButtonSharpen";
            radioButtonSharpen.Size = new Size(65, 25);
            radioButtonSharpen.TabIndex = 12;
            radioButtonSharpen.Text = "Резкость";
            radioButtonSharpen.UseVisualStyleBackColor = true;
            radioButtonSharpen.Click += ButtonClick_Sharpen;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.CheckAlign = ContentAlignment.TopCenter;
            radioButton4.Location = new Point(79, 8);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(90, 25);
            radioButton4.TabIndex = 11;
            radioButton4.Text = "Теснение";
            radioButton4.TextAlign = ContentAlignment.MiddleCenter;
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += ButtonClick_Embossing;
            // 
            // radioButtonAqua
            // 
            radioButtonAqua.Appearance = Appearance.Button;
            radioButtonAqua.AutoSize = true;
            radioButtonAqua.CheckAlign = ContentAlignment.TopCenter;
            radioButtonAqua.Location = new Point(174, 8);
            radioButtonAqua.Name = "radioButtonAqua";
            radioButtonAqua.Size = new Size(101, 25);
            radioButtonAqua.TabIndex = 10;
            radioButtonAqua.Text = "Акварелизация";
            radioButtonAqua.UseVisualStyleBackColor = true;
            radioButtonAqua.Click += ButtonClick_Aqua;
            // 
            // radioButtonBlackAndWhite
            // 
            radioButtonBlackAndWhite.Appearance = Appearance.Button;
            radioButtonBlackAndWhite.AutoSize = true;
            radioButtonBlackAndWhite.CheckAlign = ContentAlignment.TopCenter;
            radioButtonBlackAndWhite.Location = new Point(79, 39);
            radioButtonBlackAndWhite.Name = "radioButtonBlackAndWhite";
            radioButtonBlackAndWhite.Size = new Size(90, 25);
            radioButtonBlackAndWhite.TabIndex = 9;
            radioButtonBlackAndWhite.Text = "Черно-белое";
            radioButtonBlackAndWhite.UseVisualStyleBackColor = true;
            radioButtonBlackAndWhite.Click += ButtonClick_BlackWhite;
            // 
            // radioButtonBlur
            // 
            radioButtonBlur.Appearance = Appearance.Button;
            radioButtonBlur.AutoSize = true;
            radioButtonBlur.CheckAlign = ContentAlignment.TopCenter;
            radioButtonBlur.Location = new Point(8, 8);
            radioButtonBlur.Name = "radioButtonBlur";
            radioButtonBlur.Size = new Size(64, 25);
            radioButtonBlur.TabIndex = 8;
            radioButtonBlur.Text = "Размыть";
            radioButtonBlur.UseVisualStyleBackColor = true;
            radioButtonBlur.Click += ButtonClick_Blur;
            // 
            // pictureBoxOriginalImage
            // 
            pictureBoxOriginalImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxOriginalImage.BackColor = SystemColors.Control;
            pictureBoxOriginalImage.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxOriginalImage.ImageLocation = "";
            pictureBoxOriginalImage.Location = new Point(27, 361);
            pictureBoxOriginalImage.Margin = new Padding(0);
            pictureBoxOriginalImage.Name = "pictureBoxOriginalImage";
            pictureBoxOriginalImage.Size = new Size(387, 228);
            pictureBoxOriginalImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOriginalImage.TabIndex = 7;
            pictureBoxOriginalImage.TabStop = false;
            // 
            // pictureBoxResultImage
            // 
            pictureBoxResultImage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxResultImage.BackColor = SystemColors.Control;
            pictureBoxResultImage.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxResultImage.ImageLocation = "";
            pictureBoxResultImage.Location = new Point(484, 82);
            pictureBoxResultImage.Margin = new Padding(0);
            pictureBoxResultImage.Name = "pictureBoxResultImage";
            pictureBoxResultImage.Size = new Size(629, 507);
            pictureBoxResultImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxResultImage.TabIndex = 4;
            pictureBoxResultImage.TabStop = false;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Menu;
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.Items.AddRange(new ToolStripItem[] { stripMenuFilesItem, stripMenuToolItem });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(0);
            menuStrip.Size = new Size(1134, 24);
            menuStrip.Stretch = false;
            menuStrip.TabIndex = 5;
            menuStrip.Text = "Menu";
            // 
            // stripMenuFilesItem
            // 
            stripMenuFilesItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuOpen, toolStripSeparator1, toolStripMenuDeleteImage, toolStripSeparator, toolStripMenuSave, toolStripSeparator2, предварительныйпросмотрToolStripMenuItem, toolStripSeparator3, toolStripMenuExit });
            stripMenuFilesItem.Name = "stripMenuFilesItem";
            stripMenuFilesItem.Size = new Size(48, 24);
            stripMenuFilesItem.Text = "&Файл";
            // 
            // toolStripMenuOpen
            // 
            toolStripMenuOpen.Image = (Image)resources.GetObject("toolStripMenuOpen.Image");
            toolStripMenuOpen.ImageTransparentColor = Color.Magenta;
            toolStripMenuOpen.Name = "toolStripMenuOpen";
            toolStripMenuOpen.ShortcutKeys = Keys.Control | Keys.O;
            toolStripMenuOpen.Size = new Size(233, 22);
            toolStripMenuOpen.Text = "&Открыть";
            toolStripMenuOpen.Click += ToolStripMenuOpenFile_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(230, 6);
            // 
            // toolStripMenuDeleteImage
            // 
            toolStripMenuDeleteImage.Enabled = false;
            toolStripMenuDeleteImage.Name = "toolStripMenuDeleteImage";
            toolStripMenuDeleteImage.Size = new Size(233, 22);
            toolStripMenuDeleteImage.Text = "Удалить изображение";
            toolStripMenuDeleteImage.Click += ButtonClick_DeleteImage;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(230, 6);
            // 
            // toolStripMenuSave
            // 
            toolStripMenuSave.Image = (Image)resources.GetObject("toolStripMenuSave.Image");
            toolStripMenuSave.ImageTransparentColor = Color.Magenta;
            toolStripMenuSave.Name = "toolStripMenuSave";
            toolStripMenuSave.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuSave.Size = new Size(233, 22);
            toolStripMenuSave.Text = "&Сохранить";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(230, 6);
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            предварительныйпросмотрToolStripMenuItem.Image = (Image)resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image");
            предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            предварительныйпросмотрToolStripMenuItem.Size = new Size(233, 22);
            предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(230, 6);
            // 
            // toolStripMenuExit
            // 
            toolStripMenuExit.Name = "toolStripMenuExit";
            toolStripMenuExit.Size = new Size(233, 22);
            toolStripMenuExit.Text = "Вы&ход";
            toolStripMenuExit.Click += ButtonClick_Exit;
            // 
            // stripMenuToolItem
            // 
            stripMenuToolItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuBlur, toolStripMenuBlackAndWhite, toolStripMenuAqua, toolStripSeparator4, toolStripMenuCancel, настройкиToolStripMenuItem, параметрыToolStripMenuItem });
            stripMenuToolItem.Name = "stripMenuToolItem";
            stripMenuToolItem.Size = new Size(95, 24);
            stripMenuToolItem.Text = "&Инструменты";
            // 
            // toolStripMenuBlur
            // 
            toolStripMenuBlur.Enabled = false;
            toolStripMenuBlur.Name = "toolStripMenuBlur";
            toolStripMenuBlur.Size = new Size(196, 22);
            toolStripMenuBlur.Text = "Размытие";
            toolStripMenuBlur.Click += ButtonClick_Blur;
            // 
            // toolStripMenuBlackAndWhite
            // 
            toolStripMenuBlackAndWhite.Enabled = false;
            toolStripMenuBlackAndWhite.Name = "toolStripMenuBlackAndWhite";
            toolStripMenuBlackAndWhite.Size = new Size(196, 22);
            toolStripMenuBlackAndWhite.Text = "Черно-белое";
            toolStripMenuBlackAndWhite.Click += ButtonClick_BlackWhite;
            // 
            // toolStripMenuAqua
            // 
            toolStripMenuAqua.Enabled = false;
            toolStripMenuAqua.Name = "toolStripMenuAqua";
            toolStripMenuAqua.Size = new Size(196, 22);
            toolStripMenuAqua.Text = "Акварелизация";
            toolStripMenuAqua.Click += ButtonClick_Aqua;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(193, 6);
            // 
            // toolStripMenuCancel
            // 
            toolStripMenuCancel.Enabled = false;
            toolStripMenuCancel.Name = "toolStripMenuCancel";
            toolStripMenuCancel.Size = new Size(196, 22);
            toolStripMenuCancel.Text = "Сбросить";
            toolStripMenuCancel.Click += ButtonClick_Cancel;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(196, 22);
            настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            параметрыToolStripMenuItem.Size = new Size(196, 22);
            параметрыToolStripMenuItem.Text = "Панель инструментов";
            параметрыToolStripMenuItem.Click += ButtonClick_SetToolBar;
            // 
            // AppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 611);
            Controls.Add(panelApp);
            MinimumSize = new Size(1150, 650);
            Name = "AppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "App";
            panelApp.ResumeLayout(false);
            panelApp.PerformLayout();
            toolStripButtons.ResumeLayout(false);
            toolStripButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultImage).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelApp;
        private Panel toolStripButtons;

        private PictureBox pictureBoxResultImage;
        private PictureBox pictureBoxOriginalImage;

        private MenuStrip menuStrip;

        private ToolStripMenuItem stripMenuFilesItem;
        private ToolStripMenuItem toolStripMenuOpen;
        private ToolStripMenuItem toolStripMenuSave;
        private ToolStripMenuItem toolStripMenuExit;
        private ToolStripMenuItem stripMenuToolItem;

        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;

        private ToolStripMenuItem toolStripMenuDeleteImage;
        private ToolStripMenuItem toolStripMenuBlur;
        private ToolStripMenuItem toolStripMenuBlackAndWhite;
        private ToolStripMenuItem toolStripMenuAqua;

        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator;

        private RadioButton radioButtonBlur;
        private RadioButton radioButton4;
        private RadioButton radioButtonAqua;
        private RadioButton radioButtonBlackAndWhite;
        private ToolStripMenuItem toolStripMenuCancel;
        private RadioButton radioButtonSharpen;
        private RadioButton radioButtonCancel;
        private RadioButton radioButtonNoise;
    }
}