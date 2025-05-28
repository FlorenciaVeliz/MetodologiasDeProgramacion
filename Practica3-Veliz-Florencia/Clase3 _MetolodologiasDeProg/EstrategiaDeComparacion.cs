/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 26/5/2025
 * Hora: 20:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of EstrategiaDeComparacion.
	/// </summary>
	public interface EstrategiaDeComparacion
	{
		bool sosIgual(Alumno a1, Alumno a2);
		bool sosMenor(Alumno a1, Alumno a2);
		bool sosMayor(Alumno a1, Alumno a2);
		
	}
}
