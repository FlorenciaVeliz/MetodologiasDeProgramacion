/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 13/4/2025
 * Hora: 22:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Clase1__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	/// 
	//Implementando interface Coleccionable que representa objetos que almacenan comparables
	public interface Coleccionable
	{
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable c);
		bool contiene(Comparable c);
	}
}
