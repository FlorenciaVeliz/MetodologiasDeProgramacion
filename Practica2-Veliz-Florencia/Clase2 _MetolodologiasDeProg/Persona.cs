/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 14/4/2025
 * Hora: 21:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase2__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	/// 
	//Creando clase persona que utiliza interface comparable y compara por dni
	public abstract class Persona : Comparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string nombre, int dni){
			this.nombre = nombre;
			this.dni = dni;
		}
		public string getNombre(){
			return this.nombre;
		}
		public int getDNI(){
			return this.dni;
		}
		public virtual bool sosIgual(Comparable c){
			return this.dni == ((Persona)c).getDNI();
		}
		public virtual bool sosMenor(Comparable c){
			return this.dni < ((Persona)c).getDNI();
		}
		public virtual bool sosMayor(Comparable c){
			return this.dni > ((Persona)c).getDNI();
		}
		public override string ToString()
		{
			return "Nombre: " + this.nombre.ToString() + " DNI: " + this.dni.ToString();
		}

	}
}
