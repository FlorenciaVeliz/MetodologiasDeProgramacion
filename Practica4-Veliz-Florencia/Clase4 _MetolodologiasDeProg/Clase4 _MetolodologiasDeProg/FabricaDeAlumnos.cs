/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 21:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of FabricaDeAlumnos.
	/// </summary>
	public class FabricaDeAlumnos : FabricaDeComparables
	{		
		public override Comparable crearAletorio(){
			return new Alumno(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(100000), (double)gen.numeroAleatorio(10), (int)gen.numeroAleatorio(10), new ComparacionLegajo());
		}
		public override Comparable crearPorTeclado(){
			return new Alumno(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado(), (double)lector.numeroPorTeclado(),(int)lector.numeroPorTeclado(), new ComparacionLegajo());
		}

	}
}
