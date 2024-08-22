// See https://aka.ms/new-console-template for more information
Console.WriteLine("Iniciar Desayuno");
DescargarArchivoAsync();

var calentarAguaTask = CalentarAguaAsync();
var comprarPanTask = ComprarPanAsync();
var comprarHuevosTask = ComprarHuevosAsync();

await Task.WhenAll(calentarAguaTask, comprarPanTask,comprarHuevosTask);
Console.WriteLine("Terminar Desayuno");
Console.Read();
static async  Task CalentarAguaAsync()
{
    Console.WriteLine("Calentando agua...");
    await Task.Delay(4000); // Simula que calentar agua toma 3 segundos
    Console.WriteLine("Agua caliente lista.");
}

static async Task ComprarPanAsync()
{
    Console.WriteLine("Comprando pan...");
    await Task.Delay(3000); // Simula que comprar pan toma 2 segundos
    Console.WriteLine("Pan comprado.");
}

static async Task ComprarHuevosAsync()
{
    Console.WriteLine("Comprando huevos...");
    await Task.Delay(1500); // Simula que comprar huevos toma 1.5 segundos
    Console.WriteLine("Huevos comprados.");
}

static async void DescargarArchivoAsync()
{
    Console.WriteLine("Empezar a descargar archivo...");
    await Task.Delay(4000); // Simula que calentar agua toma 3 segundos
    Console.WriteLine("Archivo descargado.");
}