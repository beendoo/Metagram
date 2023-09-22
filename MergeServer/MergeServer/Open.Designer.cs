namespace MergeServer
{
    partial class Open
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
            this.waiting_button = new System.Windows.Forms.Button();
            this.port_box = new System.Windows.Forms.TextBox();
            this.close_button = new System.Windows.Forms.Button();
            this.port_text = new System.Windows.Forms.Label();
            this.open1_back = new System.Windows.Forms.Panel();
            this.connect_ListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chat_TextBox = new System.Windows.Forms.RichTextBox();
            this.open1_back.SuspendLayout();
            this.SuspendLayout();
            // 
            // waiting_button
            // 
            this.waiting_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.waiting_button.FlatAppearance.BorderSize = 0;
            this.waiting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waiting_button.Font = new System.Drawing.Font("Headline R", 10F);
            this.waiting_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.waiting_button.Location = new System.Drawing.Point(251, 46);
            this.waiting_button.Name = "waiting_button";
            this.waiting_button.Size = new System.Drawing.Size(186, 56);
            this.waiting_button.TabIndex = 25;
            this.waiting_button.Text = "Waiting for Connection";
            this.waiting_button.UseVisualStyleBackColor = false;
            this.waiting_button.Click += new System.EventHandler(this.waiting_button_Click);
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.port_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port_box.Font = new System.Drawing.Font("Yet R", 15F, System.Drawing.FontStyle.Bold);
            this.port_box.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.port_box.Location = new System.Drawing.Point(102, 59);
            this.port_box.Name = "port_box";
            this.port_box.Size = new System.Drawing.Size(121, 29);
            this.port_box.TabIndex = 24;
            this.port_box.Text = "7000";
            this.port_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.close_button.FlatAppearance.BorderSize = 0;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.close_button.Location = new System.Drawing.Point(779, 26);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(39, 31);
            this.close_button.TabIndex = 23;
            this.close_button.Text = "X";
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // port_text
            // 
            this.port_text.AutoSize = true;
            this.port_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.port_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.port_text.Location = new System.Drawing.Point(27, 65);
            this.port_text.Name = "port_text";
            this.port_text.Size = new System.Drawing.Size(68, 19);
            this.port_text.TabIndex = 22;
            this.port_text.Text = "PORT";
            // 
            // open1_back
            // 
            this.open1_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.open1_back.Controls.Add(this.connect_ListBox);
            this.open1_back.Controls.Add(this.button1);
            this.open1_back.Controls.Add(this.chat_TextBox);
            this.open1_back.Controls.Add(this.waiting_button);
            this.open1_back.Controls.Add(this.port_box);
            this.open1_back.Controls.Add(this.close_button);
            this.open1_back.Controls.Add(this.port_text);
            this.open1_back.Location = new System.Drawing.Point(-6, -7);
            this.open1_back.Name = "open1_back";
            this.open1_back.Size = new System.Drawing.Size(843, 714);
            this.open1_back.TabIndex = 1;
            this.open1_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            this.open1_back.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseMove);
            this.open1_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseUp);
            // 
            // connect_ListBox
            // 
            this.connect_ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.connect_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connect_ListBox.Font = new System.Drawing.Font("Yet R", 10.2F);
            this.connect_ListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.connect_ListBox.FormattingEnabled = true;
            this.connect_ListBox.ItemHeight = 18;
            this.connect_ListBox.Location = new System.Drawing.Point(567, 125);
            this.connect_ListBox.Name = "connect_ListBox";
            this.connect_ListBox.Size = new System.Drawing.Size(243, 558);
            this.connect_ListBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.button1.Location = new System.Drawing.Point(734, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 27;
            this.button1.Text = "--";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chat_TextBox
            // 
            this.chat_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            this.chat_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chat_TextBox.Font = new System.Drawing.Font("SUITE ExtraBold", 11.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chat_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.chat_TextBox.Location = new System.Drawing.Point(31, 125);
            this.chat_TextBox.Name = "chat_TextBox";
            this.chat_TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.chat_TextBox.Size = new System.Drawing.Size(500, 558);
            this.chat_TextBox.TabIndex = 26;
            this.chat_TextBox.Text = "";
            // 
            // Open
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 700);
            this.Controls.Add(this.open1_back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Open";
            this.Text = "Open";
            this.open1_back.ResumeLayout(false);
            this.open1_back.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button waiting_button;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label port_text;
        private System.Windows.Forms.Panel open1_back;
        private System.Windows.Forms.RichTextBox chat_TextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox connect_ListBox;
    }
}

