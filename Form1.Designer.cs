using System.Windows.Forms;

namespace laboration3_TextEditor
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTxbx = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nyttToolStripMenuItem
            // 
            this.nyttToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nyttToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem2,
            this.öppnaToolStripMenuItem,
            this.sparaToolStripMenuItem,
            this.sparaSomToolStripMenuItem});
            this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
            this.nyttToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.nyttToolStripMenuItem.Text = "Arkiv";
            // 
            // nyttToolStripMenuItem2
            // 
            this.nyttToolStripMenuItem2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nyttToolStripMenuItem2.Name = "nyttToolStripMenuItem2";
            this.nyttToolStripMenuItem2.Size = new System.Drawing.Size(162, 26);
            this.nyttToolStripMenuItem2.Text = "Nytt";
            this.nyttToolStripMenuItem2.Click += new System.EventHandler(this.nyttToolStripMenuItem2_Click);
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.öppnaToolStripMenuItem_Click);
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.sparaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.sparaSomToolStripMenuItem.Text = "Spara som";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.sparaSomToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // WindowTxbx
            // 
            this.WindowTxbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowTxbx.Location = new System.Drawing.Point(0, 28);
            this.WindowTxbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WindowTxbx.Multiline = true;
            this.WindowTxbx.Name = "WindowTxbx";
            this.WindowTxbx.Size = new System.Drawing.Size(736, 210);
            this.WindowTxbx.TabIndex = 1;
            this.WindowTxbx.TextChanged += new System.EventHandler(this.WindowTxbx_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 212);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(214, 20);
            this.toolStripStatusLabel1.Text = "Antal tecken (med mellanslag):";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(213, 20);
            this.toolStripStatusLabel2.Text = "Antal tecken (utan mellanslag):";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(74, 20);
            this.toolStripStatusLabel3.Text = "Antal ord:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(86, 20);
            this.toolStripStatusLabel4.Text = "Antal rader:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 238);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.WindowTxbx);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(754, 281);
            this.Name = "Form1";
            this.Text = "Namnlös.txt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.textEditWin_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nyttToolStripMenuItem;
        private ToolStripMenuItem nyttToolStripMenuItem2;
        private ToolStripMenuItem öppnaToolStripMenuItem;
        private ToolStripMenuItem sparaToolStripMenuItem;
        private ToolStripMenuItem sparaSomToolStripMenuItem;
        private TextBox WindowTxbx;
        private ToolStripMenuItem avslutaToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
    }
}