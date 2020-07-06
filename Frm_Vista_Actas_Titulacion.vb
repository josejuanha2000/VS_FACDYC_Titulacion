Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Frm_Vista_Actas_Titulacion

    Private Sub Frm_Vista_Actas_Titulacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim sqlperiodo As New SqlCommand
    Dim sqldrperiodo As SqlDataReader
    Public sql_titulados As SqlCommand
    Dim sql_alumnos_titulados As String
    Dim d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Dim ds2 As DataSet
    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            Dim sqltitulados As String
            Me.SqlConnection1.Open()
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & " '")
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "'Order by Nombre")
            sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "'" & "AND Carrera='" & CBCarrera.Text & "'" & "AND HORATP='" & CBHORA_TP.Text & "'" & "Order by Nombre")
            'sqltitulados = ("Select * from AlumnosTitulados")
            ' "'AND'" & DateTimePicker1.ToString & "'")
            '& "'AND Fecha_Examen = " & DateTimePicker1.Text & "'")
            sql_titulados = New SqlCommand(sqltitulados, Me.SqlConnection1)
            sql_titulados.CommandType = CommandType.Text
            sql_titulados.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_titulados)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            'DataGridView1.DataSource = d_table
            Dim cr As New CRActasTitulacion
            cr.SetDataSource(d_table)
            Dim r As New FrmReporteActasTitulados
            r.CRV1.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnMostrarDatos_Click(sender As Object, e As EventArgs) Handles BtnMostrarDatos.Click
        Try
            Dim sqltitulados As String
            Me.SqlConnection1.Open()
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & " '")
            sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "'" & "AND Carrera='" & CBCarrera.Text & "'" & "AND HORATP='" & CBHORA_TP.Text & "'")
            'sqltitulados = ("Select * from AlumnosTitulados")
            ' "'AND'" & DateTimePicker1.ToString & "'")
            '& "'AND Fecha_Examen = " & DateTimePicker1.Text & "'")
            sql_titulados = New SqlCommand(sqltitulados, Me.SqlConnection1)
            sql_titulados.CommandType = CommandType.Text
            sql_titulados.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_titulados)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class