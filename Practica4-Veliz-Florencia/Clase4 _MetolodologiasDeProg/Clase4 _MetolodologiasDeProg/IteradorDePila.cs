/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 16:55
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of IteradorDePila.
	/// </summary>
	/// 
	//Ejercicio 5
	public class IteradorDePila : Iterador
	{
		private int indice;
		private Pila p;
		
		public IteradorDePila(Pila p)
		{
			this.p = p;
			this.primero();
		}
		public void primero(){
			this.indice = 0;
		}
		public void siguiente(){
			this.indice++;
		}
		public bool fin(){
			return this.indice >= p.cuantos();
		}
		public Comparable actual(){
			return p.getElementos()[indice];
		}
	}
}
