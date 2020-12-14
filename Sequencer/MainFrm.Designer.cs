
namespace Sequencer
{
    partial class MainFrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblClock = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(599, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "SHIFT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(329, 606);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "PUSH";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Push);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("B Yekan", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblClock.Location = new System.Drawing.Point(923, 19);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(78, 36);
            this.lblClock.TabIndex = 4;
            this.lblClock.Text = "00:00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(329, 675);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Auto";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(413, 606);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 63);
            this.button3.TabIndex = 6;
            this.button3.Text = "RELEASE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Release);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(-10, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1045, 80);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(166, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(721, 234);
            this.button5.TabIndex = 8;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "12";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "13";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "16";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "14";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(814, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "20";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(743, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "19";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(672, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "18";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(601, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "17";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(814, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "09";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 428);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "08";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(601, 428);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "07";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(530, 428);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "06";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(459, 428);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "05";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(388, 428);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 22;
            this.label17.Text = "04";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(317, 428);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "03";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(246, 428);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 20;
            this.label19.Text = "02";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(175, 428);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "01";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(-10, 496);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1045, 80);
            this.button6.TabIndex = 29;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 716);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblClock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Name = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button6;
    }
}

