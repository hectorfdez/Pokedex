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
        int idActual = 1;//Guardo el id del pokemon
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            idActual--;
            misPokememons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokememons.Rows[0]["nombre"].ToString();
        }

        private void derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            misPokememons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokememons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokememons.Rows[0]["imagen"]);
        }

    }
}
