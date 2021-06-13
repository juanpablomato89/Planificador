using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApplication1
{
    public class SG
    {
        #region Atributos
        private List<Persona> jtcc;
        private List<Persona> og;
        private List<Persona> aog;
        private List<int> diasguardia;        
        #endregion

        #region Constructor
        public SG()
        {
            jtcc = new List<Persona>();
            og = new List<Persona>();
            aog = new List<Persona>();
            diasguardia = new List<int>(31);
        }
        #endregion

        #region Propiedades
        public List<int> Diasguardia
        {
            get { return diasguardia; }
            set { diasguardia = value; }
        }
        public List<Persona> Og
        {
            get { return og; }
            set { og = value; }
        }
        public List<Persona> Aog
        {
            get { return aog; }
            set { aog = value; }
        }
        public List<Persona> Jtcc
        {
            get { return jtcc; }
            set { jtcc = value; }
        }
        #endregion

        #region Metodos
        public void Planificar(List<Persona> listado, int mes)
        {
            try
            {             

                int dias = 0;
                if (mes == 1 || mes == 3 || mes == 5 || 
                    mes == 7 || mes == 8
                    || mes == 10 || mes == 12)
                    dias = 31;
                else if (mes == 2)
                    dias = 28;
                else
                    dias = 30;
                LLenarDiasGuardia(dias);

                int cantguardia = dias / listado.Count;
                int cantpersonas = listado.Count - 1;
               
                if ((dias & listado.Count) != 0)
                    cantguardia++;


               #region esto es para reutilizarlo

                for (int i = 0; i < diasguardia.Count; i++)
                {
                    for (int j = 0; j < listado.Count; j++)
                    {
                        if (!TieneIncidencias(listado[j].Incidencias, i + 1) && listado[j].Cantguardia < cantguardia
                            && (listado[j].Ultimodiaguardia+3) <= diasguardia[i])
                        {
                            listado[j].Guardia.Add(diasguardia[i]);
                            listado[j].Cantguardia++;
                            listado[j].Ultimodiaguardia = diasguardia[i];
                            break;
                        }
                    }
                    OrdenarMenosGuardias(listado);
                } 
                #endregion

            }
            catch (Exception)
            {

                throw new Exception("Error");
            }
        }

        public bool TieneIncidencias(List<int> incidencias, int dia)
        {
            try
            {
                bool tiene = false;
                
                for (int i = 0; i < incidencias.Count; i++)
                {
                    if (incidencias[i] == dia || incidencias[i] - 1 == dia)
                    {
                        tiene = true;
                        break;
                    }                       

                }
                
                return tiene;
            }
            catch (Exception)
            {

                throw new Exception("Error");
            }
            
        }

        public void PlanificarAOG(int mes)
        {
            for (int i = 0; i < og.Count; i++)
            {
                aog[i].Cantguardia = 0;
                aog[i].Ultimodiaguardia = -3;
                aog[i].Guardia = new List<int>();
            }
            Planificar(aog,mes);
        }

        public void PlanificarOG(int mes)
        {
            for (int i = 0; i < og.Count; i++)
            {
                og[i].Cantguardia = 0;
                og[i].Ultimodiaguardia = -3;
                og[i].Guardia = new List<int>();
            }
            Planificar(og,mes);
        }

        public void PlanificarJTCC(int mes)
        {
            for (int i = 0; i < og.Count; i++)
            {
                jtcc[i].Cantguardia = 0;
                jtcc[i].Ultimodiaguardia = -3;
                jtcc[i].Guardia = new List<int>();
            }
            Planificar(jtcc,mes);
        }

        public void LLenarDiasGuardia(int dias)
        {
            diasguardia = new List<int>(dias);
            for (int i = 0; i < dias; i++)
            {
                diasguardia.Add(i + 1);
            }
        }

        public void OrdenarMenosGuardias(List<Persona> listado)
        {
            Persona nueva =null;
            for (int i = 0; i < listado.Count-1; i++)
            {
                for (int j = 1; j < listado.Count; j++)
                {
                    if (listado[i].Cantguardia > listado[j].Cantguardia)
                    {
                        nueva= listado[i];
                        listado.Insert(i, listado[j]);
                        listado.RemoveAt(i + 1);                        
                        listado.Insert(j, nueva);
                        listado.RemoveAt(j + 1);

                    }
                }
            } 
        }

        #endregion
       

        

        


    }
 }
