
namespace JuegoMarmotaSolucion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelJuego = new System.Windows.Forms.TableLayoutPanel();
            this.pbxAtrapame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblFallas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_ayuda = new System.Windows.Forms.PictureBox();
            this.btn_cerrarApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAtrapame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ayuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarApp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego.ColumnCount = 3;
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.17845F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.82155F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.panelJuego.Location = new System.Drawing.Point(193, 108);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.RowCount = 3;
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.panelJuego.Size = new System.Drawing.Size(454, 344);
            this.panelJuego.TabIndex = 0;
            // 
            // pbxAtrapame
            // 
            this.pbxAtrapame.BackColor = System.Drawing.Color.Transparent;
            this.pbxAtrapame.Image = ((System.Drawing.Image)(resources.GetObject("pbxAtrapame.Image")));
            this.pbxAtrapame.Location = new System.Drawing.Point(691, 25);
            this.pbxAtrapame.Name = "pbxAtrapame";
            this.pbxAtrapame.Size = new System.Drawing.Size(162, 167);
            this.pbxAtrapame.TabIndex = 0;
            this.pbxAtrapame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUNTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "FALLAS";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPuntos.Location = new System.Drawing.Point(135, 138);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(24, 26);
            this.lblPuntos.TabIndex = 3;
            this.lblPuntos.Text = "0";
            // 
            // lblFallas
            // 
            this.lblFallas.AutoSize = true;
            this.lblFallas.BackColor = System.Drawing.Color.Transparent;
            this.lblFallas.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFallas.Location = new System.Drawing.Point(135, 183);
            this.lblFallas.Name = "lblFallas";
            this.lblFallas.Size = new System.Drawing.Size(24, 26);
            this.lblFallas.TabIndex = 4;
            this.lblFallas.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -103);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(865, 653);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(865, 653);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.BackColor = System.Drawing.Color.Transparent;
            this.btn_ayuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_ayuda.Image")));
            this.btn_ayuda.Location = new System.Drawing.Point(479, 25);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(64, 54);
            this.btn_ayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ayuda.TabIndex = 6;
            this.btn_ayuda.TabStop = false;
            this.btn_ayuda.Click += new System.EventHandler(this.btn_ayuda_Click);
            // 
            // btn_cerrarApp
            // 
            this.btn_cerrarApp.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrarApp.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrarApp.Image")));
            this.btn_cerrarApp.Location = new System.Drawing.Point(298, 25);
            this.btn_cerrarApp.Name = "btn_cerrarApp";
            this.btn_cerrarApp.Size = new System.Drawing.Size(64, 54);
            this.btn_cerrarApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrarApp.TabIndex = 7;
            this.btn_cerrarApp.TabStop = false;
            this.btn_cerrarApp.Click += new System.EventHandler(this.btn_cerrarApp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(865, 492);
            this.Controls.Add(this.btn_cerrarApp);
            this.Controls.Add(this.btn_ayuda);
            this.Controls.Add(this.lblFallas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.pbxAtrapame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplasta a la Marmota";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAtrapame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ayuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrarApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelJuego;
        private System.Windows.Forms.PictureBox pbxAtrapame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblFallas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_ayuda;
        private System.Windows.Forms.PictureBox btn_cerrarApp;
    }
}

