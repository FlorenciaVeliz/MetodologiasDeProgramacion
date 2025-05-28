/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 20:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of ComparacionLegajo.
	/// </summary>
	/// 
	//Ejercicio 1
	public class ComparacionLegajo : EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getLegajo() == a2.getLegajo();
		}
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getLegajo() < a2.getLegajo();
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getLegajo() > a2.getLegajo();
		}
		public override string ToString()
		{
			 return "LEGAJO";
		}


	}
}
