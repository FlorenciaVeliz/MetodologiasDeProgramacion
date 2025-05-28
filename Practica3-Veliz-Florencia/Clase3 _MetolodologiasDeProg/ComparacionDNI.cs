/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 20:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of ComparacionDNI.
	/// </summary>
	/// 
	//Ejercicio 1
	public class ComparacionDNI : EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2){
			return a1.getDNI() == a2.getDNI();
		}
		public bool sosMenor(Alumno a1, Alumno a2){
			return a1.getDNI() < a2.getDNI();
		}
		public bool sosMayor(Alumno a1, Alumno a2){
			return a1.getDNI() > a2.getDNI();
		}
				public override string ToString()
		{
			 return "DNI";
		}
	}
}
