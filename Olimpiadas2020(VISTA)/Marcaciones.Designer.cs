namespace Olimpiadas2020_VISTA_
{
    partial class Marcaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmarcaciones = new System.Windows.Forms.DataGridView();
            this.cmbmodalidades = new System.Windows.Forms.ComboBox();
            this.cmbpais = new System.Windows.Forms.ComboBox();
            this.cmdposicion = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtmarcaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marcaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modalidades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "País:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Posición:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resúmen:";
            // 
            // dtmarcaciones
            // 
            this.dtmarcaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtmarcaciones.Location = new System.Drawing.Point(12, 265);
            this.dtmarcaciones.Name = "dtmarcaciones";
            this.dtmarcaciones.Size = new System.Drawing.Size(497, 141);
            this.dtmarcaciones.TabIndex = 5;
            this.dtmarcaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtmarcaciones_CellClick);
            // 
            // cmbmodalidades
            // 
            this.cmbmodalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmodalidades.FormattingEnabled = true;
            this.cmbmodalidades.Items.AddRange(new object[] {
            "Seleccione..."});
            this.cmbmodalidades.Location = new System.Drawing.Point(209, 67);
            this.cmbmodalidades.Name = "cmbmodalidades";
            this.cmbmodalidades.Size = new System.Drawing.Size(176, 33);
            this.cmbmodalidades.TabIndex = 6;
            // 
            // cmbpais
            // 
            this.cmbpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpais.FormattingEnabled = true;
            this.cmbpais.Location = new System.Drawing.Point(209, 120);
            this.cmbpais.Name = "cmbpais";
            this.cmbpais.Size = new System.Drawing.Size(176, 33);
            this.cmbpais.TabIndex = 7;
            // 
            // cmdposicion
            // 
            this.cmdposicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdposicion.FormattingEnabled = true;
            this.cmdposicion.Items.AddRange(new object[] {
            "Seleccionar...",
            "Primero",
            "Segundo",
            "Tercero"});
            this.cmdposicion.Location = new System.Drawing.Point(209, 172);
            this.cmdposicion.Name = "cmdposicion";
            this.cmdposicion.Size = new System.Drawing.Size(176, 33);
            this.cmdposicion.TabIndex = 8;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(404, 174);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(105, 33);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Olimpiadas2020_VISTA_.Properties.Resources.BB_0061_06;
            this.pictureBox1.Location = new System.Drawing.Point(404, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnregresar
            // 
            this.btnregresar.Location = new System.Drawing.Point(404, 213);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(105, 33);
            this.btnregresar.TabIndex = 11;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // Marcaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 418);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cmdposicion);
            this.Controls.Add(this.cmbpais);
            this.Controls.Add(this.cmbmodalidades);
            this.Controls.Add(this.dtmarcaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Marcaciones";
            this.Text = "Marcaciones";
            this.Load += new System.EventHandler(this.Marcaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtmarcaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtmarcaciones;
        private System.Windows.Forms.ComboBox cmbmodalidades;
        private System.Windows.Forms.ComboBox cmbpais;
        private System.Windows.Forms.ComboBox cmdposicion;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnregresar;
    }
}