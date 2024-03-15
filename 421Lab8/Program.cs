
public class Retailer
{
    TV tv;
}

#region TV Classes
public class TV
{
    private int price = 200;
    public void setPrice(int price)
    {
        this.price = price;
    }
    public void replenish(int budget)
    {

    }
    public  
}

public class Smart_TV:TV
{
    private int price = 300;
}

public class UltraHD_TV : TV
{
    private int price = 400;
}
#endregion

#region TV Interfaces
public interface TVIF
{

}

public interface Smart_TVIF : TVIF
{

}

public interface UltraHD_TVIF : TVIF
{

}
#endregion

#region Vizio TV Classes
public class Vizio_TV: TVIF
{

}

public class Vizio_Smart_TV : Vizio_TV, Smart_TVIF
{

}

public class Vizio_UltraHD_TV : Vizio_TV, UltraHD_TVIF
{

}
#endregion

#region Sony Tv Classes
public class Sony_TV: TVIF
{

}

public class Sony_Smart_TV:  Sony_TV, Smart_TVIF
{

}

public class Sony_UltraHD_TV : Sony_TV, UltraHD_TVIF
{

}
#endregion