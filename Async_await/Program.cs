// See https://aka.ms/new-console-template for more information


Task makeCoffee=  MakeCoffee();
Task makeToast =  MakeToast();

List<Task> tasks = new List<Task> {makeCoffee, makeToast};

await Task.WhenAll(tasks);
Console.WriteLine("All Finished");

async Task MakeToast()
{
    Console.WriteLine("Making Toast started");
    ApplyButter();
    await ToastBread();
    Console.WriteLine("Toast making finished!");
}

async Task ToastBread()
{
    await Task.Delay(2000);
    Console.WriteLine("Bread toasted");

}

void ApplyButter()
{
    Thread.Sleep(1000);
    Console.WriteLine("Butter applied!");
}

async Task MakeCoffee()
{
    Console.WriteLine("Making coffee started");
    await BoilWater();
    MixCoffee();
    AddSugar();
    Console.WriteLine("Coffee is ready!");
}

void AddSugar()
{
    Console.WriteLine("Sugar added");
}

void MixCoffee()
{
    Console.WriteLine("Coffeee mixed");
}

async Task BoilWater()
{
    await Task.Delay(3000);
    Console.WriteLine("Water boiled");
}