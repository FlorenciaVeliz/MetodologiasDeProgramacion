/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 06:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of DecoradoConLegajo.
	/// </summary>
	public class DecoradoConLegajo : AlumnoDecorator
	{
		public DecoradoConLegajo(IAlumno a):base (a)
		{
		}
		public override string mostrarCalificacion()
		{
			return base.mostrarCalificacion() + " (" + base.getLegajo() + "/" + base.getCalificacion() + ") ";
		}

	}
}
