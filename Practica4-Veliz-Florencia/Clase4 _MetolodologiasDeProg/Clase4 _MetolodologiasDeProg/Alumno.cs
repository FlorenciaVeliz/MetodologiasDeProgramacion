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

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	/// 
	//Creando clase alumno, subclase de Persona
	public class Alumno : Persona, Observador, IAlumno
	{
		private int legajo;
		private double promedio;
		private EstrategiaDeComparacion estrategia;
		private int calificacion;
		
		public Alumno (string nombre, int dni, int legajo, double promedio, int calificacion, EstrategiaDeComparacion estrategia): base(nombre, dni){
			this.legajo = legajo;
			this.promedio = promedio;
			this.calificacion = calificacion;
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
		public int getCalificacion(){
			return this.calificacion;
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
		public void  setCalificacion(int calificacion){
			this.calificacion = calificacion;
		}
		
		
		public override bool sosIgual(Comparable c){
			return this.estrategia.sosIgual(this, (IAlumno)c);
		}
		public override bool sosMenor(Comparable c){
			return this.estrategia.sosMenor(this, (IAlumno)c);;
		}
		public override bool sosMayor(Comparable c){
			return this.estrategia.sosMayor(this, (IAlumno)c);
		}
		public override string ToString()
		{
			return "Nombre: " + this.nombre.ToString() + " DNI: " + this.dni.ToString() + " Legajo: " + this.legajo.ToString() + " Promedio: " + this.promedio.ToString() + " Estrategia de comparación: " + this.estrategia.ToString();
		}
		public void prestarAtencion(){
			Console.WriteLine("Prestando atencion");
		}
		public void distraerse(){
			Random rdn = new Random();
			string [] frases = new String[]{"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
				Console.WriteLine(frases[rdn.Next(0,3)]);
		}
		//implemento interface observador
		public void actualizar(Observado o){
			if(((Profesor)o).isHablando())
			    this.prestarAtencion();
			else
				this.distraerse();
		}
		//Ejercicio 1- Practica 4, creamos nuevos metodos
		public virtual int responderPregunta(int pregunta){
			Random rdn = new Random();
			return rdn.Next(0,4);
		}
		public string mostrarCalificacion(){
			return this.nombre + "\t" + this.calificacion;
		}

	}
}
