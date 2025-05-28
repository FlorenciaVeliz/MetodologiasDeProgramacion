/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 20:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of ComparacionNombre.
	/// </summary>
	/// 
    //Ejercicio 1
	//no podemos comparar strings con <, >, ==. entonces utilizo "string.Compare" metodo de c# para comparar strings alfabéticamente
	public class ComparacionNombre : EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return string.Compare(a1.getNombre(), a2.getNombre()) == 0;
		}
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return string.Compare(a1.getNombre(), a2.getNombre()) < 0;
		}
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return string.Compare(a1.getNombre(), a2.getNombre()) > 0;
		}
				public override string ToString()
		{
			 return "NOMBRE";
		}
	}
}
