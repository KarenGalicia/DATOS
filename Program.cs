
using System;

// *USO DE TIPOS DE DATOS NUMÉRICOS*:

Console.WriteLine("*USO DE TIPOS DE DATOS NUMÉRICOS*");
Console.WriteLine("1.Programa que calcule el área de un triángulo.");
Console.WriteLine("--------------------------");

// Declaración de variables
double baseTriangulo, alturaTriangulo, areaTriangulo;

// Solicitud de datos al usuario
Console.WriteLine("Introduzca la base del triángulo: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
baseTriangulo = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca la altura del triángulo: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
alturaTriangulo = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Cálculo del área
areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

// Mostrar el resultado
Console.WriteLine("El área del triángulo es: " + areaTriangulo);

Console.WriteLine("*USO DE TIPOS DE DATOS NUMÉRICOS*");
Console.WriteLine("2.Programa que calcule el volumen de una esfera.");
Console.WriteLine("--------------------------");
// Declaración de variables
double radioEsfera, volumenEsfera;

// Solicitud de datos al usuario
Console.WriteLine("Introduzca el radio de la esfera: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
radioEsfera = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Cálculo del volumen
volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);

// Mostrar el resultado
Console.WriteLine("El volumen de la esfera es: " + volumenEsfera);

Console.WriteLine("*USO DE TIPOS DE DATOS NUMÉRICOS*");
Console.WriteLine("3.Programa que calcule la distancia entre dos puntos.");
Console.WriteLine("--------------------------");

// Declaración de variables
double x1, y1, x2, y2, distancia;

// Solicitud de datos al usuario
Console.WriteLine("Introduzca la coordenada X del primer punto: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
x1 = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca la coordenada Y del primer punto: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
y1 = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca la coordenada X del segundo punto: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
x2 = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

Console.WriteLine("Introduzca la coordenada Y del segundo punto: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
y2 = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Cálculo de la distancia
distancia = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

// Mostrar el resultado
Console.WriteLine("La distancia entre los dos puntos es: " + distancia);
Console.WriteLine("*USO DE TIPOS DE DATOS NUMÉRICOS*");
Console.WriteLine("4.Programa que calcule la temperatura en grados Fahrenheit a partir de la temperatura en grados Celsius. ");
Console.WriteLine("--------------------------");
// Declaración de variables
double temperaturaCelsius, temperaturaFahrenheit;

// Solicitud de datos al usuario
Console.WriteLine("Introduzca la temperatura en grados Celsius: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
temperaturaCelsius = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Cálculo de la temperatura en Fahrenheit
temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

// Mostrar el resultado
Console.WriteLine("La temperatura en grados Fahrenheit es: " + temperaturaFahrenheit);

Console.WriteLine("La distancia entre los dos puntos es: " + distancia);
Console.WriteLine("*USO DE TIPOS DE DATOS NUMÉRICOS*");
Console.WriteLine("5.Programa que calcule la temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit. ");
Console.WriteLine("--------------------------");

// Solicitud de datos al usuario
Console.WriteLine("Introduzca la temperatura en grados Fahrenheit: ");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
temperaturaFahrenheit = double.Parse(s: Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

// Cálculo de la temperatura en Celsius
temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;

// Mostrar el resultado
Console.WriteLine("La temperatura en grados Celsius es: " + temperaturaCelsius);
