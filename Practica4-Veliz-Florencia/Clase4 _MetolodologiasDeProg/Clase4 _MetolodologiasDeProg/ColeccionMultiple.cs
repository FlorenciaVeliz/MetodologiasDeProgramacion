/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 14/4/2025
 * Hora: 21:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	/// 
	//Creando clase coleccion multiple que implementa la interface coleccionable
	public class ColeccionMultiple : Coleccionable 
	{
		private Pila p;
		private Cola c;
		
		public ColeccionMultiple(Pila p, Cola c){
			this.p = p;
			this.c = c;
		}
		public int cuantos(){
			return p.cuantos() + c.cuantos();
		}
		public Comparable minimo(){
			Comparable c1 = p.minimo();
			Comparable c2 = c.minimo();
			return c1.sosMenor(c2) ? c1:c2;
		}
		public Comparable maximo(){
			Comparable c1 = p.maximo();
			Comparable c2 = c.maximo();
			return c1.sosMayor(c2) ? c1:c2;
		}
		public void agregar(Comparable c){
			
		}
		public bool contiene(Comparable c){
			return this.p.contiene(c) || this.c.contiene(c);
		}
		//metodos para interface iterador
		public List<Comparable> getElementos(){
			List<Comparable> elementos = new List<Comparable>();
			Iterador itePila = p.crearIterador();
			while (!itePila.fin()){
				elementos.Add(itePila.actual());
				itePila.siguiente();
			}
			Iterador iteCola = c.crearIterador();
			while (!iteCola.fin()){
				elementos.Add(iteCola.actual());
				iteCola.siguiente();
			}
			return elementos;
		}
		public Iterador crearIterador(){
			return new IteradorDeColeccionMultiple(this);
		}

	}

}
