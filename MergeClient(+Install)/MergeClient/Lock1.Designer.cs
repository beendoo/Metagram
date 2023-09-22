namespace MergeClient
{
    partial class Lock1
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
            this.lock1_back = new System.Windows.Forms.Panel();
            this.chatid_box = new System.Windows.Forms.Label();
            this.chatport_box = new System.Windows.Forms.Label();
            this.chatip_box = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.unlock_button = new System.Windows.Forms.Button();
            this.locked_text = new System.Windows.Forms.Label();
            this.pw_box = new System.Windows.Forms.TextBox();
            this.lock1_back.SuspendLayout();
            this.SuspendLayout();
            // 
            // lock1_back
            // 
            this.lock1_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.lock1_back.Controls.Add(this.chatid_box);
            this.lock1_back.Controls.Add(this.chatport_box);
            this.lock1_back.Controls.Add(this.chatip_box);
            this.lock1_back.Controls.Add(this.button1);
            this.lock1_back.Controls.Add(this.close_button);
            this.lock1_back.Controls.Add(this.unlock_button);
            this.lock1_back.Controls.Add(this.locked_text);
            this.lock1_back.Controls.Add(this.pw_box);
            this.lock1_back.Location = new System.Drawing.Point(-5, -6);
            this.lock1_back.Name = "lock1_back";
            this.lock1_back.Size = new System.Drawing.Size(561, 713);
            this.lock1_back.TabIndex = 2;
            this.lock1_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.lock1_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseMove);
            this.lock1_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseUp);
            // 
            // chatid_box
            // 
            this.chatid_box.AutoSize = true;
            this.chatid_box.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold);
            this.chatid_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.chatid_box.Location = new System.Drawing.Point(261, 191);
            this.chatid_box.Name = "chatid_box";
            this.chatid_box.Size = new System.Drawing.Size(73, 21);
            this.chatid_box.TabIndex = 33;
            this.chatid_box.Text = "chatid";
            // 
            // chatport_box
            // 
            this.chatport_box.AutoSize = true;
            this.chatport_box.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold);
            this.chatport_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.chatport_box.Location = new System.Drawing.Point(261, 156);
            this.chatport_box.Name = "chatport_box";
            this.chatport_box.Size = new System.Drawing.Size(97, 21);
            this.chatport_box.TabIndex = 32;
            this.chatport_box.Text = "chatport";
            // 
            // chatip_box
            // 
            this.chatip_box.AutoSize = true;
            this.chatip_box.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold);
            this.chatip_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.chatip_box.Location = new System.Drawing.Point(261, 119);
            this.chatip_box.Name = "chatip_box";
            this.chatip_box.Size = new System.Drawing.Size(73, 21);
            this.chatip_box.TabIndex = 31;
            this.chatip_box.Text = "chatip";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(450, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 27;
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
            this.close_button.Location = new System.Drawing.Point(495, 28);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(39, 31);
            this.close_button.TabIndex = 15;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // unlock_button
            // 
            this.unlock_button.AutoEllipsis = true;
            this.unlock_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.unlock_button.FlatAppearance.BorderSize = 0;
            this.unlock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unlock_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.unlock_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.unlock_button.Location = new System.Drawing.Point(225, 469);
            this.unlock_button.Name = "unlock_button";
            this.unlock_button.Size = new System.Drawing.Size(120, 47);
            this.unlock_button.TabIndex = 14;
            this.unlock_button.Text = "Unlock";
            this.unlock_button.UseVisualStyleBackColor = false;
            this.unlock_button.Click += new System.EventHandler(this.unlock_button_Click);
            // 
            // locked_text
            // 
            this.locked_text.AutoSize = true;
            this.locked_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.locked_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.locked_text.Location = new System.Drawing.Point(236, 340);
            this.locked_text.Name = "locked_text";
            this.locked_text.Size = new System.Drawing.Size(97, 19);
            this.locked_text.TabIndex = 13;
            this.locked_text.Text = "LOCKED";
            // 
            // pw_box
            // 
            this.pw_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.pw_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.pw_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pw_box.Location = new System.Drawing.Point(136, 413);
            this.pw_box.Name = "pw_box";
            this.pw_box.PasswordChar = '*';
            this.pw_box.Size = new System.Drawing.Size(289, 29);
            this.pw_box.TabIndex = 3;
            this.pw_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pw_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pw_box_KeyDown);
            // 
            // Lock1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.lock1_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lock1";
            this.Text = "Lock1";
            this.lock1_back.ResumeLayout(false);
            this.lock1_back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lock1_back;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Button unlock_button;
        private System.Windows.Forms.Label locked_text;
        private System.Windows.Forms.TextBox pw_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label chatid_box;
        private System.Windows.Forms.Label chatport_box;
        private System.Windows.Forms.Label chatip_box;
    }
}