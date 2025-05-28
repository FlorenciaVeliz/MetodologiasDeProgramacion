/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 13:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of DecoradoConCondicion.
	/// </summary>
	public class DecoradoConCondicion : AlumnoDecorator
	{
		public DecoradoConCondicion(IAlumno a):base (a)
		{
		}
		public override string mostrarCalificacion()
		{
			int nota = base.getCalificacion();
			string condicion;
			if (nota >= 7){
				condicion = "PROMOCION";
			}
			else if(nota >= 4){
				condicion = "APROBADO";
			}
			else 
				condicion = "DESAPROBADO";
			return base.mostrarCalificacion() + " " + nota + " (" + condicion + ")";
		}

	}
}
