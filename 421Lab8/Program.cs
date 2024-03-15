
public class Retailer
{
    TV tv;
}

#region TV Classes
public class TV
{
    private int price = 200;
    public TVIF;

    public void setPrice(int price)
    {
        this.price = price;
    }
    public TV replenish(int budget)
    {
        TV tv = new TV();
        TV 
        if (tv.price <= budget)
        {

        }
        return tv;
    }
    public String getInfo()
    {
        return "";
    }
    public int getPrice()
    {
        return this.price;
    }
    public String getType()
    {
        return "";
    }
}

public sealed class Smart_TV : TV
{
    private int price = 300;
    public Smart_TVIF;

    public double getPowerUsage()
    {
        return 5.5;
    }
}

public sealed class UltraHD_TV : TV
{
    private int price = 400;
    public UltraHD_TVIF;
}
#endregion

#region TV Interfaces
public interface TVIF
{
    public String getInfo();
    public int getPrice();
    public String getType();
    public String getBrand();
}

public interface Smart_TVIF : TVIF
{
    public double getPowerUsage();
}

public interface UltraHD_TVIF : TVIF
{

}
#endregion

#region Vizio TV Classes
public class Vizio_TV : TVIF
{
    private int price = 250;
    public String getInfo()
    {
        return "";
    }
    public int getPrice()
    {
        return this.price;
    }
    public String getType()
    {
        return "";
    }
    public String getBrand()
    {
        return "Vizio";
    }
}

public class Vizio_Smart_TV : Vizio_TV, Smart_TVIF
{
    public int price = 350;

    public double getPowerUsage()
    {
        return 6.35;
    }
}

public class Vizio_UltraHD_TV : Vizio_TV, UltraHD_TVIF
{
    public int price = 450;
}
#endregion

#region Sony Tv Classes
public class Sony_TV : TVIF
{
    public int price = 280;

    public String getInfo()
    {
        return "";
    }
    public int getPrice()
    {
        return this.price;
    }
    public String getType()
    {
        return "";
    }
    public String getBrand()
    {
        return "Vizio";
    }
}

public class Sony_Smart_TV : Sony_TV, Smart_TVIF
{
    public int price = 380;

    public double getPowerUsage()
    {
        return 5.15;
    }
}

public class Sony_UltraHD_TV : Sony_TV, UltraHD_TVIF
{
    public int price = 480;
}
#endregion

