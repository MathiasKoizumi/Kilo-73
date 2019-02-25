using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
	public class Form1 : Form
	{
		[CompilerGenerated]
		private IContainer components;

		private Jingo bob;

		public Form1 formular;

		private Jongo trælle;

		private WindowsMediaPlayer wplayer = (WindowsMediaPlayer)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));

		private Random time = new Random();

		private int ibli = 100;

		private int abli = 3000;

		public int cula = 200;

		private string currentMp3 = "Math.mp3";

		private int cola;

		private int tookie = 1000;

		private Panel panel1;

		private Button button1;

		private Button button2;

		private ComboBox comboBox1;

		private BolleHeaven kukur;

		private List<Afmagt> bollemælk;

		public Random junkie = new Random();

		public Graphics gfx;

		public System.Timers.Timer timer1;

		public System.Timers.Timer timer2;

		public bool timer1IsRunning;

		public bool timer2IsRunning;

		private double scale = 1.0;

		private bool infinity = true;

		private int typeShowUp = 2;

		private string sprach = "Shislak";

		private string[] resourse = new string[11];

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormsApplication1.Form1));
			panel1 = new System.Windows.Forms.Panel();
			comboBox1 = new System.Windows.Forms.ComboBox();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.AutoSize = true;
			panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel1.Controls.Add(comboBox1);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Font = new System.Drawing.Font("Verdana", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(787, 255);
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			comboBox1.Font = new System.Drawing.Font("Verdana", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[11]
			{
				"ascenzion+needfulthings.mp3",
				"ascenzion+getonthefunktrain.mp3",
				"eddrury+jordanstheme.mp3",
				"eddrury+mistystheme.mp3",
				"ericrfairhurst+catch22.mp3",
				"phroneeino+fourfortyfour.mp3",
				"phroneeino+pink.mp3",
				"phroneeino+theangelssing.mp3",
				"phroneeino+whoisincontrolhousemix.mp3",
				"plingolade.mp3",
				"Blue sky.mp3"
			});
			comboBox1.Location = new System.Drawing.Point(524, 160);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(251, 24);
			comboBox1.TabIndex = 5;
			comboBox1.Text = "eddrury+jordanstheme.mp3";
			comboBox1.SelectedValueChanged += new System.EventHandler(comboBox1_SelectedValueChanged);
			button2.Image = (System.Drawing.Image)componentResourceManager.GetObject("button2.Image");
			button2.Location = new System.Drawing.Point(762, 3);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(22, 20);
			button2.TabIndex = 3;
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button1.BackColor = System.Drawing.Color.Transparent;
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button1.Font = new System.Drawing.Font("Segoe Print", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.Image = (System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			button1.Location = new System.Drawing.Point(524, 201);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(251, 42);
			button1.TabIndex = 2;
			button1.Text = "T\u00b4-i\u00b4m- i\u00b4s s\u00b4o-";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(bongo);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			base.ClientSize = new System.Drawing.Size(787, 255);
			base.Controls.Add(panel1);
			Cursor = System.Windows.Forms.Cursors.Arrow;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			Text = "-Kviol";
			base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			base.Activated += new System.EventHandler(Loadup);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormClosingMeDown);
			base.Load += new System.EventHandler(Form_loadme);
			base.Shown += new System.EventHandler(Form1_Shown);
			base.ResizeEnd += new System.EventHandler(ResizeDone);
			base.EnabledChanged += new System.EventHandler(TryEnabled);
			panel1.ResumeLayout(performLayout: false);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			panel1_Paint(0, e);
			base.OnPaint(e);
		}

		public Form1()
		{
			InitializeComponent();
			gfx = panel1.CreateGraphics();
			timer1 = new System.Timers.Timer(8000.0);
			timer1.AutoReset = false;
			timer1.Elapsed += timer1_Elapsed;
			timer2 = new System.Timers.Timer(400000.0);
			timer2.AutoReset = false;
			timer2.Elapsed += timer2_Elapsed;
			timer2.Start();
			unpackSound();
			switch (junkie.Next(3))
			{
			case 0:
				sprach = "Jongonese";
				break;
			case 1:
				sprach = "Kitara";
				break;
			case 2:
				sprach = "Shislak";
				break;
			}
			nameCalling();
			kukur = new BolleHeaven(this);
		}

		private void timer1_Elapsed(object sender, ElapsedEventArgs e)
		{
			timer1IsRunning = false;
			Console.WriteLine("Timer stopped");
		}

		private void timer2_Elapsed(object sender, ElapsedEventArgs e)
		{
			timer2IsRunning = false;
			Console.WriteLine("Timer2 stopped");
		}

		public void moveLabel(Label lal, Random kf)
		{
			Point point2 = lal.Location = new Point(kf.Next(200) + 610, kf.Next(140));
		}

		public void avoidCollisionLabel(Label l, Label j)
		{
			if (l.Location.Y > j.Location.Y && l.Location.Y - j.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
			if (l.Location.Y < j.Location.Y && j.Location.Y - l.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
		}

		private void bongo(object sender, EventArgs e)
		{
			timer1 = new System.Timers.Timer(8000.0);
			timer1.AutoReset = false;
			timer1.Elapsed += timer1_Elapsed;
			timer2.Start();
			timer2IsRunning = true;
			button1.Visible = false;
			button2.Visible = false;
			comboBox1.Visible = false;
			switch (new Random().Next(28))
			{
			case 0:
				button1.Text = "F4\u00b4 zi-h\u00b4 neu-n";
				break;
			case 1:
				button1.Text = "3afs";
				break;
			case 2:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 3:
				button1.Text = "Combat f-yr\u00b4";
				break;
			case 4:
				button1.Text = "Spra\u00b4ch me\u00b4";
				break;
			case 5:
				button1.Text = "Før-\u00b4e li\u00b4d\u00b4";
				break;
			case 6:
				button1.Text = "TilbageSåLængeViSerTv";
				break;
			case 7:
				button1.Text = "GameOn43nul,5";
				break;
			case 8:
				button1.Text = "HolaEspaniolTrinkenBitteSehr";
				break;
			case 9:
				button1.Text = "BørneTVTidsFornøjelse";
				break;
			case 10:
				button1.Text = "f-4zehn2426nineundnine";
				break;
			case 11:
				button1.Text = "GræskLegeBarnLegerViTo";
				break;
			case 12:
				button1.Text = "GrønLilKærBotMig";
				break;
			case 13:
				button1.Text = "FjendenErNærPåGræsk";
				break;
			case 14:
				button1.Text = "NiftigeTankerOmRuslandsTerratorium";
				break;
			case 15:
				button1.Text = "RussiskStatsborgerskabBetyderNada";
				break;
			case 16:
				button1.Text = "LandflygtigeTankerBørneMigHeltIHampen";
				break;
			case 17:
				button1.Text = "Sa-yo-nara-";
				break;
			case 18:
				button1.Text = "ViGårHjemTilVinter";
				break;
			case 19:
				button1.Text = "BoTTedej";
				break;
			case 20:
				button1.Text = "|\u00b4na-do";
				break;
			case 21:
				button1.Text = "Yg\u00b4dra-\u00b4sil";
				break;
			case 22:
				button1.Text = "BummiBedste";
				break;
			case 23:
				button1.Text = "\u00b4ov be\u00b4n";
				break;
			case 24:
				button1.Text = "Vi-go";
				break;
			case 25:
				button1.Text = "BørneTroldeSnavs";
				break;
			case 26:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 27:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			default:
				button1.Text = "Dummy!!!";
				break;
			}
			for (int i = 0; i < 1; i++)
			{
				juggleMeNotPleaseHornyBilbaoWorksFine();
			}
			button1.Visible = true;
			button2.Visible = true;
			comboBox1.Visible = true;
		}

		public void fillArrayBollemælk()
		{
			Jingo jingo = new Jingo(this);
			jingo.showBirth();
			jingo.jingoTime(tidspres());
			jingo.timesTwenty(DateTime.Now);
		}

		private Juklas tidspres()
		{
			throw new NotImplementedException();
		}

		private void Form_loadme(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			base.FormBorderStyle = FormBorderStyle.None;
			panel1.Size = base.ClientSize;
		}

		private void FormClosingMeDown(object sender, FormClosingEventArgs e)
		{
			TryToDelete("Math.mp3");
		}

		private static bool TryToDelete(string f)
		{
			try
			{
				File.Delete(f);
				return true;
			}
			catch (IOException)
			{
				return false;
			}
		}

		private void Loadup(object sender, EventArgs e)
		{
			gfx = panel1.CreateGraphics();
			button1.Location = new Point(base.ClientSize.Width - (button1.Width + 100), base.ClientSize.Height - (button1.Height + 50));
			button2.Location = new Point(base.ClientSize.Width - 45, 10);
			Point location = button1.Location;
			location.Y -= button1.Height + 10;
			comboBox1.Location = location;
		}

		internal void burnRubber(double p, float p_2, int colorpoint)
		{
			if (gfx != null && junkie.Next((int)p_2) <= 800)
			{
				for (int i = 0; i < 1000; i++)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(10), colorpoint - junkie.Next(colorpoint), colorpoint - junkie.Next(colorpoint), colorpoint - junkie.Next(colorpoint))), new Rectangle(junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p)));
				}
			}
		}

		internal void brunstigCookie(Børnetid børnetid, int p)
		{
		}

		public void newJongo()
		{
			trælle = new Jongo(this);
		}

		private void unpackSound()
		{
			resourse[0] = (string)comboBox1.Items[0];
			resourse[1] = (string)comboBox1.Items[1];
			resourse[2] = (string)comboBox1.Items[2];
			resourse[3] = (string)comboBox1.Items[3];
			resourse[4] = (string)comboBox1.Items[4];
			resourse[5] = (string)comboBox1.Items[5];
			resourse[6] = (string)comboBox1.Items[6];
			resourse[7] = (string)comboBox1.Items[7];
			resourse[8] = (string)comboBox1.Items[8];
			resourse[9] = (string)comboBox1.Items[9];
			resourse[10] = (string)comboBox1.Items[10];
			for (int i = 0; i < 11; i++)
			{
				Stream manifestResourceStream = GetType().Assembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Music." + resourse[i]);
				if (!File.Exists(resourse[i]))
				{
					using (Stream output = File.Create(resourse[i]))
					{
						CopyStream(manifestResourceStream, output);
					}
				}
			}
		}

		public void playMP3()
		{
			wplayer.controls.stop();
			wplayer.URL = resourse[junkie.Next(11)];
			wplayer.controls.play();
		}

		public static void CopyStream(Stream input, Stream output)
		{
			byte[] array = new byte[8192];
			int count;
			while ((count = input.Read(array, 0, array.Length)) > 0)
			{
				output.Write(array, 0, count);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		public void timetoJongoisme()
		{
			for (int i = 0; i < trælle.getJohn().Count; i++)
			{
				Point[] waypoints = trælle.getJohn()[i].getWaypoints();
				for (int j = 0; j < waypoints.Length; j++)
				{
					waypoints[j].X = waypoints[j].X + 1;
					waypoints[j].Y = waypoints[j].Y + 200;
				}
				trælle.getJohn()[i].changeCourse();
			}
		}

		public void jongoTime()
		{
			if (!timer2IsRunning)
			{
				return;
			}
			if (trælle == null)
			{
				newJongo();
			}
			int num = junkie.Next(1700);
			int num2 = junkie.Next(1000);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png");
			Image image = Image.FromStream(manifestResourceStream);
			switch (junkie.Next(7))
			{
			case 0:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 1:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman2.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 2:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman3.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 3:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman4.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 4:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman5.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 5:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman6.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 6:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman7.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			}
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string text in array)
			{
			}
			BolleHeaven bolleHeaven = new BolleHeaven(this);
			for (int num3 = junkie.Next(4) + 22; num3 >= 0; num3--)
			{
				if (junkie.Next(2) == 0)
				{
					bolleHeaven = new BolleHeaven(this);
				}
				if (cula < 4)
				{
					switch (junkie.Next(3))
					{
					case 0:
						sprach = "Jongonese";
						break;
					case 1:
						sprach = "Kitara";
						break;
					case 2:
						sprach = "Shislak";
						break;
					}
					nameCalling();
					cula = 200;
				}
				cula--;
				for (int num4 = trælle.getJohn().Count - 1; num4 > 0; num4--)
				{
					if (ibli < 3)
					{
						ibli = 300;
					}
					else
					{
						ibli -= 2;
					}
					if (abli < 3)
					{
						abli = 6000;
					}
					else
					{
						abli -= 2;
					}
					tookie--;
					trælle.getJohn()[num4].changeCourse();
					trælle.getJohn()[num4].moodChange(trælle.getJohn()[num4].changeCourse(), new Juklas(this));
					timetoJongoisme();
					switch (time.Next(8))
					{
					case 0:
						gfx.FillEllipse(new SolidBrush(trælle.getJohn()[num4].getColor()), new Rectangle(trælle.getJohn()[num4].getPoint(), trælle.getJohn()[num4].getSize()));
						break;
					case 1:
						for (int num8 = 100; num8 >= 0; num8--)
						{
							Random random = new Random();
							gfx.FillClosedCurve(new SolidBrush(Color.FromArgb(random.Next(150), random.Next(25) + 200, random.Next(15) + 200, random.Next(40) + 215)), createPoints(3));
						}
						break;
					case 2:
						for (int num9 = 40; num9 >= 0; num9--)
						{
							Point[] points = createPoints(4, 0);
							gfx.FillPolygon(new SolidBrush(Color.FromArgb(new Random().Next(180), new Random().Next(40) + 200, new Random().Next(40) + 200, new Random().Next(55) + 200)), points);
						}
						break;
					case 3:
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(900), junkie.Next(700), junkie.Next(900), junkie.Next(700));
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(900), junkie.Next(10), junkie.Next(100) + 800, junkie.Next(10) + 700);
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(10), junkie.Next(10), junkie.Next(800) + 10, junkie.Next(10) + 700);
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), 450, 350, junkie.Next(900), junkie.Next(700));
						break;
					case 4:
						if (junkie.Next(cula) <= 20)
						{
							if (sprach == "Kitara")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.gEn2Name(245, junkie) + " " + bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
							else if (sprach == "Jongonese")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.wordUP() + " " + bolleHeaven.wordUP(), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.wordUP(), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
							else if (sprach == "Shislak")
							{
								if (junkie.Next(3) == 0)
								{
									gfx.DrawString(bolleHeaven.testMeYO() + " " + bolleHeaven.testMeYO(), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
								}
								else
								{
									gfx.DrawString(bolleHeaven.testMeYO(), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
								}
							}
						}
						if (junkie.Next(300) == 0)
						{
							switch (junkie.Next(8))
							{
							case 0:
								gfx.DrawString("B\u00b4or te med\u00b4 bte-læ-s\u00b4en", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 1:
								gfx.DrawString("To-Hundrede-Mennesker", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 2:
								gfx.DrawString("4'BøttenKasper", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 3:
								gfx.DrawString("TovliEtScriptHa!!", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 4:
								gfx.DrawString("200 Metric Tons---Beware!!!", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 5:
								gfx.DrawString("Clitoris Ring Me Up Sooner Today", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 6:
								gfx.DrawString("JoinForce!!!RingBellNow", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							case 7:
								gfx.DrawString("TweiHundredSwizerNoiaComeOn!!", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
								break;
							}
							cola = 1;
						}
						if (junkie.Next(400) == 0)
						{
							gfx.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 72f, FontStyle.Bold), new LinearGradientBrush(new Point(0, 0), new Point(600, 600), Color.White, Color.DarkSlateGray), new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
						}
						break;
					case 5:
					{
						int num6 = -200;
						int num7 = 1000;
						if (tookie < 0)
						{
							tookie = Børnetid.tandemspring(4000);
							for (int j = 0; j < 20; j++)
							{
								gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(60) + 100, junkie.Next(25) + 230, junkie.Next(25) + 230, junkie.Next(25) + 230)), new Rectangle(junkie.Next(100) + num6, junkie.Next(50) + num6, junkie.Next(1000) + num7, junkie.Next(1000) + num7));
							}
						}
						break;
					}
					case 6:
						if (junkie.Next(2) != 0)
						{
							double num5 = junkie.NextDouble();
							Image image2;
							switch (junkie.Next(5))
							{
							case 0:
								manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Planet.png");
								image2 = Image.FromStream(manifestResourceStream);
								break;
							case 1:
								manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet2.png");
								image2 = Image.FromStream(manifestResourceStream);
								break;
							case 2:
								manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet3.png");
								image2 = Image.FromStream(manifestResourceStream);
								break;
							case 3:
								manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet4.png");
								image2 = Image.FromStream(manifestResourceStream);
								break;
							case 4:
								manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.planet5.png");
								image2 = Image.FromStream(manifestResourceStream);
								break;
							default:
								manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.world.png");
								image2 = Image.FromStream(manifestResourceStream);
								break;
							}
							if (junkie.Next(abli) > 2500)
							{
								gfx.DrawImage(image2, (int)(100.0 + (double)num * Math.Sin(junkie.Next(10000))) + 200, 100 + num2 + (int)(200.0 * Math.Sin(junkie.Next(10000))), (int)((double)image2.Width * 0.1 * num5 + (double)(image2.Width / 9)), (int)((double)image2.Height * 0.1 * num5 + (double)(image2.Height / 9)));
							}
							if (junkie.Next(ibli) > 150)
							{
								gfx.DrawImage(image, new Rectangle(new Point(100 + num + (int)(100.0 * Math.Sin(junkie.Next(10000))), 100 + num2 + (int)(200.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * 0.3), (int)((double)image.Height * 0.3)))));
							}
							image2.Dispose();
						}
						break;
					case 7:
						if (junkie.Next(5) == 0)
						{
							BlackStrangeCloud(100);
						}
						break;
					}
				}
			}
		}

		private Point[] createPoints(int p, int p_2)
		{
			Point[] array = new Point[p];
			for (int num = p - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(530) + 50, new Random().Next(200));
			}
			return array;
		}

		private Point[] createPoints(int k)
		{
			Point[] array = new Point[k];
			for (int num = k - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(630) + 200, new Random().Next(350) + 150);
			}
			modifyPoints(array);
			return array;
		}

		public void modifyPoints(Point[] j)
		{
			for (int num = j.Length - 1; num >= 0; num--)
			{
				double num2 = Math.Sin(new Random().Next(500));
				if (num2 == 0.0)
				{
					num2 = 1.0;
				}
				j[num].X = j[num].X * (int)(Math.Sin(new Random().Next(500)) / num2);
			}
		}

		public Form1 sendForm()
		{
			return this;
		}

		internal void TeleTubingDoneWrong(int p, string p_2)
		{
			if (gfx != null)
			{
				gfx.DrawString(p_2, new Font("Comic Sans MS", 32f, FontStyle.Italic), Brushes.White, new PointF(junkie.Next(1000), junkie.Next(1600)));
			}
		}

		internal void JusticeFormMoney(int k, int p)
		{
			if (gfx != null)
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddBezier(junkie.Next(k + 600) - junkie.Next(k + 600) + 450, junkie.Next(k + 500) - junkie.Next(k + 500) + 450, junkie.Next(k + 300) - junkie.Next(k + 300) + 450, junkie.Next(k + 600) - junkie.Next(k + 600) + 450, junkie.Next(k + 800) - junkie.Next(k + 800) + 450, junkie.Next(k + 400) - junkie.Next(k + 400) + 450, junkie.Next(k) - junkie.Next(k) + 450, junkie.Next(k + 500) - junkie.Next(k + 500) + 450);
				PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);
				pathGradientBrush.CenterColor = Color.FromArgb(junkie.Next(5), junkie.Next(250), junkie.Next(250), junkie.Next(250));
				gfx.FillPath(pathGradientBrush, graphicsPath);
			}
		}

		private void ResizeDone(object sender, EventArgs e)
		{
		}

		private void TryEnabled(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			playMP3();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			playMP3();
		}

		public override void Refresh()
		{
		}

		public void explodeMe(int x, int y)
		{
			int num = 100;
			int num2 = junkie.Next(x);
			int num3 = junkie.Next(y);
			int maxValue = junkie.Next(25) + 45;
			int maxValue2 = junkie.Next(25) + 45;
			int maxValue3 = junkie.Next(25) + 45;
			for (int i = 0; i < 50; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 20, junkie.Next(maxValue) + 185, junkie.Next(maxValue2) + 185, junkie.Next(maxValue3) + 185)), new Rectangle(junkie.Next(100) - junkie.Next(100) + num2, junkie.Next(100) - junkie.Next(100) + num3, junkie.Next(100) + num, junkie.Next(100) + num));
				}
			}
		}

		internal void drawFunnyShapes(int p, int p_2)
		{
			if (gfx == null)
			{
				return;
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Spaceship.png");
			Image image = Image.FromStream(manifestResourceStream);
			manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Pill-icon.png");
			Image image2 = Image.FromStream(manifestResourceStream);
			SetImgOpacity(image, (float)junkie.NextDouble());
			SetImgOpacity(image2, (float)junkie.NextDouble());
			for (int i = 0; i < p + junkie.Next(500); i++)
			{
				double num = Math.Abs((double)junkie.Next(20) + 3.0 * Math.Sin(junkie.Next(360)));
				if (num < 2.0)
				{
					num = 3.0;
				}
				gfx.DrawImage(image, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 500, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 400, (int)((double)image.Width / num), (int)((double)image.Height / num));
				gfx.DrawImage(image2, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 500, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 400, (int)((double)image.Width / num), (int)((double)image.Height / num));
			}
		}

		public static Image SetImgOpacity(Image imgPic, float imgOpac)
		{
			Bitmap bitmap = new Bitmap(imgPic.Width, imgPic.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			ColorMatrix colorMatrix = new ColorMatrix();
			colorMatrix.Matrix33 = imgOpac;
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			graphics.DrawImage(imgPic, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, imgPic.Width, imgPic.Height, GraphicsUnit.Pixel, imageAttributes);
			graphics.Dispose();
			return bitmap;
		}

		internal void Explosionshow(int numbers, Rectangle area)
		{
			for (int i = 0; i < numbers; i++)
			{
				explodeMe(area);
			}
		}

		private void explodeMe(Rectangle area)
		{
			if (gfx == null)
			{
				return;
			}
			int num = 60;
			int num2 = junkie.Next(area.X, area.X + area.Width);
			int num3 = junkie.Next(area.Y, area.Y + area.Height);
			int num4 = junkie.Next(15) + 60;
			int num5 = junkie.Next(15) + 60;
			int num6 = junkie.Next(15) + 60;
			switch (junkie.Next(7))
			{
			case 0:
				num4 -= 60;
				break;
			case 1:
				num5 -= 60;
				break;
			case 2:
				num6 -= 60;
				break;
			case 3:
				num4 -= 60;
				num6 -= 60;
				break;
			case 4:
				num5 -= 60;
				num4 -= 60;
				break;
			case 5:
				num6 -= 60;
				num5 -= 60;
				break;
			}
			for (int i = 0; i < 10; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 10, junkie.Next(num4) + 175, junkie.Next(num5) + 175, junkie.Next(num6) + 175)), new Rectangle(junkie.Next(30) - junkie.Next(30) + num2, junkie.Next(30) - junkie.Next(30) + num3, junkie.Next(20) + num, junkie.Next(20) + num));
				}
			}
		}

		internal void writeMeAStory()
		{
			int num = junkie.Next(600);
			int num2 = junkie.Next(800);
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					gfx.DrawString(sentenceVolaHovskiPovski[i], new Font("Arial", 24f), Brushes.White, 100 + num, 100 + num2 + i * 30);
				}
				Thread.Sleep(2000);
			}
		}

		public void SpellOut(int p)
		{
			if (kukur == null)
			{
				return;
			}
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				int num = junkie.Next(600);
				int num2 = junkie.Next(800);
				List<string> list = new List<string>();
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					list.AddRange(sentenceVolaHovskiPovski[i].Split(' '));
				}
				List<string> list2 = list;
				int num3 = 0;
				Size size = new Size(0, 0);
				for (int j = 0; j < p; j++)
				{
					gfx.DrawString(list[j], new Font("Arial", 48f), Brushes.White, 50 + size.Width + num, 100 + num2);
					size.Width += TextRenderer.MeasureText(list[j], new Font("Arial", 48f)).Width;
					num3 += list[j].Length;
					Thread.Sleep(200);
				}
				Thread.Sleep(100);
			}
		}

		internal void RoundweGo(int p)
		{
		}

		internal void BlackHoleoneTwothousand(int p, Rectangle area)
		{
			int num = junkie.Next(area.Left, area.Left + area.Width);
			int num2 = junkie.Next(area.Top, area.Top + area.Height);
			Color color;
			switch (junkie.Next(5))
			{
			case 0:
				color = Color.FromArgb(2, Color.Red);
				break;
			case 1:
				color = Color.FromArgb(2, Color.SeaGreen);
				break;
			case 2:
				color = Color.FromArgb(2, Color.Yellow);
				break;
			case 3:
				color = Color.FromArgb(2, Color.Brown);
				break;
			case 4:
				color = Color.FromArgb(2, Color.DarkGreen);
				break;
			default:
				color = Color.FromArgb(2, Color.Red);
				break;
			}
			for (int i = 0; i < p; i++)
			{
				gfx.FillEllipse(new SolidBrush(color), new Rectangle(junkie.Next(50) - junkie.Next(50) + num, junkie.Next(50) - junkie.Next(50) + num2, junkie.Next(400) + 300, junkie.Next(400) + 300));
			}
		}

		public void FlashMob(int p)
		{
			switch (junkie.Next(2))
			{
			case 1:
			{
				Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.skullandguns.png");
				Image image2 = Image.FromStream(manifestResourceStream2);
				if (junkie.Next(2) == 0)
				{
					gfx.DrawImage(image2, 600 - image2.Width / 2, 500 - image2.Height / 2, (float)((double)image2.Width * 1.5), (float)((double)image2.Height * 1.5));
				}
				break;
			}
			case 0:
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.peace.png");
				Image image = Image.FromStream(manifestResourceStream);
				if (junkie.Next(2) == 0)
				{
					gfx.DrawImage(image, 500 - image.Width / 2, 200 - image.Height / 2, (float)((double)image.Width * 2.5), (float)((double)image.Height * 2.5));
				}
				break;
			}
			}
		}

		public void CallMe(int p)
		{
			if (junkie.Next(20) != 0)
			{
				return;
			}
			for (int i = 0; i < 10; i++)
			{
				switch (junkie.Next(9))
				{
				case 0:
				{
					Assembly executingAssembly8 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream8 = executingAssembly8.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask.png");
					Image image8 = Image.FromStream(manifestResourceStream8);
					if (junkie.Next(2) == 0)
					{
						for (int num3 = 0; num3 < 1; num3++)
						{
							gfx.DrawImage(image8, junkie.Next(1400), junkie.Next(800), (float)((double)image8.Width * 0.3), (float)((double)image8.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 1:
				{
					Assembly executingAssembly5 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream5 = executingAssembly5.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask2.png");
					Image image5 = Image.FromStream(manifestResourceStream5);
					if (junkie.Next(2) == 0)
					{
						for (int n = 0; n < 1; n++)
						{
							gfx.DrawImage(image5, junkie.Next(1400), junkie.Next(800), (float)((double)image5.Width * 0.3), (float)((double)image5.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 2:
				{
					Assembly executingAssembly9 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream9 = executingAssembly9.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask.png");
					Image image9 = Image.FromStream(manifestResourceStream9);
					if (junkie.Next(2) == 0)
					{
						for (int num4 = 0; num4 < 1; num4++)
						{
							gfx.DrawImage(image9, junkie.Next(1400), junkie.Next(800), (float)((double)image9.Width * 0.3), (float)((double)image9.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 3:
				{
					Assembly executingAssembly3 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask2.png");
					Image image3 = Image.FromStream(manifestResourceStream3);
					if (junkie.Next(2) == 0)
					{
						for (int l = 0; l < 1; l++)
						{
							gfx.DrawImage(image3, junkie.Next(1400), junkie.Next(800), (float)((double)image3.Width * 0.3), (float)((double)image3.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 4:
				{
					Assembly executingAssembly6 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream6 = executingAssembly6.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask3.png");
					Image image6 = Image.FromStream(manifestResourceStream6);
					if (junkie.Next(2) == 0)
					{
						for (int num = 0; num < 1; num++)
						{
							gfx.DrawImage(image6, junkie.Next(1400), junkie.Next(800), (float)((double)image6.Width * 0.3), (float)((double)image6.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 5:
				{
					Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask3.png");
					Image image2 = Image.FromStream(manifestResourceStream2);
					if (junkie.Next(2) == 0)
					{
						for (int k = 0; k < 1; k++)
						{
							gfx.DrawImage(image2, junkie.Next(1400), junkie.Next(800), (float)((double)image2.Width * 0.3), (float)((double)image2.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 6:
				{
					Assembly executingAssembly7 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream7 = executingAssembly7.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask.png");
					Image image7 = Image.FromStream(manifestResourceStream7);
					if (junkie.Next(2) == 0)
					{
						for (int num2 = 0; num2 < 1; num2++)
						{
							gfx.DrawImage(image7, junkie.Next(1400), junkie.Next(800), (float)((double)image7.Width * 0.3), (float)((double)image7.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 7:
				{
					Assembly executingAssembly4 = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream4 = executingAssembly4.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask2.png");
					Image image4 = Image.FromStream(manifestResourceStream4);
					if (junkie.Next(2) == 0)
					{
						for (int m = 0; m < 1; m++)
						{
							gfx.DrawImage(image4, junkie.Next(1400), junkie.Next(800), (float)((double)image4.Width * 0.3), (float)((double)image4.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				case 8:
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.flask3.png");
					Image image = Image.FromStream(manifestResourceStream);
					if (junkie.Next(2) == 0)
					{
						for (int j = 0; j < 1; j++)
						{
							gfx.DrawImage(image, junkie.Next(1400), junkie.Next(800), (float)((double)image.Width * 0.3), (float)((double)image.Height * 0.3));
							Thread.Sleep(100);
						}
					}
					break;
				}
				}
			}
		}

		internal void JumpOut(int p)
		{
			if (junkie.Next(3) == 0)
			{
				typeShowUp = junkie.Next(3);
			}
			if (typeShowUp == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Alien2.png");
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Classicrobot.png");
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.eyerobot.png");
					break;
				case 3:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.insect_robot.png");
					break;
				case 4:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot.png");
					break;
				case 5:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot2.png");
					break;
				default:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot2.png");
					break;
				}
				Image image = Image.FromStream(manifestResourceStream);
				int num = junkie.Next(1600);
				int num2 = junkie.Next(1000);
				double num3 = (double)junkie.Next(10) + 0.6;
				for (int i = 0; i < 22; i++)
				{
					gfx.DrawImage(image, num - (int)((double)image.Width / num3) / 2, num2 - (int)((double)image.Width / num3) / 2, (int)((double)image.Width / num3), (int)((double)image.Height / num3));
					if (num3 >= 0.6)
					{
						num3 -= 0.2;
					}
					if (num3 <= 0.2)
					{
						num3 = 0.2;
					}
				}
			}
			else if (typeShowUp == 1)
			{
				Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader.png");
					break;
				case 1:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader2.png");
					break;
				case 2:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader3.png");
					break;
				case 3:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader4.png");
					break;
				case 4:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				case 5:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				default:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				}
				Image image2 = Image.FromStream(manifestResourceStream2);
				int num4 = junkie.Next(1600);
				int num5 = junkie.Next(1000);
				double num6 = (double)junkie.Next(10) + 0.9;
				for (int j = 0; j < 22; j++)
				{
					gfx.DrawImage(image2, num4 - (int)((double)image2.Width / num6) / 2, num5 - (int)((double)image2.Width / num6) / 2, (int)((double)image2.Width / num6), (int)((double)image2.Height / num6));
					if (num6 >= 0.9)
					{
						num6 -= 0.2;
					}
					if (num6 <= 0.2)
					{
						num6 = 0.2;
					}
				}
			}
			else
			{
				if (typeShowUp != 2)
				{
					return;
				}
				Assembly executingAssembly3 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite.png");
					break;
				case 1:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Satellite2.png");
					break;
				case 2:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite3.png");
					break;
				case 3:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite4.png");
					break;
				case 4:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				case 5:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				default:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				}
				Image image3 = Image.FromStream(manifestResourceStream3);
				int num7 = junkie.Next(1600);
				int num8 = junkie.Next(1000);
				double num9 = (double)junkie.Next(10) + 1.9;
				for (int k = 0; k < 22; k++)
				{
					gfx.DrawImage(image3, num7 - (int)((double)image3.Width / num9) / 2, num8 - (int)((double)image3.Width / num9) / 2, (int)((double)image3.Width / num9), (int)((double)image3.Height / num9));
					if (num9 >= 1.9)
					{
						num9 -= 0.2;
					}
					if (num9 <= 0.2)
					{
						num9 = 0.2;
					}
				}
			}
		}

		internal void BlackStrangeSpellOut(int p)
		{
			for (int i = 0; i < 50; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(7) + 15, junkie.Next(20), junkie.Next(20), junkie.Next(20))), new Rectangle(junkie.Next(200) - junkie.Next(200) + base.ClientSize.Width / 2 - 500, junkie.Next(200) - junkie.Next(200) + base.ClientSize.Height / 2 - 400, junkie.Next(500) + 500, junkie.Next(500) + 500));
				}
			}
			if (kukur == null || gfx == null)
			{
				return;
			}
			string a;
			if ((a = sprach) != null)
			{
				if (!(a == "Jongonese"))
				{
					if (!(a == "Shislak"))
					{
						if (a == "Kitara")
						{
							int num = junkie.Next(6);
							Size size = new Size(0, 0);
							string[] array = new string[num];
							for (int j = 0; j < num; j++)
							{
								array[j] = kukur.gEn2Name(200, junkie);
							}
							for (int k = 0; k < array.Length; k++)
							{
								gfx.DrawString(array[k], new Font("Segoe Script", 72f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size.Width, 300f);
								size.Width += (int)gfx.MeasureString(array[k], new Font("Segoe Script", 72f, FontStyle.Bold)).Width;
								num += array[k].Length;
								Thread.Sleep(300);
							}
						}
					}
					else
					{
						int num2 = junkie.Next(6);
						Size size2 = new Size(0, 0);
						string[] array2 = new string[num2];
						for (int l = 0; l < num2; l++)
						{
							array2[l] = kukur.testMeYO();
						}
						for (int m = 0; m < array2.Length; m++)
						{
							gfx.DrawString(array2[m], new Font("Segoe Script", 72f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size2.Width, 300f);
							size2.Width += (int)gfx.MeasureString(array2[m], new Font("Segoe Script", 72f, FontStyle.Bold)).Width;
							num2 += array2[m].Length;
							Thread.Sleep(300);
						}
					}
				}
				else
				{
					int num3 = junkie.Next(6);
					Size size3 = new Size(0, 0);
					string[] array3 = new string[num3];
					for (int n = 0; n < num3; n++)
					{
						array3[n] = kukur.wordUP();
					}
					for (int num4 = 0; num4 < array3.Length; num4++)
					{
						gfx.DrawString(array3[num4], new Font("Segoe Script", 72f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size3.Width, 300f);
						size3.Width += (int)gfx.MeasureString(array3[num4], new Font("Segoe Script", 72f, FontStyle.Bold)).Width;
						num3 += array3[num4].Length;
						Thread.Sleep(300);
					}
				}
			}
			Thread.Sleep(400);
		}

		internal void BlackStrangeCloud(int p)
		{
			for (int i = 0; i < 15; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(7) + 5, junkie.Next(20), junkie.Next(20), junkie.Next(20))), new Rectangle(junkie.Next(700) - junkie.Next(700) + base.ClientSize.Width / 2 - 100, junkie.Next(700) - junkie.Next(700) + base.ClientSize.Height / 2 - 200, junkie.Next(400) + 400, junkie.Next(400) + 400));
				}
			}
		}

		internal void trySpiralExplosions(int p, int p_2, int p_3)
		{
			if (gfx == null)
			{
				return;
			}
			int num = junkie.Next(80);
			int posX = junkie.Next(1500);
			int posX2 = junkie.Next(900);
			int num2 = junkie.Next(15) + 60;
			int num3 = junkie.Next(15) + 60;
			int num4 = junkie.Next(15) + 60;
			switch (junkie.Next(7))
			{
			case 0:
				num2 -= 60;
				break;
			case 1:
				num3 -= 60;
				break;
			case 2:
				num4 -= 60;
				break;
			case 3:
				num2 -= 60;
				num4 -= 60;
				break;
			case 4:
				num3 -= 60;
				num2 -= 60;
				break;
			case 5:
				num4 -= 60;
				num3 -= 60;
				break;
			}
			for (int i = 0; i < p; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 50, junkie.Next(num2) + 175, junkie.Next(num3) + 175, junkie.Next(num4) + 175)), new Rectangle(junkie.Next(30) - junkie.Next(30) + sinusModifier(posX), junkie.Next(30) - junkie.Next(30) + sinusModifier(posX2), junkie.Next(30) + num, junkie.Next(30) + num));
				}
			}
		}

		private int sinusModifier(int posX)
		{
			return Math.Abs((int)(Math.Sin(junkie.Next(360)) * (double)posX));
		}

		internal void ConnectTheLightsBabyJohnny(int p)
		{
			List<Point> list = new List<Point>();
			for (int i = 0; i < 10; i++)
			{
				int num = 100;
				int num2 = junkie.Next(1200);
				int num3 = junkie.Next(900);
				list.Add(new Point(num2 + 75, num3 + 75));
				int maxValue = junkie.Next(25) + 45;
				int maxValue2 = junkie.Next(25) + 45;
				int maxValue3 = junkie.Next(25) + 45;
				for (int j = 0; j < 50; j++)
				{
					if (gfx != null)
					{
						gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 20, junkie.Next(maxValue) + 85, junkie.Next(maxValue2) + 85, junkie.Next(maxValue3) + 85)), new Rectangle(junkie.Next(100) - junkie.Next(100) + num2, junkie.Next(100) - junkie.Next(100) + num3, junkie.Next(100) + num, junkie.Next(100) + num));
					}
				}
				if (list.Count > 1)
				{
					gfx.DrawLine(new Pen(Color.Black), list[i - 1], list[i]);
				}
			}
		}

		internal void drawSprialythingys(int p)
		{
			int num = 0;
			for (int i = 0; i < 500; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(10) + 5, junkie.Next(155) + 85, junkie.Next(155) + 85, junkie.Next(155) + 85)), new Rectangle(junkie.Next(1) - junkie.Next(1) + (int)((double)num * Math.Cos(num)) + junkie.Next(1200), junkie.Next(1) - junkie.Next(1) + (int)((double)num * Math.Sin(num)) + junkie.Next(900), junkie.Next(30) + p, junkie.Next(30) + p));
				}
				num++;
			}
		}

		public void ShowME()
		{
			if (junkie.Next(3) == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy4.png");
				Image image = Image.FromStream(manifestResourceStream);
				switch (junkie.Next(7))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy2.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy3.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 3:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.galaxy4.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 4:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.nebula.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 5:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.nebula2.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 6:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.nebula3.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
			}
		}

		public void sayonaraCaptainHereComesTheRain()
		{
			if (junkie.Next(1) == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene.jpg");
				Image image = Image.FromStream(manifestResourceStream);
				switch (junkie.Next(12))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene2.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene4.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 3:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene4.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 4:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene5.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 5:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene6.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 6:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene7.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 7:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene8.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 8:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene9.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 9:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene10.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 10:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene11.jpg");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 11:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.scene.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
				Thread.Sleep(2000);
				weatherManHereICome();
			}
		}

		public void weatherManHereICome()
		{
			if (junkie.Next(1) != 0)
			{
				return;
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.rain.png");
			Image image = Image.FromStream(manifestResourceStream);
			if (junkie.Next(5) == 0)
			{
				if (junkie.Next(1) == 0)
				{
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.rain.png");
					image = Image.FromStream(manifestResourceStream);
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
			}
			if (junkie.Next(3) == 0)
			{
				switch (junkie.Next(3))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.voltage.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.voltage2.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.voltage3.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				}
				gfx.DrawImage(image, 0, 0, 1750, 1100);
			}
			if (junkie.Next(4) != 0)
			{
				return;
			}
			manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.cloud.png");
			image = Image.FromStream(manifestResourceStream);
			manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.cloud2.png");
			Image image2 = Image.FromStream(manifestResourceStream);
			double num = junkie.NextDouble();
			if (num > 0.5)
			{
				num = 0.5;
			}
			for (int i = 0; i < 15; i++)
			{
				if (junkie.Next(2) == 0)
				{
					gfx.DrawImage(image, junkie.Next(1600), junkie.Next(200), (float)((double)image.Width * num), (float)((double)image.Height * num));
				}
				else
				{
					gfx.DrawImage(image2, junkie.Next(1600), junkie.Next(200), (float)((double)image2.Width * num), (float)((double)image2.Height * num));
				}
			}
		}

		private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			wplayer.controls.stop();
			wplayer.URL = resourse[comboBox1.SelectedIndex];
			wplayer.controls.play();
		}

		private void juggleMeNotPleaseHornyBilbaoWorksFine()
		{
			for (int i = 0; i < 1; i++)
			{
				new Spaceship1(this);
			}
		}

		public void wierdoFuckMe(int p)
		{
			if (kukur == null)
			{
				return;
			}
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				int num = junkie.Next(600);
				int num2 = junkie.Next(800);
				List<string> list = new List<string>();
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					list.AddRange(sentenceVolaHovskiPovski[i].Split(' '));
				}
				List<string> list2 = list;
				string[] array = new string[10]
				{
					"Arial",
					"Times New Roman",
					"Verdana",
					"Tahoma",
					"Garamond",
					"",
					"",
					"",
					"",
					""
				};
				new Size(0, 0);
				string familyName = array[3];
				string text = "";
				for (int j = 0; j < p; j++)
				{
					text = text + list[j] + " ";
				}
				gfx.DrawString(text, new Font(familyName, 48f), Brushes.White, 50 + num, 100 + num2);
			}
			Thread.Sleep(600);
		}

		public void landingIsHere(int p)
		{
			explodeMe(junkie.Next(500), junkie.Next(500));
			Thread.Sleep(400);
			switch (junkie.Next(4))
			{
			case 0:
			{
				Assembly executingAssembly4 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream4 = executingAssembly4.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.SpaceShip2.png");
				Image image4 = Image.FromStream(manifestResourceStream4);
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image4, (float)junkie.Next(1300), (float)junkie.Next(900), (float)image4.Width, (float)image4.Height);
				}
				break;
			}
			case 1:
			{
				Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.spaceship3.png");
				Image image2 = Image.FromStream(manifestResourceStream2);
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image2, junkie.Next(1300), junkie.Next(900), (float)((double)image2.Width * 0.7), (float)((double)image2.Height * 0.7));
				}
				break;
			}
			case 2:
			{
				Assembly executingAssembly3 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.spaceship4.png");
				Image image3 = Image.FromStream(manifestResourceStream3);
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image3, junkie.Next(1300), junkie.Next(900), (float)((double)image3.Width * 1.5), (float)((double)image3.Height * 1.5));
				}
				break;
			}
			case 3:
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.spaceship5.png");
				Image image = Image.FromStream(manifestResourceStream);
				if (junkie.Next(1) == 0)
				{
					gfx.DrawImage(image, junkie.Next(1300), junkie.Next(900), (float)((double)image.Width * 0.5), (float)((double)image.Height * 0.5));
				}
				break;
			}
			}
			Thread.Sleep(400);
		}

		public void nameCalling()
		{
			if (sprach == "Kitara")
			{
				if (junkie.Next(1) == 0)
				{
					gfx.DrawString("Kitara is here", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
				}
			}
			else if (sprach == "Jongonese")
			{
				if (junkie.Next(1) == 0)
				{
					gfx.DrawString("Jongonese is back", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
				}
			}
			else if (sprach == "Shislak" && junkie.Next(1) == 0)
			{
				gfx.DrawString("The name is Shislak", new Font("Segoe Script", 72f, FontStyle.Bold), Brushes.White, new PointF(300f, 500f));
			}
		}

		public void pitViper()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			switch (junkie.Next(6))
			{
			case 0:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 1:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit2.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 2:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit3.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 3:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit4.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 4:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit5.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 5:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit6.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			}
			int num = junkie.Next(1600);
			int num2 = junkie.Next(1050);
			double num3 = junkie.NextDouble() + 0.1;
			for (int i = 0; i < junkie.Next(50, 1000); i++)
			{
				if (junkie.Next(17) != 0)
				{
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(600.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num3), (int)((double)image.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
			}
		}

		public void drawAlienFishTank()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.parrot.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			switch (junkie.Next(14))
			{
			case 0:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.parrot.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 1:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.shark.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 2:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.whale.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 3:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.fish.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 4:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.fish2.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 5:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.fish3.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 6:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.parrot2.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 7:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.dino.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 8:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.dino2.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 9:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.dino3.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 10:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.monkey.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 11:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.monkey2.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 12:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.monkey3.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 13:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.donkey.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			}
			int num = junkie.Next(1600);
			int num2 = junkie.Next(1050);
			int num3 = junkie.Next(300, 700);
			int num4 = junkie.Next(300, 700);
			for (int i = 0; i < junkie.Next(50, 500); i++)
			{
				double num5 = junkie.NextDouble() + 0.1;
				if (junkie.Next(17) != 0)
				{
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)((double)num3 * Math.Sin(junkie.Next(10000))), num2 + (int)((double)num4 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num5), (int)((double)image.Height * num5)))));
					Thread.Sleep(junkie.Next(100));
				}
			}
		}

		public void WalkAroundSpaceman()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			switch (junkie.Next(6))
			{
			case 0:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 1:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit2.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 2:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit3.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 3:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit4.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 4:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit5.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			case 5:
				manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.pit6.png");
				image = Image.FromStream(manifestResourceStream);
				break;
			}
			Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png");
			Image image2 = Image.FromStream(manifestResourceStream2);
			Image image3 = Image.FromStream(manifestResourceStream2);
			switch (junkie.Next(7))
			{
			case 0:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png");
				image2 = Image.FromStream(manifestResourceStream2);
				break;
			case 1:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman2.png");
				image2 = Image.FromStream(manifestResourceStream2);
				break;
			case 2:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman3.png");
				image2 = Image.FromStream(manifestResourceStream2);
				break;
			case 3:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman4.png");
				image2 = Image.FromStream(manifestResourceStream2);
				break;
			case 4:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman5.png");
				image2 = Image.FromStream(manifestResourceStream2);
				break;
			case 5:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman6.png");
				image2 = Image.FromStream(manifestResourceStream2);
				break;
			case 6:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman7.png");
				image2 = Image.FromStream(manifestResourceStream2);
				break;
			}
			switch (junkie.Next(7))
			{
			case 0:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman.png");
				image3 = Image.FromStream(manifestResourceStream2);
				break;
			case 1:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman2.png");
				image3 = Image.FromStream(manifestResourceStream2);
				break;
			case 2:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman3.png");
				image3 = Image.FromStream(manifestResourceStream2);
				break;
			case 3:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman4.png");
				image3 = Image.FromStream(manifestResourceStream2);
				break;
			case 4:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman5.png");
				image3 = Image.FromStream(manifestResourceStream2);
				break;
			case 5:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman6.png");
				image3 = Image.FromStream(manifestResourceStream2);
				break;
			case 6:
				manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alienman7.png");
				image3 = Image.FromStream(manifestResourceStream2);
				break;
			}
			int num = junkie.Next(1600);
			int num2 = junkie.Next(1050);
			double num3 = junkie.NextDouble() + 0.1;
			if (num3 > 0.6)
			{
				num3 = 0.6;
			}
			for (int i = 0; i < junkie.Next(50, 1000); i++)
			{
				if (junkie.Next(17) != 0)
				{
					gfx.DrawImage(image2, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(300.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image2.Width * num3), (int)((double)image2.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
				else
				{
					gfx.DrawImage(image3, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(300.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image3.Width * num3), (int)((double)image3.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
				if (junkie.Next(2) == 0)
				{
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)(1000.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(300.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num3), (int)((double)image.Height * num3)))));
					Thread.Sleep(junkie.Next(100));
				}
			}
		}

		public void violenceNearby()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp.png");
			Image image = Image.FromStream(manifestResourceStream);
			Image.FromStream(manifestResourceStream);
			int num = junkie.Next(800);
			int num2 = junkie.Next(650);
			int num3 = junkie.Next(200, 800);
			int num4 = junkie.Next(200, 600);
			for (int i = 0; i < junkie.Next(50, 500); i++)
			{
				if (junkie.Next(17) != 0)
				{
					switch (junkie.Next(5))
					{
					case 0:
						manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp.png");
						image = Image.FromStream(manifestResourceStream);
						break;
					case 1:
						manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp2.png");
						image = Image.FromStream(manifestResourceStream);
						break;
					case 2:
						manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp3.png");
						image = Image.FromStream(manifestResourceStream);
						break;
					case 3:
						manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.wasp4.png");
						image = Image.FromStream(manifestResourceStream);
						break;
					case 4:
						manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.waspboss.png");
						image = Image.FromStream(manifestResourceStream);
						break;
					}
					double num5 = junkie.NextDouble() + 0.3;
					gfx.DrawImage(image, new Rectangle(new Point(num + (int)((double)num3 * Math.Sin(junkie.Next(10000))), num2 + (int)((double)num4 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num5), (int)((double)image.Height * num5)))));
					Thread.Sleep(junkie.Next(100));
				}
			}
			manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.airforce.png");
			image = Image.FromStream(manifestResourceStream);
			Thread.Sleep(junkie.Next(200));
			for (int j = 0; j < junkie.Next(2, 10); j++)
			{
				int num6 = junkie.Next(5, 10);
				double num7 = junkie.NextDouble() + 0.1;
				gfx.DrawImage(image, new Rectangle(new Point(junkie.Next(800), junkie.Next(300)), new Size(new Point((int)((double)image.Width / ((double)num6 * num7)), (int)((double)image.Height / ((double)num6 * num7))))));
				Thread.Sleep(junkie.Next(2000));
			}
			num = junkie.Next(800);
			num2 = junkie.Next(650);
			for (int k = 0; k < junkie.Next(50, 200); k++)
			{
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.soldier.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.soldier2.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.soldier3.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 3:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.turret.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 4:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.turret2.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 5:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.forceToReckonWith.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				}
				double num8 = junkie.NextDouble() + 0.1;
				int num9 = junkie.Next(1, 10);
				gfx.DrawImage(image, new Rectangle(new Point(num + (int)(400.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(200.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num8) / num9, (int)((double)image.Height * num8) / num9))));
				Thread.Sleep(junkie.Next(100));
			}
			num = junkie.Next(800);
			num2 = junkie.Next(650);
			for (int l = 0; l < junkie.Next(50, 200); l++)
			{
				switch (junkie.Next(4))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion2.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion3.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				case 3:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.explosion4.png");
					image = Image.FromStream(manifestResourceStream);
					break;
				}
				double num10 = junkie.NextDouble() + 0.1;
				int num11 = junkie.Next(1, 10);
				gfx.DrawImage(image, new Rectangle(new Point(num + (int)(400.0 * Math.Sin(junkie.Next(10000))), num2 + (int)(200.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point((int)((double)image.Width * num10) / num11, (int)((double)image.Height * num10) / num11))));
				Thread.Sleep(junkie.Next(100));
			}
		}
	}
}
