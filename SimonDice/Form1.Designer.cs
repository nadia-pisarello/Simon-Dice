namespace SimonDice
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.fondo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.verde = new System.Windows.Forms.Button();
            this.rojo = new System.Windows.Forms.Button();
            this.amarillo = new System.Windows.Forms.Button();
            this.azul = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.cont_lb = new System.Windows.Forms.Label();
            this.rondas = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.jugador_tbox = new System.Windows.Forms.TextBox();
            this.inicio = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.fondo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.AutoSize = true;
            this.fondo.Controls.Add(this.tableLayoutPanel1);
            this.fondo.Controls.Add(this.menu);
            this.fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(684, 420);
            this.fondo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.verde, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rojo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.amarillo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.azul, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 420);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // verde
            // 
            this.verde.BackColor = System.Drawing.Color.Lime;
            this.verde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verde.ForeColor = System.Drawing.Color.ForestGreen;
            this.verde.Location = new System.Drawing.Point(6, 7);
            this.verde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(184, 197);
            this.verde.TabIndex = 0;
            this.verde.UseVisualStyleBackColor = false;
            this.verde.Click += new System.EventHandler(this.verde_Click);
            // 
            // rojo
            // 
            this.rojo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rojo.BackColor = System.Drawing.Color.Red;
            this.rojo.Location = new System.Drawing.Point(200, 7);
            this.rojo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(185, 197);
            this.rojo.TabIndex = 1;
            this.rojo.UseVisualStyleBackColor = false;
            this.rojo.Click += new System.EventHandler(this.rojo_Click);
            // 
            // amarillo
            // 
            this.amarillo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amarillo.BackColor = System.Drawing.Color.Yellow;
            this.amarillo.Location = new System.Drawing.Point(6, 216);
            this.amarillo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amarillo.Name = "amarillo";
            this.amarillo.Size = new System.Drawing.Size(184, 197);
            this.amarillo.TabIndex = 2;
            this.amarillo.UseVisualStyleBackColor = false;
            this.amarillo.Click += new System.EventHandler(this.amarillo_Click);
            // 
            // azul
            // 
            this.azul.BackColor = System.Drawing.Color.Cyan;
            this.azul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.azul.Location = new System.Drawing.Point(200, 216);
            this.azul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(185, 197);
            this.azul.TabIndex = 3;
            this.azul.UseVisualStyleBackColor = false;
            this.azul.Click += new System.EventHandler(this.azul_Click);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.cont_lb);
            this.menu.Controls.Add(this.rondas);
            this.menu.Controls.Add(this.label_nombre);
            this.menu.Controls.Add(this.jugador_tbox);
            this.menu.Controls.Add(this.inicio);
            this.menu.Dock = System.Windows.Forms.DockStyle.Right;
            this.menu.Location = new System.Drawing.Point(391, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(293, 420);
            this.menu.TabIndex = 0;
            // 
            // cont_lb
            // 
            this.cont_lb.AutoSize = true;
            this.cont_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cont_lb.Location = new System.Drawing.Point(182, 148);
            this.cont_lb.Name = "cont_lb";
            this.cont_lb.Size = new System.Drawing.Size(23, 25);
            this.cont_lb.TabIndex = 4;
            this.cont_lb.Text = "0";
            // 
            // rondas
            // 
            this.rondas.AutoSize = true;
            this.rondas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rondas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rondas.Location = new System.Drawing.Point(24, 148);
            this.rondas.Name = "rondas";
            this.rondas.Size = new System.Drawing.Size(103, 27);
            this.rondas.TabIndex = 3;
            this.rondas.Text = "Ronda/s : ";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_nombre.Location = new System.Drawing.Point(19, 22);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(185, 25);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre de Jugador";
            // 
            // jugador_tbox
            // 
            this.jugador_tbox.BackColor = System.Drawing.SystemColors.Control;
            this.jugador_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.jugador_tbox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.jugador_tbox.Location = new System.Drawing.Point(24, 66);
            this.jugador_tbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jugador_tbox.Name = "jugador_tbox";
            this.jugador_tbox.Size = new System.Drawing.Size(230, 30);
            this.jugador_tbox.TabIndex = 1;
            this.jugador_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inicio
            // 
            this.inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inicio.Location = new System.Drawing.Point(24, 238);
            this.inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(230, 45);
            this.inicio.TabIndex = 0;
            this.inicio.Text = "Iniciar";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 420);
            this.Controls.Add(this.fondo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Simon Dice";
            this.fondo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel fondo;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button verde;
        private System.Windows.Forms.Button rojo;
        private System.Windows.Forms.Button amarillo;
        private System.Windows.Forms.Button azul;
        private System.Windows.Forms.TextBox jugador_tbox;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label rondas;
        private System.Windows.Forms.Label cont_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

