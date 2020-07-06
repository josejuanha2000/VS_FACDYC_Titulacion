Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class FRM_Titulados_Fecha
    Private Sub FRM_Titulados_Fecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargar_periodo()
    End Sub
    Dim sqlperiodo As New SqlCommand
    Dim sqldrperiodo As SqlDataReader
    Public sql_titulados As SqlCommand
    Dim sql_alumnos_titulados As String
    Dim d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Dim ds2 As DataSet
    Private Sub ButtonDerecho_Click(sender As Object, e As EventArgs) Handles ButtonDerecho.Click
        Try
            Dim sqltitulados As String
            Me.SqlConnection1.Open()
            'sqltitulados = ("Select * from AlumnosTitulados where Periodo_Escolar= '" & CB_Periodo.Text & "'" & "and fecha_Examen >='" & Me.DateTimePicker1.MinDate & "'" & " and fecha_Examen <='" & Me.DateTimePicker2.MinDate & "'")
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & " '")
            sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & "'" & "AND Carrera='" & "D" & "'" & "Order by Nombre")

            ' "'AND'" & DateTimePicker1.ToString & "'")
            '& "'AND Fecha_Examen = " & DateTimePicker1.Text & "'")
            sql_titulados = New SqlCommand(sqltitulados, Me.SqlConnection1)
            sql_titulados.CommandType = CommandType.Text
            sql_titulados.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_titulados)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            Dim cr As New CR_Titulados_Fecha
            cr.SetDataSource(d_table)
            Dim r As New Reporte_Titulados
            r.CRV1.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub cargar_periodo()
        Try
            Me.SqlConnection1.Open()
            sqlperiodo.CommandType = CommandType.Text
            sqlperiodo.CommandText = ("select * from periodos")
            sqlperiodo.Connection = Me.SqlConnection1
            sqldrperiodo = sqlperiodo.ExecuteReader()
            While sqldrperiodo.Read = True
                CB_Periodo.Items.Add(sqldrperiodo.Item(0))
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrperiodo.Close()
        Me.SqlConnection1.Close()
    End Sub

    Private Sub ButtonCriminologia_Click(sender As Object, e As EventArgs) Handles ButtonCriminologia.Click
        Try
            Dim sqltitulados As String
            Me.SqlConnection1.Open()
            'sqltitulados = ("Select * from AlumnosTitulados where Periodo_Escolar= '" & CB_Periodo.Text & "'" & "and fecha_Examen >='" & Me.DateTimePicker1.MinDate & "'" & " and fecha_Examen <='" & Me.DateTimePicker2.MinDate & "'")
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & " '")
            sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & " '" & "AND Carrera='" & "C" & " '" & "Order by Nombre")

            ' "'AND'" & DateTimePicker1.ToString & "'")
            '& "'AND Fecha_Examen = " & DateTimePicker1.Text & "'")
            sql_titulados = New SqlCommand(sqltitulados, Me.SqlConnection1)
            sql_titulados.CommandType = CommandType.Text
            sql_titulados.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_titulados)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            Dim cr As New CR_Titulados_Fecha
            cr.SetDataSource(d_table)
            Dim r As New Reporte_Titulados
            r.CRV1.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class