using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gokuBattle
{
	public partial class MainForm : Form
	{
		bool viradoRP1 = true;
		bool viradoRP2 = true;
		
		public MainForm()
		{
			InitializeComponent();
			pictureBox2.Parent = pictureBox1;
			pictureBox3.Parent = pictureBox1;
			pictureBox4.Parent = pictureBox1;
			pictureBox5.Parent = pictureBox1;
			pictureBox6.Parent = pictureBox1;
			pictureBox7.Parent = pictureBox1;
			pictureBox2.Left = 50;
			pictureBox2.Top = 220;
			pictureBox7.Left = 1150;
			pictureBox7.Top = 220;
			timer1.Interval = 15;
			timer2.Interval = 15;
			timer3.Interval = 70;
			timer4.Interval = 70;
			timer5.Interval = 15;
			timer6.Interval = 15;
			timer7.Interval = 70;
			timer8.Interval = 70;
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			
			
			if(e.KeyCode == Keys.W)
			{
				pictureBox2.Top -= 25;
			}
			if(e.KeyCode == Keys.S)
			{
				pictureBox2.Top += 25;
			}
			if(e.KeyCode == Keys.A)
			{
				pictureBox2.Left -= 25;
				pictureBox2.Load("gokuIdleL.gif");
				viradoRP1 = false;
			}
			if(e.KeyCode == Keys.D)
			{
				pictureBox2.Left += 25;
				pictureBox2.Load("gokuIdleR.gif");
				viradoRP1 = true;
			}
			if(e.KeyCode == Keys.Space)
			{
				if(viradoRP1 == true)
				{
					timer1.Enabled = true;
					pictureBox2.Load("gokuAttackR.png");
					pictureBox3.Visible = true;
					pictureBox3.Top = pictureBox2.Top + 45;
					pictureBox3.Left = pictureBox2.Left + 110;
					timer4.Enabled = true;
				}
				if(viradoRP1 == false)
				{
					timer2.Enabled = true;
					pictureBox2.Load("gokuAttackL.png");
					pictureBox4.Visible = true;
					pictureBox4.Top = pictureBox2.Top + 45;
					pictureBox4.Left = pictureBox2.Left - 20;
					timer3.Enabled = true;
				}
			}
			
			if(e.KeyCode == Keys.I)
			{
				pictureBox7.Top -= 25;
			}
			if(e.KeyCode == Keys.K)
			{
				pictureBox7.Top += 25;
			}
			if(e.KeyCode == Keys.J)
			{
				pictureBox7.Left -= 25;
				pictureBox7.Load("gokuIdleL.gif");
				viradoRP2 = false;
			}
			if(e.KeyCode == Keys.L)
			{
				pictureBox7.Left += 25;
				pictureBox7.Load("gokuIdleR.gif");
				viradoRP2 = true;
			}
			if(e.KeyCode == Keys.Enter)
			{
				if(viradoRP2 == true)
				{
					timer5.Enabled = true;
					pictureBox7.Load("gokuAttackR.png");
					pictureBox6.Visible = true;
					pictureBox6.Top = pictureBox7.Top + 45;
					pictureBox6.Left = pictureBox7.Left + 110;
					timer8.Enabled = true;
				}
				if(viradoRP2 == false)
				{
					timer6.Enabled = true;
					pictureBox7.Load("gokuAttackL.png");
					pictureBox5.Visible = true;
					pictureBox5.Top = pictureBox7.Top + 45;
					pictureBox5.Left = pictureBox7.Left - 20;
					timer7.Enabled = true;
				}
			}
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			pictureBox3.Left += 30;
		}
		void Timer2Tick(object sender, EventArgs e)
		{
			pictureBox4.Left -= 30;
		}
		void Timer3Tick(object sender, EventArgs e)
		{
			pictureBox2.Load("gokuIdleL.gif"); 
			timer3.Enabled = false;
		}
		void Timer4Tick(object sender, EventArgs e)
		{
			pictureBox2.Load("gokuIdleR.gif");
			timer4.Enabled = false;
		}
		void Timer5Tick(object sender, EventArgs e)
		{
			pictureBox6.Left += 30;
		}
		void Timer6Tick(object sender, EventArgs e)
		{
			pictureBox5.Left -= 30;
		}
		void Timer7Tick(object sender, EventArgs e)
		{
			pictureBox7.Load("gokuIdleL.gif"); 
			timer7.Enabled = false;
		}
		void Timer8Tick(object sender, EventArgs e)
		{
			pictureBox7.Load("gokuIdleR.gif");
			timer8.Enabled = false;
		}
	}
}
