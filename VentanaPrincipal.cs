using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokememons = new DataTable();
        int idActual = 0;//Guardo el id del pokemon
        public VentanaPrincipal()
        {
            InitializeComponent();
            misPokememons = miConexion.getPokemonPorId(1);
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            nombrePokemon.Text = misPokememons.Rows[0]["nombre"].ToString();
            altura.Text = misPokememons.Rows[0]["altura"].ToString();
            peso.Text = misPokememons.Rows[0]["peso"].ToString();
            especie.Text = misPokememons.Rows[0]["especie"].ToString();
            peso.Text = misPokememons.Rows[0]["peso"].ToString();
            habitat.Text = misPokememons.Rows[0]["habitat"].ToString();
            tipo1.Text = misPokememons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokememons.Rows[0]["tipo2"].ToString();
            habilidad.Text = misPokememons.Rows[0]["habilidad"].ToString();
            movimiento1.Text = misPokememons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokememons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokememons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokememons.Rows[0]["movimiento4"].ToString();
            preEvolucion.Text = misPokememons.Rows[0]["preEvolucion"].ToString();
            posEvolucion.Text = misPokememons.Rows[0]["posEvolucion"].ToString();
            descripcion.Text = misPokememons.Rows[0]["descripcion"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokememons.Rows[0]["imagen"]);
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            nombrePokemon.Text = misPokememons.Rows[0]["nombre"].ToString();
            altura.Text = misPokememons.Rows[0]["altura"].ToString();
            peso.Text = misPokememons.Rows[0]["peso"].ToString();
            especie.Text = misPokememons.Rows[0]["especie"].ToString();
            peso.Text = misPokememons.Rows[0]["peso"].ToString();
            habitat.Text = misPokememons.Rows[0]["habitat"].ToString();
            tipo1.Text = misPokememons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokememons.Rows[0]["tipo2"].ToString();
            habilidad.Text = misPokememons.Rows[0]["habilidad"].ToString();
            movimiento1.Text = misPokememons.Rows[0]["movimiento1"].ToString();
            movimiento2.Text = misPokememons.Rows[0]["movimiento2"].ToString();
            movimiento3.Text = misPokememons.Rows[0]["movimiento3"].ToString();
            movimiento4.Text = misPokememons.Rows[0]["movimiento4"].ToString();
            preEvolucion.Text = misPokememons.Rows[0]["preEvolucion"].ToString();
            posEvolucion.Text = misPokememons.Rows[0]["posEvolucion"].ToString();
            descripcion.Text = misPokememons.Rows[0]["descripcion"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokememons.Rows[0]["imagen"]);

        }

    }
}
