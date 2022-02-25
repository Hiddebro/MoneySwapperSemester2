
namespace moneyswapper
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
            this.BtnOsrsToRs3 = new System.Windows.Forms.Button();
            this.TbOsrsMoney = new System.Windows.Forms.TextBox();
            this.LbOsrsMoney = new System.Windows.Forms.Label();
            this.LbRs3Money = new System.Windows.Forms.Label();
            this.BtnRs3ToOsrs = new System.Windows.Forms.Button();
            this.TbRs3Money = new System.Windows.Forms.TextBox();
            this.LbPreviewOsrsToRs3Swap = new System.Windows.Forms.Label();
            this.LbPreviewRs3ToOsrsSwap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOsrsToRs3
            // 
            this.BtnOsrsToRs3.Location = new System.Drawing.Point(241, 45);
            this.BtnOsrsToRs3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOsrsToRs3.Name = "BtnOsrsToRs3";
            this.BtnOsrsToRs3.Size = new System.Drawing.Size(138, 31);
            this.BtnOsrsToRs3.TabIndex = 0;
            this.BtnOsrsToRs3.Text = "Swap Osrs to Rs3";
            this.BtnOsrsToRs3.UseVisualStyleBackColor = true;
            this.BtnOsrsToRs3.Click += new System.EventHandler(this.BtnOsrsToRs3_Click);
            // 
            // TbOsrsMoney
            // 
            this.TbOsrsMoney.ForeColor = System.Drawing.Color.LightGray;
            this.TbOsrsMoney.Location = new System.Drawing.Point(241, 109);
            this.TbOsrsMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbOsrsMoney.Name = "TbOsrsMoney";
            this.TbOsrsMoney.Size = new System.Drawing.Size(129, 27);
            this.TbOsrsMoney.TabIndex = 1;
            this.TbOsrsMoney.Text = "Osrs amount";
            this.TbOsrsMoney.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbOsrsMoney_MouseClick);
            this.TbOsrsMoney.TextChanged += new System.EventHandler(this.TbOsrsMoney_TextChanged);
            // 
            // LbOsrsMoney
            // 
            this.LbOsrsMoney.AutoSize = true;
            this.LbOsrsMoney.Location = new System.Drawing.Point(241, 175);
            this.LbOsrsMoney.Name = "LbOsrsMoney";
            this.LbOsrsMoney.Size = new System.Drawing.Size(17, 20);
            this.LbOsrsMoney.TabIndex = 2;
            this.LbOsrsMoney.Text = "0";
            // 
            // LbRs3Money
            // 
            this.LbRs3Money.AutoSize = true;
            this.LbRs3Money.Location = new System.Drawing.Point(422, 175);
            this.LbRs3Money.Name = "LbRs3Money";
            this.LbRs3Money.Size = new System.Drawing.Size(17, 20);
            this.LbRs3Money.TabIndex = 3;
            this.LbRs3Money.Text = "0";
            // 
            // BtnRs3ToOsrs
            // 
            this.BtnRs3ToOsrs.Location = new System.Drawing.Point(422, 45);
            this.BtnRs3ToOsrs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRs3ToOsrs.Name = "BtnRs3ToOsrs";
            this.BtnRs3ToOsrs.Size = new System.Drawing.Size(139, 31);
            this.BtnRs3ToOsrs.TabIndex = 4;
            this.BtnRs3ToOsrs.Text = "Swap Rs3 to Osrs";
            this.BtnRs3ToOsrs.UseVisualStyleBackColor = true;
            this.BtnRs3ToOsrs.Click += new System.EventHandler(this.BtnRs3ToOsrs_Click);
            // 
            // TbRs3Money
            // 
            this.TbRs3Money.ForeColor = System.Drawing.Color.LightGray;
            this.TbRs3Money.Location = new System.Drawing.Point(422, 109);
            this.TbRs3Money.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TbRs3Money.Name = "TbRs3Money";
            this.TbRs3Money.Size = new System.Drawing.Size(127, 27);
            this.TbRs3Money.TabIndex = 5;
            this.TbRs3Money.Text = "Rs3 amount";
            this.TbRs3Money.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TbRs3Money_MouseClick);
            this.TbRs3Money.TextChanged += new System.EventHandler(this.TbRs3Money_TextChanged);
            // 
            // LbPreviewOsrsToRs3Swap
            // 
            this.LbPreviewOsrsToRs3Swap.AutoSize = true;
            this.LbPreviewOsrsToRs3Swap.Location = new System.Drawing.Point(77, 116);
            this.LbPreviewOsrsToRs3Swap.Name = "LbPreviewOsrsToRs3Swap";
            this.LbPreviewOsrsToRs3Swap.Size = new System.Drawing.Size(17, 20);
            this.LbPreviewOsrsToRs3Swap.TabIndex = 6;
            this.LbPreviewOsrsToRs3Swap.Text = "0";
            // 
            // LbPreviewRs3ToOsrsSwap
            // 
            this.LbPreviewRs3ToOsrsSwap.AutoSize = true;
            this.LbPreviewRs3ToOsrsSwap.Location = new System.Drawing.Point(571, 116);
            this.LbPreviewRs3ToOsrsSwap.Name = "LbPreviewRs3ToOsrsSwap";
            this.LbPreviewRs3ToOsrsSwap.Size = new System.Drawing.Size(17, 20);
            this.LbPreviewRs3ToOsrsSwap.TabIndex = 7;
            this.LbPreviewRs3ToOsrsSwap.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "New RS3 balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "New OSRS balance:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 604);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BtnOsrsToRs3);
            this.tabPage2.Controls.Add(this.LbPreviewRs3ToOsrsSwap);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.BtnRs3ToOsrs);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.LbRs3Money);
            this.tabPage2.Controls.Add(this.TbRs3Money);
            this.tabPage2.Controls.Add(this.LbOsrsMoney);
            this.tabPage2.Controls.Add(this.LbPreviewOsrsToRs3Swap);
            this.tabPage2.Controls.Add(this.TbOsrsMoney);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rs3 balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Osrs balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOsrsToRs3;
        public System.Windows.Forms.TextBox TbOsrsMoney;
        public System.Windows.Forms.Label LbOsrsMoney;
        public System.Windows.Forms.Label LbRs3Money;
        private System.Windows.Forms.Button BtnRs3ToOsrs;
        public System.Windows.Forms.TextBox TbRs3Money;
        private System.Windows.Forms.Label LbPreviewOsrsToRs3Swap;
        private System.Windows.Forms.Label LbPreviewRs3ToOsrsSwap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

