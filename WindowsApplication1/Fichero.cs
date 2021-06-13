using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WindowsApplication1
{
    public class Fichero
    {
        #region Atributos
        private StreamReader reader;        
        #endregion

        #region Constructor
        public Fichero(string archivo)
        {
            reader = new StreamReader(archivo);            
        }
        #endregion

        #region Propiedades
        public StreamReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }
        #endregion

        #region Metodos
        public List<Persona> Leer()
        {
            try
            {
                List<Persona> listapersona = new List<Persona>();
                 string lectura = reader.ReadToEnd();
                string[] puntocoma = lectura.Split(';');
                List<int> listaincidencias = new List<int>();

                for (int i = 0; i < puntocoma.Length-1; i++)
                {
                    string[] coma = puntocoma[i].Split(',');

                    string nombre = coma[0];

                    for (int j = 1; j < coma.Length; j++)
                    {
                        if (coma[j].Length <= 2)
                            listaincidencias.Add(int.Parse(coma[j].ToString()));
                        else
                        {
                            string[] inci = coma[j].Split('-');
                            int inicio = int.Parse(inci[0].ToString());
                            int final = int.Parse(inci[1].ToString());
                            while (inicio <= final)
                            {
                                listaincidencias.Add(inicio);
                                inicio++;
                            }
                                
                            
                        }

                    }
                    Persona persona = new Persona(nombre, "", "");
                    persona.Incidencias = listaincidencias;
                    listapersona.Add(persona);
                    listaincidencias = new List<int>();
                }
                return listapersona;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


        #endregion
    }
}
