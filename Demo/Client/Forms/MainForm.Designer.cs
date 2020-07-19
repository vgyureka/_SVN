namespace Client.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SystemtabControl = new System.Windows.Forms.TabControl();
            this.controls = new System.Windows.Forms.TabPage();
            this.ClienttabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelClientName = new System.Windows.Forms.Panel();
            this.CurrentSetuplabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExportButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.detailUserControl1 = new Client.Controls.DetailUserControl();
            this.SystemtabControl.SuspendLayout();
            this.controls.SuspendLayout();
            this.ClienttabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelClientName.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemtabControl
            // 
            this.SystemtabControl.Controls.Add(this.controls);
            this.SystemtabControl.Controls.Add(this.tabPage2);
            this.SystemtabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemtabControl.Location = new System.Drawing.Point(0, 0);
            this.SystemtabControl.Name = "SystemtabControl";
            this.SystemtabControl.SelectedIndex = 0;
            this.SystemtabControl.Size = new System.Drawing.Size(972, 450);
            this.SystemtabControl.TabIndex = 0;
            // 
            // controls
            // 
            this.controls.Controls.Add(this.ClienttabControl);
            this.controls.Controls.Add(this.panelClientName);
            this.controls.Controls.Add(this.toolStrip1);
            this.controls.Location = new System.Drawing.Point(4, 22);
            this.controls.Name = "controls";
            this.controls.Padding = new System.Windows.Forms.Padding(3);
            this.controls.Size = new System.Drawing.Size(964, 424);
            this.controls.TabIndex = 0;
            this.controls.Text = "tabPage1";
            this.controls.UseVisualStyleBackColor = true;
            // 
            // ClienttabControl
            // 
            this.ClienttabControl.Controls.Add(this.tabPage1);
            this.ClienttabControl.Controls.Add(this.tabPage3);
            this.ClienttabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClienttabControl.Location = new System.Drawing.Point(3, 115);
            this.ClienttabControl.Name = "ClienttabControl";
            this.ClienttabControl.SelectedIndex = 0;
            this.ClienttabControl.Size = new System.Drawing.Size(958, 306);
            this.ClienttabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.detailUserControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(950, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(950, 280);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelClientName
            // 
            this.panelClientName.Controls.Add(this.CurrentSetuplabel);
            this.panelClientName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClientName.Location = new System.Drawing.Point(3, 57);
            this.panelClientName.Name = "panelClientName";
            this.panelClientName.Size = new System.Drawing.Size(958, 58);
            this.panelClientName.TabIndex = 1;
            // 
            // CurrentSetuplabel
            // 
            this.CurrentSetuplabel.AutoSize = true;
            this.CurrentSetuplabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentSetuplabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CurrentSetuplabel.Location = new System.Drawing.Point(14, 17);
            this.CurrentSetuplabel.Name = "CurrentSetuplabel";
            this.CurrentSetuplabel.Size = new System.Drawing.Size(116, 25);
            this.CurrentSetuplabel.TabIndex = 0;
            this.CurrentSetuplabel.Text = "Client Name";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.toolStripSeparator1,
            this.OpenSplitButton,
            this.toolStripSeparator2,
            this.ExportButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(958, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(36, 51);
            this.NewButton.Text = "New";
            this.NewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // OpenSplitButton
            // 
            this.OpenSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenSplitButton.Image")));
            this.OpenSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenSplitButton.Name = "OpenSplitButton";
            this.OpenSplitButton.Size = new System.Drawing.Size(48, 51);
            this.OpenSplitButton.Text = "Open";
            this.OpenSplitButton.ButtonClick += new System.EventHandler(this.OpenSplitButton_ButtonClick);
            this.OpenSplitButton.DropDownOpening += new System.EventHandler(this.OpenSplitButton_DropDownOpening);
            this.OpenSplitButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OpenSplitButton_DropDownItemClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // ExportButton
            // 
            this.ExportButton.Image = ((System.Drawing.Image)(resources.GetObject("ExportButton.Image")));
            this.ExportButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(44, 51);
            this.ExportButton.Text = "Export";
            this.ExportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // detailUserControl1
            // 
            this.detailUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailUserControl1.Location = new System.Drawing.Point(3, 3);
            this.detailUserControl1.Name = "detailUserControl1";
            this.detailUserControl1.Size = new System.Drawing.Size(944, 274);
            this.detailUserControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.SystemtabControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.SystemtabControl.ResumeLayout(false);
            this.controls.ResumeLayout(false);
            this.controls.PerformLayout();
            this.ClienttabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelClientName.ResumeLayout(false);
            this.panelClientName.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SystemtabControl;
        private System.Windows.Forms.TabPage controls;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton OpenSplitButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ExportButton;
        private System.Windows.Forms.Panel panelClientName;
        private System.Windows.Forms.Label CurrentSetuplabel;
        private System.Windows.Forms.TabControl ClienttabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private Controls.DetailUserControl detailUserControl1;
    }
}