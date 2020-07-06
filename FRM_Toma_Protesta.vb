Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Public Class FRM_Toma_Protesta
    Dim sqlmatricula As New SqlCommand
    Dim sqldrmatricula As SqlDataReader
    Dim sqlbuscar_matricula As New SqlCommand
    Dim sqlbuscardr_matricula As SqlDataReader

    Private Sub FRM_Toma_Protesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_alumnos_titulados()
    End Sub
    Sub buscar_datos()
        Try
            Me.SqlConnection1.Open()
            sqlbuscar_matricula.CommandType = CommandType.Text
            'sqlmatricula.CommandText = ("select * from AlumnosTitulados where AlumnosTitulados.matricula='" & TBMatricula.Text & "'" & "and AlumnosTitulados.Periodo_Escolar='" & CB_Periodo.Text & "'")
            'sqlmatricula.CommandText = ("select * from Toma_Protesta where Toma_Protesta.matricula='" & TBMatricula.Text & "'")
            sqlbuscar_matricula.CommandText = ("select * from Toma_Protesta WHERE Toma_Protesta.matricula='" & TBMatricula.Text & "'")
            sqlbuscar_matricula.Connection = Me.SqlConnection1
            sqlbuscardr_matricula = sqlbuscar_matricula.ExecuteReader()
            sqlbuscardr_matricula.Read()
            If sqlbuscardr_matricula.HasRows Then
                Btn_Actualizar.Enabled = True
                Btn_Nuevo.Enabled = True
                Btn_Guardar.Enabled = False
                Me.SqlConnection1.Close()
                Call buscar_matricula()
                'Btn_Nuevo.Enabled = False
            Else
                MsgBox("Alumno no existe, Favor de dar de alta")
                Btn_Guardar.Enabled = True
                Btn_Actualizar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'Me.sqlbuscardr_matricula.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub buscar_matricula()
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandType = CommandType.Text
            'sqlmatricula.CommandText = ("select * from AlumnosTitulados where AlumnosTitulados.matricula='" & TBMatricula.Text & "'" & "and AlumnosTitulados.Periodo_Escolar='" & CB_Periodo.Text & "'")
            'sqlmatricula.CommandText = ("select * from Toma_Protesta where Toma_Protesta.matricula='" & TBMatricula.Text & "'")
            sqlmatricula.CommandText = ("select * from Toma_Protesta WHERE Toma_Protesta.matricula='" & TBMatricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            Me.TBNombre.Text = sqldrmatricula("Nombre")
            'Me.CBSemestre.Text = sqldrmatricula("Semestre")
            If IsDBNull(sqldrmatricula("Semestre")) Then
                Me.CBSemestre.Text = ""
            Else
                Me.CBSemestre.Text = sqldrmatricula("Semestre")
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
            If IsDBNull(sqldrmatricula("FechaTP")) Then
                Me.DateTimePicker1.Text = TimeOfDay
            Else
                Me.DateTimePicker1.Text = sqldrmatricula("FechaTP")
            End If
            If IsDBNull(sqldrmatricula("HORATP")) Then
                Me.CBHORA_TP.Text = ""
            Else
                Me.CBHORA_TP.Text = sqldrmatricula("HORATP")
            End If

            If IsDBNull(sqldrmatricula("No_Acta")) Then
                Me.TB_No_Acta.Text = ""
            Else
                Me.TB_No_Acta.Text = sqldrmatricula("No_Acta")
            End If

            If IsDBNull(sqldrmatricula("Sem_Titulacion")) Then
                Me.TB_Periodo_Generacion.Text = ""
            Else
                Me.TB_Periodo_Generacion.Text = sqldrmatricula("Sem_Titulacion")
            End If

            If IsDBNull(sqldrmatricula("Carrera")) Then
                Me.RB_Derecho.Checked = False
            Else
                If (sqldrmatricula("Carrera")) = "D" Then
                    Me.RB_Derecho.Checked = True
                Else
                    If (sqldrmatricula("Carrera")) = "C" Then
                        Me.RB_Criminologia.Checked = True
                    Else
                        If (sqldrmatricula("Carrera")) = "J" Then
                            Me.RB_CienciasJuridicas.Checked = True
                        Else
                            If (sqldrmatricula("Carrera")) = "U" Then
                                Me.RB_DerechoyCjuridicas.Checked = True
                            Else
                                If (sqldrmatricula("Carrera")) = "S" Then
                                    Me.RB_DerechoyCSociales.Checked = True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If IsDBNull(sqldrmatricula("Sistema")) Then
                Me.RB_Escolaridad.Checked = False
            Else
                If (sqldrmatricula("Sistema")) = "E" Then
                    Me.RB_Escolaridad.Checked = True
                Else
                    If (sqldrmatricula("Sistema")) = "S" Then
                        Me.RB_Sepad.Checked = True
                    Else
                        If (sqldrmatricula("Sistema")) = "A" Then
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
            If IsDBNull(sqldrmatricula("Modalidad")) Then
            Else
                If (sqldrmatricula("Modalidad")) = "M" Then
                    Me.RB_MateriasPosgrado.Checked = True
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
                                    Me.RB_ExperienciaLaboral.Checked = True
                                Else
                                    If (sqldrmatricula("Modalidad")) = "T" Then
                                        Me.RB_Tesis.Checked = True
                                    Else
                                        If (sqldrmatricula("Modalidad")) = "A" Then
                                            Me.RB_Automatico.Checked = True
                                        Else
                                            If (sqldrmatricula("Modalidad")) = "R" Then
                                                Me.RB_AutomaticoPromedio.Checked = True
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub Actualizar_Datos_TP()
        Try
            Me.SqlConnection1.Open()
            Dim Actualizar As String
            Actualizar = MsgBox("Esta seguro que desa Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Actualizar")
            If Actualizar = vbYes Then
                'Dim Titulacion As String = ("UPDATE Toma_Protesta SET Nombre=@Nombre,Semestre=@Semestre,Carrera=@Carrera,Sexo=@Sexo,Edad=@Edad,No_Acta=@No_Acta,Fecha_Examen=@Fecha_Examen,Sem_Titulacion=@Sem_Titulacion,Sistema=@Sistema,Egresado=@Egresado,Titulado=@Titulado,Modalidad=@Modalidad,Carrera_Titulacion=@Carrera_Titulacion,Fecha_Estimada1=@Fecha_Estimada1,Fecha_Estimada2=@Fecha_Estimada2,No_Oficio=@No_Oficio  WHERE Matricula = '" & TBMatricula.Text & "'" & "AND Periodo_Escolar='" & CB_Periodo.Text & "'")
                Dim Titulacion As String = ("UPDATE Toma_Protesta SET Nombre=@Nombre,Semestre=@Semestre,Carrera=@Carrera,Sexo=@Sexo,Edad=@Edad,FechaTP=@FechaTP,HoraTP=@horaTP,No_Acta=@No_Acta,Sem_Titulacion=@Sem_Titulacion,Sistema=@Sistema,Modalidad=@Modalidad  WHERE Matricula = '" & TBMatricula.Text & "'")
                Dim CONEXION1 As New SqlClient.SqlCommand(Titulacion, Me.SqlConnection1)
                CONEXION1.Parameters.Add(New SqlParameter("Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Semestre", SqlDbType.NVarChar, 2)).Value = Me.CBSemestre.Text
                'CONEXION1.Parameters.Add(New SqlParameter("Carrera", SqlDbType.NVarChar, 1)).Value = Me.CBCarrera.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sexo", SqlDbType.NVarChar, 1)).Value = Me.CBSexo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Edad", SqlDbType.NVarChar, 2)).Value = Me.TBEdad.Text
                'CONEXION1.Parameters.Add(New SqlParameter("No_Acta", SqlDbType.NVarChar, 9)).Value = Me.TB_No_Acta.Text
                CONEXION1.Parameters.Add(New SqlParameter("FechaTP", SqlDbType.DateTime)).Value = Me.DateTimePicker1.Text
                CONEXION1.Parameters.Add(New SqlParameter("HoraTP", SqlDbType.NVarChar, 4)).Value = Me.CBHORA_TP.Text
                CONEXION1.Parameters.Add(New SqlParameter("No_Acta", SqlDbType.NVarChar, 10)).Value = Me.TB_No_Acta.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sem_Titulacion", SqlDbType.NVarChar, 50)).Value = Me.TB_Periodo_Generacion.Text
                'CONEXION1.Parameters.Add(New SqlParameter("Fecha_Estimada2", SqlDbType.DateTime)).Value = Me.DateTimePickerEst2.Text
                'CONEXION1.Parameters.Add(New SqlParameter("No_Oficio", SqlDbType.NVarChar, 10)).Value = Me.TBNoOficio.Text

                If Me.RB_Derecho.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "D" 'CARRERA
                Else
                    If Me.RB_Criminologia.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "C" 'CRIMINOLOGIA
                    Else
                        If RB_CienciasJuridicas.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "J" 'CIENCIAS JURIDICAS
                        Else
                            If RB_DerechoyCjuridicas.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "U" 'DERECHO Y C. JURIDICAS
                            Else
                                If RB_DerechoyCSociales.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "S" 'DERECHO Y CIENCIAS SOCIALES
                                End If
                            End If
                        End If
                    End If
                End If

                If Me.RB_Escolaridad.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "E" 'ESCOLARIDAD
                Else
                    If Me.RB_Sepad.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "S" 'SEPAD
                    Else
                        If Me.RB_Sabinas.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "A" 'SABINAS
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

                If Me.RB_MateriasPosgrado.Checked = True Then
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
                                If Me.RB_ExperienciaLaboral.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "E" 'EXPERIENCIA lABORAL
                                Else
                                    If Me.RB_Tesis.Checked = True Then
                                        CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "T" 'TESIS
                                    Else
                                        If Me.RB_Automatico.Checked = True Then
                                            CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "A" 'AUTOMATICO
                                        Else
                                            If Me.RB_AutomaticoPromedio.Checked = True Then
                                                CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "R" 'AUTOMATICO PROMEDIO
                                            End If
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
    Sub AGREGAR_ALUMNO_TP()
        Try
            Me.SqlConnection1.Open()
            Dim AGREGAR As String
            AGREGAR = MsgBox("Esta seguro que desa Agregar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Actualizar")
            If AGREGAR = vbYes Then
                Dim INSDATOS_TITULADO As String = "INSERT INTO Toma_Protesta (Matricula,Nombre,Semestre,Carrera,Sexo,Edad,FechaTP,horaTP,No_Acta,Sem_Titulacion,Sistema,Modalidad) Values (@Matricula,@Nombre,@Semestre,@Carrera,@Sexo,@Edad,@FechaTP,@horaTP,@No_Acta,@Sem_Titulacion,@Sistema,@Modalidad)"
                Dim CONEXION1 As New SqlClient.SqlCommand(INSDATOS_TITULADO, Me.SqlConnection1)
                CONEXION1.Parameters.Add(New SqlParameter("Matricula", SqlDbType.NVarChar, 7)).Value = Me.TBMatricula.Text
                CONEXION1.Parameters.Add(New SqlParameter("Nombre", SqlDbType.NVarChar, 50)).Value = Me.TBNombre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Semestre", SqlDbType.NVarChar, 2)).Value = Me.CBSemestre.Text
                'CONEXION1.Parameters.Add(New SqlParameter("Carrera", SqlDbType.NVarChar, 1)).Value = ""
                If Me.RB_Derecho.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "D" 'CARRERA
                Else
                    If Me.RB_Criminologia.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "C" 'CRIMINOLOGIA
                    Else
                        If RB_CienciasJuridicas.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "J" 'CIENCIAS JURIDICAS
                        Else
                            If RB_DerechoyCjuridicas.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "U" 'DERECHO Y C. JURIDICAS
                            Else
                                If RB_DerechoyCSociales.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("@Carrera", SqlDbType.NVarChar, 1)).Value = "S" 'DERECHO Y CIENCIAS SOCIALES
                                End If
                            End If
                        End If
                    End If
                End If

                CONEXION1.Parameters.Add(New SqlParameter("Sexo", SqlDbType.NVarChar, 1)).Value = Me.CBSexo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Edad", SqlDbType.NVarChar, 2)).Value = Me.TBEdad.Text
                'CONEXION1.Parameters.Add(New SqlParameter("No_Acta", SqlDbType.NVarChar, 9)).Value = Me.TB_No_Acta.Text
                CONEXION1.Parameters.Add(New SqlParameter("FechaTP", SqlDbType.DateTime)).Value = Me.DateTimePicker1.Text
                CONEXION1.Parameters.Add(New SqlParameter("HoraTP", SqlDbType.NVarChar, 4)).Value = Me.CBHORA_TP.Text
                CONEXION1.Parameters.Add(New SqlParameter("No_Acta", SqlDbType.NVarChar, 10)).Value = Me.TB_No_Acta.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sem_Titulacion", SqlDbType.NVarChar, 50)).Value = Me.TB_Periodo_Generacion.Text

                'CONEXION1.Parameters.Add(New SqlParameter("Sistema", SqlDbType.NVarChar, 1)).Value = ""
                'CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = ""

                'CONEXION1.Parameters.Add(New SqlParameter("Fecha_Estimada1", SqlDbType.DateTime)).Value = Me.DateTimePickerEst1.Text
                'CONEXION1.Parameters.Add(New SqlParameter("Fecha_Estimada2", SqlDbType.DateTime)).Value = Me.DateTimePickerEst2.Text
                'CONEXION1.Parameters.Add(New SqlParameter("No_Oficio", SqlDbType.NVarChar, 10)).Value = Me.TBNoOficio.Text

                If Me.RB_Escolaridad.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "E" 'ESCOLARIDAD
                Else
                    If Me.RB_Sepad.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "S" 'SEPAD
                    Else
                        If Me.RB_Sabinas.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("@Sistema", SqlDbType.NVarChar, 1)).Value = "A" 'SABINAS
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

                If Me.RB_MateriasPosgrado.Checked = True Then
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
                                If Me.RB_ExperienciaLaboral.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "E" 'EXPERIENCIA lABORAL
                                Else
                                    If Me.RB_Tesis.Checked = True Then
                                        CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "T" 'TESIS
                                    Else
                                        If Me.RB_Automatico.Checked = True Then
                                            CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "A" 'AUTOMATICO
                                        Else
                                            If Me.RB_AutomaticoPromedio.Checked = True Then
                                                CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "R" 'AUTOMATICO
                                            End If
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
    Sub Cargar_alumnos_titulados()
        Dim sql_cmd_alumnos As SqlCommand
        Dim sql_alumnos_titulados As String
        Dim d_table As DataTable
        Dim d_adapter As SqlDataAdapter
        Dim ds As DataSet
        Try
            Me.SqlConnection1.Open()
            sql_alumnos_titulados = ("Select * from Toma_Protesta")
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
    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        'Call buscar_matricula()
        Call buscar_datos()

    End Sub

    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Call Actualizar_Datos_TP()
        Call nuevo_registro()
    End Sub
    Private Sub Btn_Nuevo_Click(sender As Object, e As EventArgs) Handles Btn_Nuevo.Click
        Call nuevo_registro()
        Btn_Guardar.Enabled = True
        Btn_Actualizar.Enabled = False
    End Sub
    Sub nuevo_registro()
        TBMatricula.Focus()
        TBMatricula.Text = ""
        TBNombre.Text = ""
        TBEdad.Text = ""
        'CBCarrera.Text = ""
        CBSemestre.Text = ""
        CBSexo.Text = ""
        CBHORA_TP.Text = ""
        TB_No_Acta.Text = ""
        TB_Periodo_Generacion.Text = ""
        Btn_Actualizar.Enabled = False
        Btn_Nuevo.Enabled = False
        Btn_Guardar.Enabled = False
        RB_Automatico.Checked = False
        RB_AutomaticoPromedio.Checked = False
        RB_CienciasJuridicas.Checked = False
        RB_Criminologia.Checked = False
        RB_Cuautitlan.Checked = False
        RB_Curso.Checked = False
        RB_Derecho.Checked = False
        RB_DerechoyCjuridicas.Checked = False
        RB_DerechoyCSociales.Checked = False
        RB_Escolaridad.Checked = False
        RB_ExperienciaLaboral.Checked = False
        RB_Linares.Checked = False
        RB_MateriasPosgrado.Checked = False
        RB_Promedio.Checked = False
        RB_Sabinas.Checked = False
        RB_Seminario.Checked = False
        RB_Sepad.Checked = False
        RB_Tesis.Checked = False
    End Sub

    Private Sub Btn_Guardar_Click(sender As Object, e As EventArgs) Handles Btn_Guardar.Click
        Call AGREGAR_ALUMNO_TP()
        Call nuevo_registro()
    End Sub
End Class