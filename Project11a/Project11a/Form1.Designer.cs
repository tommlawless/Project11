namespace Project11a
{
    partial class project11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(project11));
            this.menuStripBook = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBooksByPublisher = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFindRecordMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFindByCode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFindByName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFirst = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLast = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.menuStripBook.SuspendLayout();
            this.toolStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripBook
            // 
            this.menuStripBook.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFileMenu,
            this.toolStripMenuItemEditMenu,
            this.toolStripMenuItemFindRecordMenu});
            this.menuStripBook.Location = new System.Drawing.Point(0, 0);
            this.menuStripBook.Name = "menuStripBook";
            this.menuStripBook.Size = new System.Drawing.Size(315, 24);
            this.menuStripBook.TabIndex = 16;
            this.menuStripBook.Text = "menuStrip1";
            // 
            // toolStripMenuItemFileMenu
            // 
            this.toolStripMenuItemFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBooksByPublisher,
            this.toolStripMenuItemExit});
            this.toolStripMenuItemFileMenu.Name = "toolStripMenuItemFileMenu";
            this.toolStripMenuItemFileMenu.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFileMenu.Text = "File";
            // 
            // toolStripMenuItemBooksByPublisher
            // 
            this.toolStripMenuItemBooksByPublisher.Name = "toolStripMenuItemBooksByPublisher";
            this.toolStripMenuItemBooksByPublisher.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemBooksByPublisher.Text = "Books by Publisher";
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ToolStripMenuItemExit_Click);
            // 
            // toolStripMenuItemEditMenu
            // 
            this.toolStripMenuItemEditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemNew,
            this.toolStripMenuItemEdit,
            this.toolStripMenuItemUpdate,
            this.toolStripMenuItemCancel,
            this.toolStripMenuItemDelete});
            this.toolStripMenuItemEditMenu.Name = "toolStripMenuItemEditMenu";
            this.toolStripMenuItemEditMenu.Size = new System.Drawing.Size(39, 20);
            this.toolStripMenuItemEditMenu.Text = "Edit";
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemNew.Text = "New";
            // 
            // toolStripMenuItemEdit
            // 
            this.toolStripMenuItemEdit.Name = "toolStripMenuItemEdit";
            this.toolStripMenuItemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuItemEdit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemEdit.Text = "Edit";
            // 
            // toolStripMenuItemUpdate
            // 
            this.toolStripMenuItemUpdate.Name = "toolStripMenuItemUpdate";
            this.toolStripMenuItemUpdate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.toolStripMenuItemUpdate.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemUpdate.Text = "Update";
            // 
            // toolStripMenuItemCancel
            // 
            this.toolStripMenuItemCancel.Name = "toolStripMenuItemCancel";
            this.toolStripMenuItemCancel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItemCancel.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemCancel.Text = "Cancel";
            // 
            // toolStripMenuItemDelete
            // 
            this.toolStripMenuItemDelete.Name = "toolStripMenuItemDelete";
            this.toolStripMenuItemDelete.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.toolStripMenuItemDelete.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemDelete.Text = "Delete";
            // 
            // toolStripMenuItemFindRecordMenu
            // 
            this.toolStripMenuItemFindRecordMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFindByCode,
            this.toolStripMenuItemFindByName});
            this.toolStripMenuItemFindRecordMenu.Name = "toolStripMenuItemFindRecordMenu";
            this.toolStripMenuItemFindRecordMenu.Size = new System.Drawing.Size(82, 20);
            this.toolStripMenuItemFindRecordMenu.Text = "Find Record";
            // 
            // toolStripMenuItemFindByCode
            // 
            this.toolStripMenuItemFindByCode.Name = "toolStripMenuItemFindByCode";
            this.toolStripMenuItemFindByCode.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItemFindByCode.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemFindByCode.Text = "Find by Code";
            // 
            // toolStripMenuItemFindByName
            // 
            this.toolStripMenuItemFindByName.Name = "toolStripMenuItemFindByName";
            this.toolStripMenuItemFindByName.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
            this.toolStripMenuItemFindByName.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItemFindByName.Text = "Find by Name";
            // 
            // toolStripButtons
            // 
            this.toolStripButtons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFirst,
            this.toolStripButtonPrevious,
            this.toolStripButtonNext,
            this.toolStripButtonLast});
            this.toolStripButtons.Location = new System.Drawing.Point(0, 24);
            this.toolStripButtons.Name = "toolStripButtons";
            this.toolStripButtons.Size = new System.Drawing.Size(315, 27);
            this.toolStripButtons.TabIndex = 17;
            this.toolStripButtons.Text = "toolStrip1";
            // 
            // toolStripButtonFirst
            // 
            this.toolStripButtonFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFirst.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFirst.Image")));
            this.toolStripButtonFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFirst.Name = "toolStripButtonFirst";
            this.toolStripButtonFirst.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonFirst.Text = "toolStripButton1";
            this.toolStripButtonFirst.ToolTipText = "First";
            // 
            // toolStripButtonPrevious
            // 
            this.toolStripButtonPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrevious.Image")));
            this.toolStripButtonPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrevious.Name = "toolStripButtonPrevious";
            this.toolStripButtonPrevious.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonPrevious.Text = "toolStripButton2";
            this.toolStripButtonPrevious.ToolTipText = "Previous";
            // 
            // toolStripButtonNext
            // 
            this.toolStripButtonNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNext.Image")));
            this.toolStripButtonNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNext.Name = "toolStripButtonNext";
            this.toolStripButtonNext.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonNext.Text = "toolStripButton3";
            this.toolStripButtonNext.ToolTipText = "Next";
            // 
            // toolStripButtonLast
            // 
            this.toolStripButtonLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLast.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLast.Image")));
            this.toolStripButtonLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLast.Name = "toolStripButtonLast";
            this.toolStripButtonLast.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonLast.Text = "toolStripButton4";
            this.toolStripButtonLast.ToolTipText = "Last";
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 272);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(315, 22);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(41, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Price ($)";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(85, 80);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(187, 20);
            this.textBoxTitle.TabIndex = 22;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(85, 120);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(187, 20);
            this.textBoxType.TabIndex = 23;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(85, 160);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(187, 20);
            this.textBoxPrice.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(32, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Code";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(85, 194);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(187, 20);
            this.textBoxCode.TabIndex = 26;
            // 
            // project11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 294);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStripButtons);
            this.Controls.Add(this.menuStripBook);
            this.Name = "project11";
            this.Text = "Project 11";
            this.Load += new System.EventHandler(this.project11_Load);
            this.menuStripBook.ResumeLayout(false);
            this.menuStripBook.PerformLayout();
            this.toolStripButtons.ResumeLayout(false);
            this.toolStripButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripBook;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFileMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBooksByPublisher;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFindRecordMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFindByCode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFindByName;
        private System.Windows.Forms.ToolStrip toolStripButtons;
        private System.Windows.Forms.ToolStripButton toolStripButtonFirst;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrevious;
        private System.Windows.Forms.ToolStripButton toolStripButtonNext;
        private System.Windows.Forms.ToolStripButton toolStripButtonLast;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCode;
    }
}

