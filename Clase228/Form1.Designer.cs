namespace Clase228
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
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.btLongitud = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btPrueba = new System.Windows.Forms.Button();
            this.BtMayuscula = new System.Windows.Forms.Button();
            this.btMinuscula = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscado = new System.Windows.Forms.TextBox();
            this.txtDeletrear = new System.Windows.Forms.Button();
            this.btExtraer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrase.Location = new System.Drawing.Point(56, 31);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(493, 38);
            this.txtFrase.TabIndex = 0;
            // 
            // btLongitud
            // 
            this.btLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLongitud.Location = new System.Drawing.Point(56, 75);
            this.btLongitud.Name = "btLongitud";
            this.btLongitud.Size = new System.Drawing.Size(144, 39);
            this.btLongitud.TabIndex = 1;
            this.btLongitud.Text = "Longitud";
            this.btLongitud.UseVisualStyleBackColor = true;
            this.btLongitud.Click += new System.EventHandler(this.btLongitud_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(63, 395);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 31);
            this.lblResultado.TabIndex = 2;
            // 
            // btPrueba
            // 
            this.btPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrueba.Location = new System.Drawing.Point(209, 75);
            this.btPrueba.Name = "btPrueba";
            this.btPrueba.Size = new System.Drawing.Size(138, 39);
            this.btPrueba.TabIndex = 3;
            this.btPrueba.Text = "Prueba";
            this.btPrueba.UseVisualStyleBackColor = true;
            this.btPrueba.Click += new System.EventHandler(this.btPrueba_Click);
            // 
            // BtMayuscula
            // 
            this.BtMayuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtMayuscula.Location = new System.Drawing.Point(353, 75);
            this.BtMayuscula.Name = "BtMayuscula";
            this.BtMayuscula.Size = new System.Drawing.Size(196, 36);
            this.BtMayuscula.TabIndex = 4;
            this.BtMayuscula.Text = "MAYUSCULA";
            this.BtMayuscula.UseVisualStyleBackColor = true;
            this.BtMayuscula.Click += new System.EventHandler(this.BtMayuscula_Click);
            // 
            // btMinuscula
            // 
            this.btMinuscula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMinuscula.Location = new System.Drawing.Point(56, 120);
            this.btMinuscula.Name = "btMinuscula";
            this.btMinuscula.Size = new System.Drawing.Size(196, 36);
            this.btMinuscula.TabIndex = 5;
            this.btMinuscula.Text = "minuscula";
            this.btMinuscula.UseVisualStyleBackColor = true;
            this.btMinuscula.Click += new System.EventHandler(this.btMinuscula_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(258, 120);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(196, 36);
            this.btBuscar.TabIndex = 6;
            this.btBuscar.Text = "BUSCAR";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscado
            // 
            this.txtBuscado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscado.Location = new System.Drawing.Point(56, 213);
            this.txtBuscado.Name = "txtBuscado";
            this.txtBuscado.Size = new System.Drawing.Size(493, 38);
            this.txtBuscado.TabIndex = 7;
            // 
            // txtDeletrear
            // 
            this.txtDeletrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeletrear.Location = new System.Drawing.Point(56, 162);
            this.txtDeletrear.Name = "txtDeletrear";
            this.txtDeletrear.Size = new System.Drawing.Size(196, 36);
            this.txtDeletrear.TabIndex = 8;
            this.txtDeletrear.Text = "Deletrear";
            this.txtDeletrear.UseVisualStyleBackColor = true;
            this.txtDeletrear.Click += new System.EventHandler(this.txtDeletrear_Click);
            // 
            // btExtraer
            // 
            this.btExtraer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExtraer.Location = new System.Drawing.Point(258, 162);
            this.btExtraer.Name = "btExtraer";
            this.btExtraer.Size = new System.Drawing.Size(196, 36);
            this.btExtraer.TabIndex = 9;
            this.btExtraer.Text = "Extraer";
            this.btExtraer.UseVisualStyleBackColor = true;
            this.btExtraer.Click += new System.EventHandler(this.btExtraer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 450);
            this.Controls.Add(this.btExtraer);
            this.Controls.Add(this.txtDeletrear);
            this.Controls.Add(this.txtBuscado);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btMinuscula);
            this.Controls.Add(this.BtMayuscula);
            this.Controls.Add(this.btPrueba);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btLongitud);
            this.Controls.Add(this.txtFrase);
            this.Name = "Form1";
            this.Text = "Minuscula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Button btLongitud;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btPrueba;
        private System.Windows.Forms.Button BtMayuscula;
        private System.Windows.Forms.Button btMinuscula;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Button txtDeletrear;
        private System.Windows.Forms.Button btExtraer;
    }
}

