namespace MapGis
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.legend1 = new LegendControl.Legend();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnElinimarLayer = new System.Windows.Forms.Button();
			this.btnAbrir = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rdInformacion = new System.Windows.Forms.RadioButton();
			this.btnFullExtend = new System.Windows.Forms.RadioButton();
			this.rdPan = new System.Windows.Forms.RadioButton();
			this.rdZoomOut = new System.Windows.Forms.RadioButton();
			this.rdZoomIn = new System.Windows.Forms.RadioButton();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.cboMaps = new System.Windows.Forms.ComboBox();
			this.AxMap1 = new AxMapWinGIS.AxMap();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AxMap1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.legend1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 479);
			this.panel1.TabIndex = 0;
			// 
			// legend1
			// 
			this.legend1.BackColor = System.Drawing.Color.White;
			this.legend1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.legend1.DisplayTilesGroup = false;
			this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.legend1.Location = new System.Drawing.Point(0, 100);
			this.legend1.Map = null;
			this.legend1.Name = "legend1";
			this.legend1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.legend1.SelectedLayer = -1;
			this.legend1.ShowGroupFolders = true;
			this.legend1.ShowLabels = false;
			this.legend1.Size = new System.Drawing.Size(196, 375);
			this.legend1.TabIndex = 2;
			this.legend1.LayerSelected += new LegendControl.LayerSelected(this.legend1_LayerSelected);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.btnElinimarLayer);
			this.panel2.Controls.Add(this.btnAbrir);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(196, 100);
			this.panel2.TabIndex = 1;
			// 
			// btnElinimarLayer
			// 
			this.btnElinimarLayer.Location = new System.Drawing.Point(8, 54);
			this.btnElinimarLayer.Name = "btnElinimarLayer";
			this.btnElinimarLayer.Size = new System.Drawing.Size(75, 23);
			this.btnElinimarLayer.TabIndex = 1;
			this.btnElinimarLayer.Text = "----";
			this.btnElinimarLayer.UseVisualStyleBackColor = true;
			this.btnElinimarLayer.Click += new System.EventHandler(this.btnElinimarLayer_Click);
			// 
			// btnAbrir
			// 
			this.btnAbrir.Location = new System.Drawing.Point(114, 8);
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Size = new System.Drawing.Size(75, 23);
			this.btnAbrir.TabIndex = 0;
			this.btnAbrir.Text = "Abrir";
			this.btnAbrir.UseVisualStyleBackColor = true;
			this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.rdInformacion);
			this.panel3.Controls.Add(this.btnFullExtend);
			this.panel3.Controls.Add(this.rdPan);
			this.panel3.Controls.Add(this.rdZoomOut);
			this.panel3.Controls.Add(this.rdZoomIn);
			this.panel3.Controls.Add(this.btnBuscar);
			this.panel3.Controls.Add(this.cboMaps);
			this.panel3.Controls.Add(this.AxMap1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(200, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(821, 479);
			this.panel3.TabIndex = 1;
			// 
			// rdInformacion
			// 
			this.rdInformacion.AutoSize = true;
			this.rdInformacion.Image = ((System.Drawing.Image)(resources.GetObject("rdInformacion.Image")));
			this.rdInformacion.Location = new System.Drawing.Point(4, 222);
			this.rdInformacion.Name = "rdInformacion";
			this.rdInformacion.Size = new System.Drawing.Size(44, 30);
			this.rdInformacion.TabIndex = 12;
			this.rdInformacion.TabStop = true;
			this.rdInformacion.UseVisualStyleBackColor = true;
			this.rdInformacion.Visible = false;
			this.rdInformacion.CheckedChanged += new System.EventHandler(this.rdInformacion_CheckedChanged);
			// 
			// btnFullExtend
			// 
			this.btnFullExtend.AutoSize = true;
			this.btnFullExtend.Image = ((System.Drawing.Image)(resources.GetObject("btnFullExtend.Image")));
			this.btnFullExtend.Location = new System.Drawing.Point(6, 118);
			this.btnFullExtend.Name = "btnFullExtend";
			this.btnFullExtend.Size = new System.Drawing.Size(57, 46);
			this.btnFullExtend.TabIndex = 11;
			this.btnFullExtend.TabStop = true;
			this.btnFullExtend.UseVisualStyleBackColor = true;
			this.btnFullExtend.CheckedChanged += new System.EventHandler(this.btnFullExtend_CheckedChanged);
			// 
			// rdPan
			// 
			this.rdPan.AutoSize = true;
			this.rdPan.Image = ((System.Drawing.Image)(resources.GetObject("rdPan.Image")));
			this.rdPan.Location = new System.Drawing.Point(5, 170);
			this.rdPan.Name = "rdPan";
			this.rdPan.Size = new System.Drawing.Size(46, 46);
			this.rdPan.TabIndex = 10;
			this.rdPan.TabStop = true;
			this.rdPan.UseVisualStyleBackColor = true;
			this.rdPan.CheckedChanged += new System.EventHandler(this.rdPan_CheckedChanged);
			// 
			// rdZoomOut
			// 
			this.rdZoomOut.AutoSize = true;
			this.rdZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("rdZoomOut.Image")));
			this.rdZoomOut.Location = new System.Drawing.Point(6, 66);
			this.rdZoomOut.Name = "rdZoomOut";
			this.rdZoomOut.Size = new System.Drawing.Size(49, 46);
			this.rdZoomOut.TabIndex = 9;
			this.rdZoomOut.TabStop = true;
			this.rdZoomOut.UseVisualStyleBackColor = true;
			this.rdZoomOut.CheckedChanged += new System.EventHandler(this.rdZoomOut_CheckedChanged);
			// 
			// rdZoomIn
			// 
			this.rdZoomIn.AutoSize = true;
			this.rdZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("rdZoomIn.Image")));
			this.rdZoomIn.Location = new System.Drawing.Point(6, 14);
			this.rdZoomIn.Name = "rdZoomIn";
			this.rdZoomIn.Size = new System.Drawing.Size(46, 46);
			this.rdZoomIn.TabIndex = 8;
			this.rdZoomIn.TabStop = true;
			this.rdZoomIn.UseVisualStyleBackColor = true;
			this.rdZoomIn.CheckedChanged += new System.EventHandler(this.rdZoomIn_CheckedChanged);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(603, 11);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Visible = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// cboMaps
			// 
			this.cboMaps.Enabled = false;
			this.cboMaps.FormattingEnabled = true;
			this.cboMaps.Location = new System.Drawing.Point(276, 14);
			this.cboMaps.Name = "cboMaps";
			this.cboMaps.Size = new System.Drawing.Size(320, 21);
			this.cboMaps.TabIndex = 1;
			this.cboMaps.Visible = false;
			// 
			// AxMap1
			// 
			this.AxMap1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AxMap1.Enabled = true;
			this.AxMap1.Location = new System.Drawing.Point(0, 0);
			this.AxMap1.Name = "AxMap1";
			this.AxMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxMap1.OcxState")));
			this.AxMap1.Size = new System.Drawing.Size(821, 479);
			this.AxMap1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1021, 479);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AxMap1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private LegendControl.Legend legend1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private AxMapWinGIS.AxMap AxMap1;
		private System.Windows.Forms.Button btnAbrir;
		private System.Windows.Forms.Button btnElinimarLayer;
		private System.Windows.Forms.ComboBox cboMaps;
		private System.Windows.Forms.Button btnBuscar;
		internal System.Windows.Forms.RadioButton btnFullExtend;
		internal System.Windows.Forms.RadioButton rdPan;
		internal System.Windows.Forms.RadioButton rdZoomOut;
		internal System.Windows.Forms.RadioButton rdZoomIn;
		private System.Windows.Forms.RadioButton rdInformacion;
	}
}

