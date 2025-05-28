/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 13:37
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of DecoradoAsteriscos.
	/// </summary>
	public class DecoradoAsteriscos : AlumnoDecorator
	{
		public DecoradoAsteriscos(IAlumno a): base (a)
		{
		}
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
			string borde = new string('*', resultado.Length + 4);
			
			return borde + "\n*" + resultado + " *\n" + borde;
		}
	}
}
