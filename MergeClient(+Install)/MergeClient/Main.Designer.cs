namespace MergeClient
{
    partial class Main
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
            this.Chat_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.lock_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.Port_text = new System.Windows.Forms.Label();
            this.UserID_text = new System.Windows.Forms.Label();
            this.ServerIP_text = new System.Windows.Forms.Label();
            this.Send_button = new System.Windows.Forms.Button();
            this.message_box = new System.Windows.Forms.TextBox();
            this.lock1_back.SuspendLayout();
            this.SuspendLayout();
            // 
            // lock1_back
            // 
            this.lock1_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.lock1_back.Controls.Add(this.chatid_box);
            this.lock1_back.Controls.Add(this.chatport_box);
            this.lock1_back.Controls.Add(this.chatip_box);
            this.lock1_back.Controls.Add(this.Chat_box);
            this.lock1_back.Controls.Add(this.button1);
            this.lock1_back.Controls.Add(this.logout_button);
            this.lock1_back.Controls.Add(this.lock_button);
            this.lock1_back.Controls.Add(this.close_button);
            this.lock1_back.Controls.Add(this.Port_text);
            this.lock1_back.Controls.Add(this.UserID_text);
            this.lock1_back.Controls.Add(this.ServerIP_text);
            this.lock1_back.Controls.Add(this.Send_button);
            this.lock1_back.Controls.Add(this.message_box);
            this.lock1_back.Location = new System.Drawing.Point(-5, -5);
            this.lock1_back.Name = "lock1_back";
            this.lock1_back.Size = new System.Drawing.Size(561, 710);
            this.lock1_back.TabIndex = 15;
            this.lock1_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.lock1_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseMove);
            this.lock1_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseUp);
            // 
            // chatid_box
            // 
            this.chatid_box.AutoSize = true;
            this.chatid_box.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold);
            this.chatid_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chatid_box.Location = new System.Drawing.Point(102, 101);
            this.chatid_box.Name = "chatid_box";
            this.chatid_box.Size = new System.Drawing.Size(73, 21);
            this.chatid_box.TabIndex = 30;
            this.chatid_box.Text = "chatid";
            // 
            // chatport_box
            // 
            this.chatport_box.AutoSize = true;
            this.chatport_box.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold);
            this.chatport_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chatport_box.Location = new System.Drawing.Point(102, 66);
            this.chatport_box.Name = "chatport_box";
            this.chatport_box.Size = new System.Drawing.Size(97, 21);
            this.chatport_box.TabIndex = 29;
            this.chatport_box.Text = "chatport";
            // 
            // chatip_box
            // 
            this.chatip_box.AutoSize = true;
            this.chatip_box.Font = new System.Drawing.Font("Yet R", 12F, System.Drawing.FontStyle.Bold);
            this.chatip_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chatip_box.Location = new System.Drawing.Point(159, 30);
            this.chatip_box.Name = "chatip_box";
            this.chatip_box.Size = new System.Drawing.Size(73, 21);
            this.chatip_box.TabIndex = 28;
            this.chatip_box.Text = "chatip";
            // 
            // Chat_box
            // 
            this.Chat_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.Chat_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Chat_box.Font = new System.Drawing.Font("SUITE ExtraBold", 11.2F, System.Drawing.FontStyle.Bold);
            this.Chat_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.Chat_box.Location = new System.Drawing.Point(28, 160);
            this.Chat_box.Multiline = true;
            this.Chat_box.Name = "Chat_box";
            this.Chat_box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Chat_box.Size = new System.Drawing.Size(502, 382);
            this.Chat_box.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(450, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.logout_button.Location = new System.Drawing.Point(405, 80);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(129, 42);
            this.logout_button.TabIndex = 25;
            this.logout_button.Text = "Log out";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // lock_button
            // 
            this.lock_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.lock_button.FlatAppearance.BorderSize = 0;
            this.lock_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lock_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.lock_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.lock_button.Location = new System.Drawing.Point(294, 80);
            this.lock_button.Name = "lock_button";
            this.lock_button.Size = new System.Drawing.Size(90, 42);
            this.lock_button.TabIndex = 21;
            this.lock_button.Text = "Lock";
            this.lock_button.UseVisualStyleBackColor = false;
            this.lock_button.Click += new System.EventHandler(this.lock_button_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.close_button.Location = new System.Drawing.Point(495, 27);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(39, 31);
            this.close_button.TabIndex = 20;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // Port_text
            // 
            this.Port_text.AutoSize = true;
            this.Port_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.Port_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.Port_text.Location = new System.Drawing.Point(28, 68);
            this.Port_text.Name = "Port_text";
            this.Port_text.Size = new System.Drawing.Size(68, 19);
            this.Port_text.TabIndex = 19;
            this.Port_text.Text = "PORT";
            // 
            // UserID_text
            // 
            this.UserID_text.AutoSize = true;
            this.UserID_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.UserID_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.UserID_text.Location = new System.Drawing.Point(28, 103);
            this.UserID_text.Name = "UserID_text";
            this.UserID_text.Size = new System.Drawing.Size(65, 19);
            this.UserID_text.TabIndex = 18;
            this.UserID_text.Text = "USER";
            // 
            // ServerIP_text
            // 
            this.ServerIP_text.AutoSize = true;
            this.ServerIP_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.ServerIP_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.ServerIP_text.Location = new System.Drawing.Point(28, 32);
            this.ServerIP_text.Name = "ServerIP_text";
            this.ServerIP_text.Size = new System.Drawing.Size(125, 19);
            this.ServerIP_text.TabIndex = 17;
            this.ServerIP_text.Text = "SERVER IP";
            // 
            // Send_button
            // 
            this.Send_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.Send_button.FlatAppearance.BorderSize = 0;
            this.Send_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.Send_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.Send_button.Location = new System.Drawing.Point(436, 573);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(94, 106);
            this.Send_button.TabIndex = 16;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = false;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // message_box
            // 
            this.message_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.message_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message_box.Font = new System.Drawing.Font("SUITE ExtraBold", 11.2F, System.Drawing.FontStyle.Bold);
            this.message_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.message_box.Location = new System.Drawing.Point(28, 573);
            this.message_box.Multiline = true;
            this.message_box.Name = "message_box";
            this.message_box.Size = new System.Drawing.Size(388, 106);
            this.message_box.TabIndex = 15;
            this.message_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_message_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 700);
            this.Controls.Add(this.lock1_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.lock1_back.ResumeLayout(false);
            this.lock1_back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lock1_back;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label Port_text;
        private System.Windows.Forms.Label UserID_text;
        private System.Windows.Forms.Label ServerIP_text;
        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.TextBox message_box;
        private System.Windows.Forms.Button lock_button;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Chat_box;
        private System.Windows.Forms.Label chatid_box;
        private System.Windows.Forms.Label chatport_box;
        private System.Windows.Forms.Label chatip_box;
    }
}