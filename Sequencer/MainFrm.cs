using Sequencer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sequencer
{
    public partial class MainFrm : Form
    {
        const int GATE_WIDTH = 70;
        const int EDGE = 173;

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


            foreach (var o in OrderTemp)
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
            this.Controls.Add(new_parcel.Button);
            new_parcel.Button.Tag = new_parcel;

            new_parcel.Button.Click += Button_Click;
            new_parcel.Button.BringToFront();


            Parcels.Add(new_parcel);
            Clock++;

        }

        int sec = 0;
        public int Clock
        {
            get
            {
                return sec;
            }
            set
            {
                sec = value;
                if (sec < 10)
                    lblClock.Text = "00:" + "0" + sec;
                else
                    lblClock.Text = "00:" + sec;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            Push(sender, e);
            Release(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
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
    }
}
