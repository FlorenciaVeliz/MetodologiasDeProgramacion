/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 22:58
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of IteradorDeColeccionMultiple.
	/// </summary>
	public class IteradorDeColeccionMultiple : Iterador
	{
		private int indice;
		private ColeccionMultiple multiple;
		
		public IteradorDeColeccionMultiple(ColeccionMultiple multiple)
		{
			this.multiple = multiple;
			this.primero();
		}
		public void primero(){
			this.indice = 0;
		}
		public void siguiente(){
			this.indice++;
		}
		public bool fin(){
			return this.indice >= multiple.cuantos();
		}
		public Comparable actual(){
			return multiple.getElementos()[indice];
		}

	}
}
