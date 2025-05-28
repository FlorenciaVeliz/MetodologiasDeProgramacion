/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 14/4/2025
 * Hora: 21:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase1__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	/// 
	//Creando clase alumno, subclase de Persona
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		
		public Alumno (string nombre, int dni, int legajo, double promedio): base(nombre, dni){
			this.legajo = legajo;
			this.promedio = promedio;
		}
		public int getLegajo(){
			return this.legajo;
		}
		public double getPromedio(){
			return this.promedio;
		}
		public override bool sosIgual(Comparable c){
			return this.legajo == ((Alumno)c).getLegajo();
		}
		public override bool sosMenor(Comparable c){
			return this.legajo < ((Alumno)c).getLegajo();
		}
		public override bool sosMayor(Comparable c){
			return this.legajo > ((Alumno)c).getLegajo();
		}
		public override string ToString()
		{
			return "Nombre: " + this.nombre.ToString() + " DNI: " + this.dni.ToString() + " Legajo: " + this.legajo.ToString() + " Promedio: " + this.promedio.ToString();;
		}

	}
}
