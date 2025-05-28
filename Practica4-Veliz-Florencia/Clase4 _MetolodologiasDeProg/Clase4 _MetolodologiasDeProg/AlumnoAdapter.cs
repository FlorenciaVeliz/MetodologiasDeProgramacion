/*
 * Creado por SharpDevelop.
 * Usuario: usuario
 * Fecha: 28/5/2025
 * Hora: 06:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MetodologíasDeProgramaciónI;

namespace Clase4__MetolodologiasDeProg
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter : Student
	{
		private IAlumno alumno;
		public AlumnoAdapter(IAlumno alumno){
			this.alumno = alumno;
		}
		public string getName(){
			return this.alumno.getNombre();
		}
		public int yourAnswerIs(int question){
			return alumno.responderPregunta(question);
		}
		public void setScore(int score){
			this.alumno.setCalificacion(score);
		}
		public string showResult(){
			return this.alumno.mostrarCalificacion();
		}
		public bool equals(Student student){
			return this.alumno.sosIgual(((AlumnoAdapter)student).alumno);
		}
		public bool lessThan(Student student){
			return this.alumno.sosMenor(((AlumnoAdapter)student).alumno);
		}
		public bool greaterThan(Student student){
			return this.alumno.sosMayor(((AlumnoAdapter)student).alumno);
		}

	}
}
