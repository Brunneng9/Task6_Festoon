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
            RegularFestoon regularFestoon = new RegularFestoon(value , regularBulb );
            regularFestoon.ReturnFestoonStatus();
        }
      
    }
}

public class Bulb
{
    bool BulbStatus { get; set; }
    public bool ReturnBulbStatus()
    {
        return BulbStatus;
    }
    public void  SetBulbStatus(bool status)
    {
        BulbStatus = status;
    }
}

public class ColorBulb
{
    bool BulbStatus { get; set; }
    BulbColor colorBulbColor { get; set; }
}
abstract class Festoon
{
    public static int Bulbnumber { get; set; }
    public Festoon(int bulbnumber)
    {
        Bulbnumber = bulbnumber;
    }
    public int ReturnBulbQuantity()
    {
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
                BulbFestoon[i].SetBulbStatus(true);
            }
            else
            {
                BulbFestoon[i].SetBulbStatus(false);
            }
            Console.WriteLine($"Bulb #{i} is {BulbFestoon[i]}");
        }

    }
 
   

}


enum BulbColor
{
    Off,
    Red,
    Yellow,
    Green,
    Blue
}