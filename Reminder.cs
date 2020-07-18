using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formochka
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
            
        }
        public int index;
        List<string> list = new List<string>();
        List<string> list_for_time = new List<string>();


        private void label2_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();

            edit.Owner = this;
            
           
           

            edit.ShowDialog();
        }

        

        private void plusButton_MouseLeave(object sender, EventArgs e)
        {
            plusButton.BackColor = Color.FromArgb(76, 68, 68);
            plusButton.ForeColor = Color.White;
        }

        private void plusButton_MouseEnter(object sender, EventArgs e)
        {
            plusButton.BackColor = Color.White;
            plusButton.ForeColor = Color.Black;
        }
        
        
        
        
        public void Add(int index,string task, string full_task ,string time)
        {


            try
            {
                list_for_time.Insert(index, time);
                listBox1.Items.Insert(index, task);
                list.Insert(index, full_task);
            }
            catch
            {
                list_for_time.Insert(0, time);
                listBox1.Items.Insert(0, task);
                list.Insert(0, full_task);
            }

        }
        public void Remove(int index)
        {
            listBox1.Items.RemoveAt(index);
            list.RemoveAt(index);
            list_for_time.RemoveAt(index);
        }
        
        public string task;
        public string full_task;
        public string time;
        private void listBox1_Click(object sender, EventArgs e)
        {
            index = listBox1.SelectedIndex;
            try
            {
                task = (string)listBox1.Items[index];
                full_task = list[index];
                time = list_for_time[index];
                Thread.Sleep(1000);
                Remove(index);
            }
            catch 
            {
                return;
            }

            
            
           
        }
        private void listBox1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Brush brush = Brushes.White;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected, Color.White, Color.White);
                brush = Brushes.Black;
            }
            e.DrawBackground();
            try
            {
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, brush, e.Bounds);
            }
            catch
            {
                return;
            }
            e.DrawFocusRectangle();
        }

        private void Reminder_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(Application.StartupPath + "\\tasks.txt");
            System.IO.FileInfo fit = new System.IO.FileInfo(Application.StartupPath + "\\time.txt");
            System.IO.StreamReader sr = null;
            System.IO.StreamReader srt = null;

            ReadFile(fi, sr, srt,fit, list);


            this.SendToBack();
            timer1.Start();
            this.StartPosition = FormStartPosition.Manual;
            Screen screen = Screen.FromControl(this);
            this.Top = screen.WorkingArea.Height - this.Size.Height;
            
            this.Left = screen.WorkingArea.Width - this.Size.Width;

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += new DrawItemEventHandler(listBox1_DrawItem);

            this.Opacity = 0.5D;
        }

        private void ReadFile(System.IO.FileInfo fi, System.IO.StreamReader sr, System.IO.StreamReader srt, System.IO.FileInfo fit, List<string> list)
        {
            if (fi.Exists)
            {
                sr = fi.OpenText();
                string line ;
                string line_time;
                string task = "  ";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (line.Length > 30)
                    {
                        for(int i = 0; i < 27; i++)
                        {
                            task += line[i];
                        }
                        listBox1.Items.Insert(0, task+"...");
                        list.Insert(0, line);
                        task = "  ";
                    }
                    else
                    {
                        listBox1.Items.Insert(0,"  "+line);
                        list.Insert(0, line);
                    }
                    
                }
                if (fit.Exists)
                {
                    srt = fit.OpenText();
                    while (!srt.EndOfStream)
                    {
                        line_time = srt.ReadLine();
                        if (line_time == "")
                        {
                            line_time = null;
                        }
                        list_for_time.Insert(0, line_time);
                    }
                }
            }
            else
            {
                return;
            }

            
            
            sr.Close();
        }

        private void Reminder_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label2_Click(sender, e);
            }
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {          
            Application.Exit();
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(76, 68, 68);
        }

        

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {


            Add(index, task, full_task,time);
               
            FullDescription fullDesc = new FullDescription(full_task,time);
            fullDesc.Owner = this;
            fullDesc.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < list_for_time.Count(); i++)
            {
                if (list_for_time[i] != null)
                {
                    string el = list_for_time[i];
                    string hour = "";
                    string min = "";
                    hour += el[0];hour += el[1];
                    min += el[3];min += el[4];
                    if(System.DateTime.Now.Hour == Convert.ToInt32(hour))
                    {
                        if (System.DateTime.Now.Minute == Convert.ToInt32(min))
                        {
                            MessageBox.Show(
                                $"{list[i]}",
                                "Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                            list_for_time[i] = null;
                        }
                    }
                }
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void Reminder_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(Application.StartupPath + "\\tasks.txt");
            System.IO.FileInfo fit = new System.IO.FileInfo(Application.StartupPath + "\\time.txt");
            System.IO.StreamWriter sw = null;
            System.IO.StreamWriter swt = null;

            IsExists(fi, sw,list);
            IsExists(fit, swt, list_for_time);

            
        }

        private void IsExists(System.IO.FileInfo fi, System.IO.StreamWriter sw, List<string> list)
        {
            try
            {
                sw = fi.CreateText();
            }
            catch
            {
                return;
            }
            for (int task = 0; task < list.Count; task++)
            {
                sw.WriteLine(list[task]);
            }
            sw.Close();
        }
    }
}
