namespace Potation {
    partial class frmSetting {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.lbPotation = new System.Windows.Forms.Label();
            this.potationPanel = new System.Windows.Forms.Panel();
            this.notifyPotation = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctxPotation = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChooseFont = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnChooseBackground = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.potationPanel.SuspendLayout();
            this.ctxPotation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPotation
            // 
            this.lbPotation.AutoSize = true;
            this.lbPotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbPotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPotation.ForeColor = System.Drawing.Color.Red;
            this.lbPotation.Location = new System.Drawing.Point(34, 18);
            this.lbPotation.Name = "lbPotation";
            this.lbPotation.Size = new System.Drawing.Size(551, 39);
            this.lbPotation.TabIndex = 0;
            this.lbPotation.Text = "Do what you love, love what you do";
            // 
            // potationPanel
            // 
            this.potationPanel.BackColor = System.Drawing.Color.Transparent;
            this.potationPanel.Controls.Add(this.lbPotation);
            this.potationPanel.Location = new System.Drawing.Point(6, 25);
            this.potationPanel.Name = "potationPanel";
            this.potationPanel.Size = new System.Drawing.Size(679, 83);
            this.potationPanel.TabIndex = 2;
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
            this.ctxPotation.Size = new System.Drawing.Size(123, 48);
            // 
            // ctxConfig
            // 
            this.ctxConfig.Name = "ctxConfig";
            this.ctxConfig.Size = new System.Drawing.Size(122, 22);
            this.ctxConfig.Text = "Cấu hình";
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(122, 22);
            this.ctxExit.Text = "Thoát";
            // 
            // btnChooseFont
            // 
            this.btnChooseFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFont.Location = new System.Drawing.Point(242, 126);
            this.btnChooseFont.Name = "btnChooseFont";
            this.btnChooseFont.Size = new System.Drawing.Size(97, 40);
            this.btnChooseFont.TabIndex = 3;
            this.btnChooseFont.Text = "Chọn font";
            this.btnChooseFont.UseVisualStyleBackColor = true;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseColor.Location = new System.Drawing.Point(365, 126);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(97, 40);
            this.btnChooseColor.TabIndex = 3;
            this.btnChooseColor.Text = "Chọn màu";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            // 
            // btnChooseBackground
            // 
            this.btnChooseBackground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseBackground.Location = new System.Drawing.Point(487, 126);
            this.btnChooseBackground.Name = "btnChooseBackground";
            this.btnChooseBackground.Size = new System.Drawing.Size(131, 40);
            this.btnChooseBackground.TabIndex = 3;
            this.btnChooseBackground.Text = "Chọn ảnh nền";
            this.btnChooseBackground.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChooseBackground);
            this.groupBox1.Controls.Add(this.btnChooseColor);
            this.groupBox1.Controls.Add(this.potationPanel);
            this.groupBox1.Controls.Add(this.btnChooseFont);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 474);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chương trình";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSetting
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(719, 555);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frmSetting";
            this.Text = "Cấu hình chương trình Potation";
            this.potationPanel.ResumeLayout(false);
            this.potationPanel.PerformLayout();
            this.ctxPotation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPotation;
        private System.Windows.Forms.Panel potationPanel;
        private System.Windows.Forms.NotifyIcon notifyPotation;
        private System.Windows.Forms.ContextMenuStrip ctxPotation;
        private System.Windows.Forms.ToolStripMenuItem ctxConfig;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
        private System.Windows.Forms.Button btnChooseFont;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnChooseBackground;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}