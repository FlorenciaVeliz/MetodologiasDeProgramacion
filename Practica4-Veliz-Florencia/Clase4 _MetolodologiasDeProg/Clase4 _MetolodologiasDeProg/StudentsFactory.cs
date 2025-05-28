/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 14:00
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of StudentsFactory.
	/// </summary>
	public class StudentsFactory : FabricaDeAlumnos
	{
		public override Comparable crearAletorio(){
			IAlumno alumno = new Alumno(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(100000), (double)gen.numeroAleatorio(10), (int)gen.numeroAleatorio(10), new ComparacionLegajo());
			IAlumno decorado = new DecoradoAsteriscos(
			new DecoradoConCondicion(
				new DecoradoNotaEnLetras(
					new DecoradoConLegajo(alumno)
				)
			)
		);
			return decorado;
		}
		public override Comparable crearPorTeclado(){
			IAlumno alumno = new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), (double)lector.numeroPorTeclado(),(int)lector.numeroPorTeclado(), new ComparacionLegajo());
			IAlumno decorado = new DecoradoAsteriscos(
			new DecoradoConCondicion(
				new DecoradoNotaEnLetras(
					new DecoradoConLegajo(alumno)
				)
			)
		);
			return decorado;
		}
			
	}
}
