/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 20:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of ComparacionPromedio.
	/// </summary>
	/// 
    //Ejercicio 1
	public class ComparacionPromedio : EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getPromedio() == a2.getPromedio();
		}
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getPromedio() < a2.getPromedio();
		}
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getPromedio() > a2.getPromedio();
		}
		public override string ToString()
		{
			 return "PROMEDIO";
		}
	}
}
