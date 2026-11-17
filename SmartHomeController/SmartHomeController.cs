using SmartHomeController;

try
{
    SmartDevice badDevice = new SmartLight(0, "red", 0, "test light", false);
}
catch (ArgumentException ex)
{
    Console.WriteLine(Message);
}
