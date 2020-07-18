namespace Formochka
{
    partial class FullDescription
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.icon_of_alert = new System.Windows.Forms.Panel();
            this.alert = new System.Windows.Forms.Label();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Complete_Button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.Memo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.icon_of_alert);
            this.panel1.Controls.Add(this.alert);
            this.panel1.Controls.Add(this.Edit_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Delete_Button);
            this.panel1.Controls.Add(this.Complete_Button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 461);
            this.panel1.TabIndex = 2;
            // 
            // icon_of_alert
            // 
            this.icon_of_alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.icon_of_alert.BackgroundImage = global::Reminder.Resources._322492_32;
            this.icon_of_alert.Location = new System.Drawing.Point(39, 306);
            this.icon_of_alert.Name = "icon_of_alert";
            this.icon_of_alert.Size = new System.Drawing.Size(40, 40);
            this.icon_of_alert.TabIndex = 7;
            // 
            // alert
            // 
            this.alert.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.alert.ForeColor = System.Drawing.Color.White;
            this.alert.Location = new System.Drawing.Point(77, 281);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(284, 79);
            this.alert.TabIndex = 6;
            this.alert.Text = "No alert";
            this.alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Edit_Button
            // 
            this.Edit_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Edit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Edit_Button.Location = new System.Drawing.Point(158, 386);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(113, 30);
            this.Edit_Button.TabIndex = 5;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 223);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delete_Button
            // 
            this.Delete_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Delete_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Delete_Button.Location = new System.Drawing.Point(277, 386);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(113, 30);
            this.Delete_Button.TabIndex = 4;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Complete_Button
            // 
            this.Complete_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Complete_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Complete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Complete_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Complete_Button.Location = new System.Drawing.Point(39, 386);
            this.Complete_Button.Name = "Complete_Button";
            this.Complete_Button.Size = new System.Drawing.Size(113, 30);
            this.Complete_Button.TabIndex = 1;
            this.Complete_Button.Text = "Complete";
            this.Complete_Button.UseVisualStyleBackColor = true;
            this.Complete_Button.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Memo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 58);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button3.Location = new System.Drawing.Point(0, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Memo
            // 
            this.Memo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Memo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Memo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Memo.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Memo.ForeColor = System.Drawing.Color.White;
            this.Memo.Location = new System.Drawing.Point(0, 0);
            this.Memo.Multiline = true;
            this.Memo.Name = "Memo";
            this.Memo.Size = new System.Drawing.Size(428, 58);
            this.Memo.TabIndex = 0;
            this.Memo.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            // 
            // FullDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FullDescription";
            this.Text = "FullDescription";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Complete_Button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Memo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label alert;
        private System.Windows.Forms.Panel icon_of_alert;
    }
}