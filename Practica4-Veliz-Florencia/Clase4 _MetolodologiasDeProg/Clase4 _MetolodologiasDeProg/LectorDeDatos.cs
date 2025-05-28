/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 20:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary>
	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		public int numeroPorTeclado(){
			Console.WriteLine("ingrese un numero entero: ");
			return int.Parse(Console.ReadLine());
		}
		public string stringPorTeclado(){
			Console.WriteLine("ingrese un string: ");
			return Console.ReadLine();
		}
	}
}
