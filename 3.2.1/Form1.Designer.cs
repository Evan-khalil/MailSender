namespace _3._2._1
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
            this.SendBtn = new System.Windows.Forms.Button();
            this.FromTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ToTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MessageTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.Label();
            this.ServerTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.Enabled = false;
            this.SendBtn.Location = new System.Drawing.Point(175, 501);
            this.SendBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(310, 57);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // FromTxtBox
            // 
            this.FromTxtBox.Location = new System.Drawing.Point(175, 84);
            this.FromTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.FromTxtBox.Name = "FromTxtBox";
            this.FromTxtBox.Size = new System.Drawing.Size(312, 26);
            this.FromTxtBox.TabIndex = 1;
            this.FromTxtBox.TextChanged += new System.EventHandler(this.From_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // ToTxtBox
            // 
            this.ToTxtBox.Location = new System.Drawing.Point(175, 161);
            this.ToTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ToTxtBox.Name = "ToTxtBox";
            this.ToTxtBox.Size = new System.Drawing.Size(312, 26);
            this.ToTxtBox.TabIndex = 3;
            this.ToTxtBox.TextChanged += new System.EventHandler(this.To_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subject";
            // 
            // SubjectTxtBox
            // 
            this.SubjectTxtBox.Location = new System.Drawing.Point(175, 211);
            this.SubjectTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.SubjectTxtBox.Name = "SubjectTxtBox";
            this.SubjectTxtBox.Size = new System.Drawing.Size(312, 26);
            this.SubjectTxtBox.TabIndex = 5;
            this.SubjectTxtBox.TextChanged += new System.EventHandler(this.Sub_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message";
            // 
            // MessageTxtBox
            // 
            this.MessageTxtBox.Location = new System.Drawing.Point(175, 255);
            this.MessageTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.MessageTxtBox.Multiline = true;
            this.MessageTxtBox.Name = "MessageTxtBox";
            this.MessageTxtBox.Size = new System.Drawing.Size(312, 235);
            this.MessageTxtBox.TabIndex = 7;
            this.MessageTxtBox.TextChanged += new System.EventHandler(this.Message_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(175, 123);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.PasswordChar = '*';
            this.PasswordTxtBox.Size = new System.Drawing.Size(312, 26);
            this.PasswordTxtBox.TabIndex = 9;
            this.PasswordTxtBox.TextChanged += new System.EventHandler(this.Pass_TextChanged);
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(88, 43);
            this.Server.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(55, 20);
            this.Server.TabIndex = 12;
            this.Server.Text = "Server";
            // 
            // ServerTxtBox
            // 
            this.ServerTxtBox.Location = new System.Drawing.Point(175, 41);
            this.ServerTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.ServerTxtBox.Name = "ServerTxtBox";
            this.ServerTxtBox.Size = new System.Drawing.Size(312, 26);
            this.ServerTxtBox.TabIndex = 11;
            this.ServerTxtBox.TextChanged += new System.EventHandler(this.Server_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 795);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.ServerTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MessageTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubjectTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ToTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FromTxtBox);
            this.Controls.Add(this.SendBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Mail Sender";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox FromTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ToTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MessageTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.TextBox ServerTxtBox;
    }
}

