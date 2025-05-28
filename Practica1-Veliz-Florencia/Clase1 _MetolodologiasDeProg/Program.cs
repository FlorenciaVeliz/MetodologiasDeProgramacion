/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 13/4/2025
 * Hora: 21:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase1__MetolodologiasDeProg
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pila p = new Pila();
			Cola c = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(p, c);
			llenarAlumnos(p);
			llenarAlumnos(c);
			/*Console.WriteLine("----- PILA -----");
			llenar(p);
			informar(p);
			
			Console.WriteLine("----- COLA -----");
			llenar(c);
			informar(c);
			
			Console.WriteLine("----- COLECCION MULTIPLE -----");
			*/
			informar(multiple);
			
			Console.Write("Presione cualquier tecla para salir . . . ");
			Console.ReadKey(true);
		}
		//Implementando función llenar
		public static void llenar(Coleccionable col){
			Random r = new Random();
			for(int i=0; i<20; i++){
				int numeroAleatorio = r.Next(1, 101);
				Comparable aux = new Numero(numeroAleatorio);
				col.agregar(aux);
			}
		}
		//Implementando función informar
		public static void informar(Coleccionable col){
			Console.WriteLine("Cantidad de elementos: " + col.cuantos());
			Console.WriteLine("Valor Mínimo: " + col.minimo());
			Console.WriteLine("Valor Máximo: " + col.maximo());
			//Console.WriteLine("Ingrese un número para verificar si está en la colección: ");
			//Comparable aux = new Numero(int.Parse(Console.ReadLine()));
			//Console.WriteLine("Ingrese un DNI para verificar si el alumno está en la colección: ");
			//Comparable aux = new Alumno("", int.Parse(Console.ReadLine()),0,0.0);
			Console.WriteLine("Ingrese un Legajo para verificar si el alumno está en la colección: ");
			Comparable aux = new Alumno("",0,int.Parse(Console.ReadLine()),0.0);
			if(col.contiene(aux)){
			   	Console.WriteLine("El elemento leído SI está en la colección");
			    Console.WriteLine();
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
				Console.WriteLine();
			}
		}
		//Implementando funcion llenar alumnos
		public static void llenarAlumnos(Coleccionable col){
			Random r = new Random();
			string[] nombres = {"Florencia", "Agustina", "Ana", "Maria", "Martina", "Emilia", "Luz", "Paula", "Emma", "Victoria", "Brian", "Thiago", "Martin", "Juan", "Pablo", "Franco", "Santiago", "Matias", "Nicolas", "Mateo"};
			for(int i=0; i<20; i++){
				string nombreAleatorio = nombres[r.Next(nombres.Length)];
				int dniAleatorio = r.Next(00000001, 50000000);
				int legajoAleatorio = r.Next(001, 999);
				double promedioAleatorio = r.NextDouble()*10;
		
				Comparable aux = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio);
				col.agregar(aux);
			}
		}
	}
}