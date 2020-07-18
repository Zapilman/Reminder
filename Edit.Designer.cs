namespace Formochka
{
    partial class Edit
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AM_PM = new System.Windows.Forms.Label();
            this.Min_Box = new System.Windows.Forms.ComboBox();
            this.Hour_Box = new System.Windows.Forms.ComboBox();
            this.notification = new System.Windows.Forms.Label();
            this.check_time = new System.Windows.Forms.CheckBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Memo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel3.Location = new System.Drawing.Point(-13, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 10);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.AM_PM);
            this.panel1.Controls.Add(this.Min_Box);
            this.panel1.Controls.Add(this.Hour_Box);
            this.panel1.Controls.Add(this.notification);
            this.panel1.Controls.Add(this.check_time);
            this.panel1.Controls.Add(this.Save_Button);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 450);
            this.panel1.TabIndex = 1;
            // 
            // AM_PM
            // 
            this.AM_PM.AutoSize = true;
            this.AM_PM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AM_PM.ForeColor = System.Drawing.Color.White;
            this.AM_PM.Location = new System.Drawing.Point(326, 168);
            this.AM_PM.Name = "AM_PM";
            this.AM_PM.Size = new System.Drawing.Size(0, 20);
            this.AM_PM.TabIndex = 10;
            // 
            // Min_Box
            // 
            this.Min_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Min_Box.FormattingEnabled = true;
            this.Min_Box.Location = new System.Drawing.Point(185, 164);
            this.Min_Box.Name = "Min_Box";
            this.Min_Box.Size = new System.Drawing.Size(121, 24);
            this.Min_Box.TabIndex = 9;
            // 
            // Hour_Box
            // 
            this.Hour_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Hour_Box.FormattingEnabled = true;
            this.Hour_Box.Location = new System.Drawing.Point(58, 164);
            this.Hour_Box.Name = "Hour_Box";
            this.Hour_Box.Size = new System.Drawing.Size(121, 24);
            this.Hour_Box.TabIndex = 8;
            this.Hour_Box.SelectedIndexChanged += new System.EventHandler(this.Hour_Box_SelectedIndexChanged);
            // 
            // notification
            // 
            this.notification.AutoSize = true;
            this.notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notification.ForeColor = System.Drawing.Color.White;
            this.notification.Location = new System.Drawing.Point(54, 164);
            this.notification.Name = "notification";
            this.notification.Size = new System.Drawing.Size(213, 20);
            this.notification.TabIndex = 6;
            this.notification.Text = "You won\'t get a notification.";
            // 
            // check_time
            // 
            this.check_time.AutoSize = true;
            this.check_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.check_time.ForeColor = System.Drawing.Color.White;
            this.check_time.Location = new System.Drawing.Point(58, 122);
            this.check_time.Name = "check_time";
            this.check_time.Size = new System.Drawing.Size(78, 29);
            this.check_time.TabIndex = 5;
            this.check_time.Text = "Time";
            this.check_time.UseVisualStyleBackColor = true;
            this.check_time.CheckedChanged += new System.EventHandler(this.check_time_CheckedChanged);
            // 
            // Save_Button
            // 
            this.Save_Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Save_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.Save_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Save_Button.Location = new System.Drawing.Point(280, 384);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(113, 30);
            this.Save_Button.TabIndex = 4;
            this.Save_Button.Text = "Save";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(97)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.closeButton.Location = new System.Drawing.Point(58, 384);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(113, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.Memo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(446, 58);
            this.panel2.TabIndex = 1;
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
            this.Memo.Size = new System.Drawing.Size(446, 58);
            this.Memo.TabIndex = 0;
            this.Memo.WordWrap = false;
            this.Memo.Enter += new System.EventHandler(this.Memo_Enter);
            this.Memo.Leave += new System.EventHandler(this.Memo_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.ShowInTaskbar = false;
            this.Text = "Edit";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Edit_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Memo;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label notification;
        private System.Windows.Forms.CheckBox check_time;
        private System.Windows.Forms.Label AM_PM;
        private System.Windows.Forms.ComboBox Min_Box;
        private System.Windows.Forms.ComboBox Hour_Box;
    }
}