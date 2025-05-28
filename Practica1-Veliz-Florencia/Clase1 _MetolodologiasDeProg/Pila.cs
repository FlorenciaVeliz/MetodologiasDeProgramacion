/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 13/4/2025
 * Hora: 22:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase1__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	/// 
	//creando clase Pila que implementa interface Coleccionable
	public class Pila : Coleccionable
	{
		List<Comparable> elementos;
		
		public Pila(){
			this.elementos = new List<Comparable>();
		}
		public void apilar (Comparable c){
			this.elementos.Add(c);
		}
		public Comparable desapilar(){
			Comparable aux = this.elementos[elementos.Count -1];
			this.elementos.RemoveAt(this.elementos.Count -1);
            return aux;			                        
		}
		//Interface Coleccionable
		public int cuantos(){
			return this.elementos.Count;
		}
		public Comparable minimo(){
			Comparable minimoActual = this.elementos[0];
			for(int i=1; i<this.cuantos(); i++){
				if (this.elementos[i].sosMenor(minimoActual)){
					minimoActual = this.elementos[i];
				}
			}
			return minimoActual;
		}
		public Comparable maximo(){
			Comparable maximoActual = this.elementos[0];
			for(int i=1; i<this.cuantos(); i++){
				if (this.elementos[i].sosMayor(maximoActual)){
					maximoActual = this.elementos[i];
				}
			}
			return maximoActual;
		}
		public void agregar(Comparable c){
			this.apilar(c);
		}
		public bool contiene(Comparable c){
			foreach(Comparable elem in this.elementos){
				if(elem.sosIgual(c)){
					return true;
				}
			}
			return false;	
		}
//
	}
}
