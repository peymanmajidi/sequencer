﻿using Sequencer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequencer
{
    public partial class MainFrm : Form
    {
        const int GATE_WIDTH = 70;
        const int EDGE = 100;

        public static List<Gate> Gates = new List<Gate>();


        public List<int> OrderTemp = new List<int>()
        {
            12,13,20,18,4,5,16,17,19,3,1,15,2,9,7,8,11,6,10,14
        };
        public Stack<int> Order = new Stack<int>();


        List<Parcel> Parcels = new List<Parcel>();
        public MainFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Release(sender, e);

            foreach (var parcel in Parcels)
            {
                parcel.Shift();
            }

            //var index = 1;

            //if (Parcels.Count > 0)
            //    index = Parcels.LastOrDefault().Index + 1;

            //var new_parcel = new Parcel(index);
            //this.Controls.Add(new_parcel.Button);
            //new_parcel.Button.Tag = new_parcel;

            //new_parcel.Button.Click += Button_Click;


            //Parcels.Add(new_parcel);

            Clock++;


        }

        private void Button_Click(object sender, EventArgs e)
        {

            var button = (Button)sender;
            var parcel = (Parcel)button.Tag;
            Clock++;
            parcel.Shift();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
      
            
            trackBar1_Scroll(sender, e);
            for (int i = 0; i < 10; i++)
            {
                var spot = new Gate();
                spot.Index = i + 1;
                spot.Start = EDGE + (i * GATE_WIDTH);
                spot.End = spot.Start + GATE_WIDTH;
                spot.Row = Row.DOWN;
                Gates.Add(spot);

            }
            for (int i = 0; i < 10; i++)
            {
                var spot = new Gate();
                spot.Index = i + 11;
                spot.Start = EDGE + (i * GATE_WIDTH);
                spot.End = spot.Start + GATE_WIDTH;
                spot.Row = Row.UP;

                Gates.Add(spot);

            }

            LoadData();

        }

        private void LoadData()
        {
            progressBar.Value = 0;
            progressBar.Maximum = OrderTemp.Count;
           

            foreach (var o in OrderTemp.Distinct().Reverse())
            {
                Order.Push(o);
            }
        }

        private void Push(object sender, EventArgs e)
        {
            foreach (var parcel in Parcels)
            {
                parcel.Shift();
            }


            if (Order.Count < 1)
                return;


            var new_parcel = new Parcel(Order.Pop());
            progressBar.PerformStep();
            this.Controls.Add(new_parcel.Button);
            new_parcel.Button.Tag = new_parcel;

            new_parcel.Button.Click += Button_Click;
            new_parcel.Button.BringToFront();


            Parcels.Add(new_parcel);
            Clock++;

        }

        int sec = 0;
        int min = 0;
        public int Clock
        {
            get
            {
                return sec + (min * 60);
            }
            set
            {
                sec = value;

                var seconds = (sec % 60) < 10 ? "0" + (sec % 60) : (sec % 60).ToString();
                var minutes = (sec / 60) < 10 ? "0" + (sec / 60) : (sec / 60).ToString();

                lblClock.Text = $"{minutes}:{seconds}";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            Push(sender, e);
            Release(sender, e);
        }


        private void Release(object sender, EventArgs e)
        {
            if (Parcels.Where(p => p.Placed).Count() != Parcels.Count())
                return;

            bool did_something = false;
            var down_parcels = Parcels.Where(p => p.Gate.Row == Row.DOWN && p.Placed && !p.Exit);
            var up_parcels = Parcels.Where(p => p.Gate.Row == Row.UP && p.Placed && !p.Exit);


            foreach (var parcel in down_parcels)
            {
                parcel.Release();
                did_something = true;
            }
            if (down_parcels.Where(p => p.Exit).Count() == down_parcels.Count())
            {
                foreach (var parcel in up_parcels)
                {
                    parcel.Release();
                    did_something = true;
                }
            }
            if (did_something)
                Clock++;



            var exited = Parcels.Where(p => p.Exit);

            foreach (var parcel in exited)
            {
                parcel.Release();

            }



        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void picRuntime_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                picPower.Image = Properties.Resources.btt_on;
            }
            else
            {
                picPower.Image = Properties.Resources.btt_off;

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = (trackBar1.Value * 100);
            lblMiliSec.Text = $"{timer1.Interval} ms";
        }

        private void button3_Click(object sender, EventArgs e)
        {


            Reset();

            LoadData();


        }

        private void Reset()
        {
            foreach (var parcel in Parcels)
            {
                this.Controls.Remove(parcel.Button);
            }
            Parcels.Clear();
            Order.Clear();

            Clock = 0;
            timer1.Enabled = false;
            picPower.Image = Properties.Resources.btt_off;
        }

        private void MainFrm_DragDrop(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Copy;
            var fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            var file = fileList[0];

            LoadTextFile(file);

        }

        private void LoadTextFile(string file)
        {
            Reset();

            if (file.ToLower().EndsWith(".txt"))
            {
                var data = File.ReadAllText(file);
                var listed_data = data.Split('\n').ToList();
                if (listed_data.Count() > 1)
                {
                    OrderTemp.Clear();
                    foreach (var item in listed_data)
                    {
                        var n = 0;
                        try
                        {
                            n = Int32.Parse(item);
                        }
                        catch
                        {


                        }
                        if (n > 0 && n<=20)
                        {
                            OrderTemp.Add(n);
                        }

                    }
                    OrderTemp = OrderTemp.Distinct().ToList();
                    lblLog.Text = $"{OrderTemp.Count()} Parcel(s) Loaded Successfuly";
                    lblPersian.Text = "ورودی متنی بارگذاری شد";
                    panelLoad.BackColor = Color.Gold;



                }
                else
                {
                    lblLog.Text = $"{0} Parcel(s) Loaded Successfuly";
                    lblPersian.Text = "ورودی متنی مشکل دارد";
                    panelLoad.BackColor = Color.Red;

                }


            }
            else
            {
                lblLog.Text = $"0 Parcel(s) Loaded Successfuly";
                panelLoad.BackColor = Color.Red;
                lblPersian.Text = "فایل ورودی بایستی متنی باشد";


            }





            panelLoad.Visible = true;

            try
            {
                new Thread(() =>
                {
                    Thread.Sleep(3000);
                    panelLoad.Visible = false;


                }).Start();

            }
            catch
            {

                panelLoad.Visible = false;

            }
            LoadData();
        }

        private void MainFrm_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Copy;


        }

        private void lblLog_Click(object sender, EventArgs e)
        {
            Entries();
        }

        private void panelLoad_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void lblPersian_Click(object sender, EventArgs e)
        {
            panelLoad.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            open.Filter = "Text File ورودی متنی| *.txt";
            if(open.ShowDialog()== DialogResult.OK)
            {
                LoadTextFile(open.FileName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Entries();
        }

        private void Entries()
        {
            var msg = "Parcel(s) List: ";
            foreach (var item in OrderTemp)
            {
                msg += Environment.NewLine + item;
            }
            MessageBox.Show(msg, "لیست بسته های در صف انتظار", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelLoad_Click(object sender, EventArgs e)
        {
            panelLoad.Visible = false;

        }
    }
}
