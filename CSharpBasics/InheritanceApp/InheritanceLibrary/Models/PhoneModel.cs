using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Models;

public class PhoneModel
{
    public void PlaceCall()
    {

    }

    public void EndCall()
    {

    }
}
public class WalkieTalkie
{

}
public class HotspotModel
{

}

public class LandLine : PhoneModel
{

}
public class SmartphoneModel : CellphoneModel
{
    public List<string> Apps { get; set; }
    public void ConnectToInternet()
    {

    }
}
public class CellphoneModel : PhoneModel
{
    public string Carrier { get; set; }
}

