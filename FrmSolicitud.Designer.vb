<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSolicitud
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
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RB_Automatica = New System.Windows.Forms.RadioButton()
        Me.RB_Experiencia_Profesional = New System.Windows.Forms.RadioButton()
        Me.RB_Tesis_Examen_Profesional = New System.Windows.Forms.RadioButton()
        Me.RB_Materias_Posgrado = New System.Windows.Forms.RadioButton()
        Me.RB_Curso_Induccion_Profesional = New System.Windows.Forms.RadioButton()
        Me.RB_Promedio = New System.Windows.Forms.RadioButton()
        Me.RB_Seminario_Titulacion = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TB_Correo_Electronico = New System.Windows.Forms.TextBox()
        Me.TB_Tel_Oficina = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TB_Tel_Particular = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TB_Tel_Movil = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_Dom_Pais = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TB_Dom_Colonia = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TB_Dom_Estado = New System.Windows.Forms.TextBox()
        Me.TB_Dom_Numero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TB_Dom_Municipio = New System.Windows.Forms.TextBox()
        Me.TB_Dom_Calle = New System.Windows.Forms.TextBox()
        Me.TB_Apellido_Materno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CB_Periodo_Termino = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CB_Sexo = New System.Windows.Forms.ComboBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_Año_Terminacion = New System.Windows.Forms.TextBox()
        Me.CB_Carrera = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker_Nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TB_Apellido_Paterno = New System.Windows.Forms.TextBox()
        Me.TB_Matricula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker_Registro = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.Enabled = False
        Me.BTN_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Guardar.Location = New System.Drawing.Point(35, 15)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.Size = New System.Drawing.Size(109, 30)
        Me.BTN_Guardar.TabIndex = 21
        Me.BTN_Guardar.Text = "Guardar"
        Me.BTN_Guardar.UseVisualStyleBackColor = True
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Enabled = False
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.Location = New System.Drawing.Point(775, 15)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(89, 30)
        Me.Btn_Actualizar.TabIndex = 22
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(34, 540)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(831, 176)
        Me.DataGridView1.TabIndex = 20
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.RB_Automatica)
        Me.GroupBox5.Controls.Add(Me.RB_Experiencia_Profesional)
        Me.GroupBox5.Controls.Add(Me.RB_Tesis_Examen_Profesional)
        Me.GroupBox5.Controls.Add(Me.RB_Materias_Posgrado)
        Me.GroupBox5.Controls.Add(Me.RB_Curso_Induccion_Profesional)
        Me.GroupBox5.Controls.Add(Me.RB_Promedio)
        Me.GroupBox5.Controls.Add(Me.RB_Seminario_Titulacion)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(35, 442)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(829, 96)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Modalidad:"
        '
        'RB_Automatica
        '
        Me.RB_Automatica.AutoSize = True
        Me.RB_Automatica.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Automatica.Location = New System.Drawing.Point(625, 24)
        Me.RB_Automatica.Name = "RB_Automatica"
        Me.RB_Automatica.Size = New System.Drawing.Size(95, 17)
        Me.RB_Automatica.TabIndex = 64
        Me.RB_Automatica.TabStop = True
        Me.RB_Automatica.Text = "AUTOMÁTICA"
        Me.RB_Automatica.UseVisualStyleBackColor = True
        '
        'RB_Experiencia_Profesional
        '
        Me.RB_Experiencia_Profesional.AutoSize = True
        Me.RB_Experiencia_Profesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Experiencia_Profesional.Location = New System.Drawing.Point(371, 48)
        Me.RB_Experiencia_Profesional.Name = "RB_Experiencia_Profesional"
        Me.RB_Experiencia_Profesional.Size = New System.Drawing.Size(174, 17)
        Me.RB_Experiencia_Profesional.TabIndex = 63
        Me.RB_Experiencia_Profesional.TabStop = True
        Me.RB_Experiencia_Profesional.Text = "EXPERIENCIA PROFESIONAL"
        Me.RB_Experiencia_Profesional.UseVisualStyleBackColor = True
        '
        'RB_Tesis_Examen_Profesional
        '
        Me.RB_Tesis_Examen_Profesional.AutoSize = True
        Me.RB_Tesis_Examen_Profesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Tesis_Examen_Profesional.Location = New System.Drawing.Point(371, 24)
        Me.RB_Tesis_Examen_Profesional.Name = "RB_Tesis_Examen_Profesional"
        Me.RB_Tesis_Examen_Profesional.Size = New System.Drawing.Size(188, 17)
        Me.RB_Tesis_Examen_Profesional.TabIndex = 63
        Me.RB_Tesis_Examen_Profesional.TabStop = True
        Me.RB_Tesis_Examen_Profesional.Text = "TESIS (EXAMEN PROFESIONAL)"
        Me.RB_Tesis_Examen_Profesional.UseVisualStyleBackColor = True
        '
        'RB_Materias_Posgrado
        '
        Me.RB_Materias_Posgrado.AutoSize = True
        Me.RB_Materias_Posgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Materias_Posgrado.Location = New System.Drawing.Point(625, 51)
        Me.RB_Materias_Posgrado.Name = "RB_Materias_Posgrado"
        Me.RB_Materias_Posgrado.Size = New System.Drawing.Size(162, 17)
        Me.RB_Materias_Posgrado.TabIndex = 65
        Me.RB_Materias_Posgrado.TabStop = True
        Me.RB_Materias_Posgrado.Text = "MATERIAS DE POSGRADO"
        Me.RB_Materias_Posgrado.UseVisualStyleBackColor = True
        '
        'RB_Curso_Induccion_Profesional
        '
        Me.RB_Curso_Induccion_Profesional.AutoSize = True
        Me.RB_Curso_Induccion_Profesional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Curso_Induccion_Profesional.Location = New System.Drawing.Point(21, 48)
        Me.RB_Curso_Induccion_Profesional.Name = "RB_Curso_Induccion_Profesional"
        Me.RB_Curso_Induccion_Profesional.Size = New System.Drawing.Size(296, 17)
        Me.RB_Curso_Induccion_Profesional.TabIndex = 61
        Me.RB_Curso_Induccion_Profesional.TabStop = True
        Me.RB_Curso_Induccion_Profesional.Text = "CURSO DE INDUCCION AL EJERCICIO PROFESIONAL"
        Me.RB_Curso_Induccion_Profesional.UseVisualStyleBackColor = True
        '
        'RB_Promedio
        '
        Me.RB_Promedio.AutoSize = True
        Me.RB_Promedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Promedio.Location = New System.Drawing.Point(21, 24)
        Me.RB_Promedio.Name = "RB_Promedio"
        Me.RB_Promedio.Size = New System.Drawing.Size(83, 17)
        Me.RB_Promedio.TabIndex = 60
        Me.RB_Promedio.TabStop = True
        Me.RB_Promedio.Text = "PROMEDIO"
        Me.RB_Promedio.UseVisualStyleBackColor = True
        '
        'RB_Seminario_Titulacion
        '
        Me.RB_Seminario_Titulacion.AutoSize = True
        Me.RB_Seminario_Titulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Seminario_Titulacion.Location = New System.Drawing.Point(21, 72)
        Me.RB_Seminario_Titulacion.Name = "RB_Seminario_Titulacion"
        Me.RB_Seminario_Titulacion.Size = New System.Drawing.Size(170, 17)
        Me.RB_Seminario_Titulacion.TabIndex = 62
        Me.RB_Seminario_Titulacion.TabStop = True
        Me.RB_Seminario_Titulacion.Text = "SEMINARIO DE TITULACION"
        Me.RB_Seminario_Titulacion.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.TB_Correo_Electronico)
        Me.GroupBox6.Controls.Add(Me.TB_Tel_Oficina)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.TB_Tel_Particular)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.TB_Tel_Movil)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TB_Dom_Pais)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.TB_Dom_Colonia)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.TB_Dom_Estado)
        Me.GroupBox6.Controls.Add(Me.TB_Dom_Numero)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.TB_Dom_Municipio)
        Me.GroupBox6.Controls.Add(Me.TB_Dom_Calle)
        Me.GroupBox6.Controls.Add(Me.TB_Apellido_Materno)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.CB_Periodo_Termino)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.CB_Sexo)
        Me.GroupBox6.Controls.Add(Me.BtnMostrar)
        Me.GroupBox6.Controls.Add(Me.TB_Nombre)
        Me.GroupBox6.Controls.Add(Me.TB_Año_Terminacion)
        Me.GroupBox6.Controls.Add(Me.CB_Carrera)
        Me.GroupBox6.Controls.Add(Me.DateTimePicker_Nacimiento)
        Me.GroupBox6.Controls.Add(Me.TB_Apellido_Paterno)
        Me.GroupBox6.Controls.Add(Me.TB_Matricula)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(16, 70)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(868, 354)
        Me.GroupBox6.TabIndex = 78
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del Alumno"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(673, 285)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 101
        Me.Label20.Text = "Oficina:"
        '
        'TB_Correo_Electronico
        '
        Me.TB_Correo_Electronico.Location = New System.Drawing.Point(272, 312)
        Me.TB_Correo_Electronico.Name = "TB_Correo_Electronico"
        Me.TB_Correo_Electronico.Size = New System.Drawing.Size(376, 20)
        Me.TB_Correo_Electronico.TabIndex = 98
        '
        'TB_Tel_Oficina
        '
        Me.TB_Tel_Oficina.Location = New System.Drawing.Point(557, 260)
        Me.TB_Tel_Oficina.Name = "TB_Tel_Oficina"
        Me.TB_Tel_Oficina.Size = New System.Drawing.Size(292, 20)
        Me.TB_Tel_Oficina.TabIndex = 18
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(128, 315)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(135, 13)
        Me.Label24.TabIndex = 99
        Me.Label24.Text = "CORREO ELECTRONICO:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(438, 285)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 13)
        Me.Label21.TabIndex = 99
        Me.Label21.Text = "Particular:"
        '
        'TB_Tel_Particular
        '
        Me.TB_Tel_Particular.Location = New System.Drawing.Point(390, 260)
        Me.TB_Tel_Particular.Name = "TB_Tel_Particular"
        Me.TB_Tel_Particular.Size = New System.Drawing.Size(153, 20)
        Me.TB_Tel_Particular.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(209, 285)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 13)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "Movil:"
        '
        'TB_Tel_Movil
        '
        Me.TB_Tel_Movil.Location = New System.Drawing.Point(96, 259)
        Me.TB_Tel_Movil.Name = "TB_Tel_Movil"
        Me.TB_Tel_Movil.Size = New System.Drawing.Size(287, 20)
        Me.TB_Tel_Movil.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 13)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "TELEFONO (S):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(672, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 95
        Me.Label11.Text = "Pais:"
        '
        'TB_Dom_Pais
        '
        Me.TB_Dom_Pais.Location = New System.Drawing.Point(556, 215)
        Me.TB_Dom_Pais.Name = "TB_Dom_Pais"
        Me.TB_Dom_Pais.Size = New System.Drawing.Size(293, 20)
        Me.TB_Dom_Pais.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(437, 237)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 93
        Me.Label17.Text = "Estado:"
        '
        'TB_Dom_Colonia
        '
        Me.TB_Dom_Colonia.Location = New System.Drawing.Point(477, 168)
        Me.TB_Dom_Colonia.Name = "TB_Dom_Colonia"
        Me.TB_Dom_Colonia.Size = New System.Drawing.Size(287, 20)
        Me.TB_Dom_Colonia.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(586, 190)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 89
        Me.Label16.Text = "Colonia:"
        '
        'TB_Dom_Estado
        '
        Me.TB_Dom_Estado.Location = New System.Drawing.Point(390, 214)
        Me.TB_Dom_Estado.Name = "TB_Dom_Estado"
        Me.TB_Dom_Estado.Size = New System.Drawing.Size(153, 20)
        Me.TB_Dom_Estado.TabIndex = 14
        '
        'TB_Dom_Numero
        '
        Me.TB_Dom_Numero.Location = New System.Drawing.Point(390, 168)
        Me.TB_Dom_Numero.Name = "TB_Dom_Numero"
        Me.TB_Dom_Numero.Size = New System.Drawing.Size(65, 20)
        Me.TB_Dom_Numero.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(418, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "No:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(208, 236)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "Municipio:"
        '
        'TB_Dom_Municipio
        '
        Me.TB_Dom_Municipio.Location = New System.Drawing.Point(96, 214)
        Me.TB_Dom_Municipio.Name = "TB_Dom_Municipio"
        Me.TB_Dom_Municipio.Size = New System.Drawing.Size(287, 20)
        Me.TB_Dom_Municipio.TabIndex = 13
        '
        'TB_Dom_Calle
        '
        Me.TB_Dom_Calle.Location = New System.Drawing.Point(96, 168)
        Me.TB_Dom_Calle.Name = "TB_Dom_Calle"
        Me.TB_Dom_Calle.Size = New System.Drawing.Size(287, 20)
        Me.TB_Dom_Calle.TabIndex = 10
        '
        'TB_Apellido_Materno
        '
        Me.TB_Apellido_Materno.Location = New System.Drawing.Point(384, 61)
        Me.TB_Apellido_Materno.Name = "TB_Apellido_Materno"
        Me.TB_Apellido_Materno.Size = New System.Drawing.Size(185, 20)
        Me.TB_Apellido_Materno.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Calle:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(294, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Apelldio Materno:"
        '
        'CB_Periodo_Termino
        '
        Me.CB_Periodo_Termino.FormattingEnabled = True
        Me.CB_Periodo_Termino.Items.AddRange(New Object() {"ENE-JULIO", "AGO-DIC"})
        Me.CB_Periodo_Termino.Location = New System.Drawing.Point(413, 130)
        Me.CB_Periodo_Termino.Name = "CB_Periodo_Termino"
        Me.CB_Periodo_Termino.Size = New System.Drawing.Size(218, 21)
        Me.CB_Periodo_Termino.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "DOMICILIO:"
        '
        'CB_Sexo
        '
        Me.CB_Sexo.FormattingEnabled = True
        Me.CB_Sexo.Items.AddRange(New Object() {"M", "F"})
        Me.CB_Sexo.Location = New System.Drawing.Point(437, 97)
        Me.CB_Sexo.Name = "CB_Sexo"
        Me.CB_Sexo.Size = New System.Drawing.Size(59, 21)
        Me.CB_Sexo.TabIndex = 6
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.Location = New System.Drawing.Point(739, 16)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(26, 27)
        Me.BtnMostrar.TabIndex = 43
        Me.BtnMostrar.Text = "..."
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(645, 60)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(205, 20)
        Me.TB_Nombre.TabIndex = 4
        '
        'TB_Año_Terminacion
        '
        Me.TB_Año_Terminacion.Location = New System.Drawing.Point(675, 129)
        Me.TB_Año_Terminacion.Name = "TB_Año_Terminacion"
        Me.TB_Año_Terminacion.Size = New System.Drawing.Size(47, 20)
        Me.TB_Año_Terminacion.TabIndex = 9
        '
        'CB_Carrera
        '
        Me.CB_Carrera.FormattingEnabled = True
        Me.CB_Carrera.Items.AddRange(New Object() {"D", "C"})
        Me.CB_Carrera.Location = New System.Drawing.Point(565, 97)
        Me.CB_Carrera.Name = "CB_Carrera"
        Me.CB_Carrera.Size = New System.Drawing.Size(62, 21)
        Me.CB_Carrera.TabIndex = 7
        '
        'DateTimePicker_Nacimiento
        '
        Me.DateTimePicker_Nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Nacimiento.Location = New System.Drawing.Point(133, 97)
        Me.DateTimePicker_Nacimiento.Name = "DateTimePicker_Nacimiento"
        Me.DateTimePicker_Nacimiento.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePicker_Nacimiento.TabIndex = 5
        '
        'TB_Apellido_Paterno
        '
        Me.TB_Apellido_Paterno.Location = New System.Drawing.Point(103, 60)
        Me.TB_Apellido_Paterno.Name = "TB_Apellido_Paterno"
        Me.TB_Apellido_Paterno.Size = New System.Drawing.Size(185, 20)
        Me.TB_Apellido_Paterno.TabIndex = 2
        '
        'TB_Matricula
        '
        Me.TB_Matricula.Location = New System.Drawing.Point(644, 20)
        Me.TB_Matricula.MaxLength = 7
        Me.TB_Matricula.Multiline = True
        Me.TB_Matricula.Name = "TB_Matricula"
        Me.TB_Matricula.Size = New System.Drawing.Size(89, 20)
        Me.TB_Matricula.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(395, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "AÑO DEL PERIODO ESCOLAR QUE TERMINO ESTUDIOS DE LICENCIATURA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(581, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Nombre(s):"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(397, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(642, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(515, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carrera:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Nacimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(587, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Matricula:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(389, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Fecha de Registro:"
        '
        'DateTimePicker_Registro
        '
        Me.DateTimePicker_Registro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Registro.Location = New System.Drawing.Point(324, 25)
        Me.DateTimePicker_Registro.Name = "DateTimePicker_Registro"
        Me.DateTimePicker_Registro.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePicker_Registro.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(285, 427)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(334, 13)
        Me.Label23.TabIndex = 85
        Me.Label23.Text = "MARQUE LA MODALIDAD DE TITULACIÓN QUE ELIGIÓ:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=Titulacion;User ID=sa;Password=Facdyc2" &
    "020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'FrmSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(896, 717)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Controls.Add(Me.DateTimePicker_Registro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Name = "FrmSolicitud"
        Me.Text = "Solicitud para tramite de titulacion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTN_Guardar As System.Windows.Forms.Button
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Automatica As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Experiencia_Profesional As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Tesis_Examen_Profesional As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Materias_Posgrado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Curso_Induccion_Profesional As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Promedio As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Seminario_Titulacion As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_Apellido_Materno As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CB_Periodo_Termino As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker_Registro As System.Windows.Forms.DateTimePicker
    Friend WithEvents CB_Sexo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents TB_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TB_Año_Terminacion As System.Windows.Forms.TextBox
    Friend WithEvents CB_Carrera As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker_Nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents TB_Apellido_Paterno As System.Windows.Forms.TextBox
    Friend WithEvents TB_Matricula As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TB_Tel_Oficina As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TB_Tel_Particular As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents TB_Tel_Movil As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TB_Dom_Pais As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TB_Dom_Colonia As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TB_Dom_Estado As System.Windows.Forms.TextBox
    Friend WithEvents TB_Dom_Numero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TB_Dom_Municipio As System.Windows.Forms.TextBox
    Friend WithEvents TB_Dom_Calle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents TB_Correo_Electronico As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
