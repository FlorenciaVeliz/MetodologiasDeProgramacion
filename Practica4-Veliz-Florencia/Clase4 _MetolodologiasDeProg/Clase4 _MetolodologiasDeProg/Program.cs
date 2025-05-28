/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 04:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MetodologíasDeProgramaciónI;
using System.Collections.Generic;

namespace Clase4__MetolodologiasDeProg
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool salir = false;
			while(!salir){
				Console.Clear();
				Console.WriteLine("Seleccione el ejercicio que quiera ejecutar:");
				Console.WriteLine("1 - Main del EJERCICIO 4");
				Console.WriteLine("2 - Main del EJERCICIO 8");
				Console.WriteLine("0 - SALIR");
				Console.WriteLine("Ingrese su opción: ");
				
				string opcion = Console.ReadLine();
				Console.WriteLine();
				
				Teacher teacher = new Teacher();
				
				switch(opcion){
					case "1":
						for(int i=0; i<10; i++){
							Alumno a = (Alumno)FabricaDeComparables.crearAleatorio(2);
							Student alumnoAdaptado = new AlumnoAdapter(a);
							teacher.goToClass(alumnoAdaptado);
						}
						for(int i=0; i<10; i++){
							Random r = new Random();
							string[] nombres = {"Florencia", "Agustina", "Ana", "Maria", "Martina", "Emilia", "Luz", "Paula", "Emma", "Victoria", "Brian", "Thiago", "Martin", "Juan", "Pablo", "Franco", "Santiago", "Matias", "Nicolas", "Mateo"};
							string nombreAleatorio = nombres[r.Next(nombres.Length)];
							int dniAleatorio = r.Next(1, 50000000);
							int legajoAleatorio = r.Next(1, 999);
							double promedioAleatorio = r.NextDouble()*10;
							
							AlumnoMuyEstudioso alumnoEstudioso = new AlumnoMuyEstudioso(nombreAleatorio, dniAleatorio, legajoAleatorio, promedioAleatorio, 10, new ComparacionLegajo());
							Student alumnoAdaptado = new AlumnoAdapter(alumnoEstudioso);
							teacher.goToClass(alumnoAdaptado);
						}
						teacher.teachingAClass();
						break;
						
					case "2":
						List<Student> alumnos = new List<Student>();
						FabricaDeComparables fabrica = new StudentsFactory();
		
						for (int i=0; i<5; i++){
							IAlumno decorado = (IAlumno)fabrica.crearAletorio();
							Student alumnoAdaptado = new AlumnoAdapter(decorado);
							alumnos.Add(alumnoAdaptado);
							teacher.goToClass(alumnoAdaptado);
						}
						teacher.teachingAClass();
						
						foreach(Student alumno in alumnos){
							Console.WriteLine(alumno.showResult());
						}
						break;
					case "0":
						salir = true;
						break;
					default:
						Console.WriteLine("Opción no valida");
						break;
				}
				if (!salir){
					Console.Write("Presione cualquier tecla para salir . . . ");
					Console.ReadKey(true);
				}
			}
		}
	}
}
