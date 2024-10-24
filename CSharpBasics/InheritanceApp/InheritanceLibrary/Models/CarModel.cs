using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLibrary.Models;

public class CarModel
{
    public int NumberOfWheels { get; set; }
    public int NumberOfDoors { get; set; }

    public void StartCar()
    {

    }
    public void StopCar()
    {

    }
}
// A Corolla is a CarModel
public class Corolla : CarModel
{

}
// A Camry is a CarModel
public class Camry : CarModel
{

}