using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task6_Festoon
{
	class Program
	{
		static void Main(string[] args)
		{
			int value = Helper.EnterValue();
			Bulb[] regularBulb = new Bulb[value];
			for (int i = 0; i < regularBulb.Length; i++)
			{
				regularBulb[i] = new Bulb();
			}

			RegularFestoon regularFestoon = new RegularFestoon(value, regularBulb);
			Console.WriteLine("Regular Festoon Status");
			regularFestoon.ReturnFestoonStatus();

			int value2 = Helper.EnterValue();
			ColorBulb[] colorBulb = new ColorBulb[value2];
			for (int i = 0; i < colorBulb.Length; i++)
			{
				colorBulb[i] = new ColorBulb();
			}
			
			ColoredFestoon coloredFestoon = new ColoredFestoon(value2, colorBulb);
			coloredFestoon.SetupFestoon();

			Console.WriteLine("Colored Festoon Status");
			coloredFestoon.ReturnColoredFestoonStatus();
		}

	}
}

public class Bulb
{
	public Bulb() { }
	public bool BulbStatus { get; set; }
}

public class ColorBulb
{
	public ColorBulb() { }
	public bool BulbStatus { get; set; }
	public BulbColor colorBulbColor { get; set; }
}

abstract class Festoon
{
	public int Bulbnumber { get; set; }

	public Festoon(int bulbnumber)
	{
		Bulbnumber = bulbnumber;
	}

	public int ReturnBulbQuantity()
	{
		int bulbnumber = Bulbnumber;
		return Bulbnumber;
	}
}

class RegularFestoon : Festoon
{
	public Bulb[] BulbFestoon { get; set; }

	public RegularFestoon(int bulbNumber, Bulb[] bulbFestoon)
		: base(bulbNumber)
	{
		BulbFestoon = bulbFestoon;
	}

	public void ReturnFestoonStatus()
	{
		var time = DateTime.Now;
		for (int i = 0; i < Bulbnumber; i++)
		{
			if ((time.Minute % 2) != 0)
			{
				if (i % 2 != 0)
				{
					BulbFestoon[i].BulbStatus = false;
				}

				else
				{
					BulbFestoon[i].BulbStatus = true;
				}
			}
			else
			{
				if (i % 2 != 0)
				{
					BulbFestoon[i].BulbStatus = true;
				}

				else
				{
					BulbFestoon[i].BulbStatus = false;
				}
			}
		}
		int j = 1;
		
		foreach (Bulb bulb in BulbFestoon)
		{
		
			Console.WriteLine($"Bulb {j} is {bulb.BulbStatus}");
			j++;
		}
	}
}

class ColoredFestoon : Festoon
{
	public ColorBulb[] ColorBulbFestoon { get; set; }

	public ColoredFestoon(int colorbulbNumber, ColorBulb[] colorBulbFestoon)
	: base(colorbulbNumber)
	{
		ColorBulbFestoon = colorBulbFestoon;
	}

	public void SetupFestoon()
	{
	    
		for (int i = 0; i < Bulbnumber; i += 4)
		{
			ColorBulbFestoon[i].colorBulbColor = BulbColor.Red;

			if (i + 1 < Bulbnumber)
			{
				ColorBulbFestoon[i + 1].colorBulbColor = BulbColor.Yellow;
			}
			
			if (i + 2 < Bulbnumber)
			{
				ColorBulbFestoon[i + 2].colorBulbColor = BulbColor.Green;
			}
			
			if (i + 3 < Bulbnumber)
			{
				ColorBulbFestoon[i + 3].colorBulbColor = BulbColor.Blue;
			}

			

		}
	}

	public void ReturnColoredFestoonStatus()
	{
		var time = DateTime.Now;
		for (int i = 0; i < Bulbnumber; i++)
		{
			if ((time.Minute % 2) != 0)
			{
				if (i % 2 != 0)
				{
					ColorBulbFestoon[i].BulbStatus = false;
				}

				else
				{
					ColorBulbFestoon[i].BulbStatus = true;
				}
			}
			else
			{
				if (i % 2 != 0)
				{
					ColorBulbFestoon[i].BulbStatus = true;
				}

				else
				{
					ColorBulbFestoon[i].BulbStatus = false;
				}
			}
		}
		int j = 1;
		foreach (ColorBulb bulb in ColorBulbFestoon)
		{

			Console.WriteLine($"Bulb {j} is {bulb.BulbStatus}, bulbcolor is {bulb.colorBulbColor}");
			j++;
		}
	}
}

public enum BulbColor
{
	Off,
	Red,
	Yellow,
	Green,
	Blue
}