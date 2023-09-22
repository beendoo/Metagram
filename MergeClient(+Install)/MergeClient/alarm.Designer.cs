namespace MergeClient
{
    partial class alarm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alarm1_text = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.alarm1_text);
            this.panel1.Location = new System.Drawing.Point(-6, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 86);
            this.panel1.TabIndex = 1;
            // 
            // alarm1_text
            // 
            this.alarm1_text.AutoSize = true;
            this.alarm1_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.alarm1_text.Font = new System.Drawing.Font("Headline R", 11.2F);
            this.alarm1_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(96)))), ((int)(((byte)(138)))));
            this.alarm1_text.Location = new System.Drawing.Point(73, 35);
            this.alarm1_text.Name = "alarm1_text";
            this.alarm1_text.Size = new System.Drawing.Size(213, 19);
            this.alarm1_text.TabIndex = 14;
            this.alarm1_text.Text = "* NEW MESSAGE *";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 70);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alarm";
            this.Text = "alarm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label alarm1_text;
        private System.Windows.Forms.Timer timer1;
    }
}