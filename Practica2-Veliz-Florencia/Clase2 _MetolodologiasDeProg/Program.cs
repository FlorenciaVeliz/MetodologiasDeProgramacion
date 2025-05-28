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

namespace Clase2__MetolodologiasDeProg
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool salir = false;
			while(!salir){
				Console.Clear();
				Console.WriteLine("Seleccione el ejercicio que quiera ejecutar:");
				Console.WriteLine("1 - EJERCICIO 7, imprimir elementos de pila, cola y conjunto");
				Console.WriteLine("2 - EJERCICIO 9, cambio de estrategia de comparacion e informe mínimo y máximo");
				Console.WriteLine("0 - SALIR");
				Console.WriteLine("Ingrese su opción: ");
				
				string opcion = Console.ReadLine();
				Console.WriteLine();
				//declaro pila afuera para que no haya error por declararla 2 veces
				Pila p = new Pila();
				switch(opcion){
					case "1":
						Cola c = new Cola();
						Conjunto con = new Conjunto();
						llenarAlumnos(p);
						llenarAlumnos(c);
						llenarAlumnos(con);
						Console.WriteLine("-- IMPRIMIENDO ELEMENTOS DE LA PILA --");
						imprimirElementos(p);
						Console.WriteLine();
						Console.WriteLine("-- IMPRIMIENDO ELEMENTOS DE LA COLA --");
						imprimirElementos(c);
						Console.WriteLine();
						Console.WriteLine("-- IMPRIMIENDO ELEMENTOS DEL CONJUNTO --");
						imprimirElementos(con);
						break;
					case "2":
						llenarAlumnos(p);
						cambiarEstrategia(p, new ComparacionNombre());
						informar(p);
						Console.WriteLine();
						cambiarEstrategia(p, new ComparacionLegajo());
						informar(p);
						Console.WriteLine();
						cambiarEstrategia(p, new ComparacionPromedio());
						informar(p);
						Console.WriteLine();
						cambiarEstrategia(p, new ComparacionDNI());
						informar(p);
						break;
					case "0":
						salir = true;
						break;
					default:
						Console.WriteLine("Opción no valida");
						break;
				}
				if (!salir){
					Console.Write("Presione cualquier tecla para salir . . . ");
					Console.ReadKey(true);
				}
			}
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
			
			//Console.WriteLine("Ingrese un Legajo para verificar si el alumno está en la colección: ");
			Comparable alumno = new Alumno("",0,0,0.0, new ComparacionLegajo());
			/*if(col.contiene(alumno)){
			   	Console.WriteLine("El elemento leído SI está en la colección");
			    Console.WriteLine();
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
				Console.WriteLine();
			}
			*/
		}
		
		//Implementando funcion llenar alumnos
		public static void llenarAlumnos(Coleccionable col){
			Random r = new Random();
			string[] nombres = {"Florencia", "Agustina", "Ana", "Maria", "Martina", "Emilia", "Luz", "Paula", "Emma", "Victoria", "Brian", "Thiago", "Martin", "Juan", "Pablo", "Franco", "Santiago", "Matias", "Nicolas", "Mateo"};
			for(int i=0; i<5; i++){
				string nombreAleatorio = nombres[r.Next(nombres.Length)];
				int dniAleatorio = r.Next(1, 50000000);
				int legajoAleatorio = r.Next(1, 999);
				double promedioAleatorio = r.NextDouble()*10;
		        
				//Ejercicio 2
				EstrategiaDeComparacion estrategia = new ComparacionLegajo();
				Comparable alumno = new Alumno(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio, estrategia);
				col.agregar(alumno);
			}
		}
		//Ejercicio 6
		public static void imprimirElementos(Coleccionable col){
			Iterador ite = col.crearIterador();
			ite.primero();
			while(!ite.fin()){
				Console.WriteLine(ite.actual());
				ite.siguiente();
			}
			Console.WriteLine("El recorrido finalizo");
		}
		//Ejercicio 8
		public static void cambiarEstrategia(Coleccionable col, EstrategiaDeComparacion estrategia){
			Iterador ite = col.crearIterador();
			ite.primero();
			
			while(!ite.fin()){
				Comparable actual = ite.actual();
				if (actual is Alumno){
					((Alumno)actual).setEstrategia(estrategia);
				}
				ite.siguiente();
			}
		}
	}
}