using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sequencer.Models
{
    public class Parcel : IParcel

    {
        const int SIZE = 50;
        const int GAP = 21;
        const int INSIDE = 27;
        const int LEFT = 1050;
        const int TOP = 232;
        const int PROFILER = 940;



        public int Index { get; set; }
        public bool Placed { get; set; }
        public int Number { get; set; }
        public bool Back { get; set; }
        public bool Exit { get; set; }
        public Button Button { get; set; } = new Button() { Left = LEFT, Top = TOP, Size = new Size(SIZE, SIZE), BackColor = Color.Gold };
        public Gate Gate { get; set; } = new Gate();

        public Parcel(int index)
        {
            Index = index;
            Number = Index;
            Button.BackColor = Color.FromArgb(100, new Random().Next(0, 255), new Random().Next(0, 255));
            Button.Font = new Font("B yekan", 16);
            Button.FlatStyle = FlatStyle.Popup;
            Button.ForeColor = Color.Black;
            if (index % 5 == 0)
                Button.BackColor = Color.Red;
            if (index % 10 == 0)
                Button.BackColor = Color.Gold;
            if (index % 6 == 0)
                Button.BackColor = Color.LightGreen;




            Gate = MainFrm.Gates.FirstOrDefault(s => s.Index == index);
            if (Gate == null)
            {
                Gate = new Gate();
            }

        }

        public void Down()
        {


            Button.Location = new Point(Button.Location.X, Button.Location.Y + Button.Width + INSIDE);

        }

        public bool IsInSide()
        {
            if (Button.Location.X >= Gate.Start && Button.Location.X <= Gate.End)
                return true;
            return false;
        }
        public void Shift()
        {
            if (Placed)
            {
                Button.BackgroundImage = null;

                return;
            }

            if (IsInSide())
            {
                if (Gate.Row == Row.UP)
                    Up();
                else
                    Down();
                Placed = true;

                return;
            }


            Button.Location = new Point(Button.Location.X - Button.Width - GAP, Button.Location.Y);
            if (Button.Location.X < PROFILER)
                Button.Text = Number.ToString();
            if (IsInSide())
            {
                if (Gate.Row == Row.UP)
                    Button.BackgroundImage = Properties.Resources.up;

                else
                    Button.BackgroundImage = Properties.Resources.down;



            }

        }

        public void Release()
        {
            if (Exit)
            {
                Button.Location = new Point(Button.Location.X - Button.Width - GAP, Button.Location.Y);
                return;
            }
            if (Exit || !Placed)
                return;
            Button.BackColor = Color.Gold;

            if (!Back)
            {


                if (Gate.Row == Row.DOWN)
                {
                    Button.BackgroundImage = Properties.Resources.up;

                    Up();
                }
                else
                {
                    Button.BackgroundImage = Properties.Resources.down;

                    Down();
                }

                Back = true;

                return;
            }
            Button.BackgroundImage = null; ;

            Button.Location = new Point(Button.Location.X - Button.Width - GAP, Button.Location.Y);

            if (Button.Location.X < 0)
            {
                Exit = true;
                Button.Location = new Point(1200, 492);
            }

        }



        public void Up()
        {
            Button.Location = new Point(Button.Location.X, Button.Location.Y - Button.Width - INSIDE);

        }
    }
}
