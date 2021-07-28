using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WorkTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool isWorking;
        int saniye, dakika, saat;
        SqlConnection connectServer = new SqlConnection("Data Source=.\\SQLEXPRESS;Database=WorkingData; User Id=mello;Password=44tecH.s;");
        string projectName;
        int day;
        private void ReadData()
        {
            connectServer.Open();
            SqlCommand commandData = new SqlCommand("Select * From WorkingTimeTable", connectServer);
            SqlDataReader readData = commandData.ExecuteReader();

            while (readData.Read())
            {
                ListViewItem addData = new ListViewItem(new string[] { readData["day"].ToString(), readData["date"].ToString(), readData["duration"].ToString(), readData["project"].ToString() });
                listView1.Items.Add(addData);
                day = (int)readData[4] + 1;
            }

            connectServer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            isWorking = false;
            Start.Text = "Start";
            ReadData();
            notifyIcon1.Visible = true;
            Pause.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Start.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Stop.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            Minimalize.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);

        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (isWorking == false)
            {
                projectName = Interaction.InputBox("Enter the project name.", "Welcome", "project name");
                timer1.Enabled = true;
                Start.Text = "Pause";
                Pause.Text = projectName;
                isWorking = true;
            }
            else
            {
                if (Start.Text == "Pause")
                {
                    timer1.Enabled = false;
                    Start.Text = "Continue";
                }
                else if (Start.Text == "Continue")
                {
                    timer1.Enabled = true;
                    Start.Text = "Pause";
                }
            }

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DateTime date = DateTime.Now;
            connectServer.Open();

            var duration = $" {saat} : {dakika} : {saniye}";
            SqlCommand processData = new SqlCommand("insert into WorkingTimeTable (date,duration,project,day) values (@date,'" + duration + "','" + projectName + "', '" + day + "') ", connectServer);
            processData.Parameters.AddWithValue("@date", date);
            processData.ExecuteNonQuery();
            connectServer.Close();

            MessageBox.Show("You working time to day is " + saat + ":" + dakika + ":" + saniye);

            this.Close();
            Application.Exit();
        }

        private void InfText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Minimalize_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sayac_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }

            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            if (Win32.GetIdleTime() > 200000)
            {
                timer1.Enabled = false;
                Start.Text = "Continue";
                Show();
                this.WindowState = FormWindowState.Normal;
                MessageBox.Show("Work Timer is paused!");
            }

            sayac.Text = $" {saat} \n {dakika} \n{saniye}";
            notifyIcon1.Text = $" {saat} : {dakika} ";

            saniye++;
        }
    }

    internal struct LASTINPUTINFO
    {
        public uint cbSize;
        public uint dwTime;
    }
    public class Win32
    {
        [DllImport("User32.dll")]
        public static extern bool LockWorkStation();
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();

        public static uint GetIdleTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            GetLastInputInfo(ref lastInPut);
            return ((uint)Environment.TickCount - lastInPut.dwTime);
        }

        public static long GetTickCount()
        {
            return Environment.TickCount;
        }
        public static long GetLastInputTime()
        {
            LASTINPUTINFO lastInPut = new LASTINPUTINFO();
            lastInPut.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(lastInPut);
            if (!GetLastInputInfo(ref lastInPut))
            {
                throw new Exception(GetLastError().ToString());
            }
            return lastInPut.dwTime;
        }
    }

}
