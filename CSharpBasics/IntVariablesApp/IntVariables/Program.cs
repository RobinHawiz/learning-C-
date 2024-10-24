// Behind the scenes this is Int32
int age = 0;

age = 43;

// signed Int32 can be two billion +/-, because the last bit is used to mark the number as positive or negative
// unsigned UInt32 - 4 billion, because the last bit is not used as a marker anymore, and is instead used as a number
// bit - 0 or 1
// byte - 8 bits - 00000000
// Int32 can hold a 32 bit integer value

Console.WriteLine(age);
// Is the same as writing...
Console.WriteLine(age.ToString());

// Don't divide ints - Console.WriteLine(age / 2);