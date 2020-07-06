Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class FRM_MenuPrincipal
  
    Private Sub DatosTituladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosTituladosToolStripMenuItem.Click
        FRM_Datos_Alumnos.Show()
    End Sub

    Private Sub ReporteXFechasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteXFechasToolStripMenuItem.Click
        FRM_Titulados_Fecha.Show()
    End Sub
    Private Sub FRM_MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub OficioDeAcreeditacionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DatosTPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatosTPToolStripMenuItem.Click
        FRM_Toma_Protesta.Show()

    End Sub

    Private Sub ListadoActasTitulacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoActasTitulacionToolStripMenuItem.Click
        Frm_Vista_Actas_Titulacion.Show()
    End Sub

    Private Sub ListadoDeActasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeActasToolStripMenuItem.Click
        Frm_Toma_Protesta_Fecha_Hora.Show()
    End Sub

    Private Sub CapturaDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CapturaDeDatosToolStripMenuItem.Click
        FrmSolicitud.Show()
    End Sub
    Private Sub ReporteXFechaCarrerSexoEdadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteXFechaCarrerSexoEdadToolStripMenuItem.Click
        Frm_Titulados_Fecha_Carr_Sexo_Eda.Show()
    End Sub
End Class