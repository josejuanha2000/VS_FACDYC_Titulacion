<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MenuPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TITULACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosTituladosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteXFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoActasTitulacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteXFechaCarrerSexoEdadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOMADEPROTESTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosTPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeActasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SOLICITUDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TITULACIONToolStripMenuItem, Me.TOMADEPROTESTAToolStripMenuItem, Me.SOLICITUDToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TITULACIONToolStripMenuItem
        '
        Me.TITULACIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosTituladosToolStripMenuItem, Me.ReporteXFechasToolStripMenuItem, Me.ListadoActasTitulacionToolStripMenuItem, Me.ReporteXFechaCarrerSexoEdadToolStripMenuItem})
        Me.TITULACIONToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITULACIONToolStripMenuItem.Name = "TITULACIONToolStripMenuItem"
        Me.TITULACIONToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.TITULACIONToolStripMenuItem.Text = "TITULACION"
        '
        'DatosTituladosToolStripMenuItem
        '
        Me.DatosTituladosToolStripMenuItem.Name = "DatosTituladosToolStripMenuItem"
        Me.DatosTituladosToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.DatosTituladosToolStripMenuItem.Text = "Datos Titulados"
        '
        'ReporteXFechasToolStripMenuItem
        '
        Me.ReporteXFechasToolStripMenuItem.Name = "ReporteXFechasToolStripMenuItem"
        Me.ReporteXFechasToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ReporteXFechasToolStripMenuItem.Text = "Reporte x Fechas"
        '
        'ListadoActasTitulacionToolStripMenuItem
        '
        Me.ListadoActasTitulacionToolStripMenuItem.Name = "ListadoActasTitulacionToolStripMenuItem"
        Me.ListadoActasTitulacionToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ListadoActasTitulacionToolStripMenuItem.Text = "Listado Actas Titulacion"
        '
        'ReporteXFechaCarrerSexoEdadToolStripMenuItem
        '
        Me.ReporteXFechaCarrerSexoEdadToolStripMenuItem.Name = "ReporteXFechaCarrerSexoEdadToolStripMenuItem"
        Me.ReporteXFechaCarrerSexoEdadToolStripMenuItem.Size = New System.Drawing.Size(269, 22)
        Me.ReporteXFechaCarrerSexoEdadToolStripMenuItem.Text = "Reporte x Fecha_Carrer_Sexo_Edad"
        '
        'TOMADEPROTESTAToolStripMenuItem
        '
        Me.TOMADEPROTESTAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosTPToolStripMenuItem, Me.ListadoDeActasToolStripMenuItem})
        Me.TOMADEPROTESTAToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOMADEPROTESTAToolStripMenuItem.Name = "TOMADEPROTESTAToolStripMenuItem"
        Me.TOMADEPROTESTAToolStripMenuItem.Size = New System.Drawing.Size(133, 20)
        Me.TOMADEPROTESTAToolStripMenuItem.Text = "TOMA DE PROTESTA"
        '
        'DatosTPToolStripMenuItem
        '
        Me.DatosTPToolStripMenuItem.Name = "DatosTPToolStripMenuItem"
        Me.DatosTPToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.DatosTPToolStripMenuItem.Text = "Datos Alumnos"
        '
        'ListadoDeActasToolStripMenuItem
        '
        Me.ListadoDeActasToolStripMenuItem.Name = "ListadoDeActasToolStripMenuItem"
        Me.ListadoDeActasToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ListadoDeActasToolStripMenuItem.Text = "Listado de Toma Protesta"
        '
        'SOLICITUDToolStripMenuItem
        '
        Me.SOLICITUDToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturaDeDatosToolStripMenuItem})
        Me.SOLICITUDToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SOLICITUDToolStripMenuItem.Name = "SOLICITUDToolStripMenuItem"
        Me.SOLICITUDToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SOLICITUDToolStripMenuItem.Text = "SOLICITUD"
        '
        'CapturaDeDatosToolStripMenuItem
        '
        Me.CapturaDeDatosToolStripMenuItem.Name = "CapturaDeDatosToolStripMenuItem"
        Me.CapturaDeDatosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.CapturaDeDatosToolStripMenuItem.Text = "Captura de Datos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirDelSistemaToolStripMenuItem})
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.SalirToolStripMenuItem.Text = "SALIR"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=Titulacion;User ID=sa;Password=Facdyc2" &
    "020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FDC_Titulacion.My.Resources.Resources.Titulacion
        Me.PictureBox1.Location = New System.Drawing.Point(7, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(469, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FRM_MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(484, 434)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FRM_MenuPrincipal"
        Me.Text = "TITULADOS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TITULACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosTituladosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteXFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOMADEPROTESTAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeActasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SOLICITUDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturaDeDatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosTPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoActasTitulacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ReporteXFechaCarrerSexoEdadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
