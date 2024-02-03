// See https://aka.ms/new-console-template for more information

// arreglos 

using System.Collections;

int[] numeros = new int[6];
int[] notas;
int[] salario = { 1500, 200, 4000 };
string[] nombre = { "Alex", "Ericka", "Susana" };
float[] precio = new float[] { 500.78f, 600.35f, 98.7f };


for (int i = 0; i < nombre.Length; i++)
{
    Console.WriteLine("Digite el nombre");
    nombre[i] = Console.ReadLine();
    Console.WriteLine("Digite el salario");
    salario[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("----- information de los empleados -----");
for (int i = 0; i < nombre.Length; i++)
{
    
    Console.WriteLine($"Nombre {nombre[i]} Salario: {salario[i]}");
}



ArrayList arrayList = new ArrayList();

arrayList.Add(1);
arrayList.Add(2);
arrayList.Add("pedro");
arrayList.Add(25.13f);
arrayList.Add(true);

foreach (var item in arrayList)
{
    Console.WriteLine( item);
}



// nombre, tipo, salario 
string[] nombres = new string[] { "john", "paul", "ringo", "george" };

nombres = Enumerable.Repeat("-",  4).ToArray<string>();

//Console.WriteLine("Cantidad de nombres: " + nombres.Count());

//Console.WriteLine("Promedio: " + salario.Average());

//Console.WriteLine($"Suma salarios {salario.Sum()}");  

foreach (var item in nombres)
{
    Console.WriteLine(item);
}



numeros[0] = 55;
numeros[1] = 66;
numeros[2] = 77;
numeros[5] = 44;

//foreach (var valor in numeros)
//{
//    Console.WriteLine(valor);
//}

//for (int i = 0; i < numeros.Length; i++) //  
//{
//    Console.WriteLine(numeros[i]);
//}
