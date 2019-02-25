namespace WindowsFormsApplication1
{
	internal class Spaceship1
	{
		private Form1 form1;

		public Spaceship1(Form1 form1)
		{
			this.form1 = form1;
			form1.sayonaraCaptainHereComesTheRain();
			form1.drawAlienFishTank();
			form1.drawAlienFishTank();
			form1.drawAlienFishTank();
			form1.landingIsHere(200);
			form1.burnRubber(200.0, 110f, 50);
			form1.WalkAroundSpaceman();
			form1.violenceNearby();
			form1.BlackStrangeSpellOut(100);
			for (int i = 0; i < form1.junkie.Next(1, 10); i++)
			{
				form1.wierdoFuckMe(form1.junkie.Next(3, 6));
			}
			for (int j = 0; j < 3; j++)
			{
				new Tegneserie(new JoyRomeo(form1), form1);
			}
		}
	}
}
