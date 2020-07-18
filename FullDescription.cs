using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formochka
{
    public partial class FullDescription : Form
    {
        public FullDescription(string memory,string timing)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Screen screen = Screen.FromControl(this);
            this.Top = screen.Bounds.Height - this.Size.Height;
            this.Left = screen.Bounds.Width - this.Size.Width;
            this.KeyPreview = true;
            if (timing != null)
            {
                alert.Text = timing;
                alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                icon_of_alert.Visible = false;
            }
            label1.Text += memory;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Reminder main = this.Owner as Reminder;
            if (main != null)
            {
                main.Remove(main.index);
                this.Close();
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Reminder main = this.Owner as Reminder;
            if (main != null)
            {
                main.Remove(main.index);
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Owner = this;
            Reminder main = this.Owner as Reminder;
            main.Remove(main.index);
            edit.Change_Text_Box(label1.Text);
            edit.ShowDialog();
            if (edit.Visible != true)
            {
                label1.Text = edit.Take_From_TextBox();
                if (main != null)
                {
                    edit.Save(label1.Text, main);
                }

                if (edit.time != null)
                {
                    alert.Text = edit.time;
                    icon_of_alert.Visible = false;
                }
            }
            
        }
        
    }
}
