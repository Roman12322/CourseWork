
namespace Курсовая
{
    partial class Calculator
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
            this.FirstCalcUp = new System.Windows.Forms.TextBox();
            this.FirstCalcDown = new System.Windows.Forms.TextBox();
            this.SecondCalcUp = new System.Windows.Forms.TextBox();
            this.SecondCalcDown = new System.Windows.Forms.TextBox();
            this.AnsBoxUp = new System.Windows.Forms.TextBox();
            this.AnsBoxDwn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Summing = new System.Windows.Forms.Button();
            this.TakingOff = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstCalcUp
            // 
            this.FirstCalcUp.Location = new System.Drawing.Point(106, 16);
            this.FirstCalcUp.Name = "FirstCalcUp";
            this.FirstCalcUp.Size = new System.Drawing.Size(100, 20);
            this.FirstCalcUp.TabIndex = 2;
            this.FirstCalcUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstCalcUp_KeyPress);
            // 
            // FirstCalcDown
            // 
            this.FirstCalcDown.Location = new System.Drawing.Point(106, 54);
            this.FirstCalcDown.Name = "FirstCalcDown";
            this.FirstCalcDown.Size = new System.Drawing.Size(100, 20);
            this.FirstCalcDown.TabIndex = 3;
            this.FirstCalcDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstCalcDown_KeyPress);
            // 
            // SecondCalcUp
            // 
            this.SecondCalcUp.Location = new System.Drawing.Point(331, 17);
            this.SecondCalcUp.Name = "SecondCalcUp";
            this.SecondCalcUp.Size = new System.Drawing.Size(100, 20);
            this.SecondCalcUp.TabIndex = 4;
            this.SecondCalcUp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondCalcUp_KeyPress);
            // 
            // SecondCalcDown
            // 
            this.SecondCalcDown.Location = new System.Drawing.Point(331, 54);
            this.SecondCalcDown.Name = "SecondCalcDown";
            this.SecondCalcDown.Size = new System.Drawing.Size(100, 20);
            this.SecondCalcDown.TabIndex = 5;
            this.SecondCalcDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondCalcDown_KeyPress);
            // 
            // AnsBoxUp
            // 
            this.AnsBoxUp.Location = new System.Drawing.Point(554, 17);
            this.AnsBoxUp.Name = "AnsBoxUp";
            this.AnsBoxUp.Size = new System.Drawing.Size(100, 20);
            this.AnsBoxUp.TabIndex = 6;
            // 
            // AnsBoxDwn
            // 
            this.AnsBoxDwn.Location = new System.Drawing.Point(554, 54);
            this.AnsBoxDwn.Name = "AnsBoxDwn";
            this.AnsBoxDwn.Size = new System.Drawing.Size(100, 20);
            this.AnsBoxDwn.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First element up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First element down";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Second element up";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Second element down";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Answer up";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Answer down";
            // 
            // Summing
            // 
            this.Summing.Location = new System.Drawing.Point(596, 260);
            this.Summing.Name = "Summing";
            this.Summing.Size = new System.Drawing.Size(58, 23);
            this.Summing.TabIndex = 14;
            this.Summing.Text = "Summing";
            this.Summing.UseVisualStyleBackColor = true;
            this.Summing.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // TakingOff
            // 
            this.TakingOff.Location = new System.Drawing.Point(527, 260);
            this.TakingOff.Name = "TakingOff";
            this.TakingOff.Size = new System.Drawing.Size(63, 23);
            this.TakingOff.TabIndex = 15;
            this.TakingOff.Text = "Take Off";
            this.TakingOff.UseVisualStyleBackColor = true;
            this.TakingOff.Click += new System.EventHandler(this.TakingOff_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(8, 90);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(467, 193);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 16;
            this.PictureBox.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(478, 260);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(43, 23);
            this.saveButton.TabIndex = 17;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 295);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.TakingOff);
            this.Controls.Add(this.Summing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnsBoxDwn);
            this.Controls.Add(this.AnsBoxUp);
            this.Controls.Add(this.SecondCalcDown);
            this.Controls.Add(this.SecondCalcUp);
            this.Controls.Add(this.FirstCalcDown);
            this.Controls.Add(this.FirstCalcUp);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FirstCalcUp;
        private System.Windows.Forms.TextBox FirstCalcDown;
        private System.Windows.Forms.TextBox SecondCalcUp;
        private System.Windows.Forms.TextBox SecondCalcDown;
        private System.Windows.Forms.TextBox AnsBoxUp;
        private System.Windows.Forms.TextBox AnsBoxDwn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Summing;
        private System.Windows.Forms.Button TakingOff;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button saveButton;
    }
}