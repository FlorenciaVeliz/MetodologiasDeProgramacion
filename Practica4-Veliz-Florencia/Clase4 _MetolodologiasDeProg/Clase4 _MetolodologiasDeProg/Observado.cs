/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 03:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of Observado.
	/// </summary>
	public interface Observado
	{
		void agregarObservador(Observador o);
		void quitarObservador(Observador o);
		void notificar();
		
	}
}
