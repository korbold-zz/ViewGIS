<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnElminarLayer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AxMap1 = New AxMapWinGIS.AxMap()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddData = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFullExtend = New System.Windows.Forms.RadioButton()
        Me.rdPan = New System.Windows.Forms.RadioButton()
        Me.rdZoomOut = New System.Windows.Forms.RadioButton()
        Me.rdZoomIn = New System.Windows.Forms.RadioButton()
        Me.Map = New AxMapWinGIS.AxMap()
        Me.Legend1 = New LegendControl.Legend()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AxMap1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Map, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Legend1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 488)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnElminarLayer)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(196, 79)
        Me.Panel4.TabIndex = 2
        '
        'btnElminarLayer
        '
        Me.btnElminarLayer.Location = New System.Drawing.Point(55, 23)
        Me.btnElminarLayer.Name = "btnElminarLayer"
        Me.btnElminarLayer.Size = New System.Drawing.Size(66, 34)
        Me.btnElminarLayer.TabIndex = 0
        Me.btnElminarLayer.Text = "--"
        Me.btnElminarLayer.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.AxMap1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(641, 488)
        Me.Panel2.TabIndex = 1
        '
        'AxMap1
        '
        Me.AxMap1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxMap1.Enabled = True
        Me.AxMap1.Location = New System.Drawing.Point(0, 0)
        Me.AxMap1.Name = "AxMap1"
        Me.AxMap1.OcxState = CType(resources.GetObject("AxMap1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMap1.Size = New System.Drawing.Size(637, 484)
        Me.AxMap1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnAddData)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(200, 388)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(641, 100)
        Me.Panel3.TabIndex = 2
        '
        'btnAddData
        '
        Me.btnAddData.Location = New System.Drawing.Point(110, 36)
        Me.btnAddData.Name = "btnAddData"
        Me.btnAddData.Size = New System.Drawing.Size(75, 23)
        Me.btnAddData.TabIndex = 1
        Me.btnAddData.Text = "Abrir Archivo"
        Me.btnAddData.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullExtend)
        Me.GroupBox1.Controls.Add(Me.rdPan)
        Me.GroupBox1.Controls.Add(Me.rdZoomOut)
        Me.GroupBox1.Controls.Add(Me.rdZoomIn)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnFullExtend
        '
        Me.btnFullExtend.AutoSize = True
        Me.btnFullExtend.Location = New System.Drawing.Point(249, 30)
        Me.btnFullExtend.Name = "btnFullExtend"
        Me.btnFullExtend.Size = New System.Drawing.Size(77, 17)
        Me.btnFullExtend.TabIndex = 3
        Me.btnFullExtend.TabStop = True
        Me.btnFullExtend.Text = "Full Extend"
        Me.btnFullExtend.UseVisualStyleBackColor = True
        '
        'rdPan
        '
        Me.rdPan.AutoSize = True
        Me.rdPan.Location = New System.Drawing.Point(199, 30)
        Me.rdPan.Name = "rdPan"
        Me.rdPan.Size = New System.Drawing.Size(44, 17)
        Me.rdPan.TabIndex = 2
        Me.rdPan.TabStop = True
        Me.rdPan.Text = "Pan"
        Me.rdPan.UseVisualStyleBackColor = True
        '
        'rdZoomOut
        '
        Me.rdZoomOut.AutoSize = True
        Me.rdZoomOut.Location = New System.Drawing.Point(103, 30)
        Me.rdZoomOut.Name = "rdZoomOut"
        Me.rdZoomOut.Size = New System.Drawing.Size(72, 17)
        Me.rdZoomOut.TabIndex = 1
        Me.rdZoomOut.TabStop = True
        Me.rdZoomOut.Text = "Zoom Out"
        Me.rdZoomOut.UseVisualStyleBackColor = True
        '
        'rdZoomIn
        '
        Me.rdZoomIn.AutoSize = True
        Me.rdZoomIn.Location = New System.Drawing.Point(7, 30)
        Me.rdZoomIn.Name = "rdZoomIn"
        Me.rdZoomIn.Size = New System.Drawing.Size(64, 17)
        Me.rdZoomIn.TabIndex = 0
        Me.rdZoomIn.TabStop = True
        Me.rdZoomIn.Text = "Zoom In"
        Me.rdZoomIn.UseVisualStyleBackColor = True
        '
        'Map
        '
        Me.Map.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Map.Enabled = True
        Me.Map.Location = New System.Drawing.Point(0, 0)
        Me.Map.Name = "Map"
        Me.Map.OcxState = CType(resources.GetObject("Map.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Map.Size = New System.Drawing.Size(637, 484)
        Me.Map.TabIndex = 0
        '
        'Legend1
        '
        Me.Legend1.BackColor = System.Drawing.Color.White
        Me.Legend1.DisplayTilesGroup = False
        Me.Legend1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Legend1.Location = New System.Drawing.Point(0, 79)
        Me.Legend1.Map = Nothing
        Me.Legend1.Name = "Legend1"
        Me.Legend1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Legend1.SelectedLayer = -1
        Me.Legend1.ShowGroupFolders = True
        Me.Legend1.ShowLabels = False
        Me.Legend1.Size = New System.Drawing.Size(196, 405)
        Me.Legend1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 488)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.AxMap1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Map, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Map As AxMapWinGIS.AxMap
    Friend WithEvents btnAddData As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdPan As System.Windows.Forms.RadioButton
    Friend WithEvents rdZoomOut As System.Windows.Forms.RadioButton
    Friend WithEvents rdZoomIn As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnElminarLayer As System.Windows.Forms.Button
    Friend WithEvents btnFullExtend As System.Windows.Forms.RadioButton
    Friend WithEvents AxMap1 As AxMapWinGIS.AxMap
    Friend WithEvents Legend1 As LegendControl.Legend

End Class
