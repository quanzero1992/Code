namespace eReview01.Source.Framework
{
     partial class FormMasterBase
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
            this.cmsBase = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cteNew = new System.Windows.Forms.ToolStripMenuItem();
            this.cteEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cteDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cteRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBase = new System.Windows.Forms.MenuStrip();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsBase.SuspendLayout();
            this.mnuBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsBase
            // 
            this.cmsBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cteNew,
            this.cteEdit,
            this.cteDelete,
            this.cteRefresh});
            this.cmsBase.Name = "contextMenuStrip1";
            this.cmsBase.Size = new System.Drawing.Size(106, 92);
            this.cmsBase.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsBase_ItemClicked);
            // 
            // cteNew
            // 
            this.cteNew.Image = global::eReview01.Properties.Resources.ADD1;
            this.cteNew.Name = "cteNew";
            this.cteNew.Size = new System.Drawing.Size(105, 22);
            this.cteNew.Text = "Thêm";
            // 
            // cteEdit
            // 
            this.cteEdit.Image = global::eReview01.Properties.Resources.editmode;
            this.cteEdit.Name = "cteEdit";
            this.cteEdit.Size = new System.Drawing.Size(105, 22);
            this.cteEdit.Text = "Xem";
            // 
            // cteDelete
            // 
            this.cteDelete.Image = global::eReview01.Properties.Resources.Delete16;
            this.cteDelete.Name = "cteDelete";
            this.cteDelete.Size = new System.Drawing.Size(105, 22);
            this.cteDelete.Text = "Xóa";
            // 
            // cteRefresh
            // 
            this.cteRefresh.Image = global::eReview01.Properties.Resources.RefreshDocViewHS;
            this.cteRefresh.Name = "cteRefresh";
            this.cteRefresh.Size = new System.Drawing.Size(105, 22);
            this.cteRefresh.Text = "Nạp";
            // 
            // mnuBase
            // 
            this.mnuBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuEdit,
            this.mnuDelete,
            this.mnuRefesh});
            this.mnuBase.Location = new System.Drawing.Point(0, 0);
            this.mnuBase.Name = "mnuBase";
            this.mnuBase.ShowItemToolTips = true;
            this.mnuBase.Size = new System.Drawing.Size(284, 24);
            this.mnuBase.TabIndex = 1;
            this.mnuBase.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuContext_ItemClicked);
            // 
            // mnuNew
            // 
            this.mnuNew.Image = global::eReview01.Properties.Resources.ADD1;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeyDisplayString = "Ctrl+N";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(66, 20);
            this.mnuNew.Text = "Thêm";
            this.mnuNew.ToolTipText = "Ctrl+N";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Image = global::eReview01.Properties.Resources.editmode;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.ShortcutKeyDisplayString = "Ctrl+E";
            this.mnuEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuEdit.Size = new System.Drawing.Size(59, 20);
            this.mnuEdit.Text = "Xem";
            this.mnuEdit.ToolTipText = "Ctrl+E";
            // 
            // mnuDelete
            // 
            this.mnuDelete.Image = global::eReview01.Properties.Resources.Delete16;
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.ShortcutKeyDisplayString = "Del";
            this.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuDelete.Size = new System.Drawing.Size(55, 20);
            this.mnuDelete.Text = "Xóa";
            this.mnuDelete.ToolTipText = "Del";
            // 
            // mnuRefesh
            // 
            this.mnuRefesh.Image = global::eReview01.Properties.Resources.RefreshDocViewHS;
            this.mnuRefesh.Name = "mnuRefesh";
            this.mnuRefesh.ShortcutKeyDisplayString = "F5";
            this.mnuRefesh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuRefesh.Size = new System.Drawing.Size(57, 20);
            this.mnuRefesh.Text = "Nạp";
            this.mnuRefesh.ToolTipText = "F5";
            // 
            // FormMasterBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mnuBase);
            this.MainMenuStrip = this.mnuBase;
            this.Name = "FormMasterBase";
            this.ShowIcon = false;
            this.Text = "Master form";
            this.Load += new System.EventHandler(this.MasterFormBase_Load);
            this.Shown += new System.EventHandler(this.FormMasterBase_Shown);
            this.cmsBase.ResumeLayout(false);
            this.mnuBase.ResumeLayout(false);
            this.mnuBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cteNew;
        private System.Windows.Forms.ToolStripMenuItem cteEdit;
        private System.Windows.Forms.ToolStripMenuItem cteDelete;
        public System.Windows.Forms.ContextMenuStrip cmsBase;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuRefesh;
        private System.Windows.Forms.ToolStripMenuItem cteRefresh;
        public System.Windows.Forms.MenuStrip mnuBase;


    }
}
