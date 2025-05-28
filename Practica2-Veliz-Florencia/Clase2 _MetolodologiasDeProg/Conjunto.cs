/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 21:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase2__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	/// 
	//Ejercicio 3 y 4
	public class Conjunto : Coleccionable
	{
		private List<Comparable> elementos;
		
		public Conjunto(){
			elementos = new List<Comparable>();
		}
		public void agregarAlConjunto(Comparable elemento){
			if (!pertenece (elemento)){
				elementos.Add(elemento);
			}
		}
		public bool pertenece(Comparable elemento){
			foreach (Comparable elem in this.elementos){
				if(elem.sosIgual(elemento)){
					return true;
				}
			}
			return false;
		}
		//Interface coleccionable
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
			this.agregarAlConjunto(c);
		}
		public bool contiene(Comparable c){
			return pertenece(c);
		}
		//Ejercicio 5
		//metodos para interface iterador
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		public Iterador crearIterador(){
			return new IteradorDeConjunto(this);
		}
	}
}
