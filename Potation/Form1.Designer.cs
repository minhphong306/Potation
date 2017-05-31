namespace Potation {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbPotation = new System.Windows.Forms.Label();
            this.potationPanel = new System.Windows.Forms.Panel();
            this.notifyPotation = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxPotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.potationPanel.SuspendLayout();
            this.ctxPotation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPotation
            // 
            this.lbPotation.AutoSize = true;
            this.lbPotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPotation.ForeColor = System.Drawing.Color.Red;
            this.lbPotation.Location = new System.Drawing.Point(14, 25);
            this.lbPotation.Name = "lbPotation";
            this.lbPotation.Size = new System.Drawing.Size(649, 46);
            this.lbPotation.TabIndex = 0;
            this.lbPotation.Text = "Do what you love, love what you do";
            this.lbPotation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.lbPotation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.lbPotation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // potationPanel
            // 
            this.potationPanel.BackColor = System.Drawing.Color.Transparent;
            this.potationPanel.Controls.Add(this.lbPotation);
            this.potationPanel.Location = new System.Drawing.Point(12, 32);
            this.potationPanel.Name = "potationPanel";
            this.potationPanel.Size = new System.Drawing.Size(675, 77);
            this.potationPanel.TabIndex = 1;
            this.potationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.potationPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.potationPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // notifyPotation
            // 
            this.notifyPotation.ContextMenuStrip = this.ctxPotation;
            this.notifyPotation.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyPotation.Icon")));
            this.notifyPotation.Text = "Potation - version 1.0";
            this.notifyPotation.Visible = true;
            // 
            // ctxPotation
            // 
            this.ctxPotation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxConfig,
            this.ctxExit});
            this.ctxPotation.Name = "ctxPotation";
            this.ctxPotation.Size = new System.Drawing.Size(153, 70);
            // 
            // ctxConfig
            // 
            this.ctxConfig.Name = "ctxConfig";
            this.ctxConfig.Size = new System.Drawing.Size(152, 22);
            this.ctxConfig.Text = "Cấu hình";
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(152, 22);
            this.ctxExit.Text = "Thoát";
            this.ctxExit.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 118);
            this.Controls.Add(this.potationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.potationPanel.ResumeLayout(false);
            this.potationPanel.PerformLayout();
            this.ctxPotation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPotation;
        private System.Windows.Forms.Panel potationPanel;
        private System.Windows.Forms.NotifyIcon notifyPotation;
        private System.Windows.Forms.ContextMenuStrip ctxPotation;
        private System.Windows.Forms.ToolStripMenuItem ctxConfig;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
    }
}

