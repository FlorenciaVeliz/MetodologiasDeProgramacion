/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 20:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of EstrategiaDeComparacion.
	/// </summary>
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(IAlumno a1, IAlumno a2);
		bool sosMenor(IAlumno a1, IAlumno a2);
		bool sosMayor(IAlumno a1, IAlumno a2);
		
	}
}
