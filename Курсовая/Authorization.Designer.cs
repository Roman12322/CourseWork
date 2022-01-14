
namespace Курсовая
{
    partial class Authorization
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthLogBox = new System.Windows.Forms.TextBox();
            this.AuthPassBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.CreateAcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // AuthLogBox
            // 
            this.AuthLogBox.Location = new System.Drawing.Point(80, 49);
            this.AuthLogBox.Name = "AuthLogBox";
            this.AuthLogBox.Size = new System.Drawing.Size(131, 20);
            this.AuthLogBox.TabIndex = 2;
            // 
            // AuthPassBox
            // 
            this.AuthPassBox.Location = new System.Drawing.Point(80, 85);
            this.AuthPassBox.Name = "AuthPassBox";
            this.AuthPassBox.PasswordChar = '*';
            this.AuthPassBox.Size = new System.Drawing.Size(131, 20);
            this.AuthPassBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "AUTHORIZATION";
            // 
            // AuthButton
            // 
            this.AuthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthButton.Location = new System.Drawing.Point(136, 140);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(75, 23);
            this.AuthButton.TabIndex = 5;
            this.AuthButton.Text = "Sign In";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // CreateAcc
            // 
            this.CreateAcc.AutoSize = true;
            this.CreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAcc.Location = new System.Drawing.Point(12, 145);
            this.CreateAcc.Name = "CreateAcc";
            this.CreateAcc.Size = new System.Drawing.Size(71, 13);
            this.CreateAcc.TabIndex = 6;
            this.CreateAcc.Text = "New account";
            this.CreateAcc.Click += new System.EventHandler(this.CreateAcc_Click);
            // 
            // Authorization
            // 
            this.ClientSize = new System.Drawing.Size(221, 175);
            this.Controls.Add(this.CreateAcc);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AuthPassBox);
            this.Controls.Add(this.AuthLogBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AuthLogBox;
        private System.Windows.Forms.TextBox AuthPassBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Label CreateAcc;
    }
}