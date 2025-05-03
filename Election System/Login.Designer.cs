namespace Election_System
{
    partial class Login
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
            this.voters_id_login = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // voters_id_login
            // 
            this.voters_id_login.Location = new System.Drawing.Point(38, 115);
            this.voters_id_login.Name = "voters_id_login";
            this.voters_id_login.Size = new System.Drawing.Size(127, 20);
            this.voters_id_login.TabIndex = 1;
            this.voters_id_login.TextChanged += new System.EventHandler(this.voters_id_login_TextChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(38, 141);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome back, Students!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Don\'t have an account yet?";
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(183, 181);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 467);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.voters_id_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox voters_id_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_register;
    }
}

