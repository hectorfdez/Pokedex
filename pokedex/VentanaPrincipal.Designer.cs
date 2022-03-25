
namespace Pokedex
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.habitat = new System.Windows.Forms.Label();
            this.tipo1 = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.habilidad = new System.Windows.Forms.Label();
            this.movimiento1 = new System.Windows.Forms.Label();
            this.movimiento2 = new System.Windows.Forms.Label();
            this.movimiento3 = new System.Windows.Forms.Label();
            this.movimiento4 = new System.Windows.Forms.Label();
            this.preEvolucion = new System.Windows.Forms.Label();
            this.posEvolucion = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.izquierda = new System.Windows.Forms.Button();
            this.derecha = new System.Windows.Forms.Button();
            this.botondescripcion = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox1.Location = new System.Drawing.Point(57, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.Color.Transparent;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.Location = new System.Drawing.Point(98, 267);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(114, 23);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.Text = "Nombre:";
            this.nombrePokemon.Click += new System.EventHandler(this.nombrePokemon_Click);
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.Color.Transparent;
            this.altura.Location = new System.Drawing.Point(359, 212);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(47, 19);
            this.altura.TabIndex = 5;
            this.altura.Text = "Altura";
            this.altura.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.altura.Click += new System.EventHandler(this.label1_Click);
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.Color.Transparent;
            this.peso.Location = new System.Drawing.Point(43, 308);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(36, 19);
            this.peso.TabIndex = 6;
            this.peso.Text = "Peso";
            this.peso.Click += new System.EventHandler(this.peso_Click);
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Transparent;
            this.especie.Location = new System.Drawing.Point(423, 212);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(49, 19);
            this.especie.TabIndex = 7;
            this.especie.Text = "Especie";
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.Color.Transparent;
            this.habitat.Location = new System.Drawing.Point(484, 212);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(58, 19);
            this.habitat.TabIndex = 8;
            this.habitat.Text = "Habitat";
            // 
            // tipo1
            // 
            this.tipo1.BackColor = System.Drawing.Color.Transparent;
            this.tipo1.Location = new System.Drawing.Point(494, 235);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(42, 19);
            this.tipo1.TabIndex = 9;
            this.tipo1.Text = "Tipo1";
            this.tipo1.Click += new System.EventHandler(this.tipo1_Click);
            // 
            // tipo2
            // 
            this.tipo2.BackColor = System.Drawing.Color.Transparent;
            this.tipo2.Location = new System.Drawing.Point(359, 235);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(47, 19);
            this.tipo2.TabIndex = 10;
            this.tipo2.Text = "Tipo2";
            // 
            // habilidad
            // 
            this.habilidad.BackColor = System.Drawing.Color.Transparent;
            this.habilidad.Location = new System.Drawing.Point(423, 235);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(51, 19);
            this.habilidad.TabIndex = 11;
            this.habilidad.Text = "Habilidad ";
            // 
            // movimiento1
            // 
            this.movimiento1.BackColor = System.Drawing.Color.Transparent;
            this.movimiento1.Location = new System.Drawing.Point(359, 153);
            this.movimiento1.Name = "movimiento1";
            this.movimiento1.Size = new System.Drawing.Size(74, 17);
            this.movimiento1.TabIndex = 12;
            this.movimiento1.Text = "Movimiento 1";
            this.movimiento1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // movimiento2
            // 
            this.movimiento2.BackColor = System.Drawing.Color.Transparent;
            this.movimiento2.Location = new System.Drawing.Point(359, 172);
            this.movimiento2.Name = "movimiento2";
            this.movimiento2.Size = new System.Drawing.Size(74, 17);
            this.movimiento2.TabIndex = 13;
            this.movimiento2.Text = "Movimiento 2";
            // 
            // movimiento3
            // 
            this.movimiento3.BackColor = System.Drawing.Color.Transparent;
            this.movimiento3.Location = new System.Drawing.Point(465, 153);
            this.movimiento3.Name = "movimiento3";
            this.movimiento3.Size = new System.Drawing.Size(77, 17);
            this.movimiento3.TabIndex = 14;
            this.movimiento3.Text = "Movimiento 3";
            // 
            // movimiento4
            // 
            this.movimiento4.BackColor = System.Drawing.Color.Transparent;
            this.movimiento4.Location = new System.Drawing.Point(465, 172);
            this.movimiento4.Name = "movimiento4";
            this.movimiento4.Size = new System.Drawing.Size(73, 22);
            this.movimiento4.TabIndex = 15;
            this.movimiento4.Text = "Movimiento 4";
            // 
            // preEvolucion
            // 
            this.preEvolucion.BackColor = System.Drawing.Color.Transparent;
            this.preEvolucion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.preEvolucion.Location = new System.Drawing.Point(356, 332);
            this.preEvolucion.Name = "preEvolucion";
            this.preEvolucion.Size = new System.Drawing.Size(77, 20);
            this.preEvolucion.TabIndex = 16;
            this.preEvolucion.Text = "preEvolucion";
            // 
            // posEvolucion
            // 
            this.posEvolucion.BackColor = System.Drawing.Color.Transparent;
            this.posEvolucion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.posEvolucion.Location = new System.Drawing.Point(465, 332);
            this.posEvolucion.Name = "posEvolucion";
            this.posEvolucion.Size = new System.Drawing.Size(71, 23);
            this.posEvolucion.TabIndex = 17;
            this.posEvolucion.Text = "posEvolucion";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Black;
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Image = ((System.Drawing.Image)(resources.GetObject("descripcion.Image")));
            this.descripcion.Location = new System.Drawing.Point(385, 9);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(189, 121);
            this.descripcion.TabIndex = 18;
            this.descripcion.Text = "Descripción";
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.descripcion.Click += new System.EventHandler(this.descripcion_Click);
            // 
            // izquierda
            // 
            this.izquierda.BackColor = System.Drawing.Color.Transparent;
            this.izquierda.FlatAppearance.BorderSize = 0;
            this.izquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izquierda.Location = new System.Drawing.Point(348, 278);
            this.izquierda.Name = "izquierda";
            this.izquierda.Size = new System.Drawing.Size(69, 26);
            this.izquierda.TabIndex = 0;
            this.izquierda.Text = "<";
            this.izquierda.UseVisualStyleBackColor = false;
            this.izquierda.Click += new System.EventHandler(this.izquierda_Click);
            // 
            // derecha
            // 
            this.derecha.BackColor = System.Drawing.Color.Transparent;
            this.derecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.derecha.Location = new System.Drawing.Point(417, 278);
            this.derecha.Name = "derecha";
            this.derecha.Size = new System.Drawing.Size(69, 26);
            this.derecha.TabIndex = 0;
            this.derecha.Text = ">";
            this.derecha.UseVisualStyleBackColor = false;
            this.derecha.Click += new System.EventHandler(this.derecha_Click_1);
            // 
            // botondescripcion
            // 
            this.botondescripcion.BackColor = System.Drawing.Color.Yellow;
            this.botondescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botondescripcion.Location = new System.Drawing.Point(37, 340);
            this.botondescripcion.Name = "botondescripcion";
            this.botondescripcion.Size = new System.Drawing.Size(118, 39);
            this.botondescripcion.TabIndex = 19;
            this.botondescripcion.Text = "Descripcion";
            this.botondescripcion.UseVisualStyleBackColor = false;
            this.botondescripcion.Click += new System.EventHandler(this.botondescripcion_Click);
            // 
            // cerrar
            // 
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.Location = new System.Drawing.Point(440, 97);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 20;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(56)))), ((int)(((byte)(101)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 420);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.botondescripcion);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.posEvolucion);
            this.Controls.Add(this.preEvolucion);
            this.Controls.Add(this.movimiento4);
            this.Controls.Add(this.movimiento3);
            this.Controls.Add(this.movimiento2);
            this.Controls.Add(this.movimiento1);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.derecha);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.izquierda);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Label habilidad;
        private System.Windows.Forms.Label movimiento1;
        private System.Windows.Forms.Label movimiento2;
        private System.Windows.Forms.Label movimiento3;
        private System.Windows.Forms.Label movimiento4;
        private System.Windows.Forms.Label preEvolucion;
        private System.Windows.Forms.Label posEvolucion;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Button izquierda;
        private System.Windows.Forms.Button derecha;
        private System.Windows.Forms.Button botondescripcion;
        private System.Windows.Forms.Button cerrar;
    }
}

