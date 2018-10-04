Public Class Form1

    Private Sub btnAddData_Click(sender As Object, e As EventArgs) Handles btnAddData.Click
        AddLayer()

         

        
    End Sub

    Private Sub AddLayer()
        Dim shpfile As MapWinGIS.Shapefile
        Dim grid As MapWinGIS.Grid
        Dim gridScheme As MapWinGIS.GridColorScheme
        Dim image As MapWinGIS.Image
        Dim utils As MapWinGIS.Utils
        Dim openDlg As OpenFileDialog
        openDlg = New OpenFileDialog
        Dim handle As Integer
        Dim ext As String


        'Initialize dialog
        openDlg.Filter = "Shapefile (*.shp)|*.shp"
        openDlg.CheckFileExists = True

        If openDlg.ShowDialog(Me) = DialogResult.OK Then
           
                shpfile = New MapWinGIS.ShapefileClass

                'open the shapefile
            shpfile.Open(openDlg.FileName)

                'add the shapefile to the map and legend
                handle = Legend1.Layers.Add(shpfile, True)

                'set the layer name
                'Legend1.Map.set_LayerName(handle, System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename))
                Legend1.Map.LayerName(handle) = System.IO.Path.GetFileNameWithoutExtension(shpfile.Filename)
            Dim a As Integer
            a = Legend1.SelectedLayer.ToString



        End If



        
    End Sub

    Private Sub rdZoomIn_CheckedChanged(sender As Object, e As EventArgs) Handles rdZoomIn.CheckedChanged
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomIn
    End Sub

    Private Sub rdZoomOut_CheckedChanged(sender As Object, e As EventArgs) Handles rdZoomOut.CheckedChanged
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmZoomOut
    End Sub

    Private Sub rdPan_CheckedChanged(sender As Object, e As EventArgs) Handles rdPan.CheckedChanged
        AxMap1.CursorMode = MapWinGIS.tkCursorMode.cmPan
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Legend1.Map = AxMap1.GetOcx()

    End Sub

    Private Sub btnElminarLayer_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub btnElminarLayer_Click_1(sender As Object, e As EventArgs) Handles btnElminarLayer.Click
        Legend1.Layers.Remove(Legend1.SelectedLayer)
        Legend1.Refresh()
    End Sub

    Private Sub btnFullExtend_CheckedChanged(sender As Object, e As EventArgs) Handles btnFullExtend.CheckedChanged
        AxMap1.ZoomToMaxExtents()
    End Sub
End Class
