/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 17:06
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase2__MetolodologiasDeProg
{
	/// <summary>
	/// Description of IteradorDeConjunto.
	/// </summary>
	/// 
	//Ejercicio 5
	public class IteradorDeConjunto : Iterador
	{
		private int indice;
		private Conjunto con;
		
		public IteradorDeConjunto(Conjunto con)
		{
			this.con = con;
			this.primero();
		}
		public void primero(){
			this.indice = 0;
		}
		public void siguiente(){
			this.indice++;
		}
		public bool fin(){
			return this.indice >= con.cuantos();
		}
		public Comparable actual(){
			return con.getElementos()[indice];
		}
	}
}
