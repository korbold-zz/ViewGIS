Public Class Form1

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        AddLayer() ' LLAMA AL METODO

    End Sub


    Private Sub AddLayer()
        Dim shpfile As MapWinGIS.Shapefile 'DECLARA UNA VARIABLE DE TIPO SHAPEFILE

        Dim openDlg As OpenFileDialog
        openDlg = New OpenFileDialog 'DECLARA UNA NUEVA VARIABLE DE TIPO SHAPEFILE

        Dim handle As Integer 'DECLARA UNA VARIABLE DE TIPO INTEGER

        'INICIALIZA EL DIALOGO CON EL TIPO DE ARCHIVO
        openDlg.Filter = "Shapefile (*.shp)|*.shp"
        openDlg.CheckFileExists = True 'SI EXITE EL ARVICHO SERA VERDADERO

        If openDlg.ShowDialog(Me) = DialogResult.OK Then 'SI ESVERDADERO CON EL ARCHIVO 

            shpfile = New MapWinGIS.ShapefileClass 'CREAR UNA NUEVA VARIABLE DE INSTACIACION DE LA CLASE DEL ARCHIVO SHAPEFILE

            'ABRE EL SHAPE
            shpfile.Open(openDlg.FileName)

            'AGREGA EL SHAPE AL MAPA Y AL LEGEND
            handle = Legend1.Layers.Add(shpfile, True)

            'COLOCA EL NOMBRE EN EL LAYER DEL SHAPE
            'Legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename))
            Legend1.Map.LayerName(handle) = System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename)
            Dim a As Integer
            a = Legend1.SelectedLayer.ToString

        End If
    End Sub

    

    Private Sub rdZoomIn_CheckedChanged(sender As Object, e As EventArgs) Handles rdZoomIn.CheckedChanged
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn 'EL CURSO AUMENTA EL ZOOM DEL OBJETO VISUALIZADO (MAP CONTROL)
    End Sub

    Private Sub rdZoomOut_CheckedChanged(sender As Object, e As EventArgs) Handles rdZoomOut.CheckedChanged
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut 'EL CURSO REDUCE EL ZOOM DEL OBJETO VISUALIZADO (MAP CONTROL)
    End Sub

    Private Sub rdPan_CheckedChanged(sender As Object, e As EventArgs) Handles rdPan.CheckedChanged
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan 'EL CURSO PUEDE MOVER EL OBJETO VISUALIZADO A CUALQUIER GRADO (MAP CONTROL)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Legend1.Map = AxMap1.GetOcx 'RECUPERA UNA REFERENCIA AL CONTRO ACTIVEX SUBYACENTE

        Dim shpfile As MapWinGIS.Shapefile 'DECLARA UNA VARIABLE DE TIPO SHAPEFILE

        Dim openDlg As OpenFileDialog
        openDlg = New OpenFileDialog 'DECLARA UNA NUEVA VARIABLE DE TIPO SHAPEFILE

        openDlg.FileName = "D:\PROGRAMAS\PROGRAMAS GIS\CAPASCIUDAD\CapasCiudadIbarra\Catastro_Urbano_Area_Urbana.shp"
        'CARGAMOS CON LE METODO DE LA DIRECION DEL SHAPE

        shpfile = New MapWinGIS.ShapefileClass 'CREAR UNA NUEVA VARIABLE DE INSTACIACION DE LA CLASE DEL ARCHIVO SHAPEFILE

        'ABRE EL SHAPE
        shpfile.Open(openDlg.FileName)
        AxMap1.AddLayer(shpfile, True) ' AGREGA EN EL OBJETO DEL MAPWINDOW / MAP MAP CONTROL

    End Sub

   
    Private Sub btnElminarLayer_Click_1(sender As Object, e As EventArgs) Handles btnElminarLayer.Click
        Legend1.Layers.Remove(Legend1.SelectedLayer) 'ELIMINA UN LEGEND SELECIONADO
        Legend1.Refresh() ' ACTUALIZA EL LEGEND
    End Sub

    Private Sub btnFullExtend_CheckedChanged(sender As Object, e As EventArgs) Handles btnFullExtend.CheckedChanged
        AxMap1.ZoomToMaxExtents()  'REESTABLECE EL A SU FORMA ORIGINAL EL MAPA
    End Sub
End Class
