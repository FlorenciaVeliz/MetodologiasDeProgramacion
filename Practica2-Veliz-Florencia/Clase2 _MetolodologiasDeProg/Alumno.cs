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

namespace Clase2__MetolodologiasDeProg
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
		private EstrategiaDeComparacion estrategia;
		
		public Alumno (string nombre, int dni, int legajo, double promedio, EstrategiaDeComparacion estrategia): base(nombre, dni){
			this.legajo = legajo;
			this.promedio = promedio;
			this.estrategia = estrategia;
		}
		public int getLegajo(){
			return this.legajo;
		}
		public double getPromedio(){
			return this.promedio;
		}
		public EstrategiaDeComparacion getEstrategia(){
			return this.estrategia;
		}
		public void setLegajo(int legajo){
			this.legajo = legajo;
		}
		public void setPromedio(double promedio){
			this.promedio = promedio;
		}
		public void setEstrategia(EstrategiaDeComparacion nuevaEstrategia){
			this.estrategia = nuevaEstrategia;
		}
		
		
		public override bool sosIgual(Comparable c){
			return this.estrategia.sosIgual(this, (Alumno)c);
		}
		public override bool sosMenor(Comparable c){
			return this.estrategia.sosMenor(this, (Alumno)c);;
		}
		public override bool sosMayor(Comparable c){
			return this.estrategia.sosMayor(this, (Alumno)c);
		}
		public override string ToString()
		{
			return "Nombre: " + this.nombre.ToString() + " DNI: " + this.dni.ToString() + " Legajo: " + this.legajo.ToString() + " Promedio: " + this.promedio.ToString() + " Estrategia de comparación: " + this.estrategia.ToString();
		}

	}
}
