Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportAppServer
Imports CrystalDecisions.CrystalReports
Public Class FRM_Datos_Alumnos
    Dim sqlperiodo As New SqlCommand
    Dim sqldrperiodo As SqlDataReader
    Dim sqlmatricula As New SqlCommand
    Dim sqldrmatricula As SqlDataReader
    Private Sub FRM_Datos_Alumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.CB_Periodo.Focus()
        Call cargar_periodo()
    End Sub
    Sub cargar_periodo()
        Try
            Me.SqlConnection1.Open()
            sqlperiodo.CommandType = CommandType.Text
            sqlperiodo.CommandText = ("select * from periodos order by Cve_periodo")
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
    Sub buscar_matricula()
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandType = CommandType.Text
            sqlmatricula.CommandText = ("select * from AlumnosTitulados where AlumnosTitulados.matricula='" & TBMatricula.Text & "'" & "and AlumnosTitulados.Periodo_Escolar='" & CB_Periodo.Text & "'")
            'sqlmatricula.CommandText = ("select * from AlumnosTitulados where AlumnosTitulados.matricula='" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then
                Btn_Actualizar.Enabled = True
                Btn_Oficio_Titulacion.Enabled = True
                BTN_Guardar.Enabled = False
                'If sqlbuscardr_matricula.HasRows Then
                ' Btn_Actualizar.Enabled = True
                ' Btn_Nuevo.Enabled = True
                ' BTN_Guardar.Enabled = False
                ' Me.SqlConnection1.Close()
                ' Call buscar_matricula()
                ' Else
                ' MsgBox("Alumno no existe, Favor de dar de alta")
                ' BTN_Guardar.Enabled = True
                ' Btn_Actualizar.Enabled = False
                ' End If
                Me.TBNombre.Text = sqldrmatricula("Nombre")
                Me.CBSemestre.Text = sqldrmatricula("Semestre")
                If IsDBNull(sqldrmatricula("Carrera")) Then
                    Me.CBCarrera.Text = ""
                Else
                    Me.CBCarrera.Text = sqldrmatricula("Carrera")
                End If
                If IsDBNull(sqldrmatricula("Sexo")) Then
                    Me.CBSexo.Text = ""
                Else
                    Me.CBSexo.Text = sqldrmatricula("Sexo")
                End If
                If IsDBNull(sqldrmatricula("Edad")) Then
                    Me.TBEdad.Text = ""
                Else
                    Me.TBEdad.Text = sqldrmatricula("Edad")
                End If
                If IsDBNull(sqldrmatricula("No_Acta")) Then
                    Me.TB_No_Acta.Text = ""
                Else
                    Me.TB_No_Acta.Text = sqldrmatricula("No_Acta")
                End If
                If IsDBNull(sqldrmatricula("HORATP")) Then
                    Me.CBHORA_TP.Text = ""
                Else
                    Me.CBHORA_TP.Text = sqldrmatricula("HORATP")
                End If

                If IsDBNull(sqldrmatricula("Fecha_Examen")) Then
                    Me.DateTimePicker1.Text = TimeOfDay
                Else
                    Me.DateTimePicker1.Text = sqldrmatricula("Fecha_Examen")
                End If
                If IsDBNull(sqldrmatricula("Sem_Titulacion")) Then
                    Me.TB_Periodo_Generacion.Text = ""
                Else
                    Me.TB_Periodo_Generacion.Text = sqldrmatricula("Sem_Titulacion")
                End If
                If IsDBNull(sqldrmatricula("Carrera_Titulacion")) Then
                    Me.CBCarreraTitulacion.Text = ""
                Else
                    Me.CBCarreraTitulacion.Text = sqldrmatricula("Carrera_Titulacion")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Estimada1")) Then
                    Me.DateTimePickerEst1.Text = TimeOfDay
                Else
                    Me.DateTimePickerEst1.Text = sqldrmatricula("Fecha_Estimada1")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Estimada2")) Then
                    Me.DateTimePickerEst2.Text = TimeOfDay
                Else
                    Me.DateTimePickerEst2.Text = sqldrmatricula("Fecha_Estimada2")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Acreditacion")) Then
                    Me.DateTimePickerAcreditacion.Text = TimeOfDay
                Else
                    Me.DateTimePickerAcreditacion.Text = sqldrmatricula("Fecha_Acreditacion")
                End If
                If IsDBNull(sqldrmatricula("No_Oficio")) Then
                    Me.TBNoOficio.Text = ""
                Else
                    Me.TBNoOficio.Text = sqldrmatricula("No_Oficio")
                End If
                If IsDBNull(sqldrmatricula("Sistema")) Then
                    Me.RB_Escolaridad.Checked = False
                Else
                    If (sqldrmatricula("Sistema")) = "E" Then
                        Me.RB_Escolaridad.Checked = True
                    Else
                        If (sqldrmatricula("Sistema")) = "D" Then
                            Me.RB_Sepad.Checked = True
                        Else
                            If (sqldrmatricula("Sistema")) = "S" Then
                                Me.RB_Sabinas.Checked = True
                            Else
                                If (sqldrmatricula("Sistema")) = "L" Then
                                    Me.RB_Linares.Checked = True
                                Else
                                    If (sqldrmatricula("Sistema")) = "C" Then
                                        Me.RB_Cuautitlan.Checked = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If IsDBNull(sqldrmatricula("Egresado")) Then
                    Me.RB_Egresados.Checked = False
                Else
                    If (sqldrmatricula("Egresado")) = "1" Then
                        Me.RB_Egresados.Checked = True
                    Else
                        Me.RB_Egresados.Checked = False
                    End If
                End If
                If IsDBNull(sqldrmatricula("Titulado")) Then
                    Me.RB_Titulado.Checked = False
                Else
                    If (sqldrmatricula("Titulado")) = "1" Then
                        Me.RB_Titulado.Checked = True
                    Else
                        Me.RB_Titulado.Checked = False
                    End If
                End If
                If IsDBNull(sqldrmatricula("Modalidad")) Then
                Else
                    If (sqldrmatricula("Modalidad")) = "M" Then 'MATERIAS DE POSGRADO
                        Me.RB_Materias_Posgrado.Checked = True
                    Else
                        If (sqldrmatricula("Modalidad")) = "S" Then 'SEMINARIO
                            Me.RB_Seminario.Checked = True
                        Else
                            If (sqldrmatricula("Modalidad")) = "C" Then 'CURSO
                                Me.RB_Curso.Checked = True
                            Else
                                If (sqldrmatricula("Modalidad")) = "P" Then 'PROMEDIO
                                    Me.RB_Promedio.Checked = True
                                Else
                                    If (sqldrmatricula("Modalidad")) = "E" Then 'EXPERIENCIA LABORAL
                                        Me.RB_Experiencia_Laboral.Checked = True
                                    Else
                                        If (sqldrmatricula("Modalidad")) = "T" Then 'TESIS
                                            Me.RB_Tesis.Checked = True
                                        Else
                                            If (sqldrmatricula("Modalidad")) = "A" Then 'AUTOMATICO
                                                Me.RB_Automatico.Checked = True
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("Alumno no existe en este periodo ")
                sqldrmatricula.Close()
                Me.SqlConnection1.Close()

                Call buscar_matricula_Otro_Periodo()
                ' BTN_Guardar.Enabled = True
                ' Btn_Actualizar.Enabled = False
                ' Call Limpiar_campos()
                ' Me.TBNombre.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_matricula_Otro_Periodo()
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandType = CommandType.Text
            'sqlmatricula.CommandText = ("select * from AlumnosTitulados where AlumnosTitulados.matricula='" & TBMatricula.Text & "'" & "and AlumnosTitulados.Periodo_Escolar='" & CB_Periodo.Text & "'")
            sqlmatricula.CommandText = ("select * from AlumnosTitulados where AlumnosTitulados.matricula='" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then
                MsgBox("Alumno se encontro en otro periodo, favor de actalizar los datos")
                Btn_Actualizar.Enabled = True
                Btn_Oficio_Titulacion.Enabled = True
                BTN_Guardar.Enabled = True
                'If sqlbuscardr_matricula.HasRows Then
                ' Btn_Actualizar.Enabled = True
                ' Btn_Nuevo.Enabled = True
                ' BTN_Guardar.Enabled = False
                ' Me.SqlConnection1.Close()
                ' Call buscar_matricula()
                ' Else
                ' MsgBox("Alumno no existe, Favor de dar de alta")
                ' BTN_Guardar.Enabled = True
                ' Btn_Actualizar.Enabled = False
                ' End If
                Me.TBNombre.Text = sqldrmatricula("Nombre")
                Me.CBSemestre.Text = sqldrmatricula("Semestre")
                If IsDBNull(sqldrmatricula("Carrera")) Then
                    Me.CBCarrera.Text = ""
                Else
                    Me.CBCarrera.Text = sqldrmatricula("Carrera")
                End If
                If IsDBNull(sqldrmatricula("Sexo")) Then
                    Me.CBSexo.Text = ""
                Else
                    Me.CBSexo.Text = sqldrmatricula("Sexo")
                End If
                If IsDBNull(sqldrmatricula("Edad")) Then
                    Me.TBEdad.Text = ""
                Else
                    Me.TBEdad.Text = sqldrmatricula("Edad")
                End If
                If IsDBNull(sqldrmatricula("No_Acta")) Then
                    Me.TB_No_Acta.Text = ""
                Else
                    Me.TB_No_Acta.Text = sqldrmatricula("No_Acta")
                End If

                If IsDBNull(sqldrmatricula("HORATP")) Then
                    Me.CBHORA_TP.Text = ""
                Else
                    Me.CBHORA_TP.Text = sqldrmatricula("HORATP")
                End If

                If IsDBNull(sqldrmatricula("Fecha_Examen")) Then
                    Me.DateTimePicker1.Text = TimeOfDay
                Else
                    Me.DateTimePicker1.Text = sqldrmatricula("Fecha_Examen")
                End If
                If IsDBNull(sqldrmatricula("Sem_Titulacion")) Then
                    Me.TB_Periodo_Generacion.Text = ""
                Else
                    Me.TB_Periodo_Generacion.Text = sqldrmatricula("Sem_Titulacion")
                End If
                If IsDBNull(sqldrmatricula("Carrera_Titulacion")) Then
                    Me.CBCarreraTitulacion.Text = ""
                Else
                    Me.CBCarreraTitulacion.Text = sqldrmatricula("Carrera_Titulacion")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Estimada1")) Then
                    Me.DateTimePickerEst1.Text = TimeOfDay
                Else
                    Me.DateTimePickerEst1.Text = sqldrmatricula("Fecha_Estimada1")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Estimada2")) Then
                    Me.DateTimePickerEst2.Text = TimeOfDay
                Else
                    Me.DateTimePickerEst2.Text = sqldrmatricula("Fecha_Estimada2")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Acreditacion")) Then
                    Me.DateTimePickerAcreditacion.Text = TimeOfDay
                Else
                    Me.DateTimePickerAcreditacion.Text = sqldrmatricula("Fecha_Acreditacion")
                End If
                If IsDBNull(sqldrmatricula("No_Oficio")) Then
                    Me.TBNoOficio.Text = ""
                Else
                    Me.TBNoOficio.Text = sqldrmatricula("No_Oficio")
                End If
                If IsDBNull(sqldrmatricula("Sistema")) Then
                    Me.RB_Escolaridad.Checked = False
                Else
                    If (sqldrmatricula("Sistema")) = "E" Then
                        Me.RB_Escolaridad.Checked = True
                    Else
                        If (sqldrmatricula("Sistema")) = "D" Then
                            Me.RB_Sepad.Checked = True
                        Else
                            If (sqldrmatricula("Sistema")) = "S" Then
                                Me.RB_Sabinas.Checked = True
                            Else
                                If (sqldrmatricula("Sistema")) = "L" Then
                                    Me.RB_Linares.Checked = True
                                Else
                                    If (sqldrmatricula("Sistema")) = "C" Then
                                        Me.RB_Cuautitlan.Checked = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                If IsDBNull(sqldrmatricula("Egresado")) Then
                    Me.RB_Egresados.Checked = False
                Else
                    If (sqldrmatricula("Egresado")) = "1" Then
                        Me.RB_Egresados.Checked = True
                    Else
                        Me.RB_Egresados.Checked = False
                    End If
                End If
                If IsDBNull(sqldrmatricula("Titulado")) Then
                    Me.RB_Titulado.Checked = False
                Else
                    If (sqldrmatricula("Titulado")) = "1" Then
                        Me.RB_Titulado.Checked = True
                    Else
                        Me.RB_Titulado.Checked = False
                    End If
                End If
                If IsDBNull(sqldrmatricula("Modalidad")) Then
                Else
                    If (sqldrmatricula("Modalidad")) = "M" Then
                        Me.RB_Materias_Posgrado.Checked = True
                    Else
                        If (sqldrmatricula("Modalidad")) = "S" Then
                            Me.RB_Seminario.Checked = True
                        Else
                            If (sqldrmatricula("Modalidad")) = "C" Then
                                Me.RB_Curso.Checked = True
                            Else
                                If (sqldrmatricula("Modalidad")) = "P" Then
                                    Me.RB_Promedio.Checked = True
                                Else
                                    If (sqldrmatricula("Modalidad")) = "E" Then
                                        Me.RB_Experiencia_Laboral.Checked = True
                                    Else
                                        If (sqldrmatricula("Modalidad")) = "T" Then
                                            Me.RB_Tesis.Checked = True
                                        Else
                                            If (sqldrmatricula("Modalidad")) = "A" Then
                                                Me.RB_Automatico.Checked = True
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("Alumno no existe en archivo, Favor de Registrarlo")
                BTN_Guardar.Enabled = True
                Btn_Actualizar.Enabled = False
                Call Limpiar_campos()
                Me.TBNombre.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub Actualizar_Datos_Alumnos()
        Try
            Me.SqlConnection1.Open()
            Dim Actualizar As String
            Actualizar = MsgBox("Esta seguro que desa Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Actualizar")
            If Actualizar = vbYes Then
                'Dim Titulacion As String = ("UPDATE AlumnosTitulados SET Periodo_Escolar=@Periodo_Escolar,Nombre=@Nombre,Semestre=@Semestre,Carrera=@Carrera,Sexo=@Sexo,Edad=@Edad,No_Acta=@No_Acta,Fecha_Examen=@Fecha_Examen,Sem_Titulacion=@Sem_Titulacion,Sistema=@Sistema,Egresado=@Egresado,Titulado=@Titulado,Modalidad=@Modalidad,Carrera_Titulacion=@Carrera_Titulacion,Fecha_Estimada1=@Fecha_Estimada1,Fecha_Estimada2=@Fecha_Estimada2,No_Oficio=@No_Oficio  WHERE Matricula = '" & TBMatricula.Text & "'" & "AND Periodo_Escolar='" & CB_Periodo.Text & "'")
                Dim Titulacion As String = ("UPDATE AlumnosTitulados SET Nombre=@Nombre,Semestre=@Semestre,Carrera=@Carrera,Sexo=@Sexo,Edad=@Edad,No_Acta=@No_Acta,HORATP=@HORATP,Fecha_Examen=@Fecha_Examen,Sem_Titulacion=@Sem_Titulacion,Sistema=@Sistema,Egresado=@Egresado,Titulado=@Titulado,Modalidad=@Modalidad,Carrera_Titulacion=@Carrera_Titulacion,Fecha_Estimada1=@Fecha_Estimada1,Fecha_Estimada2=@Fecha_Estimada2,No_Oficio=@No_Oficio,Fecha_Acreditacion=@Fecha_Acreditacion  WHERE Matricula = '" & TBMatricula.Text & "'" & "and AlumnosTitulados.Periodo_Escolar='" & CB_Periodo.Text & "'")

                Dim CONEXION1 As New SqlClient.SqlCommand(Titulacion, Me.SqlConnection1)
                'CONEXION1.Parameters.Add(New SqlParameter("Periodo_Escolar", SqlDbType.NVarChar, 7)).Value = Me.CB_Periodo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Semestre", SqlDbType.NVarChar, 2)).Value = Me.CBSemestre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Carrera", SqlDbType.NVarChar, 1)).Value = Me.CBCarrera.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sexo", SqlDbType.NVarChar, 1)).Value = Me.CBSexo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Edad", SqlDbType.NVarChar, 2)).Value = Me.TBEdad.Text
                CONEXION1.Parameters.Add(New SqlParameter("No_Acta", SqlDbType.NVarChar, 10)).Value = Me.TB_No_Acta.Text
                CONEXION1.Parameters.Add(New SqlParameter("HORATP", SqlDbType.NVarChar, 4)).Value = Me.CBHORA_TP.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Examen", SqlDbType.DateTime)).Value = Me.DateTimePicker1.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sem_Titulacion", SqlDbType.NVarChar, 50)).Value = Me.TB_Periodo_Generacion.Text
                CONEXION1.Parameters.Add(New SqlParameter("Carrera_Titulacion", SqlDbType.NVarChar, 50)).Value = Me.CBCarreraTitulacion.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Estimada1", SqlDbType.DateTime)).Value = Me.DateTimePickerEst1.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Estimada2", SqlDbType.DateTime)).Value = Me.DateTimePickerEst2.Text
                CONEXION1.Parameters.Add(New SqlParameter("No_Oficio", SqlDbType.NVarChar, 10)).Value = Me.TBNoOficio.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Acreditacion", SqlDbType.DateTime)).Value = Me.DateTimePickerAcreditacion.Text

                If Me.RB_Escolaridad.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "E" 'ESCOLARIDAD
                Else
                    If Me.RB_Sepad.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "D" 'SEPAD
                    Else
                        If Me.RB_Sabinas.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "S" 'SABINAS
                        Else
                            If Me.RB_Linares.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "L" 'LINARES
                            Else
                                If Me.RB_Cuautitlan.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "C" 'CUAUTITLAN
                                End If
                            End If
                        End If
                    End If
                End If
                If Me.RB_Egresados.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Egresado", SqlDbType.NVarChar, 1)).Value = "1" 'EGRESADO
                Else
                    CONEXION1.Parameters.Add(New SqlParameter("@Egresado", SqlDbType.NVarChar, 1)).Value = "0" 'EGRESADO
                End If

                If Me.RB_Titulado.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Titulado", SqlDbType.NVarChar, 1)).Value = "1" 'TITULADO
                Else
                    CONEXION1.Parameters.Add(New SqlParameter("@Titulado", SqlDbType.NVarChar, 1)).Value = "0" 'TITULADO
                End If

                If Me.RB_Materias_Posgrado.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "M" 'Materias Posgrado
                Else
                    If Me.RB_Seminario.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "S" 'Seminario
                    Else
                        If Me.RB_Curso.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "C" 'Curso
                        Else
                            If Me.RB_Promedio.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "P" 'Promedio
                            Else
                                If Me.RB_Experiencia_Laboral.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "E" 'EXPERIENCIA lABORAL
                                Else
                                    If Me.RB_Tesis.Checked = True Then
                                        CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "T" 'TESIS
                                    Else
                                        If Me.RB_Automatico.Checked = True Then
                                            CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "A" 'AUTOMATICO
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                CONEXION1.CommandText = Titulacion
                CONEXION1.ExecuteNonQuery()
                MsgBox("Datos Guardados correctamente", , "Guardar")
                Me.SqlConnection1.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub Cargar_alumnos_periodo()
        Dim sql_cmd_alumnos As SqlCommand
        Dim sql_alumnos_titulados As String
        Dim d_table As DataTable
        Dim d_adapter As SqlDataAdapter
        Dim ds As DataSet
        Try
            Me.SqlConnection1.Open()
            sql_alumnos_titulados = ("Select * from AlumnosTitulados where Periodo_Escolar= '" & CB_Periodo.Text & "'")
            sql_cmd_alumnos = New SqlCommand(sql_alumnos_titulados, Me.SqlConnection1)
            sql_cmd_alumnos.CommandType = CommandType.Text
            sql_cmd_alumnos.ExecuteNonQuery()
            d_adapter = New SqlDataAdapter(sql_cmd_alumnos)
            ds = New System.Data.DataSet
            d_table = New DataTable
            d_adapter.Fill(d_table)
            DataGridView1.DataSource = d_table
            'DataGridView1.DataSource = ds.Tables(0)
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub Agregar_Datos_Alumnos_Titulacion()
        Try
            Me.SqlConnection1.Open()
            Dim Agregar_Datos_Tit As String
            Agregar_Datos_Tit = MsgBox("Esta seguro de Guardar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Actualizar")
            If Agregar_Datos_Tit = vbYes Then
                'Dim INSDATOS_Titulacion As String = ("UPDATE AlumnosTitulados SET Nombre=@Nombre,Semestre=@Semestre,Carrera=@Carrera,Sexo=@Sexo,Edad=@Edad,No_Acta=@No_Acta,Fecha_Examen=@Fecha_Examen,Sem_Titulacion=@Sem_Titulacion,Sistema=@Sistema,Egresado=@Egresado,Titulado=@Titulado,Modalidad=@Modalidad,Carrera_Titulacion=@Carrera_Titulacion,Fecha_Estimada1=@Fecha_Estimada1,Fecha_Estimada2=@Fecha_Estimada2,No_Oficio=@No_Oficio  WHERE Matricula = '" & TBMatricula.Text & "'" & "AND Periodo_Escolar='" & CB_Periodo.Text & "'")
                Dim INSDATOS_TITULADO As String = "INSERT INTO AlumnosTitulados (Periodo_Escolar,Matricula,Nombre,Semestre,Carrera,Sexo,Edad,No_Acta,HORATP,Fecha_Examen,Sem_Titulacion,Carrera_Titulacion,Fecha_Estimada1,Fecha_Estimada2,No_Oficio,Sistema,Egresado,Titulado,Modalidad,Fecha_Acreditacion) Values (@Periodo_Escolar,@Matricula,@Nombre,@Semestre,@Carrera,@Sexo,@Edad,@No_Acta,@HORATP,@Fecha_Examen,@Sem_Titulacion,@Carrera_Titulacion,@Fecha_Estimada1,@Fecha_Estimada2,@No_Oficio,@Sistema,@Egresado,@Titulado,@Modalidad,@Fecha_Acreditacion)"
                Dim CONEXION1 As New SqlClient.SqlCommand(INSDATOS_TITULADO, Me.SqlConnection1)
                CONEXION1.Parameters.Add(New SqlParameter("Periodo_Escolar", SqlDbType.NVarChar, 7)).Value = Me.CB_Periodo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Matricula", SqlDbType.NVarChar, 7)).Value = Me.TBMatricula.Text
                CONEXION1.Parameters.Add(New SqlParameter("Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Semestre", SqlDbType.NVarChar, 2)).Value = Me.CBSemestre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Carrera", SqlDbType.NVarChar, 1)).Value = Me.CBCarrera.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sexo", SqlDbType.NVarChar, 1)).Value = Me.CBSexo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Edad", SqlDbType.NVarChar, 2)).Value = Me.TBEdad.Text
                CONEXION1.Parameters.Add(New SqlParameter("No_Acta", SqlDbType.NVarChar, 9)).Value = Me.TB_No_Acta.Text
                CONEXION1.Parameters.Add(New SqlParameter("HORATP", SqlDbType.NVarChar, 4)).Value = Me.CBHORA_TP.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Examen", SqlDbType.DateTime)).Value = Me.DateTimePicker1.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sem_Titulacion", SqlDbType.NVarChar, 50)).Value = Me.TB_Periodo_Generacion.Text
                CONEXION1.Parameters.Add(New SqlParameter("Carrera_Titulacion", SqlDbType.NVarChar, 50)).Value = Me.CBCarreraTitulacion.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Estimada1", SqlDbType.DateTime)).Value = Me.DateTimePickerEst1.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Estimada2", SqlDbType.DateTime)).Value = Me.DateTimePickerEst2.Text
                CONEXION1.Parameters.Add(New SqlParameter("No_Oficio", SqlDbType.NVarChar, 10)).Value = Me.TBNoOficio.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Acreditacion", SqlDbType.DateTime)).Value = Me.DateTimePickerAcreditacion.Text
                If Me.RB_Escolaridad.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("Sistema", SqlDbType.NVarChar, 1)).Value = "E" 'ESCOLARIDAD
                Else
                    If Me.RB_Sepad.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("Sistema", SqlDbType.NVarChar, 1)).Value = "D" 'SEPAD
                    Else
                        If Me.RB_Sabinas.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("Sistema", SqlDbType.NVarChar, 1)).Value = "S" 'SABINAS
                        Else
                            If Me.RB_Linares.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("Sistema", SqlDbType.NVarChar, 1)).Value = "L" 'LINARES
                            Else
                                If Me.RB_Cuautitlan.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("Sistema", SqlDbType.NVarChar, 1)).Value = "C" 'CUAUTITLAN
                                Else
                                    CONEXION1.Parameters.Add(New SqlParameter("Sistema", SqlDbType.NVarChar, 1)).Value = "" 'nada
                                End If
                            End If
                        End If
                    End If
                End If
                If Me.RB_Egresados.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("Egresado", SqlDbType.NChar, 1)).Value = "1" 'EGRESADO
                Else
                    CONEXION1.Parameters.Add(New SqlParameter("Egresado", SqlDbType.NChar, 1)).Value = "0" 'EGRESADO
                End If

                If Me.RB_Titulado.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("Titulado", SqlDbType.NChar, 1)).Value = "1" 'TITULADO
                Else
                    CONEXION1.Parameters.Add(New SqlParameter("Titulado", SqlDbType.NChar, 1)).Value = "0" 'TITULADO
                End If

                If Me.RB_Materias_Posgrado.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "M" 'Materias Posgrado
                Else
                    If Me.RB_Seminario.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "S" 'Seminario
                    Else
                        If Me.RB_Curso.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "C" 'Curso
                        Else
                            If Me.RB_Promedio.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "P" 'Promedio
                            Else
                                If Me.RB_Experiencia_Laboral.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "E" 'EXPERIENCIA lABORAL
                                Else
                                    If Me.RB_Tesis.Checked = True Then
                                        CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "T" 'TESIS
                                    Else
                                        If Me.RB_Automatico.Checked = True Then
                                            CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "A" 'AUTOMATICO
                                        Else
                                            CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "" 'NADA
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
                CONEXION1.CommandText = INSDATOS_TITULADO
                CONEXION1.ExecuteNonQuery()

                MsgBox("Datos Guardados correctamente", , "Guardar")
                Me.SqlConnection1.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Call buscar_matricula()
    End Sub
    Private Sub CB_Periodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Periodo.SelectedIndexChanged
        Call Cargar_alumnos_periodo()
        Me.TBMatricula.Focus()

    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Call Actualizar_Datos_Alumnos()
        Call Limpiar_campos()
        TBMatricula.Text = ""
    End Sub

    Private Sub Btn_Oficio_Titulacion_Click(sender As Object, e As EventArgs) Handles Btn_Oficio_Titulacion.Click
        Try
            Dim sqltitulados2 As String
            Dim sql_titulados2 As SqlCommand
            Dim d_adapter2 As SqlDataAdapter
            Dim d_table2 As DataTable

            Me.SqlConnection1.Open()
            sqltitulados2 = ("Select * from AlumnosTitulados where Periodo_Escolar= '" & CB_Periodo.Text & "'" & "AND matricula='" & Me.TBMatricula.Text & "'")
            'sqltitulados = ("Select * from AlumnosTitulados where  Fecha_Examen >='" & Format(DateTimePicker1.Value.Date.ToString, "Short Date") & "' " & "AND Fecha_Examen<='" & Format(DateTimePicker2.Value.Date.ToString, "Short Date") & "' " & "AND Periodo_Escolar='" & CB_Periodo.Text & " '")
            sql_titulados2 = New SqlCommand(sqltitulados2, Me.SqlConnection1)
            sql_titulados2.CommandType = CommandType.Text
            sql_titulados2.ExecuteNonQuery()
            d_adapter2 = New SqlDataAdapter(sql_titulados2)
            d_table2 = New DataTable
            d_adapter2.Fill(d_table2)

            Dim cr As New CR_Oficio_Acreditacion
            cr.SetDataSource(d_table2)
            Dim r As New Oficio_Acreditacion
            r.CRV2.ReportSource = cr
            r.ShowDialog()
            Me.SqlConnection1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub Limpiar_campos()
        TB_No_Acta.Text = ""
        TB_Periodo_Generacion.Text = ""
        TBEdad.Text = ""
        'TBMatricula.Text = ""
        TBNombre.Text = ""
        TBNoOficio.Text = ""
        CBCarrera.Text = ""
        CBSemestre.Text = ""
        CBSexo.Text = ""
        CBCarreraTitulacion.Text = ""
        CBHORA_TP.Text = ""
        'RB_Automatico.Enabled = False
        'RB_Cuautitlan.Enabled = False
        'RB_Curso.Enabled = False
        'RB_Egresados.Enabled = False
        'RB_Escolaridad.Enabled = False
        'RB_Linares.Enabled = False
        'RB_Experiencia_Laboral.Enabled = False
        'RB_Promedio.Enabled = False
        'RB_Sabinas.Enabled = False
        'RB_Seminario.Enabled = False
        'RB_Sepad.Enabled = False
        'RB_Tesis.Enabled = False
        'RB_Titulado.Enabled = False
        Btn_Actualizar.Enabled = False
        BTN_Guardar.Enabled = False
        Btn_Oficio_Titulacion.Enabled = False
        DateTimePicker1.Text = TimeOfDay
        DateTimePickerEst1.Text = TimeOfDay
        DateTimePickerEst2.Text = TimeOfDay
        DateTimePickerAcreditacion.Text = TimeOfDay
        Me.TBMatricula.Focus()
    End Sub

    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        Call Agregar_Datos_Alumnos_Titulacion()
        Call Limpiar_campos()
        Btn_Actualizar.Enabled = False
        'BTN_Guardar.Enabled = False
        Btn_Oficio_Titulacion.Enabled = False
        TBMatricula.Text = ""
    End Sub
End Class
