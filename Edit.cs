using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formochka
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            Screen screen = Screen.FromControl(this);
            this.Top = screen.Bounds.Height - this.Size.Height;
            this.Left = screen.Bounds.Width - this.Size.Width;
            this.KeyPreview = true;
            Memo.Text = "memo...";
            this.Hour_Box.Visible = false;
            for(int i = System.DateTime.Now.Hour; i <= 24; i++)
            {
                this.Hour_Box.Items.Add(i);
            }
            this.Min_Box.Visible = false;
            for (int i = 0; i < 60; i++)
            {
                this.Min_Box.Items.Add(i);
            }
        }
        
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Change_Text_Box(string text)
        {
            Memo.Text = text;
        }


        public string Take_From_TextBox()
        {
            return Memo.Text;
        }
        public int month, year, min, hour, sec,day;

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Reminder main = this.Owner as Reminder;
            if (main != null)
            {
                Save(Memo.Text, main);

            }
            this.Close();
        }
        public string time = null;

        private void Hour_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)Hour_Box.SelectedItem < 12)
            {
                AM_PM.Text = "AM";
            }
            else
            {
                AM_PM.Text = "PM";
            }
        }

        

        public void Save(string text,Reminder main)
        {

            if (text.Contains("\r\n"))
            {
                text = text.Replace("\r\n", "");
            }
            if (text == "memo..." || String.IsNullOrEmpty(text))
            {
                MessageBox.Show("Ты дурак?? Зачем сохранять пустое задание??");
                return;
            }
            
            if (this.check_time.Checked)
            {

                try
                {
                    min = (int)Min_Box.SelectedItem;
                    hour = (int)Hour_Box.SelectedItem;
                }
                catch
                {
                    return;
                }

                if (hour < 10 && min<10)
                {
                    time = $"0{hour}:0{min}";
                }
                else if (hour < 10)
                {
                    time = $"0{hour}:{min}";
                }
                else if (min < 10)
                {
                    time = $"{hour}:0{min}";
                }
                else
                {
                    time = $"{hour}:{min}";
                }

                if (IsTimeValid(time))
                {
                    MessageBox.Show("Select time in the future");
                    return;
                }

            }
            string task = "  ";
            if (text.Length > 30)
            {
                for (int i = 0; i < 27; i++)
                {
                    task += text[i];
                }

                main.Add(main.index, task + "...", text, time);
            }
            else
            {
                task = "  " + text;
                main.Add(main.index, task, text, time);
            }
        }

        private bool IsTimeValid(string time)
        {
            string min = "";
            string hour = "";
            hour += time[0];hour+=time[1];
            min += time[3];min += time[4];

            if (System.DateTime.Now.Hour == Convert.ToInt32(hour))
            {
                if (System.DateTime.Now.Minute > Convert.ToInt32(min))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }


        private void Memo_Enter(object sender, EventArgs e)
        {
            if (Memo.Text == "memo...")
            {
                Memo.Text = "";
                Memo.ForeColor = Color.White;
            }
        }

        private void Memo_Leave(object sender, EventArgs e)
        {
            if (Memo.Text == "")
            {
                Memo.ForeColor = Color.Gray;
                Memo.Text = "memo...";
            }
        }

        private void Edit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Memo.Focus();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                Save_Button_Click(sender, e);
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }


        }

        private void check_time_CheckedChanged(object sender, EventArgs e)
        {
            if (check_time.Checked)
            {
                this.Hour_Box.Visible = true;
                this.Min_Box.Visible = true;
                this.notification.Visible = false;
                this.AM_PM.Visible = true;
            }
            else
            {
                this.Hour_Box.Visible = false;
                this.AM_PM.Visible = false;
                this.notification.Visible = true;
                this.Min_Box.Visible = false;
            }
            
        }

        
    }
}
