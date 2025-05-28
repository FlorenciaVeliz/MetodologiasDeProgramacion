/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 23:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor : Persona, Observado
	{
		private int antiguedad;
		private bool hablando;
		private List<Observador> observadores;
		
		public Profesor(string nombre, int dni, int antiguedad): base(nombre, dni){
			this.antiguedad = antiguedad;
			this.hablando = false;
			this.observadores = new List<Observador>();
			
		}
		public void hablarALaClase() {
			Console.WriteLine("Hablando de algún tema");
			this.hablando = true;
			this.notificar();
		}
		public void escribirEnElPizarron(){
			Console.WriteLine("Escribiendo en el pizarron");
			this.hablando = false;
			this.notificar();
		}
		public int getAntiguedad(){
			return this.antiguedad;
		}
		public bool isHablando(){
			return this.hablando;
		}
		
		override public bool sosIgual(Comparable c){
			return this.antiguedad == ((Profesor)c).antiguedad;	
		}
		override public bool sosMenor(Comparable c){
			return this.antiguedad < ((Profesor)c).antiguedad;	
		}
		override public bool sosMayor(Comparable c){
			return this.antiguedad > ((Profesor)c).antiguedad;	
		}
		override public string ToString(){
			return base.ToString() + string.Format(" Antigüedad: {0}", antiguedad);
		}
		//implemento interface observado
		public void agregarObservador(Observador o){
			this.observadores.Add(o);
		}
		public void quitarObservador(Observador o){
			this.observadores.Remove(o);
		}
		public void notificar(){
			foreach(Observador observador in observadores){
				observador.actualizar(this);
			}
		}
		public int getCantidadObservadores() {
			return this.observadores.Count;
		}
	}
}
