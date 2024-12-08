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
            pictureBoxOriginalImage = new PictureBox();
            pictureBoxResultImage = new PictureBox();
            toolStripButtons = new ToolStrip();
            toolStripBlurButton = new ToolStripButton();
            toolStripWandBButton = new ToolStripButton();
            toolStripAquaButton = new ToolStripButton();
            menuStrip = new MenuStrip();
            stripMenuFilesItem = new ToolStripMenuItem();
            toolStripMenuOpen = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripMenuClear = new ToolStripMenuItem();
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
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            параметрыToolStripMenuItem = new ToolStripMenuItem();
            StripMenuReferenceItem = new ToolStripMenuItem();
            содержимоеToolStripMenuItem = new ToolStripMenuItem();
            индексToolStripMenuItem = new ToolStripMenuItem();
            поискToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultImage).BeginInit();
            toolStripButtons.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelApp
            // 
            panelApp.BackColor = SystemColors.ActiveBorder;
            panelApp.Controls.Add(pictureBoxOriginalImage);
            panelApp.Controls.Add(pictureBoxResultImage);
            panelApp.Controls.Add(toolStripButtons);
            panelApp.Controls.Add(menuStrip);
            panelApp.Dock = DockStyle.Fill;
            panelApp.Location = new Point(0, 0);
            panelApp.Name = "panelApp";
            panelApp.Padding = new Padding(0, 0, 0, 10);
            panelApp.Size = new Size(1134, 611);
            panelApp.TabIndex = 0;
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
            // toolStripButtons
            // 
            toolStripButtons.AutoSize = false;
            toolStripButtons.BackColor = SystemColors.Menu;
            toolStripButtons.Enabled = false;
            toolStripButtons.GripStyle = ToolStripGripStyle.Hidden;
            toolStripButtons.Items.AddRange(new ToolStripItem[] { toolStripBlurButton, toolStripWandBButton, toolStripAquaButton });
            toolStripButtons.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStripButtons.Location = new Point(0, 24);
            toolStripButtons.Name = "toolStripButtons";
            toolStripButtons.Padding = new Padding(0);
            toolStripButtons.RenderMode = ToolStripRenderMode.Professional;
            toolStripButtons.Size = new Size(1134, 34);
            toolStripButtons.Stretch = true;
            toolStripButtons.TabIndex = 6;
            // 
            // toolStripBlurButton
            // 
            toolStripBlurButton.AutoSize = false;
            toolStripBlurButton.AutoToolTip = false;
            toolStripBlurButton.BackColor = SystemColors.Control;
            toolStripBlurButton.BackgroundImageLayout = ImageLayout.Stretch;
            toolStripBlurButton.Checked = true;
            toolStripBlurButton.CheckState = CheckState.Indeterminate;
            toolStripBlurButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBlurButton.ImageAlign = ContentAlignment.BottomCenter;
            toolStripBlurButton.ImageTransparentColor = Color.Magenta;
            toolStripBlurButton.Margin = new Padding(10);
            toolStripBlurButton.Name = "toolStripBlurButton";
            toolStripBlurButton.RightToLeft = RightToLeft.No;
            toolStripBlurButton.Size = new Size(65, 25);
            toolStripBlurButton.Text = "Размытие";
            toolStripBlurButton.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripBlurButton.ToolTipText = "Размытие";
            toolStripBlurButton.Click += ButtonBlur_Click;
            // 
            // toolStripWandBButton
            // 
            toolStripWandBButton.AutoSize = false;
            toolStripWandBButton.BackColor = SystemColors.ControlDarkDark;
            toolStripWandBButton.BackgroundImageLayout = ImageLayout.Zoom;
            toolStripWandBButton.Checked = true;
            toolStripWandBButton.CheckOnClick = true;
            toolStripWandBButton.CheckState = CheckState.Checked;
            toolStripWandBButton.ImageTransparentColor = Color.Magenta;
            toolStripWandBButton.Margin = new Padding(10);
            toolStripWandBButton.Name = "toolStripWandBButton";
            toolStripWandBButton.Size = new Size(84, 25);
            toolStripWandBButton.Text = "Черно-белое";
            toolStripWandBButton.TextDirection = ToolStripTextDirection.Horizontal;
            toolStripWandBButton.ToolTipText = "Черно-белое";
            toolStripWandBButton.Click += ButtonBlackWhite_Click;
            // 
            // toolStripAquaButton
            // 
            toolStripAquaButton.AutoSize = false;
            toolStripAquaButton.Checked = true;
            toolStripAquaButton.CheckState = CheckState.Indeterminate;
            toolStripAquaButton.ImageTransparentColor = Color.Magenta;
            toolStripAquaButton.Margin = new Padding(10, 10, 0, 10);
            toolStripAquaButton.Name = "toolStripAquaButton";
            toolStripAquaButton.Size = new Size(95, 25);
            toolStripAquaButton.Text = "Акварелизация";
            toolStripAquaButton.TextDirection = ToolStripTextDirection.Horizontal;
            toolStripAquaButton.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripAquaButton.ToolTipText = "Акварель";
            toolStripAquaButton.Click += toolStripAquaButton_Click;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Menu;
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.Items.AddRange(new ToolStripItem[] { stripMenuFilesItem, stripMenuToolItem, StripMenuReferenceItem });
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
            stripMenuFilesItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuOpen, toolStripSeparator1, toolStripMenuClear, toolStripSeparator, toolStripMenuSave, toolStripSeparator2, предварительныйпросмотрToolStripMenuItem, toolStripSeparator3, toolStripMenuExit });
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
            // toolStripMenuClear
            // 
            toolStripMenuClear.Enabled = false;
            toolStripMenuClear.Name = "toolStripMenuClear";
            toolStripMenuClear.Size = new Size(233, 22);
            toolStripMenuClear.Text = "Очистить";
            toolStripMenuClear.Click += ToolStripMenuIClear_Click;
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
            toolStripMenuExit.Click += ExitToolStripMenuItem_Click;
            // 
            // stripMenuToolItem
            // 
            stripMenuToolItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuBlur, toolStripMenuBlackAndWhite, toolStripMenuAqua, toolStripSeparator4, настройкиToolStripMenuItem, параметрыToolStripMenuItem });
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
            toolStripMenuBlur.Click += ButtonBlur_Click;
            // 
            // toolStripMenuBlackAndWhite
            // 
            toolStripMenuBlackAndWhite.Enabled = false;
            toolStripMenuBlackAndWhite.Name = "toolStripMenuBlackAndWhite";
            toolStripMenuBlackAndWhite.Size = new Size(196, 22);
            toolStripMenuBlackAndWhite.Text = "Черно-белое";
            toolStripMenuBlackAndWhite.Click += ButtonBlackWhite_Click;
            // 
            // toolStripMenuAqua
            // 
            toolStripMenuAqua.Enabled = false;
            toolStripMenuAqua.Name = "toolStripMenuAqua";
            toolStripMenuAqua.Size = new Size(196, 22);
            toolStripMenuAqua.Text = "Акварелизация";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(193, 6);
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
            параметрыToolStripMenuItem.Click += ToolStripMenuToolBar_Click;
            // 
            // StripMenuReferenceItem
            // 
            StripMenuReferenceItem.DropDownItems.AddRange(new ToolStripItem[] { содержимоеToolStripMenuItem, индексToolStripMenuItem, поискToolStripMenuItem, toolStripSeparator6, aboutToolStripMenuItem });
            StripMenuReferenceItem.Name = "StripMenuReferenceItem";
            StripMenuReferenceItem.Size = new Size(65, 24);
            StripMenuReferenceItem.Text = "&Справка";
            // 
            // содержимоеToolStripMenuItem
            // 
            содержимоеToolStripMenuItem.Name = "содержимоеToolStripMenuItem";
            содержимоеToolStripMenuItem.Size = new Size(158, 22);
            содержимоеToolStripMenuItem.Text = "&Содержимое";
            // 
            // индексToolStripMenuItem
            // 
            индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            индексToolStripMenuItem.Size = new Size(158, 22);
            индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            поискToolStripMenuItem.Size = new Size(158, 22);
            поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(155, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(158, 22);
            aboutToolStripMenuItem.Text = "&О программе…";
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginalImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultImage).EndInit();
            toolStripButtons.ResumeLayout(false);
            toolStripButtons.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelApp;
        private PictureBox pictureBoxResultImage;
        private MenuStrip menuStrip;
        private ToolStripMenuItem stripMenuFilesItem;
        private ToolStripMenuItem toolStripMenuOpen;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem toolStripMenuSave;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuExit;
        private ToolStripMenuItem stripMenuToolItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem StripMenuReferenceItem;
        private ToolStripMenuItem содержимоеToolStripMenuItem;
        private ToolStripMenuItem индексToolStripMenuItem;
        private ToolStripMenuItem поискToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStripButtons;
        private ToolStripButton toolStripBlurButton;
        private ToolStripButton toolStripWandBButton;
        private ToolStripButton toolStripAquaButton;
        private PictureBox pictureBoxOriginalImage;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuClear;
        private ToolStripMenuItem toolStripMenuBlur;
        private ToolStripMenuItem toolStripMenuBlackAndWhite;
        private ToolStripMenuItem toolStripMenuAqua;
        private ToolStripSeparator toolStripSeparator4;
    }
}