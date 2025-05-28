/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 13/4/2025
 * Hora: 22:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	/// 
	// creando la Clase Numero que utiliza la Interface Comparable
	public class Numero : Comparable
	{
		private int valor;
		public Numero (int valor)
		{
			this.valor = valor;
		}
		public int getValor(){
			return this.valor;
		}
		public bool sosIgual(Comparable c){
			return this.valor == ((Numero)c).getValor();
		}
		public bool sosMenor(Comparable c){
			return this.valor < ((Numero)c).getValor();
		}
		public bool sosMayor(Comparable c){
			return this.valor > ((Numero)c).getValor();
		}
		public override string ToString()
		{
			return this.valor.ToString();
		}
 
	}
}
