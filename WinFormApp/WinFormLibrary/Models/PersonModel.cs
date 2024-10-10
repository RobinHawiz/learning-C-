using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WinFormLibrary.Models;

public class PersonModel : INotifyPropertyChanged
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }
    private string _info;
    public string Info
    {
        get
        {
            return _info;
        }
        set
        {
            _info = value;
            NotifyPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

