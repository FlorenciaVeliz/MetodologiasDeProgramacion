/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 20:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of ComparacionPromedio.
	/// </summary>
	/// 
    //Ejercicio 1
	public class ComparacionPromedio : EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getPromedio() == a2.getPromedio();
		}
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getPromedio() < a2.getPromedio();
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getPromedio() > a2.getPromedio();
		}
		public override string ToString()
		{
			 return "PROMEDIO";
		}
	}
}
