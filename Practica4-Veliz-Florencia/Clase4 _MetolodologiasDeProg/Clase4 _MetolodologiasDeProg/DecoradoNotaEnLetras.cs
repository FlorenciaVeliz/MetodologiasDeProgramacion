/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 13:21
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of DecoradoNotaEnLetras.
	/// </summary>
	public class DecoradoNotaEnLetras : AlumnoDecorator
	{
		public DecoradoNotaEnLetras(IAlumno a):base (a)
		{
		}
		public override string mostrarCalificacion(){
			string[] letras = {"CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"};
			int nota = base.getCalificacion();
			return base.mostrarCalificacion() + " (" + letras[nota] + ")";
		}
	}
}
