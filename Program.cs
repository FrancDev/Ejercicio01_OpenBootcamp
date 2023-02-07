/*Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una 
variable para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.*/

Console.WriteLine("---Personal Data---");


Console.WriteLine("Ingrese su nombre ");
string nom = Console.ReadLine();
Console.Clear();

Console.WriteLine("Ingrese su Apellido ");
string apel = Console.ReadLine();
Console.Clear();

Console.WriteLine("Ingrese su Edad ");
int edad = int.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("Contacto Telefonico ");
long cont = long.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine("Sabe Programar?");
string prog = Console.ReadLine();
Console.Clear();


Console.WriteLine("Datos De Usuario");
Console.WriteLine("---------------\n Nombre:" + nom + "\n Apellido:" + apel + "\n Edad:" + edad +
                  "\n Contacto:" + cont + "\n Sabe Programar:" + prog);



