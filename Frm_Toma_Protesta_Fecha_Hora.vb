Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class Frm_Toma_Protesta_Fecha_Hora
    Private Sub Frm_Toma_Protesta_Fecha_Hora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public sql_Toma_Protesta As SqlCommand
    Dim sql_alumnos_titulados As String
    Dim d_table As DataTable
    Private d_adapter As SqlDataAdapter
    Dim ds2 As DataSet
    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        Try
            Dim sqltitulados As String
            Me.SqlConnection1.Open()
            'sqltitulados = ("Select * from Toma_Protesta where FechaTP ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND HoraTP='" & CB_Hora_Toma_Protesta.Text & "'order by Nombre")
            sqltitulados = ("Select * from Toma_Protesta where FechaTP ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND HoraTP='" & CB_Hora_Toma_Protesta.Text & "'" & "AND SISTEMA='" & CB_Sistema.Text & "'order by Nombre")

            sql_Toma_Protesta = New SqlCommand(sqltitulados, Me.SqlConnection1)
            sql_Toma_Protesta.CommandType = CommandType.Text
            sql_Toma_Protesta.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_Toma_Protesta)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            Dim cr As New CrystalReportTP
            cr.SetDataSource(d_table)
            Dim r As New Frm_Reporte_Toma_Protesta
            r.CRV2.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Btn_ImprimirTodo_Click(sender As Object, e As EventArgs) Handles Btn_ImprimirTodo.Click
        Try
            Dim sqltitulados As String
            Me.SqlConnection1.Open()
            sqltitulados = ("Select * from Toma_Protesta where FechaTP ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND HoraTP='" & CB_Hora_Toma_Protesta.Text & "'order by Nombre")
            'sqltitulados = ("Select * from Toma_Protesta where FechaTP ='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND HoraTP='" & CB_Hora_Toma_Protesta.Text & "'" & "AND SISTEMA='" & CB_Sistema.Text & "'order by Nombre")

            sql_Toma_Protesta = New SqlCommand(sqltitulados, Me.SqlConnection1)
            sql_Toma_Protesta.CommandType = CommandType.Text
            sql_Toma_Protesta.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_Toma_Protesta)
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            Dim cr As New CrystalReportTP
            cr.SetDataSource(d_table)
            Dim r As New Frm_Reporte_Toma_Protesta
            r.CRV2.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class