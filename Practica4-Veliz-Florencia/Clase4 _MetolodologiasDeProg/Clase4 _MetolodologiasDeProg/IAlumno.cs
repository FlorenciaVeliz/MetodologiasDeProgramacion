/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 06:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno : Comparable
	{
		int getCalificacion();
		void setCalificacion(int nvaCalificacion);
		int getLegajo();
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
		string getNombre();
		int getDNI();
		double getPromedio();
	
	}
}
