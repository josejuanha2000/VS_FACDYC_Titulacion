Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Frm_Titulados_Fecha_Carr_Sexo_Eda

    Private Sub Frm_Titulados_Fecha_Carr_Sexo_Eda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim sqlperiodo As New SqlCommand
    Dim sqldrperiodo As SqlDataReader
    Public sql_titulados As SqlCommand
    Dim sql_alumnos_titulados As String
    Dim d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Dim ds2 As DataSet

    
    Private Sub BtnReporte_Click(sender As Object, e As EventArgs) Handles BtnReporte.Click
        Try
            Dim sqltitulados As String
            Me.SqlConnection1.Open()
            
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & "'" & "AND Carrera='" & "D" & "'" & "Order by Nombre")
            sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Carrera='" & CB_Carrera.Text & "'" & "AND Sexo='" & CB_Sexo.Text & "'" & "Order by Nombre")

            ' "'AND'" & DateTimePicker1.ToString & "'")
            '& "'AND Fecha_Examen = " & DateTimePicker1.Text & "'")
            sql_titulados = New SqlCommand(sqltitulados, Me.SqlConnection1)
            sql_titulados.CommandType = CommandType.Text
            sql_titulados.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_titulados)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            Dim cr As New CR_Fecha_Carr_Sexo_Edad
            cr.SetDataSource(d_table)
            Dim r As New Frm_Reporte_Titulados_SENL
            r.CrystalReportViewer1.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class