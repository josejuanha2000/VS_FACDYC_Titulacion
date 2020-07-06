<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Datos_Alumnos
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
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RB_Tesis = New System.Windows.Forms.RadioButton()
        Me.RB_Promedio = New System.Windows.Forms.RadioButton()
        Me.RB_Experiencia_Laboral = New System.Windows.Forms.RadioButton()
        Me.RB_Automatico = New System.Windows.Forms.RadioButton()
        Me.RB_Seminario = New System.Windows.Forms.RadioButton()
        Me.RB_Materias_Posgrado = New System.Windows.Forms.RadioButton()
        Me.RB_Curso = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CB_Periodo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RB_Titulado = New System.Windows.Forms.RadioButton()
        Me.RB_Egresados = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_Cuautitlan = New System.Windows.Forms.RadioButton()
        Me.RB_Linares = New System.Windows.Forms.RadioButton()
        Me.RB_Sepad = New System.Windows.Forms.RadioButton()
        Me.RB_Sabinas = New System.Windows.Forms.RadioButton()
        Me.RB_Escolaridad = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBHORA_TP = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimePickerAcreditacion = New System.Windows.Forms.DateTimePicker()
        Me.TBNoOficio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBCarreraTitulacion = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DateTimePickerEst2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePickerEst1 = New System.Windows.Forms.DateTimePicker()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TB_No_Acta = New System.Windows.Forms.TextBox()
        Me.TB_Periodo_Generacion = New System.Windows.Forms.TextBox()
        Me.TBEdad = New System.Windows.Forms.TextBox()
        Me.CBSemestre = New System.Windows.Forms.ComboBox()
        Me.CBCarrera = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBMatricula = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.Btn_Oficio_Titulacion = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTN_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.RB_Tesis)
        Me.GroupBox5.Controls.Add(Me.RB_Promedio)
        Me.GroupBox5.Controls.Add(Me.RB_Experiencia_Laboral)
        Me.GroupBox5.Controls.Add(Me.RB_Automatico)
        Me.GroupBox5.Controls.Add(Me.RB_Seminario)
        Me.GroupBox5.Controls.Add(Me.RB_Materias_Posgrado)
        Me.GroupBox5.Controls.Add(Me.RB_Curso)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(346, 297)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(469, 132)
        Me.GroupBox5.TabIndex = 62
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Modalidad:"
        '
        'RB_Tesis
        '
        Me.RB_Tesis.AutoSize = True
        Me.RB_Tesis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Tesis.Location = New System.Drawing.Point(222, 48)
        Me.RB_Tesis.Name = "RB_Tesis"
        Me.RB_Tesis.Size = New System.Drawing.Size(50, 17)
        Me.RB_Tesis.TabIndex = 64
        Me.RB_Tesis.TabStop = True
        Me.RB_Tesis.Text = "Tesis"
        Me.RB_Tesis.UseVisualStyleBackColor = True
        '
        'RB_Promedio
        '
        Me.RB_Promedio.AutoSize = True
        Me.RB_Promedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Promedio.Location = New System.Drawing.Point(21, 95)
        Me.RB_Promedio.Name = "RB_Promedio"
        Me.RB_Promedio.Size = New System.Drawing.Size(69, 17)
        Me.RB_Promedio.TabIndex = 63
        Me.RB_Promedio.TabStop = True
        Me.RB_Promedio.Text = "Promedio"
        Me.RB_Promedio.UseVisualStyleBackColor = True
        '
        'RB_Experiencia_Laboral
        '
        Me.RB_Experiencia_Laboral.AutoSize = True
        Me.RB_Experiencia_Laboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Experiencia_Laboral.Location = New System.Drawing.Point(221, 24)
        Me.RB_Experiencia_Laboral.Name = "RB_Experiencia_Laboral"
        Me.RB_Experiencia_Laboral.Size = New System.Drawing.Size(118, 17)
        Me.RB_Experiencia_Laboral.TabIndex = 63
        Me.RB_Experiencia_Laboral.TabStop = True
        Me.RB_Experiencia_Laboral.Text = "Experiencia Laboral"
        Me.RB_Experiencia_Laboral.UseVisualStyleBackColor = True
        '
        'RB_Automatico
        '
        Me.RB_Automatico.AutoSize = True
        Me.RB_Automatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Automatico.Location = New System.Drawing.Point(222, 72)
        Me.RB_Automatico.Name = "RB_Automatico"
        Me.RB_Automatico.Size = New System.Drawing.Size(78, 17)
        Me.RB_Automatico.TabIndex = 65
        Me.RB_Automatico.TabStop = True
        Me.RB_Automatico.Text = "Automatico"
        Me.RB_Automatico.UseVisualStyleBackColor = True
        '
        'RB_Seminario
        '
        Me.RB_Seminario.AutoSize = True
        Me.RB_Seminario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Seminario.Location = New System.Drawing.Point(21, 48)
        Me.RB_Seminario.Name = "RB_Seminario"
        Me.RB_Seminario.Size = New System.Drawing.Size(71, 17)
        Me.RB_Seminario.TabIndex = 61
        Me.RB_Seminario.TabStop = True
        Me.RB_Seminario.Text = "Seminario"
        Me.RB_Seminario.UseVisualStyleBackColor = True
        '
        'RB_Materias_Posgrado
        '
        Me.RB_Materias_Posgrado.AutoSize = True
        Me.RB_Materias_Posgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Materias_Posgrado.Location = New System.Drawing.Point(21, 24)
        Me.RB_Materias_Posgrado.Name = "RB_Materias_Posgrado"
        Me.RB_Materias_Posgrado.Size = New System.Drawing.Size(113, 17)
        Me.RB_Materias_Posgrado.TabIndex = 60
        Me.RB_Materias_Posgrado.TabStop = True
        Me.RB_Materias_Posgrado.Text = "Materias Posgrado"
        Me.RB_Materias_Posgrado.UseVisualStyleBackColor = True
        '
        'RB_Curso
        '
        Me.RB_Curso.AutoSize = True
        Me.RB_Curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Curso.Location = New System.Drawing.Point(21, 72)
        Me.RB_Curso.Name = "RB_Curso"
        Me.RB_Curso.Size = New System.Drawing.Size(52, 17)
        Me.RB_Curso.TabIndex = 62
        Me.RB_Curso.TabStop = True
        Me.RB_Curso.Text = "Curso"
        Me.RB_Curso.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CB_Periodo)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(327, 49)
        Me.GroupBox4.TabIndex = 58
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seleccione el Periodo:"
        '
        'CB_Periodo
        '
        Me.CB_Periodo.FormattingEnabled = True
        Me.CB_Periodo.Location = New System.Drawing.Point(208, 19)
        Me.CB_Periodo.Name = "CB_Periodo"
        Me.CB_Periodo.Size = New System.Drawing.Size(98, 21)
        Me.CB_Periodo.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(102, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Periodo Escolar:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.RB_Titulado)
        Me.GroupBox3.Controls.Add(Me.RB_Egresados)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(199, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(132, 132)
        Me.GroupBox3.TabIndex = 61
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'RB_Titulado
        '
        Me.RB_Titulado.AutoSize = True
        Me.RB_Titulado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Titulado.Location = New System.Drawing.Point(31, 84)
        Me.RB_Titulado.Name = "RB_Titulado"
        Me.RB_Titulado.Size = New System.Drawing.Size(63, 17)
        Me.RB_Titulado.TabIndex = 61
        Me.RB_Titulado.TabStop = True
        Me.RB_Titulado.Text = "Titulado"
        Me.RB_Titulado.UseVisualStyleBackColor = True
        '
        'RB_Egresados
        '
        Me.RB_Egresados.AutoSize = True
        Me.RB_Egresados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Egresados.Location = New System.Drawing.Point(31, 37)
        Me.RB_Egresados.Name = "RB_Egresados"
        Me.RB_Egresados.Size = New System.Drawing.Size(70, 17)
        Me.RB_Egresados.TabIndex = 60
        Me.RB_Egresados.TabStop = True
        Me.RB_Egresados.Text = "Egresado"
        Me.RB_Egresados.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.RB_Cuautitlan)
        Me.GroupBox2.Controls.Add(Me.RB_Linares)
        Me.GroupBox2.Controls.Add(Me.RB_Sepad)
        Me.GroupBox2.Controls.Add(Me.RB_Sabinas)
        Me.GroupBox2.Controls.Add(Me.RB_Escolaridad)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 297)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 156)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sistema:"
        '
        'RB_Cuautitlan
        '
        Me.RB_Cuautitlan.AutoSize = True
        Me.RB_Cuautitlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Cuautitlan.Location = New System.Drawing.Point(16, 131)
        Me.RB_Cuautitlan.Name = "RB_Cuautitlan"
        Me.RB_Cuautitlan.Size = New System.Drawing.Size(72, 17)
        Me.RB_Cuautitlan.TabIndex = 67
        Me.RB_Cuautitlan.TabStop = True
        Me.RB_Cuautitlan.Text = "Cuautitlan"
        Me.RB_Cuautitlan.UseVisualStyleBackColor = True
        '
        'RB_Linares
        '
        Me.RB_Linares.AutoSize = True
        Me.RB_Linares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Linares.Location = New System.Drawing.Point(15, 104)
        Me.RB_Linares.Name = "RB_Linares"
        Me.RB_Linares.Size = New System.Drawing.Size(59, 17)
        Me.RB_Linares.TabIndex = 59
        Me.RB_Linares.TabStop = True
        Me.RB_Linares.Text = "Linares"
        Me.RB_Linares.UseVisualStyleBackColor = True
        '
        'RB_Sepad
        '
        Me.RB_Sepad.AutoSize = True
        Me.RB_Sepad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Sepad.Location = New System.Drawing.Point(14, 48)
        Me.RB_Sepad.Name = "RB_Sepad"
        Me.RB_Sepad.Size = New System.Drawing.Size(56, 17)
        Me.RB_Sepad.TabIndex = 45
        Me.RB_Sepad.TabStop = True
        Me.RB_Sepad.Text = "Sepad"
        Me.RB_Sepad.UseVisualStyleBackColor = True
        '
        'RB_Sabinas
        '
        Me.RB_Sabinas.AutoSize = True
        Me.RB_Sabinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Sabinas.Location = New System.Drawing.Point(14, 78)
        Me.RB_Sabinas.Name = "RB_Sabinas"
        Me.RB_Sabinas.Size = New System.Drawing.Size(63, 17)
        Me.RB_Sabinas.TabIndex = 58
        Me.RB_Sabinas.TabStop = True
        Me.RB_Sabinas.Text = "Sabinas"
        Me.RB_Sabinas.UseVisualStyleBackColor = True
        '
        'RB_Escolaridad
        '
        Me.RB_Escolaridad.AutoSize = True
        Me.RB_Escolaridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Escolaridad.Location = New System.Drawing.Point(14, 24)
        Me.RB_Escolaridad.Name = "RB_Escolaridad"
        Me.RB_Escolaridad.Size = New System.Drawing.Size(80, 17)
        Me.RB_Escolaridad.TabIndex = 14
        Me.RB_Escolaridad.TabStop = True
        Me.RB_Escolaridad.Text = "Escolaridad"
        Me.RB_Escolaridad.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.CBHORA_TP)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerAcreditacion)
        Me.GroupBox1.Controls.Add(Me.TBNoOficio)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CBCarreraTitulacion)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEst2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEst1)
        Me.GroupBox1.Controls.Add(Me.CBSexo)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.TB_No_Acta)
        Me.GroupBox1.Controls.Add(Me.TB_Periodo_Generacion)
        Me.GroupBox1.Controls.Add(Me.TBEdad)
        Me.GroupBox1.Controls.Add(Me.CBSemestre)
        Me.GroupBox1.Controls.Add(Me.CBCarrera)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.TBMatricula)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(803, 229)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Alumno"
        '
        'CBHORA_TP
        '
        Me.CBHORA_TP.FormattingEnabled = True
        Me.CBHORA_TP.Items.AddRange(New Object() {"0700", "0800", "0900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000", "2100"})
        Me.CBHORA_TP.Location = New System.Drawing.Point(311, 163)
        Me.CBHORA_TP.Name = "CBHORA_TP"
        Me.CBHORA_TP.Size = New System.Drawing.Size(87, 21)
        Me.CBHORA_TP.TabIndex = 56
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(299, 145)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Hora de Toma Protesta"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(552, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(159, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Fecha de Oficio de Acreditacion"
        '
        'DateTimePickerAcreditacion
        '
        Me.DateTimePickerAcreditacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerAcreditacion.Location = New System.Drawing.Point(551, 28)
        Me.DateTimePickerAcreditacion.Name = "DateTimePickerAcreditacion"
        Me.DateTimePickerAcreditacion.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePickerAcreditacion.TabIndex = 53
        '
        'TBNoOficio
        '
        Me.TBNoOficio.Location = New System.Drawing.Point(309, 26)
        Me.TBNoOficio.Name = "TBNoOficio"
        Me.TBNoOficio.Size = New System.Drawing.Size(185, 20)
        Me.TBNoOficio.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(309, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Numero de Oficio:"
        '
        'CBCarreraTitulacion
        '
        Me.CBCarreraTitulacion.FormattingEnabled = True
        Me.CBCarreraTitulacion.Items.AddRange(New Object() {"DERECHO", "CRIMINOLOGIA", "CIENCIAS JURIDICAS", "DERECHO Y C. JURIDICAS", "DERECHO Y C. SOCIALES"})
        Me.CBCarreraTitulacion.Location = New System.Drawing.Point(427, 122)
        Me.CBCarreraTitulacion.Name = "CBCarreraTitulacion"
        Me.CBCarreraTitulacion.Size = New System.Drawing.Size(272, 21)
        Me.CBCarreraTitulacion.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(424, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Nombre de Carrera:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(424, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Fecha_Estimada2:"
        '
        'DateTimePickerEst2
        '
        Me.DateTimePickerEst2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEst2.Location = New System.Drawing.Point(522, 196)
        Me.DateTimePickerEst2.Name = "DateTimePickerEst2"
        Me.DateTimePickerEst2.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePickerEst2.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(423, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Fecha_Estimada1:"
        '
        'DateTimePickerEst1
        '
        Me.DateTimePickerEst1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEst1.Location = New System.Drawing.Point(522, 159)
        Me.DateTimePickerEst1.Name = "DateTimePickerEst1"
        Me.DateTimePickerEst1.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePickerEst1.TabIndex = 45
        '
        'CBSexo
        '
        Me.CBSexo.FormattingEnabled = True
        Me.CBSexo.Items.AddRange(New Object() {"M", "F"})
        Me.CBSexo.Location = New System.Drawing.Point(209, 89)
        Me.CBSexo.Name = "CBSexo"
        Me.CBSexo.Size = New System.Drawing.Size(59, 21)
        Me.CBSexo.TabIndex = 44
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMostrar.Location = New System.Drawing.Point(164, 19)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(32, 34)
        Me.BtnMostrar.TabIndex = 43
        Me.BtnMostrar.Text = "..."
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'TB_No_Acta
        '
        Me.TB_No_Acta.Location = New System.Drawing.Point(103, 160)
        Me.TB_No_Acta.Name = "TB_No_Acta"
        Me.TB_No_Acta.Size = New System.Drawing.Size(185, 20)
        Me.TB_No_Acta.TabIndex = 19
        '
        'TB_Periodo_Generacion
        '
        Me.TB_Periodo_Generacion.Location = New System.Drawing.Point(425, 76)
        Me.TB_Periodo_Generacion.Name = "TB_Periodo_Generacion"
        Me.TB_Periodo_Generacion.Size = New System.Drawing.Size(326, 20)
        Me.TB_Periodo_Generacion.TabIndex = 18
        '
        'TBEdad
        '
        Me.TBEdad.Location = New System.Drawing.Point(211, 124)
        Me.TBEdad.Name = "TBEdad"
        Me.TBEdad.Size = New System.Drawing.Size(47, 20)
        Me.TBEdad.TabIndex = 15
        '
        'CBSemestre
        '
        Me.CBSemestre.FormattingEnabled = True
        Me.CBSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CBSemestre.Location = New System.Drawing.Point(70, 124)
        Me.CBSemestre.Name = "CBSemestre"
        Me.CBSemestre.Size = New System.Drawing.Size(59, 21)
        Me.CBSemestre.TabIndex = 14
        '
        'CBCarrera
        '
        Me.CBCarrera.FormattingEnabled = True
        Me.CBCarrera.Items.AddRange(New Object() {"D", "C"})
        Me.CBCarrera.Location = New System.Drawing.Point(71, 90)
        Me.CBCarrera.Name = "CBCarrera"
        Me.CBCarrera.Size = New System.Drawing.Size(62, 21)
        Me.CBCarrera.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(155, 197)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(72, 59)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(293, 20)
        Me.TBNombre.TabIndex = 11
        '
        'TBMatricula
        '
        Me.TBMatricula.Location = New System.Drawing.Point(72, 27)
        Me.TBMatricula.MaxLength = 7
        Me.TBMatricula.Multiline = True
        Me.TBMatricula.Name = "TBMatricula"
        Me.TBMatricula.Size = New System.Drawing.Size(89, 20)
        Me.TBMatricula.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Numero de Acta:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(422, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Periodo de Generación:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(162, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(167, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Edad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Semestre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carrera:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Toma de Protesta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matricula:"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=Titulacion;User ID=sa;Password=Facdyc2" &
    "020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Enabled = False
        Me.Btn_Actualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Actualizar.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Btn_Actualizar.Location = New System.Drawing.Point(830, 154)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(132, 47)
        Me.Btn_Actualizar.TabIndex = 64
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'Btn_Oficio_Titulacion
        '
        Me.Btn_Oficio_Titulacion.Enabled = False
        Me.Btn_Oficio_Titulacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Oficio_Titulacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Oficio_Titulacion.Location = New System.Drawing.Point(830, 219)
        Me.Btn_Oficio_Titulacion.Name = "Btn_Oficio_Titulacion"
        Me.Btn_Oficio_Titulacion.Size = New System.Drawing.Size(132, 48)
        Me.Btn_Oficio_Titulacion.TabIndex = 65
        Me.Btn_Oficio_Titulacion.Text = "Oficio de Titulacion"
        Me.Btn_Oficio_Titulacion.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 474)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(797, 268)
        Me.DataGridView1.TabIndex = 66
        '
        'BTN_Guardar
        '
        Me.BTN_Guardar.Enabled = False
        Me.BTN_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Guardar.ForeColor = System.Drawing.Color.DarkGreen
        Me.BTN_Guardar.Location = New System.Drawing.Point(830, 295)
        Me.BTN_Guardar.Name = "BTN_Guardar"
        Me.BTN_Guardar.Size = New System.Drawing.Size(132, 45)
        Me.BTN_Guardar.TabIndex = 67
        Me.BTN_Guardar.Text = "Guardar"
        Me.BTN_Guardar.UseVisualStyleBackColor = True
        '
        'FRM_Datos_Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(971, 749)
        Me.Controls.Add(Me.BTN_Guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Oficio_Titulacion)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_Datos_Alumnos"
        Me.Text = "Datos del Alumno"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Tesis As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Promedio As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Experiencia_Laboral As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Automatico As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Seminario As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Materias_Posgrado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Curso As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CB_Periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Titulado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Egresados As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Linares As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Sepad As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Sabinas As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Escolaridad As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBSexo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents TB_No_Acta As System.Windows.Forms.TextBox
    Friend WithEvents TB_Periodo_Generacion As System.Windows.Forms.TextBox
    Friend WithEvents TBEdad As System.Windows.Forms.TextBox
    Friend WithEvents CBSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents CBCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents RB_Cuautitlan As System.Windows.Forms.RadioButton
    Friend WithEvents Btn_Oficio_Titulacion As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEst1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerEst2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBCarreraTitulacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TBNoOficio As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents BTN_Guardar As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerAcreditacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CBHORA_TP As System.Windows.Forms.ComboBox

End Class
