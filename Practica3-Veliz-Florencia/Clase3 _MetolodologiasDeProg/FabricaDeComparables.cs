/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 21:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of FabricaDeComparables.
	/// </summary>
	public abstract class FabricaDeComparables
	{
		protected GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
		protected LectorDeDatos lector = new LectorDeDatos();
		public static Comparable crearAleatorio(int opcion){
	    FabricaDeComparables fabrica = null;
	    
	    switch(opcion){
	    		case 1: fabrica = new FabricaDeNumeros(); break;
				case 2: fabrica = new FabricaDeAlumnos(); break;
				case 3: fabrica = new FabricaDeProfesores(); break;
			default:
				throw new ArgumentException("Opción invalida");
				
			}
			return fabrica.crearAletorio();
		}
		public static Comparable crearPorTeclado(int opcion){
			FabricaDeComparables fabrica;
			
			switch(opcion){
				case 1: fabrica = new FabricaDeNumeros(); break;
				case 2: fabrica = new FabricaDeAlumnos(); break;
				case 3: fabrica = new FabricaDeProfesores(); break;
			default:
				throw new ArgumentException("Opción invalida");
			}
			return fabrica.crearPorTeclado();
		}
		public abstract Comparable crearAletorio();
		public abstract Comparable crearPorTeclado();
	}
}
