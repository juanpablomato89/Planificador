using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1
{
   public class Persona
   {
       #region Atributos
       private string nombre;
       private string apellido1;
       private string apellido2;
       private List<int> incidencias;
       private List<int> guardia;
       private int cantguardia;
       private int ultimodiaguardia;     
      
       #endregion

       #region Constructor
       public Persona(string nombre, string apellido1, string apellido2)
       {
           this.nombre = nombre;
           this.apellido1 = apellido1;
           this.apellido2 = apellido2;
           this.incidencias = new List<int>();
           this.guardia = new List<int>();
           cantguardia = 0;
           ultimodiaguardia = -3;
           
       }
       #endregion
      
       #region Propiedades
       public int Ultimodiaguardia
       {
           get { return ultimodiaguardia; }
           set { ultimodiaguardia = value; }
       }

       public string Apelleido2
       {
           get { return apellido2; }
           set { apellido2 = value; }
       }
       public string Apellido1
       {
           get { return apellido1; }
           set { apellido1 = value; }
       }
       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }
       public List<int> Incidencias
       {
           get { return incidencias; }
           set { incidencias = value; }
       }
       public List<int> Guardia
       {
           get { return guardia; }
           set { guardia = value; }
       }
       public int Cantguardia
       {
           get { return cantguardia; }
           set { cantguardia = value; }
       }
       #endregion

       #region Metodos

       #endregion



   }
}
