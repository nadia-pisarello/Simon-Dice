using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SimonDice
{
    public partial class Form1 : Form
    {
        List<String> lista_color_user = new List<String>();
        List<String> lista_simon = new List<String>();
        static Random rand = new Random();
        int contador_secuencia = 0;
        int indx_secuencia = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += Timer_Mostrar_Secuencia;
            timer2.Interval = 500;
            timer2.Tick += Timer_Restaurar_Color;
            timer3.Interval = 200;
            timer3.Tick += Timer_Restaurar_Color;

        }              

        private void inicio_Click(object sender, EventArgs e)
        {
            lista_simon.Clear();
            lista_color_user.Clear();
            if (jugador_tbox.Text == "")
            {
                MessageBox.Show("Ingrese nombre de jugador para iniciar", "Jugador", MessageBoxButtons.OK);
            }
            else
            {
                Iniciar_Juego();
            }

        }
        private void Iniciar_Juego()
        {
            Agregar_Color_Secuencia(); 
            Mostrar_Secuencia();
            Verificar_Secuencia();

        }
        private void Agregar_Color_Secuencia()
        {
            string[] colores = { "rojo", "verde", "azul", "amarillo" };
            string color = colores[rand.Next(0, colores.Length)];
            lista_simon.Add(color);

        }
        
        private void Timer_Restaurar_Color(object sender, EventArgs e)
        {
            rojo.BackColor = Color.Red; 
            verde.BackColor = Color.Lime;
            azul.BackColor = Color.Cyan;
            amarillo.BackColor = Color.Yellow;
            timer2.Stop();  
            timer3.Stop();
        }

        private void verde_Click(object sender, EventArgs e)
        {
            lista_color_user.Add("verde");
            verde.BackColor = Color.ForestGreen;
            timer3.Start();
            Verificar_Secuencia();
            
        }

        private void rojo_Click(object sender, EventArgs e)
        {
            lista_color_user.Add("rojo");
            rojo.BackColor = Color.Maroon;
            timer3.Start();
            Verificar_Secuencia();
        }

        private void amarillo_Click(object sender, EventArgs e)
        {
            lista_color_user.Add("amarillo");
            amarillo.BackColor= Color.Gold;
            timer3.Start();
            Verificar_Secuencia();
        }

        private void azul_Click(object sender, EventArgs e)
        {
            lista_color_user.Add("azul");
            azul.BackColor= Color.LightSkyBlue;
            timer3.Start();
            Verificar_Secuencia();
        }

        private void Mostrar_Secuencia()
        {
            indx_secuencia = 0;
            timer1.Start();

        }
        private void Timer_Mostrar_Secuencia(object sender, EventArgs e)
        {
            if (indx_secuencia < lista_simon.Count)
            {

                string color = lista_simon[indx_secuencia];
                switch (color)
                {
                    case "rojo":
                        rojo.BackColor = Color.Maroon; break;
                    case "verde":
                        verde.BackColor = Color.ForestGreen; break;
                    case "azul":
                        azul.BackColor = Color.DeepSkyBlue; break;
                    case "amarillo":
                        amarillo.BackColor = Color.Gold; break;

                }
                indx_secuencia++;
                timer2.Start();
            }
            else
            {
                timer1.Stop();
            }

        }

        private void Verificar_Secuencia()
        {
            if (lista_color_user.Count > lista_simon.Count)
            {
                MessageBox.Show("Te has equivocado", "Perdiste!", MessageBoxButtons.OK);
                Reiniciar_Juego();
                return;
            }
            for (int i = 0; i < lista_color_user.Count; i++)
            {
                if (!lista_color_user[i].Equals(lista_simon[i]))
                {
                    MessageBox.Show("Te has equivocado", "Perdiste!", MessageBoxButtons.OK);
                    Reiniciar_Juego();
                    return;
                }
            }
            if (lista_color_user.Count == lista_simon.Count)
            {
                lista_color_user.Clear();
                contador_secuencia++;
                cont_lb.Text = contador_secuencia.ToString();
                Iniciar_Juego();
            }

        }
        private void Reiniciar_Juego()
        {
            contador_secuencia = 0;
            cont_lb.Text = "0";
            lista_color_user.Clear();
            lista_simon.Clear();
        }
        
        
    }    
}
