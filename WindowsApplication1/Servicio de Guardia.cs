using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        private Fichero fichero;
        private SG guardia;
        int mes;
        
        public Form1(int mes)
        {           
            InitializeComponent();
            guardia = new SG();
            this.mes = mes;
        }      

        private void tabOG_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (tabOG.SelectedIndex == 0)
                {
                    fichero = new Fichero("og.txt");
                    guardia.Og = fichero.Leer();        
                    guardia.Planificar(guardia.Og,mes);
                    List<List<string>> lis = LLenarLVW(guardia.Og);
                    lvwOG.Items.Clear();
                    for (int i = 0; i < lis.Count; i++)
                    {

                        lvwOG.Items.Add(lis[i][0].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][1].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][2].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][3].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][4].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][5].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][6].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][7].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][8].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][9].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][10].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][11].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][12].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][13].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][14].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][15].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][16].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][17].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][18].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][19].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][20].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][21].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][22].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][23].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][24].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][25].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][26].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][27].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][28].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][29].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][30].ToString());
                        lvwOG.Items[i].SubItems.Add(lis[i][31].ToString());                       
                    }                   
                  
                }
                else if (tabOG.SelectedIndex == 1)
                {
                    fichero = new Fichero("aog.txt");
                    guardia.Aog = fichero.Leer();
                    guardia.Planificar(guardia.Aog,mes);
                    lvwAOG.Items.Clear();
                    List<List<string>> lis = LLenarLVW(guardia.Aog);

                    for (int i = 0; i < lis.Count; i++)
                    {

                        lvwAOG.Items.Add(lis[i][0].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][1].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][2].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][3].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][4].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][5].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][6].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][7].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][8].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][9].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][10].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][11].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][12].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][13].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][14].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][15].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][16].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][17].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][18].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][19].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][20].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][21].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][22].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][23].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][24].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][25].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][26].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][27].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][28].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][29].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][30].ToString());
                        lvwAOG.Items[i].SubItems.Add(lis[i][31].ToString());
                    }

                }
                else
                {
                    lvwJTCC.Items.Clear();
                    fichero = new Fichero("jtcc.txt");
                    guardia.Jtcc = fichero.Leer();
                    guardia.Planificar(guardia.Jtcc,mes);

                    List<List<string>> lis = LLenarLVW(guardia.Jtcc);

                    for (int i = 0; i < lis.Count; i++)
                    {                       
                        lvwJTCC.Items.Add(lis[i][0].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][1].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][2].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][3].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][4].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][5].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][6].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][7].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][8].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][9].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][10].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][11].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][12].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][13].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][14].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][15].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][16].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][17].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][18].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][19].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][20].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][21].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][22].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][23].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][24].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][25].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][26].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][27].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][28].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][29].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][30].ToString());
                        lvwJTCC.Items[i].SubItems.Add(lis[i][31].ToString());
                    }
                }               
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
        }

        public List<List<string>> LLenarLVW(List<Persona> listado)
        {
            List<string> listallenar = new List<string>();
            for (int i = 0; i < 32; i++)
            {
                listallenar.Add("");
            }
            List<List<string>> sd = new List<List<string>>();
            for (int i = 0; i < listado.Count; i++)
            {
                listallenar[0] = listado[i].Nombre;
                for (int j = 0; j < listado[i].Guardia.Count; j++)
                {                    
                    listallenar[listado[i].Guardia[j]] = "X";
                }
                for (int m = 0; m < listado[i].Incidencias.Count; m++)
                {
                    listallenar[listado[i].Incidencias[m]] = "---";
                }
                sd.Add(listallenar);
                listallenar = new List<string>();
                for (int k = 0; k < 32; k++)
                {
                    listallenar.Add("");
                }
            }

                return sd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Guardia es 1 es OG, si es 2 AOG, si es 3 JTCC
        /// </summary>
        /// <param name="guardia"></param>
        private void TieneIncidencias(int guardia,List<int> inci)
        {

        }     
    }
}