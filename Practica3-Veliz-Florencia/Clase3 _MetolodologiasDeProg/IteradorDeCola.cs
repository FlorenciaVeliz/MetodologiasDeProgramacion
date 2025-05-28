/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 17:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of IteradorDeCola.
	/// </summary>
	/// 
	//Ejercicio 5
	public class IteradorDeCola : Iterador
	{
		private int indice;
		private Cola c;
		
		public IteradorDeCola(Cola c)
		{
			this.c = c;
			this.primero();
		}
		public void primero(){
			this.indice = 0;
		}
		public void siguiente(){
			this.indice++;
		}
		public bool fin(){
			return this.indice >= c.cuantos();
		}
		public Comparable actual(){
			return c.getElementos()[indice];
		}

	}
}
