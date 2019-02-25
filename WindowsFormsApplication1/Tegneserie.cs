namespace WindowsFormsApplication1
{
	internal class Tegneserie
	{
		private Lingo børnemuseum;

		private Jingo juklas;

		private JoyRomeo jongo;

		private string s;

		private Form1 form1;

		public static int Hugo
		{
			get;
			set;
		}

		public Tegneserie(JoyRomeo romeo, Form1 form)
		{
			form1 = form;
			børnemuseum = new Lingo(new Børneleg(form1).passMeTheSugar(320), new Børnetid(new Afmagt(700.0, 440f, form), form1), 350, form1);
			juklas = romeo.partyTime();
			jongo = romeo;
			if (form1.junkie.Next(1) == 0)
			{
				new Afmagt(200.0, 5000f, form1).buildUP(300);
			}
			new Børnetid(new Afmagt(100.0, 1600f, form1), form1).bolMe(form1.junkie.Next(200));
			form1.BlackStrangeSpellOut(200);
		}

		public Tegneserie(string s)
		{
			this.s = s;
		}

		internal void lineUpSi(double p, double p_2)
		{
			new Jingo(form1).getFunnyTimesLightlyTimes(new Bongo(form1));
		}
	}
}
