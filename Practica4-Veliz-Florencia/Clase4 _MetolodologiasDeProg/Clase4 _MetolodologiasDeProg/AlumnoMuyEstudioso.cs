/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 05:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio, int calificacion, EstrategiaDeComparacion estrategia)
			:base(nombre, dni, legajo, promedio, calificacion, estrategia){
			
		}
		public override int responderPregunta(int pregunta){
			return pregunta % 3;
		}
	}
}
