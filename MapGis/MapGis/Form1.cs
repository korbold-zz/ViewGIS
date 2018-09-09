using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MapGis
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void btnAbrir_Click(object sender, EventArgs e)
		{

			AddLayer();
			
			
		}
		int punto;

		MapWinGIS.Shapefile shpfile = null;
		private void AddLayer()
		{
			
			MapWinGIS.Grid grid;
			MapWinGIS.GridColorScheme gridScheme;
			MapWinGIS.Image image;
			MapWinGIS.Utils utils;
			OpenFileDialog openDlg = new OpenFileDialog();
			int handle;
			string ext;

        //INICIALIZA EL DIALOGO CON EL TIPO DE ARCHIVO
        openDlg.Filter = "Shapefile (*.shp)|*.shp" ;
        openDlg.CheckFileExists = true; //SI EXITE EL ARVICHO SERA VERDADERO

		if (openDlg.ShowDialog(this) == DialogResult.OK)
		{ //SI ESVERDADERO CON EL ARCHIVO 

            shpfile = new MapWinGIS.ShapefileClass(); //CREAR UNA NUEVA VARIABLE DE INSTACIACION DE LA CLASE DEL ARCHIVO SHAPEFILE

            //ABRE EL SHAPE
            shpfile.Open(openDlg.FileName);

            //AGREGA EL SHAPE AL MAPA Y AL LEGEND
            handle = legend1.Layers.Add(shpfile, true);

            //COLOCA EL NOMBRE EN EL LAYER DEL SHAPE
            //Legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename))
            legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename));
			int a ;
			shpfile.SelectionColor = 4;
			a = shpfile.Table.NumRows;

			

			for (int i = 0; i < a; i++)
			{
				cboMaps.Items.Add(shpfile.Table.get_CellValue(3,i));
				ActivarBNT();
			}
			 punto= AxMap1.AddLayer(shpfile,Visible);
							
			Single tamPunto = 6;
			AxMap1.set_ShapeLayerDrawPoint(punto, true);
			AxMap1.set_ShapeLayerPointColor(punto, (UInt32)(System.Drawing.ColorTranslator.ToOle
			(System.Drawing.Color.Red))); 
			AxMap1.set_ShapeLayerPointSize(punto, tamPunto); 
			AxMap1.set_ShapeLayerPointType(punto, MapWinGIS.tkPointType.ptCircle);

			menuShape(shpfile);
			

			
		}
		}

		private void menuShape(MapWinGIS.Shapefile shpfile) {

			if (System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename) =="puntos_farmacias.PSAD_1956_UTM_Zone_17S")
			{
				int punto= AxMap1.AddLayer(shpfile, Visible);
				simbolosIconos(punto,"C:/Users/Danny/Documents/farmacia2.png" );
				etiquetas(punto, 3);
			}
			if (System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename) =="PUNTOS EDUCATIVOS.PSAD_1956_UTM_Zone_17S")
			{
				int punto= AxMap1.AddLayer(shpfile, Visible);
				simbolosIconos(punto, "C:/Users/Danny/Documents/edu.png");
				etiquetas(punto, 3);
			}
			if (System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename) =="puntos_casa_salud.PSAD_1956_UTM_Zone_17S")
			{
				int punto= AxMap1.AddLayer(shpfile, Visible);
				simbolosIconos(punto, "C:/Users/Danny/Documents/salud.png");
				etiquetas(punto, 3);
			}
			if (System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename) =="PUNTOS_UPCS.PSAD_1956_UTM_Zone_17S")
			{
				int punto= AxMap1.AddLayer(shpfile, Visible);
				simbolosIconos(punto, "C:/Users/Danny/Documents/policia.png");
				etiquetas(punto, 3);
			}
			if (System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename) =="PUNTOS_BOMBEROS.PSAD_1956_UTM_Zone_17S")
			{
				int punto= AxMap1.AddLayer(shpfile, Visible);
				simbolosIconos(punto, "C:/Users/Danny/Documents/bombero.png");
				etiquetas(punto, 3);
			}
			if (System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename) =="puntos_hidrantes.PSAD_1956_UTM_Zone_17S")
			{
				int punto= AxMap1.AddLayer(shpfile, Visible);
				simbolosIconos(punto, "C:/Users/Danny/Documents/hidrante.png");
				etiquetas(punto, 3);
			}
			
		}

		private void simbolosIconos(int elemento, string cadena) { 
			MapWinGIS.Shapefile capa = this.AxMap1.get_Shapefile(elemento);
			capa.Categories.Generate(0, MapWinGIS.tkClassificationType.ctUniqueValues, 0);
			this.AxMap1.set_ShapeLayerPointType(elemento, MapWinGIS.tkPointType.ptUserDefined);
			MapWinGIS.Image imagen = new MapWinGIS.Image();
			imagen.Clear();
			for (int i = 0; i < capa.Categories.Count; i++) {
				
				imagen.Open(cadena);
				capa.Categories.Item[i].DrawingOptions.PointType = MapWinGIS.tkPointSymbolType.ptSymbolPicture;
				capa.Categories.Item[i].DrawingOptions.Picture = imagen;
			}
		}

		private void select(int elemento)
		{

			
		
			MapWinGIS.Shapefile capa = this.AxMap1.get_Shapefile(elemento);
			capa.Categories.Generate(0, MapWinGIS.tkClassificationType.ctUniqueValues, 0);
			this.AxMap1.set_ShapeLayerPointType(elemento, MapWinGIS.tkPointType.ptUserDefined);
			MapWinGIS.Image imagen = new MapWinGIS.Image();
			

				imagen.Open("C:/Users/Danny/Documents/farmacia2.png");
				capa.Categories.Item[0].DrawingOptions.PointType = MapWinGIS.tkPointSymbolType.ptSymbolPicture;
				capa.Categories.Item[0].DrawingOptions.Picture = imagen;
			
		}
		MapWinGIS.Shapefile capa;
		private void etiquetas(int elemento, int numCampo) {
			MapWinGIS.Shapefile capa;

			capa = this.AxMap1.get_Shapefile(elemento);
			for (int numFigura = 0; numFigura < capa.NumShapes; numFigura++) { 
				MapWinGIS.Shape componente = capa.Shape[numFigura];
				String texto = capa.get_CellValue(numCampo, numFigura).ToString();
				double coordX = capa.Shape[numFigura].get_Point(0).x;
				double coordY = capa.Shape[numFigura].get_Point(0).y;
				capa.Labels.FontName = "Comic Sans MS"; 
				capa.Labels.FontSize = 15;
				capa.Labels.CollisionBuffer = 100;
				capa.Labels.AddLabel(texto, coordX, coordY);
				
			} 
		}
		private void campo(int elemento, int p)
		{
			MapWinGIS.Shapefile capa = this.AxMap1.get_Shapefile(p);
			capa.Labels.Clear();

			String texto = capa.get_CellValue(3, elemento).ToString();
			double coordX = capa.Shape[elemento].get_Point(0).x;
			double coordY = capa.Shape[elemento].get_Point(0).y;
			capa.Labels.FontName = "Baskerville Old Face";
			capa.Labels.FontSize = 14;
			capa.Labels.CollisionBuffer = 100;

			capa.Labels.AddLabel(texto, coordX, coordY);



		}
		private void etiquetasVIAS(int elemento, int numCampo)
		{
			MapWinGIS.Shapefile capa;

			capa = this.AxMap1.get_Shapefile(elemento);
			for (int numFigura = 0; numFigura < capa.NumShapes; numFigura++)
			{
				MapWinGIS.Shape componente = capa.Shape[numFigura];
				String texto = capa.get_CellValue(numCampo, numFigura).ToString();
				double coordX = capa.Shape[numFigura].get_Point(0).x;
				double coordY = capa.Shape[numFigura].get_Point(0).y;
				capa.Labels.FontName = "Arial Unicode MS";
				capa.Labels.FontSize = 7;
				capa.Labels.CollisionBuffer = 100;
				capa.Labels.AddLabel(texto, coordX, coordY);

			}
		}
		
		public void DesactivarBNT()
		{
			cboMaps.Items.Clear();
			cboMaps.Enabled=false;
			btnBuscar.Enabled=false;
			rdInformacion.Enabled=false;
			
		}
		public void ActivarBNT()
		{
			cboMaps.Enabled=true;
			btnBuscar.Enabled=true;
			rdInformacion.Enabled=true;
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			DesactivarBNT();
			load();
			  loadVias();
			  loadNombreVias();
		
		}
		private void load()
		{
			legend1.Map =(MapWinGIS.Map)AxMap1.GetOcx();


			MapWinGIS.Shapefile shpfile = null;
			OpenFileDialog openDlg = new OpenFileDialog();

			//openDlg.FileName = "D:/PROGRAMAS/PROGRAMAS GIS/CAPASCIUDAD/CapasCiudadIbarra/Catastro_Urbano_Area_Urbana.shp";
			openDlg.FileName = "D:/CARRERA INFORMATICA/SEMESTRE IV/GIS/catastro/Catastro_Urbano_Area_Urbana.WGS_1984_UTM_Zone_17S.shp";


			shpfile = new MapWinGIS.ShapefileClass();



			shpfile.Open(openDlg.FileName);
			AxMap1.AddLayer(shpfile, true); 
		}
		private void loadNombreVias()
		{
			legend1.Map =(MapWinGIS.Map)AxMap1.GetOcx();


			MapWinGIS.Shapefile shpfile = null;
			OpenFileDialog openDlg = new OpenFileDialog();

			openDlg.FileName = "D:/PROGRAMAS/PROGRAMAS GIS/CAPASCIUDAD/CapasCiudadIbarra/Nombres_Vias.shp";


			shpfile = new MapWinGIS.ShapefileClass();


					
			shpfile.Open(openDlg.FileName);
			AxMap1.AddLayer(shpfile, true);
			int punto= AxMap1.AddLayer(shpfile, Visible);
			etiquetasVIAS(punto, 1);
		}
		private void loadVias()
		{
			legend1.Map =(MapWinGIS.Map)AxMap1.GetOcx();


			MapWinGIS.Shapefile shpfile = null;
			OpenFileDialog openDlg = new OpenFileDialog();

			openDlg.FileName = "D:/PROGRAMAS/PROGRAMAS GIS/CAPASCIUDAD/CapasCiudadIbarra/Vias.shp";


			shpfile = new MapWinGIS.ShapefileClass();



			shpfile.Open(openDlg.FileName);
			AxMap1.AddLayer(shpfile, true);
			int punto= AxMap1.AddLayer(shpfile, Visible);
			etiquetasVIAS(punto, 1);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			
			int a = cboMaps.SelectedIndex;
			if (a>0)
			{
				
				
				campo(a, punto);
				
				AxMap1.ClearDrawings();
			}
			else
			{
				MessageBox.Show("Selecione..!");
			}
			
			
			
		}

		private void rdZoomIn_CheckedChanged(object sender, EventArgs e)
		{
			AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn;
		}

		private void rdPan_CheckedChanged(object sender, EventArgs e)
		{
			AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan;
		}

		private void rdZoomOut_CheckedChanged(object sender, EventArgs e)
		{
			AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut;
		}

		private void btnFullExtend_CheckedChanged(object sender, EventArgs e)
		{
			AxMap1.ZoomToMaxExtents();
		}

		private void btnElinimarLayer_Click(object sender, EventArgs e)
		{
			legend1.Layers.Remove(legend1.SelectedLayer);
			legend1.Refresh();
			
			MapWinGIS.Shapefile capa = this.AxMap1.get_Shapefile(punto);
			capa.Labels.Clear();
			load();
			loadVias();
			DesactivarBNT();
		}

		private void rdInformacion_CheckedChanged(object sender, EventArgs e)
		{
			
			etiquetas(punto, 3);
			AxMap1.ClearDrawings();
		}

		private void legend1_LayerSelected(int Handle)
		{
			legend1.Layers.GroupOf(Handle);
		}
	}
}
