Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class FrmSolicitud
    Dim sqlmatricula As New SqlCommand
    Dim sqldrmatricula As SqlDataReader
    Private Sub FrmSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Cargar_alumnos()
    End Sub
    Sub buscar_matricula()
        Try
            Me.SqlConnection1.Open()
            sqlmatricula.CommandType = CommandType.Text
            'sqlmatricula.CommandText = ("select * from Solicitud where AlumnosTitulados.matricula='" & TBMatricula.Text & "'" & "and AlumnosTitulados.Periodo_Escolar='" & CB_Periodo.Text & "'")
            sqlmatricula.CommandText = ("select * from Solicitud where Solicitud.matricula='" & TB_Matricula.Text & "'")
            sqlmatricula.Connection = Me.SqlConnection1
            sqldrmatricula = sqlmatricula.ExecuteReader()
            sqldrmatricula.Read()
            If sqldrmatricula.HasRows Then
                Btn_Actualizar.Enabled = True
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
                'Me.TBNombre.Text = sqldrmatricula("Nombre")

                If IsDBNull(sqldrmatricula("Nombre")) Then
                    Me.TB_Nombre.Text = ""
                Else
                    Me.TB_Nombre.Text = sqldrmatricula("Nombre")
                End If
                If IsDBNull(sqldrmatricula("Apellido_Paterno")) Then
                    Me.TB_Apellido_Paterno.Text = ""
                Else
                    Me.TB_Apellido_Paterno.Text = sqldrmatricula("Apellido_Paterno")
                End If
                If IsDBNull(sqldrmatricula("Apellido_Materno")) Then
                    Me.TB_Apellido_Materno.Text = ""
                Else
                    Me.TB_Apellido_Materno.Text = sqldrmatricula("Apellido_Materno")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Nacimiento")) Then
                    Me.DateTimePicker_Nacimiento.Text = TimeOfDay
                Else
                    Me.DateTimePicker_Nacimiento.Text = sqldrmatricula("Fecha_Nacimiento")
                End If
                If IsDBNull(sqldrmatricula("Sexo")) Then
                    Me.CB_Sexo.Text = ""
                Else
                    Me.CB_Sexo.Text = sqldrmatricula("Sexo")
                End If
                If IsDBNull(sqldrmatricula("Carrera")) Then
                    Me.CB_Carrera.Text = ""
                Else
                    Me.CB_Carrera.Text = sqldrmatricula("Carrera")
                End If
                If IsDBNull(sqldrmatricula("Periodo_Terminacion")) Then
                    Me.CB_Periodo_Termino.Text = ""
                Else
                    Me.CB_Periodo_Termino.Text = sqldrmatricula("Periodo_Terminacion")
                End If
                If IsDBNull(sqldrmatricula("Año_Terminacion")) Then
                    Me.TB_Año_Terminacion.Text = ""
                Else
                    Me.TB_Año_Terminacion.Text = sqldrmatricula("Año_Terminacion")
                End If
               
                If IsDBNull(sqldrmatricula("Dom_Calle")) Then
                    Me.TB_Dom_Calle.Text = ""
                Else
                    Me.TB_Dom_Calle.Text = sqldrmatricula("Dom_Calle")
                End If
                If IsDBNull(sqldrmatricula("Dom_Numero")) Then
                    Me.TB_Dom_Numero.Text = ""
                Else
                    Me.TB_Dom_Numero.Text = sqldrmatricula("Dom_Numero")
                End If
                If IsDBNull(sqldrmatricula("Dom_Colonia")) Then
                    Me.TB_Dom_Colonia.Text = ""
                Else
                    Me.TB_Dom_Colonia.Text = sqldrmatricula("Dom_Colonia")
                End If

                If IsDBNull(sqldrmatricula("Dom_Municipio")) Then
                    Me.TB_Dom_Municipio.Text = ""
                Else
                    Me.TB_Dom_Municipio.Text = sqldrmatricula("Dom_Municipio")
                End If
                If IsDBNull(sqldrmatricula("Dom_Estado")) Then
                    Me.TB_Dom_Estado.Text = ""
                Else
                    Me.TB_Dom_Estado.Text = sqldrmatricula("Dom_Estado")
                End If
                If IsDBNull(sqldrmatricula("Dom_Pais")) Then
                    Me.TB_Dom_Pais.Text = ""
                Else
                    Me.TB_Dom_Pais.Text = sqldrmatricula("Dom_Pais")
                End If
                If IsDBNull(sqldrmatricula("Tel_Movil")) Then
                    Me.TB_Tel_Movil.Text = ""
                Else
                    Me.TB_Tel_Movil.Text = sqldrmatricula("Tel_Movil")
                End If
                If IsDBNull(sqldrmatricula("Tel_Particular")) Then
                    Me.TB_Tel_Particular.Text = ""
                Else
                    Me.TB_Tel_Particular.Text = sqldrmatricula("Tel_Particular")
                End If
                If IsDBNull(sqldrmatricula("Tel_Oficina")) Then
                    Me.TB_Tel_Oficina.Text = ""
                Else
                    Me.TB_Tel_Oficina.Text = sqldrmatricula("Tel_Oficina")
                End If
                If IsDBNull(sqldrmatricula("Fecha_Registro")) Then
                    Me.DateTimePicker_Registro.Text = TimeOfDay
                Else
                    Me.DateTimePicker_Registro.Text = sqldrmatricula("Fecha_Registro")
                End If
                If IsDBNull(sqldrmatricula("Correo_Electronico")) Then
                    Me.TB_Correo_Electronico.Text = ""
                Else
                    Me.TB_Correo_Electronico.Text = sqldrmatricula("Correo_Electronico")
                End If
                If IsDBNull(sqldrmatricula("Modalidad")) Then
                    Me.RB_Promedio.Checked = False
                Else
                    If (sqldrmatricula("Modalidad")) = "P" Then
                        Me.RB_Promedio.Checked = True
                    Else
                        If (sqldrmatricula("Modalidad")) = "C" Then
                            Me.RB_Curso_Induccion_Profesional.Checked = True
                        Else
                            If (sqldrmatricula("Modalidad")) = "S" Then
                                Me.RB_Seminario_Titulacion.Checked = True
                            Else
                                If (sqldrmatricula("Modalidad")) = "T" Then
                                    Me.RB_Tesis_Examen_Profesional.Checked = True
                                Else
                                    If (sqldrmatricula("Modalidad")) = "E" Then
                                        Me.RB_Experiencia_Profesional.Checked = True
                                    Else
                                        If (sqldrmatricula("Modalidad")) = "A" Then
                                            Me.RB_Automatica.Checked = True
                                        Else
                                            If (sqldrmatricula("Modalidad")) = "M" Then
                                                Me.RB_Materias_Posgrado.Checked = True
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Else
                MsgBox("Alumno no existe en Registro ")
                sqldrmatricula.Close()
                Me.SqlConnection1.Close()
                BTN_Guardar.Enabled = True
                Btn_Actualizar.Enabled = False
                'Call buscar_matricula_Otro_Periodo()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        sqldrmatricula.Close()
        Me.SqlConnection1.Close()
    End Sub
    Sub Agregar_Datos_Alumnos_Titulacion()
        Try
            Me.SqlConnection1.Open()
            Dim Agregar_Datos_Tit As String
            Agregar_Datos_Tit = MsgBox("Esta seguro que desa Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Actualizar")
            If Agregar_Datos_Tit = vbYes Then
                'Dim INSDATOS_Titulacion As String = ("UPDATE AlumnosTitulados SET Nombre=@Nombre,Semestre=@Semestre,Carrera=@Carrera,Sexo=@Sexo,Edad=@Edad,No_Acta=@No_Acta,Fecha_Examen=@Fecha_Examen,Sem_Titulacion=@Sem_Titulacion,Sistema=@Sistema,Egresado=@Egresado,Titulado=@Titulado,Modalidad=@Modalidad,Carrera_Titulacion=@Carrera_Titulacion,Fecha_Estimada1=@Fecha_Estimada1,Fecha_Estimada2=@Fecha_Estimada2,No_Oficio=@No_Oficio  WHERE Matricula = '" & TBMatricula.Text & "'" & "AND Periodo_Escolar='" & CB_Periodo.Text & "'")
                Dim INSDATOS_TITULADO As String = "INSERT INTO Solicitud (Matricula,Apellido_Paterno,Apellido_Materno,Nombre,Fecha_Nacimiento,Sexo,Carrera,Periodo_Terminacion,Año_Terminacion,Dom_Calle,Dom_Numero,Dom_Colonia,Dom_Municipio,Dom_Estado,Dom_Pais,Tel_Movil,Tel_Particular,Tel_Oficina,Correo_Electronico,Fecha_Registro,Modalidad) Values (@Matricula,@Apellido_Paterno,@Apellido_Materno,@Nombre,@Fecha_Nacimiento,@Sexo,@Carrera,@Periodo_Terminacion,@Año_Terminacion,@Dom_Calle,@Dom_Numero,@Dom_Colonia,@Dom_Municipio,@Dom_Estado,@Dom_Pais,@Tel_Movil,@Tel_Particular,@Tel_Oficina,@Correo_Electronico,@Fecha_Registro,@Modalidad)"
                Dim CONEXION1 As New SqlClient.SqlCommand(INSDATOS_TITULADO, Me.SqlConnection1)
                CONEXION1.Parameters.Add(New SqlParameter("Matricula", SqlDbType.NChar, 7)).Value = Me.TB_Matricula.Text
                CONEXION1.Parameters.Add(New SqlParameter("Apellido_Paterno", SqlDbType.NVarChar, 20)).Value = Me.TB_Apellido_Paterno.Text
                CONEXION1.Parameters.Add(New SqlParameter("Apellido_Materno", SqlDbType.NVarChar, 20)).Value = Me.TB_Apellido_Materno.Text
                CONEXION1.Parameters.Add(New SqlParameter("Nombre", SqlDbType.NVarChar, 20)).Value = Me.TB_Nombre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Nacimiento", SqlDbType.DateTime)).Value = Me.DateTimePicker_Nacimiento.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sexo", SqlDbType.NChar, 1)).Value = Me.CB_Sexo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Carrera", SqlDbType.NChar, 1)).Value = Me.CB_Carrera.Text
                CONEXION1.Parameters.Add(New SqlParameter("Periodo_Terminacion", SqlDbType.NVarChar, 20)).Value = Me.CB_Periodo_Termino.Text
                CONEXION1.Parameters.Add(New SqlParameter("Año_Terminacion", SqlDbType.NChar, 4)).Value = Me.TB_Año_Terminacion.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Calle", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Calle.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Numero", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Numero.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Colonia", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Colonia.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Municipio", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Municipio.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Estado", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Estado.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Pais", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Pais.Text
                CONEXION1.Parameters.Add(New SqlParameter("Tel_Movil", SqlDbType.NVarChar, 20)).Value = Me.TB_Tel_Movil.Text
                CONEXION1.Parameters.Add(New SqlParameter("Tel_Particular", SqlDbType.NVarChar, 20)).Value = Me.TB_Tel_Particular.Text
                CONEXION1.Parameters.Add(New SqlParameter("Tel_Oficina", SqlDbType.NVarChar, 20)).Value = Me.TB_Tel_Particular.Text
                CONEXION1.Parameters.Add(New SqlParameter("Correo_Electronico", SqlDbType.NVarChar, 50)).Value = Me.TB_Correo_Electronico.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Registro", SqlDbType.DateTime)).Value = Me.DateTimePicker_Registro.Text

                If Me.RB_Promedio.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "P" 'PROMEDIO
                Else
                    If Me.RB_Curso_Induccion_Profesional.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "C" 'CURSO DE INDUCCION AL EJERCICIO PROFESIONAL
                    Else
                        If Me.RB_Seminario_Titulacion.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "S" 'SEMINARIO DE TITULACION
                        Else
                            If Me.RB_Tesis_Examen_Profesional.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "T" 'TESIS
                            Else
                                If Me.RB_Experiencia_Profesional.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "E" 'EXPERIENCIA PROFESIONAL
                                Else
                                    If Me.RB_Automatica.Checked = True Then
                                        CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "A" 'AUTOMATICA
                                    Else
                                        If Me.RB_Materias_Posgrado.Checked = True Then
                                            CONEXION1.Parameters.Add(New SqlParameter("Modalidad", SqlDbType.NVarChar, 1)).Value = "M" 'MATERIAS DE POSGRADO
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
                Call Cargar_alumnos()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub Actualizar_Datos_Alumnos()
        Try
            Me.SqlConnection1.Open()
            Dim Actualizar As String
            Actualizar = MsgBox("Esta seguro que desa Actualizar los datos ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Actualizar")
            If Actualizar = vbYes Then
                'Dim Titulacion As String = ("UPDATE AlumnosTitulados SET Periodo_Escolar=@Periodo_Escolar,Nombre=@Nombre,Semestre=@Semestre,Carrera=@Carrera,Sexo=@Sexo,Edad=@Edad,No_Acta=@No_Acta,Fecha_Examen=@Fecha_Examen,Sem_Titulacion=@Sem_Titulacion,Sistema=@Sistema,Egresado=@Egresado,Titulado=@Titulado,Modalidad=@Modalidad,Carrera_Titulacion=@Carrera_Titulacion,Fecha_Estimada1=@Fecha_Estimada1,Fecha_Estimada2=@Fecha_Estimada2,No_Oficio=@No_Oficio  WHERE Matricula = '" & TBMatricula.Text & "'" & "AND Periodo_Escolar='" & CB_Periodo.Text & "'")
                Dim Titulacion As String = ("UPDATE Solicitud SET Matricula=@Matricula,Apellido_Paterno=@Apellido_Paterno,Apellido_Materno=@Apellido_Materno,Nombre=@Nombre,Fecha_Nacimiento=@Fecha_Nacimiento,Sexo=@Sexo,Carrera=@Carrera,Periodo_Terminacion=@Periodo_Terminacion,Año_Terminacion=@Año_Terminacion,Dom_Calle=@Dom_Calle,Dom_Numero=@Dom_Numero,Dom_Colonia=@Dom_Colonia,Dom_Municipio=@Dom_Municipio,Dom_Estado=@Dom_Estado,Dom_Pais=@Dom_Pais,Tel_Movil=@Tel_Movil,Tel_Particular=@Tel_Particular,Tel_Oficina=@Tel_Oficina,Correo_Electronico=@Correo_Electronico,Fecha_Registro=@Fecha_Registro,Modalidad=@Modalidad  WHERE Matricula = '" & TB_Matricula.Text & "'")
                Dim CONEXION1 As New SqlClient.SqlCommand(Titulacion, Me.SqlConnection1)
                CONEXION1.Parameters.Add(New SqlParameter("Matricula", SqlDbType.NChar, 7)).Value = Me.TB_Matricula.Text
                CONEXION1.Parameters.Add(New SqlParameter("Apellido_Paterno", SqlDbType.NVarChar, 20)).Value = Me.TB_Apellido_Paterno.Text
                CONEXION1.Parameters.Add(New SqlParameter("Apellido_Materno", SqlDbType.NVarChar, 20)).Value = Me.TB_Apellido_Materno.Text
                CONEXION1.Parameters.Add(New SqlParameter("Nombre", SqlDbType.NVarChar, 20)).Value = Me.TB_Nombre.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Nacimiento", SqlDbType.DateTime)).Value = Me.DateTimePicker_Nacimiento.Text
                CONEXION1.Parameters.Add(New SqlParameter("Sexo", SqlDbType.NChar, 1)).Value = Me.CB_Sexo.Text
                CONEXION1.Parameters.Add(New SqlParameter("Carrera", SqlDbType.NChar, 1)).Value = Me.CB_Carrera.Text
                CONEXION1.Parameters.Add(New SqlParameter("Periodo_Terminacion", SqlDbType.NVarChar, 20)).Value = Me.CB_Periodo_Termino.Text
                CONEXION1.Parameters.Add(New SqlParameter("Año_Terminacion", SqlDbType.NChar, 4)).Value = Me.TB_Año_Terminacion.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Calle", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Calle.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Numero", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Numero.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Colonia", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Colonia.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Municipio", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Municipio.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Estado", SqlDbType.NVarChar, 20)).Value = Me.TB_Dom_Estado.Text
                CONEXION1.Parameters.Add(New SqlParameter("Dom_Pais", SqlDbType.NVarChar, 10)).Value = Me.TB_Dom_Pais.Text
                CONEXION1.Parameters.Add(New SqlParameter("Tel_Movil", SqlDbType.NVarChar, 20)).Value = Me.TB_Tel_Movil.Text
                CONEXION1.Parameters.Add(New SqlParameter("Tel_Particular", SqlDbType.NVarChar, 20)).Value = Me.TB_Tel_Particular.Text
                CONEXION1.Parameters.Add(New SqlParameter("Tel_Oficina", SqlDbType.NVarChar, 20)).Value = Me.TB_Tel_Oficina.Text
                CONEXION1.Parameters.Add(New SqlParameter("Correo_Electronico", SqlDbType.NVarChar, 50)).Value = Me.TB_Correo_Electronico.Text
                CONEXION1.Parameters.Add(New SqlParameter("Fecha_Registro", SqlDbType.DateTime)).Value = Me.DateTimePicker_Registro.Text

                If Me.RB_Promedio.Checked = True Then
                    CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "P" 'PROMEDIO
                Else
                    If Me.RB_Curso_Induccion_Profesional.Checked = True Then
                        CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "C" 'CURSO DE INDUCCION AL EJERCICIO
                    Else
                        If Me.RB_Seminario_Titulacion.Checked = True Then
                            CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "S" 'SEMINARIO DE TITULACION
                        Else
                            If Me.RB_Tesis_Examen_Profesional.Checked = True Then
                                CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "T" 'TESIS
                            Else
                                If Me.RB_Experiencia_Profesional.Checked = True Then
                                    CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "E" 'EXPERIENCIA PROFESIONAL
                                Else
                                    If Me.RB_Automatica.Checked = True Then
                                        CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "A" 'AUTOMATICA
                                    Else
                                        If Me.RB_Materias_Posgrado.Checked = True Then
                                            CONEXION1.Parameters.Add(New SqlParameter("@Modalidad", SqlDbType.NVarChar, 1)).Value = "M" 'MATERIAS DE POSGRADO
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
                Call Cargar_alumnos()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub BTN_Guardar_Click(sender As Object, e As EventArgs) Handles BTN_Guardar.Click
        Call Agregar_Datos_Alumnos_Titulacion()
        Call Limpiar_campos()
        Btn_Actualizar.Enabled = False
        BTN_Guardar.Enabled = False
        'TB_Matricula.Text = ""
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        Call buscar_matricula()
    End Sub
    Sub Cargar_alumnos()
        Dim sql_cmd_alumnos As SqlCommand
        Dim sql_alumnos_titulados As String
        Dim d_table As DataTable
        Dim d_adapter As SqlDataAdapter
        Dim ds As DataSet
        Try
            Me.SqlConnection1.Open()
            'sql_alumnos_titulados = ("Select * from Solicitud where Periodo_Escolar= '" & CB_Periodo.Text & "'")
            sql_alumnos_titulados = ("Select * from Solicitud ")
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
    Sub Limpiar_campos()
        TB_Matricula.Text = ""
        TB_Apellido_Materno.Text = ""
        TB_Apellido_Paterno.Text = ""
        TB_Nombre.Text = ""
        DateTimePicker_Nacimiento.Text = ""
        CB_Sexo.Text = ""
        CB_Carrera.Text = ""
        CB_Periodo_Termino.Text = ""
        TB_Año_Terminacion.Text = ""
        TB_Dom_Calle.Text = ""
        TB_Dom_Numero.Text = ""
        TB_Dom_Colonia.Text = ""
        TB_Dom_Municipio.Text = ""
        TB_Dom_Estado.Text = ""
        TB_Dom_Pais.Text = ""
        TB_Tel_Movil.Text = ""
        TB_Tel_Oficina.Text = ""
        TB_Tel_Particular.Text = ""
        TB_Correo_Electronico.Text = ""
        RB_Promedio.Checked = "0"
        RB_Curso_Induccion_Profesional.Checked = "0"
        RB_Seminario_Titulacion.Checked = "0"
        RB_Tesis_Examen_Profesional.Checked = "0"
        RB_Experiencia_Profesional.Checked = "0"
        RB_Automatica.Checked = "0"
        RB_Materias_Posgrado.Checked = "0"
        'RB_Promedio.Enabled = False
        'RB_Sabinas.Enabled = False
        'RB_Seminario.Enabled = False
        'RB_Sepad.Enabled = False
        'RB_Tesis.Enabled = False
        'RB_Titulado.Enabled = False
        'Btn_Actualizar.Enabled = False
        'BTN_Guardar.Enabled = False
        DateTimePicker_Registro.Text = TimeOfDay
        Me.TB_Matricula.Focus()
    End Sub
    Private Sub Btn_Actualizar_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click
        Call Actualizar_Datos_Alumnos()
        Call Limpiar_campos()
        Btn_Actualizar.Enabled = False
        BTN_Guardar.Enabled = False
        Me.TB_Matricula.Focus()
    End Sub
End Class