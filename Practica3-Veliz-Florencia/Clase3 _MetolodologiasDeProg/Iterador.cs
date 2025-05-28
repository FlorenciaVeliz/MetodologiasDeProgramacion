/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 16:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Iterador.
	/// </summary>
	/// 
	//Ejercicio 5
	public interface Iterador
	{
		void primero();
		void siguiente();
		bool fin();
		Comparable actual();	
	}
}
