namespace _PasswordGenerator_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Passwordbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.CheckBox();
            this.ten = new System.Windows.Forms.CheckBox();
            this.sixteen = new System.Windows.Forms.CheckBox();
            this.twenty = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check the desired length of new password\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Your new password:";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Password.Location = new System.Drawing.Point(228, 273);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(293, 23);
            this.Password.TabIndex = 7;
            // 
            // Passwordbtn
            // 
            this.Passwordbtn.Location = new System.Drawing.Point(228, 172);
            this.Passwordbtn.Name = "Passwordbtn";
            this.Passwordbtn.Size = new System.Drawing.Size(93, 48);
            this.Passwordbtn.TabIndex = 8;
            this.Passwordbtn.Text = "Get New Password";
            this.Passwordbtn.UseVisualStyleBackColor = true;
            this.Passwordbtn.Click += new System.EventHandler(this.Passwordbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Location = new System.Drawing.Point(170, 326);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(75, 23);
            this.Clearbtn.TabIndex = 9;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(331, 326);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(75, 23);
            this.Exitbtn.TabIndex = 10;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // eight
            // 
            this.eight.AutoSize = true;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(110, 86);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(126, 20);
            this.eight.TabIndex = 11;
            this.eight.Text = "8 characters...";
            this.eight.UseVisualStyleBackColor = true;
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.Location = new System.Drawing.Point(110, 131);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(134, 20);
            this.ten.TabIndex = 12;
            this.ten.Text = "10 characters...";
            this.ten.UseVisualStyleBackColor = true;
            // 
            // sixteen
            // 
            this.sixteen.AutoSize = true;
            this.sixteen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixteen.Location = new System.Drawing.Point(290, 86);
            this.sixteen.Name = "sixteen";
            this.sixteen.Size = new System.Drawing.Size(134, 20);
            this.sixteen.TabIndex = 13;
            this.sixteen.Text = "16 characters...";
            this.sixteen.UseVisualStyleBackColor = true;
            // 
            // twenty
            // 
            this.twenty.AutoSize = true;
            this.twenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twenty.Location = new System.Drawing.Point(290, 131);
            this.twenty.Name = "twenty";
            this.twenty.Size = new System.Drawing.Size(134, 20);
            this.twenty.TabIndex = 14;
            this.twenty.Text = "20 characters...";
            this.twenty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 370);
            this.Controls.Add(this.twenty);
            this.Controls.Add(this.sixteen);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Passwordbtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Password Generator....";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Passwordbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.CheckBox eight;
        private System.Windows.Forms.CheckBox ten;
        private System.Windows.Forms.CheckBox sixteen;
        private System.Windows.Forms.CheckBox twenty;
    }
}

