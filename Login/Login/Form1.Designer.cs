
namespace Login
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
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbMatkau = new System.Windows.Forms.Label();
            this.textbotmatkhau = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxusername
            // 
            this.textboxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxusername.Location = new System.Drawing.Point(328, 105);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(303, 34);
            this.textboxusername.TabIndex = 0;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(125, 110);
            this.lbUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(183, 29);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Tên Đăng Nhập";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // lbMatkau
            // 
            this.lbMatkau.AutoSize = true;
            this.lbMatkau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatkau.Location = new System.Drawing.Point(196, 213);
            this.lbMatkau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatkau.Name = "lbMatkau";
            this.lbMatkau.Size = new System.Drawing.Size(113, 29);
            this.lbMatkau.TabIndex = 3;
            this.lbMatkau.Text = "Mật Khẩu";
            this.lbMatkau.Click += new System.EventHandler(this.label1_Click);
            // 
            // textbotmatkhau
            // 
            this.textbotmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbotmatkhau.Location = new System.Drawing.Point(328, 208);
            this.textbotmatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbotmatkhau.Name = "textbotmatkhau";
            this.textbotmatkhau.Size = new System.Drawing.Size(303, 34);
            this.textbotmatkhau.TabIndex = 2;
            this.textbotmatkhau.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(373, 279);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(172, 50);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 682);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbMatkau);
            this.Controls.Add(this.textbotmatkhau);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.textboxusername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxusername;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbMatkau;
        private System.Windows.Forms.TextBox textbotmatkhau;
        private System.Windows.Forms.Button btnLogin;
    }
}

