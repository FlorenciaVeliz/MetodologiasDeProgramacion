/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 20:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool salir = false;
			while(!salir){
				Console.Clear();
				Console.WriteLine("Seleccione el ejercicio que quiera ejecutar:");
				Console.WriteLine("1 - FABRICAS (numero - alumnos - profesor)");
				Console.WriteLine("2 - EJERCICIO 14, uso de Observado y Observador");
				Console.WriteLine("0 - SALIR");
				Console.WriteLine("Ingrese su opción: ");
				
				string op = Console.ReadLine();
				Console.WriteLine();
				switch(op){
					case "1":
						//1 para numeros, 2 para alumnos, 3 para profesores
						Console.Clear();
						Console.WriteLine("1 - Crear fabrica de NUMEROS");
						Console.WriteLine("2 - Crear fabrica de ALUMNOS");
						Console.WriteLine("3 - Crear fabrica de PROFESORES");
						Console.WriteLine();
						Console.WriteLine("Seleccione la opción que desee: ");
						int opcion = int.Parse(Console.ReadLine());
						Console.WriteLine("----- PILA -----");
						Pila p = new Pila();
						llenar(p, opcion);
						informar(p, opcion);
						    
						Console.WriteLine();
						Console.WriteLine("----- COLA -----");
						Cola c = new Cola();
						llenar(c, opcion);
						informar(c, opcion);
						
						Console.WriteLine();
						Console.WriteLine("----- COLECCION MULTIPLE -----");
						ColeccionMultiple multiple = new ColeccionMultiple(p, c);
						informar(multiple, opcion);
						break;
					case "2":
						Profesor profe = new Profesor("Mauro", 1234, 6);
						Pila pila = new Pila();
						llenar(pila, 2);
						Iterador ite = pila.crearIterador();
						ite.primero();
						while(!ite.fin()){
							profe.agregarObservador((Observador)ite.actual());
							ite.siguiente();
						}
						dictadoDeClase(profe);
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
		//se elimina la función llenarAlumnos gracias a la fabrica
		public static void llenar(Coleccionable c, int opcion){
			for (int i=0; i<20; i++){
				Comparable e = FabricaDeComparables.crearAleatorio(opcion);
				c.agregar(e);
			}
		}
		//Implementando función informar
		public static void informar(Coleccionable col, int opcion){
			Console.WriteLine("Cantidad de elementos: " + col.cuantos());
			Console.WriteLine("Valor Mínimo: " + col.minimo());
			Console.WriteLine("Valor Máximo: " + col.maximo());
			
			Comparable e = FabricaDeComparables.crearPorTeclado(opcion);
			
			if(col.contiene(e)){
			   	Console.WriteLine("El elemento leído SI está en la colección");
			    Console.WriteLine();
			}
			else{
				Console.WriteLine("El elemento leído NO está en la colección");
				Console.WriteLine();
			}
		}
			public static void dictadoDeClase(Profesor profe){
			for (int i = 0; i<5; i++){
				profe.hablarALaClase();
				profe.escribirEnElPizarron();

			}
		}
		
	}
}