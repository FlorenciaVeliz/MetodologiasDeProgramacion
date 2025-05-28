/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 23:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase3__MetolodologiasDeProg
{
	/// <summary>
	/// Description of FabricaDeProfesores.
	/// </summary>
	public class FabricaDeProfesores : FabricaDeComparables
	{
		public override Comparable crearAletorio(){
			return new Profesor(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(25));
		}
		public override Comparable crearPorTeclado(){
			return new Profesor(lector.stringPorTeclado(), lector.numeroPorTeclado(), lector.numeroPorTeclado());
		}

	}
}
