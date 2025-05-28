/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 13/4/2025
 * Hora: 22:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	/// 
    //creando clase Cola que implementa interface Coleccionable
    public class Cola : Coleccionable
    {
    	List<Comparable> elementos;
    	
    	public Cola(){
    		this.elementos = new List<Comparable>();
    	}
    	public void encolar(Comparable c){
    		this.elementos.Add(c);
    	}
    	public Comparable desencolar(){
    		Comparable aux = this.elementos[0];
    		this.elementos.RemoveAt(0);
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
			this.encolar(c);
		}
		public bool contiene(Comparable c){
			foreach(Comparable elem in this.elementos){
				if(elem.sosIgual(c)){
					return true;
				}
			}
			return false;	
		}
    	//Ejercicio 5
    	//metodos para interface iterador
		public List<Comparable> getElementos(){
			return this.elementos;
		}
		public Iterador crearIterador(){
			return new IteradorDeCola(this);
		}
    }
}
