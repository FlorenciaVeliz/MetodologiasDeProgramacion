/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 27/5/2025
 * Hora: 21:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of FabricaDeNumeros.
	/// </summary>
	public class FabricaDeNumeros : FabricaDeComparables
	{
		public override Comparable crearAletorio(){
			return new Numero(gen.numeroAleatorio(1000));
		}
		public override Comparable crearPorTeclado(){
			return new Numero(lector.numeroPorTeclado());
		}

	}
}
