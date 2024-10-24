List<IComputerController> controllers = new List<IComputerController>();

GameController gameController = new GameController();
Keyboard keyboard = new Keyboard();
BatteryPoweredGameController batteryPoweredGameController = new BatteryPoweredGameController();
BatteryPoweredKeyboard batteryPoweredKeyboard = new BatteryPoweredKeyboard();

controllers.Add(gameController);
controllers.Add(keyboard);
controllers.Add(batteryPoweredGameController);
controllers.Add(batteryPoweredKeyboard);

foreach (IComputerController controller in controllers)
{
    if (controller is GameController gc)
    {

    }
    if (controller is IBatteryPowered powered)
    {

    }
}

List<IBatteryPowered> powereds = new List<IBatteryPowered>();

powereds.Add(batteryPoweredGameController);
powereds.Add(batteryPoweredKeyboard);

using (GameController gc = new GameController())
{

}


public interface IComputerController : IDisposable
{
    void Connect();
    void CurrentKeyPressed();
}
public class Keyboard : IComputerController
{
    public void Connect()
    {

    }
    public void CurrentKeyPressed()
    {

    }

    public void Dispose()
    {
        // Do whatever shutdown tasks needed.
    }

    public string ConnectionType { get; set; }
}

public interface IBatteryPowered
{
    int BatteryLevel { get; set; }
}

public class BatteryPoweredKeyboard : Keyboard, IBatteryPowered
{
    public int BatteryLevel { get; set; }
}

public class GameController : IComputerController, IDisposable
{
    public void Connect()
    {

    }
    public void CurrentKeyPressed()
    {

    }

    public void Dispose()
    {
        // Do whatever shutdown tasks needed.
    }
}

public class BatteryPoweredGameController : GameController, IBatteryPowered
{
    public int BatteryLevel { get; set; }
}