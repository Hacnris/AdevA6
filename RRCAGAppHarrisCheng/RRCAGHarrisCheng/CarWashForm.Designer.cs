
namespace RRCAGHarrisCheng
{
    partial class CarWashForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGeninvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.comboPackage = new System.Windows.Forms.ComboBox();
            this.lbPackage = new System.Windows.Forms.Label();
            this.comboFrag = new System.Windows.Forms.ComboBox();
            this.lbFrag = new System.Windows.Forms.Label();
            this.lboxInter = new System.Windows.Forms.ListBox();
            this.lbInter = new System.Windows.Forms.Label();
            this.lboxExter = new System.Windows.Forms.ListBox();
            this.lbExter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbsubBox = new System.Windows.Forms.Label();
            this.lbSubtotal = new System.Windows.Forms.Label();
            this.lbPSTBox = new System.Windows.Forms.Label();
            this.lbPST = new System.Windows.Forms.Label();
            this.lbGSTBox = new System.Windows.Forms.Label();
            this.lbTotalBox = new System.Windows.Forms.Label();
            this.lbGST = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGeninvoice,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuGeninvoice
            // 
            this.mnuGeninvoice.Name = "mnuGeninvoice";
            this.mnuGeninvoice.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuGeninvoice.Size = new System.Drawing.Size(289, 26);
            this.mnuGeninvoice.Text = "Generate &Invoice";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(289, 26);
            this.mnuExit.Text = "E&xit";
            // 
            // comboPackage
            // 
            this.comboPackage.FormattingEnabled = true;
            this.comboPackage.Location = new System.Drawing.Point(31, 81);
            this.comboPackage.Name = "comboPackage";
            this.comboPackage.Size = new System.Drawing.Size(193, 24);
            this.comboPackage.TabIndex = 1;
            // 
            // lbPackage
            // 
            this.lbPackage.AutoSize = true;
            this.lbPackage.Location = new System.Drawing.Point(28, 45);
            this.lbPackage.Name = "lbPackage";
            this.lbPackage.Size = new System.Drawing.Size(67, 17);
            this.lbPackage.TabIndex = 2;
            this.lbPackage.Text = "Package:";
            // 
            // comboFrag
            // 
            this.comboFrag.FormattingEnabled = true;
            this.comboFrag.Location = new System.Drawing.Point(281, 81);
            this.comboFrag.Name = "comboFrag";
            this.comboFrag.Size = new System.Drawing.Size(193, 24);
            this.comboFrag.TabIndex = 3;
            // 
            // lbFrag
            // 
            this.lbFrag.AutoSize = true;
            this.lbFrag.Location = new System.Drawing.Point(278, 45);
            this.lbFrag.Name = "lbFrag";
            this.lbFrag.Size = new System.Drawing.Size(77, 17);
            this.lbFrag.TabIndex = 4;
            this.lbFrag.Text = "Fragrance:";
            // 
            // lboxInter
            // 
            this.lboxInter.FormattingEnabled = true;
            this.lboxInter.ItemHeight = 16;
            this.lboxInter.Location = new System.Drawing.Point(14, 57);
            this.lboxInter.Name = "lboxInter";
            this.lboxInter.Size = new System.Drawing.Size(193, 132);
            this.lboxInter.TabIndex = 5;
            // 
            // lbInter
            // 
            this.lbInter.AutoSize = true;
            this.lbInter.Location = new System.Drawing.Point(11, 25);
            this.lbInter.Name = "lbInter";
            this.lbInter.Size = new System.Drawing.Size(56, 17);
            this.lbInter.TabIndex = 6;
            this.lbInter.Text = "Interior:";
            // 
            // lboxExter
            // 
            this.lboxExter.FormattingEnabled = true;
            this.lboxExter.ItemHeight = 16;
            this.lboxExter.Location = new System.Drawing.Point(264, 57);
            this.lboxExter.Name = "lboxExter";
            this.lboxExter.Size = new System.Drawing.Size(193, 132);
            this.lboxExter.TabIndex = 7;
            // 
            // lbExter
            // 
            this.lbExter.AutoSize = true;
            this.lbExter.Location = new System.Drawing.Point(261, 25);
            this.lbExter.Name = "lbExter";
            this.lbExter.Size = new System.Drawing.Size(60, 17);
            this.lbExter.TabIndex = 8;
            this.lbExter.Text = "Exterior:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbExter);
            this.groupBox1.Controls.Add(this.lboxExter);
            this.groupBox1.Controls.Add(this.lbInter);
            this.groupBox1.Controls.Add(this.lboxInter);
            this.groupBox1.Location = new System.Drawing.Point(17, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 242);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // lbsubBox
            // 
            this.lbsubBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbsubBox.Location = new System.Drawing.Point(372, 424);
            this.lbsubBox.Name = "lbsubBox";
            this.lbsubBox.Size = new System.Drawing.Size(131, 35);
            this.lbsubBox.TabIndex = 10;
            // 
            // lbSubtotal
            // 
            this.lbSubtotal.AutoSize = true;
            this.lbSubtotal.Location = new System.Drawing.Point(302, 433);
            this.lbSubtotal.Name = "lbSubtotal";
            this.lbSubtotal.Size = new System.Drawing.Size(64, 17);
            this.lbSubtotal.TabIndex = 11;
            this.lbSubtotal.Text = "Subtotal:";
            // 
            // lbPSTBox
            // 
            this.lbPSTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbPSTBox.Location = new System.Drawing.Point(372, 475);
            this.lbPSTBox.Name = "lbPSTBox";
            this.lbPSTBox.Size = new System.Drawing.Size(131, 35);
            this.lbPSTBox.TabIndex = 12;
            // 
            // lbPST
            // 
            this.lbPST.AutoSize = true;
            this.lbPST.Location = new System.Drawing.Point(327, 484);
            this.lbPST.Name = "lbPST";
            this.lbPST.Size = new System.Drawing.Size(39, 17);
            this.lbPST.TabIndex = 13;
            this.lbPST.Text = "PST:";
            // 
            // lbGSTBox
            // 
            this.lbGSTBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGSTBox.Location = new System.Drawing.Point(372, 525);
            this.lbGSTBox.Name = "lbGSTBox";
            this.lbGSTBox.Size = new System.Drawing.Size(131, 35);
            this.lbGSTBox.TabIndex = 14;
            // 
            // lbTotalBox
            // 
            this.lbTotalBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTotalBox.Location = new System.Drawing.Point(372, 573);
            this.lbTotalBox.Name = "lbTotalBox";
            this.lbTotalBox.Size = new System.Drawing.Size(131, 35);
            this.lbTotalBox.TabIndex = 15;
            // 
            // lbGST
            // 
            this.lbGST.AutoSize = true;
            this.lbGST.Location = new System.Drawing.Point(327, 534);
            this.lbGST.Name = "lbGST";
            this.lbGST.Size = new System.Drawing.Size(41, 17);
            this.lbGST.TabIndex = 16;
            this.lbGST.Text = "GST:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(328, 582);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 17);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "Total";
            // 
            // CarWashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 649);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbGST);
            this.Controls.Add(this.lbTotalBox);
            this.Controls.Add(this.lbGSTBox);
            this.Controls.Add(this.lbPST);
            this.Controls.Add(this.lbPSTBox);
            this.Controls.Add(this.lbSubtotal);
            this.Controls.Add(this.lbsubBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbFrag);
            this.Controls.Add(this.comboFrag);
            this.Controls.Add(this.lbPackage);
            this.Controls.Add(this.comboPackage);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "CarWashForm";
            this.Text = "Car Wash";
            this.Load += new System.EventHandler(this.CarWashForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuGeninvoice;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox comboPackage;
        private System.Windows.Forms.Label lbPackage;
        private System.Windows.Forms.ComboBox comboFrag;
        private System.Windows.Forms.Label lbFrag;
        private System.Windows.Forms.ListBox lboxInter;
        private System.Windows.Forms.Label lbInter;
        private System.Windows.Forms.ListBox lboxExter;
        private System.Windows.Forms.Label lbExter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbsubBox;
        private System.Windows.Forms.Label lbSubtotal;
        private System.Windows.Forms.Label lbPSTBox;
        private System.Windows.Forms.Label lbPST;
        private System.Windows.Forms.Label lbGSTBox;
        private System.Windows.Forms.Label lbTotalBox;
        private System.Windows.Forms.Label lbGST;
        private System.Windows.Forms.Label lbTotal;
    }
}