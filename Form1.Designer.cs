namespace CalculatorGUI
{
    partial class Form1
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
            this.EuroText = new System.Windows.Forms.TextBox();
            this.BGNText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Convert_Click = new System.Windows.Forms.Button();
            this.newAmountBGN = new System.Windows.Forms.Label();
            this.newAmountEuro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EuroText
            // 
            this.EuroText.Location = new System.Drawing.Point(210, 103);
            this.EuroText.Name = "EuroText";
            this.EuroText.Size = new System.Drawing.Size(100, 31);
            this.EuroText.TabIndex = 0;
            // 
            // BGNText
            // 
            this.BGNText.Location = new System.Drawing.Point(210, 220);
            this.BGNText.Name = "BGNText";
            this.BGNText.Size = new System.Drawing.Size(100, 31);
            this.BGNText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Euro to BGN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "BGN to Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(483, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 7;
            // 
            // Convert_Click
            // 
            this.Convert_Click.Location = new System.Drawing.Point(565, 373);
            this.Convert_Click.Name = "Convert_Click";
            this.Convert_Click.Size = new System.Drawing.Size(133, 43);
            this.Convert_Click.TabIndex = 8;
            this.Convert_Click.Text = "Convert";
            this.Convert_Click.UseVisualStyleBackColor = true;
            this.Convert_Click.Click += new System.EventHandler(this.Convert_Click_Click);
            // 
            // newAmountBGN
            // 
            this.newAmountBGN.AutoSize = true;
            this.newAmountBGN.Location = new System.Drawing.Point(469, 103);
            this.newAmountBGN.Name = "newAmountBGN";
            this.newAmountBGN.Size = new System.Drawing.Size(19, 25);
            this.newAmountBGN.TabIndex = 9;
            this.newAmountBGN.Text = "-";
            // 
            // newAmountEuro
            // 
            this.newAmountEuro.AutoSize = true;
            this.newAmountEuro.Location = new System.Drawing.Point(475, 226);
            this.newAmountEuro.Name = "newAmountEuro";
            this.newAmountEuro.Size = new System.Drawing.Size(19, 25);
            this.newAmountEuro.TabIndex = 10;
            this.newAmountEuro.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newAmountEuro);
            this.Controls.Add(this.newAmountBGN);
            this.Controls.Add(this.Convert_Click);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BGNText);
            this.Controls.Add(this.EuroText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EuroText;
        private System.Windows.Forms.TextBox BGNText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Convert_Click;
        private System.Windows.Forms.Label newAmountBGN;
        private System.Windows.Forms.Label newAmountEuro;
    }
}

