/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 06:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of AlumnoDecorator.
	/// </summary>
	public class AlumnoDecorator : IAlumno
	{
		IAlumno adicional;
		public AlumnoDecorator(IAlumno a){
			this.adicional = a;
		}
		//Implemento interface IALumno
		public bool sosIgual(Comparable c){
			return this.adicional.sosIgual(c);
		}
		public bool sosMenor(Comparable c){
			return this.adicional.sosMenor(c);
		}
		public bool sosMayor(Comparable c){
			return this.adicional.sosMayor(c);
		}
		public string getNombre(){
			return adicional.getNombre();
		}
		public int getLegajo(){
			return adicional.getLegajo();
		}
		public int getCalificacion(){
			return adicional.getCalificacion();
		}
		public int getDNI(){
			return adicional.getDNI();
		}
		public double getPromedio(){
			return adicional.getPromedio();
		}
		
		public void setCalificacion(int nvaCalificacion){
			this.adicional.setCalificacion(nvaCalificacion);
		}
		public virtual string mostrarCalificacion(){
			return this.adicional.mostrarCalificacion();
		}
		public int responderPregunta(int pregunta){
			return adicional.responderPregunta(pregunta);
		}
		

	}
}
