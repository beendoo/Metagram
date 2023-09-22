namespace MergeClient
{
    partial class Login1
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
            this.login_back = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.port_text = new System.Windows.Forms.Label();
            this.ip_text = new System.Windows.Forms.Label();
            this.port_box = new System.Windows.Forms.TextBox();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.sign_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.pw_text = new System.Windows.Forms.Label();
            this.id_text = new System.Windows.Forms.Label();
            this.pw_box = new System.Windows.Forms.TextBox();
            this.id_box = new System.Windows.Forms.TextBox();
            this.login_back.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_back
            // 
            this.login_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.login_back.Controls.Add(this.button1);
            this.login_back.Controls.Add(this.port_text);
            this.login_back.Controls.Add(this.ip_text);
            this.login_back.Controls.Add(this.port_box);
            this.login_back.Controls.Add(this.ip_box);
            this.login_back.Controls.Add(this.close_button);
            this.login_back.Controls.Add(this.sign_button);
            this.login_back.Controls.Add(this.login_button);
            this.login_back.Controls.Add(this.pw_text);
            this.login_back.Controls.Add(this.id_text);
            this.login_back.Controls.Add(this.pw_box);
            this.login_back.Controls.Add(this.id_box);
            this.login_back.Location = new System.Drawing.Point(-7, -52);
            this.login_back.Name = "login_back";
            this.login_back.Size = new System.Drawing.Size(409, 560);
            this.login_back.TabIndex = 1;
            this.login_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.login_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseMove);
            this.login_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(293, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 18;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // port_text
            // 
            this.port_text.AutoSize = true;
            this.port_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.port_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.port_text.Location = new System.Drawing.Point(33, 265);
            this.port_text.Name = "port_text";
            this.port_text.Size = new System.Drawing.Size(68, 19);
            this.port_text.TabIndex = 17;
            this.port_text.Text = "PORT";
            // 
            // ip_text
            // 
            this.ip_text.AutoSize = true;
            this.ip_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.ip_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.ip_text.Location = new System.Drawing.Point(71, 205);
            this.ip_text.Name = "ip_text";
            this.ip_text.Size = new System.Drawing.Size(30, 19);
            this.ip_text.TabIndex = 16;
            this.ip_text.Text = "IP";
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.port_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.port_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.port_box.Location = new System.Drawing.Point(112, 260);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(180, 29);
            this.port_box.TabIndex = 15;
            this.port_box.Text = "7000";
            this.port_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ip_box
            // 
            this.ip_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.ip_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.ip_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ip_box.Location = new System.Drawing.Point(112, 200);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(181, 29);
            this.ip_box.TabIndex = 14;
            this.ip_box.Text = "192.168.100.48";
            this.ip_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.close_button.Location = new System.Drawing.Point(338, 64);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(39, 31);
            this.close_button.TabIndex = 13;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // sign_button
            // 
            this.sign_button.AutoEllipsis = true;
            this.sign_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.sign_button.FlatAppearance.BorderSize = 0;
            this.sign_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.sign_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.sign_button.Location = new System.Drawing.Point(204, 454);
            this.sign_button.Name = "sign_button";
            this.sign_button.Size = new System.Drawing.Size(120, 47);
            this.sign_button.TabIndex = 6;
            this.sign_button.Text = "Sign up";
            this.sign_button.UseVisualStyleBackColor = false;
            this.sign_button.Click += new System.EventHandler(this.sign_button_Click);
            // 
            // login_button
            // 
            this.login_button.AutoEllipsis = true;
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.login_button.Location = new System.Drawing.Point(78, 454);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(120, 47);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // pw_text
            // 
            this.pw_text.AutoSize = true;
            this.pw_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.pw_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.pw_text.Location = new System.Drawing.Point(59, 383);
            this.pw_text.Name = "pw_text";
            this.pw_text.Size = new System.Drawing.Size(42, 19);
            this.pw_text.TabIndex = 4;
            this.pw_text.Text = "PW";
            // 
            // id_text
            // 
            this.id_text.AutoSize = true;
            this.id_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.id_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.id_text.Location = new System.Drawing.Point(70, 323);
            this.id_text.Name = "id_text";
            this.id_text.Size = new System.Drawing.Size(31, 19);
            this.id_text.TabIndex = 3;
            this.id_text.Text = "ID";
            // 
            // pw_box
            // 
            this.pw_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.pw_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.pw_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pw_box.Location = new System.Drawing.Point(111, 378);
            this.pw_box.Name = "pw_box";
            this.pw_box.PasswordChar = '*';
            this.pw_box.Size = new System.Drawing.Size(180, 29);
            this.pw_box.TabIndex = 2;
            this.pw_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_box
            // 
            this.id_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.id_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.id_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.id_box.Location = new System.Drawing.Point(111, 318);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(181, 29);
            this.id_box.TabIndex = 1;
            this.id_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 500);
            this.Controls.Add(this.login_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login1";
            this.Text = "Form1";
            this.login_back.ResumeLayout(false);
            this.login_back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_back;
        private System.Windows.Forms.Button sign_button;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label pw_text;
        private System.Windows.Forms.Label id_text;
        private System.Windows.Forms.TextBox pw_box;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label port_text;
        private System.Windows.Forms.Label ip_text;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Button button1;
    }
}

