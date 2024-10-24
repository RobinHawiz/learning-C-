using InheritanceLibrary.Models;

CarModel car = new CarModel();
Corolla corolla = new Corolla();

LandLine landLine = new LandLine();
SmartphoneModel smartphone = new SmartphoneModel();

List<PhoneModel> phones = new List<PhoneModel>();

phones.Add(new CellphoneModel());
phones.Add(new SmartphoneModel());

foreach (var phone in phones)
{
    if (phone is CellphoneModel cell)
    {
        cell.Carrier = "";
    }
    if (phone is SmartphoneModel smart)
    {
        smart.ConnectToInternet();
    }
}