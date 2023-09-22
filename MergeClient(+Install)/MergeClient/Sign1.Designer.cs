namespace MergeClient
{
    partial class Sign1
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
            this.sign1_back = new System.Windows.Forms.Panel();
            this.port_box = new System.Windows.Forms.TextBox();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.create_button = new System.Windows.Forms.Button();
            this.newpw_text = new System.Windows.Forms.Label();
            this.newid_text = new System.Windows.Forms.Label();
            this.newpw_box = new System.Windows.Forms.TextBox();
            this.newid_box = new System.Windows.Forms.TextBox();
            this.sign1_back.SuspendLayout();
            this.SuspendLayout();
            // 
            // sign1_back
            // 
            this.sign1_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.sign1_back.Controls.Add(this.port_box);
            this.sign1_back.Controls.Add(this.ip_box);
            this.sign1_back.Controls.Add(this.button1);
            this.sign1_back.Controls.Add(this.close_button);
            this.sign1_back.Controls.Add(this.create_button);
            this.sign1_back.Controls.Add(this.newpw_text);
            this.sign1_back.Controls.Add(this.newid_text);
            this.sign1_back.Controls.Add(this.newpw_box);
            this.sign1_back.Controls.Add(this.newid_box);
            this.sign1_back.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sign1_back.Location = new System.Drawing.Point(-5, -6);
            this.sign1_back.Name = "sign1_back";
            this.sign1_back.Size = new System.Drawing.Size(393, 413);
            this.sign1_back.TabIndex = 1;
            this.sign1_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.sign1_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseMove);
            this.sign1_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseUp);
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.port_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port_box.Font = new System.Drawing.Font("Gulim", 15F);
            this.port_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.port_box.Location = new System.Drawing.Point(111, 119);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(180, 29);
            this.port_box.TabIndex = 21;
            // 
            // ip_box
            // 
            this.ip_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.ip_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip_box.Font = new System.Drawing.Font("Gulim", 15F);
            this.ip_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.ip_box.Location = new System.Drawing.Point(111, 84);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(181, 29);
            this.ip_box.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(291, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.close_button.Location = new System.Drawing.Point(336, 18);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(39, 31);
            this.close_button.TabIndex = 12;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // create_button
            // 
            this.create_button.AutoEllipsis = true;
            this.create_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.create_button.FlatAppearance.BorderSize = 0;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.create_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.create_button.Location = new System.Drawing.Point(72, 314);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(251, 47);
            this.create_button.TabIndex = 11;
            this.create_button.Text = "Create Account";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // newpw_text
            // 
            this.newpw_text.AutoSize = true;
            this.newpw_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.newpw_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.newpw_text.Location = new System.Drawing.Point(59, 243);
            this.newpw_text.Name = "newpw_text";
            this.newpw_text.Size = new System.Drawing.Size(42, 19);
            this.newpw_text.TabIndex = 10;
            this.newpw_text.Text = "PW";
            // 
            // newid_text
            // 
            this.newid_text.AutoSize = true;
            this.newid_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.newid_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.newid_text.Location = new System.Drawing.Point(70, 183);
            this.newid_text.Name = "newid_text";
            this.newid_text.Size = new System.Drawing.Size(31, 19);
            this.newid_text.TabIndex = 9;
            this.newid_text.Text = "ID";
            // 
            // newpw_box
            // 
            this.newpw_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.newpw_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpw_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.newpw_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newpw_box.Location = new System.Drawing.Point(111, 238);
            this.newpw_box.Name = "newpw_box";
            this.newpw_box.PasswordChar = '*';
            this.newpw_box.Size = new System.Drawing.Size(180, 29);
            this.newpw_box.TabIndex = 8;
            this.newpw_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newid_box
            // 
            this.newid_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.newid_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newid_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.newid_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newid_box.Location = new System.Drawing.Point(111, 178);
            this.newid_box.Name = "newid_box";
            this.newid_box.Size = new System.Drawing.Size(181, 29);
            this.newid_box.TabIndex = 7;
            this.newid_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sign1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 400);
            this.Controls.Add(this.sign1_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign1";
            this.Text = "Sign1";
            this.sign1_back.ResumeLayout(false);
            this.sign1_back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sign1_back;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label newpw_text;
        private System.Windows.Forms.Label newid_text;
        private System.Windows.Forms.TextBox newpw_box;
        private System.Windows.Forms.TextBox newid_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.TextBox ip_box;
    }
}