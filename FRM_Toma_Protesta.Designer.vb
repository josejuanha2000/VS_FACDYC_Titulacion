<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Toma_Protesta
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Actualizar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.RB_AutomaticoPromedio = New System.Windows.Forms.RadioButton()
        Me.RB_Automatico = New System.Windows.Forms.RadioButton()
        Me.RB_Tesis = New System.Windows.Forms.RadioButton()
        Me.RB_ExperienciaLaboral = New System.Windows.Forms.RadioButton()
        Me.RB_Curso = New System.Windows.Forms.RadioButton()
        Me.RB_MateriasPosgrado = New System.Windows.Forms.RadioButton()
        Me.RB_Seminario = New System.Windows.Forms.RadioButton()
        Me.RB_Promedio = New System.Windows.Forms.RadioButton()
        Me.RB_Linares = New System.Windows.Forms.RadioButton()
        Me.RB_Sabinas = New System.Windows.Forms.RadioButton()
        Me.RB_Cuautitlan = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RB_Sepad = New System.Windows.Forms.RadioButton()
        Me.RB_Escolaridad = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_DerechoyCSociales = New System.Windows.Forms.RadioButton()
        Me.RB_DerechoyCjuridicas = New System.Windows.Forms.RadioButton()
        Me.RB_Criminologia = New System.Windows.Forms.RadioButton()
        Me.RB_CienciasJuridicas = New System.Windows.Forms.RadioButton()
        Me.RB_Derecho = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_No_Acta = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_Periodo_Generacion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBHORA_TP = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TBEdad = New System.Windows.Forms.TextBox()
        Me.CBSemestre = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBMatricula = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.Btn_Nuevo = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(54, 450)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(797, 242)
        Me.DataGridView1.TabIndex = 73
        '
        'Btn_Actualizar
        '
        Me.Btn_Actualizar.Enabled = False
        Me.Btn_Actualizar.Location = New System.Drawing.Point(730, 219)
        Me.Btn_Actualizar.Name = "Btn_Actualizar"
        Me.Btn_Actualizar.Size = New System.Drawing.Size(121, 44)
        Me.Btn_Actualizar.TabIndex = 71
        Me.Btn_Actualizar.Text = "Actualizar"
        Me.Btn_Actualizar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox5.Controls.Add(Me.RB_AutomaticoPromedio)
        Me.GroupBox5.Controls.Add(Me.RB_Automatico)
        Me.GroupBox5.Controls.Add(Me.RB_Tesis)
        Me.GroupBox5.Controls.Add(Me.RB_ExperienciaLaboral)
        Me.GroupBox5.Controls.Add(Me.RB_Curso)
        Me.GroupBox5.Controls.Add(Me.RB_MateriasPosgrado)
        Me.GroupBox5.Controls.Add(Me.RB_Seminario)
        Me.GroupBox5.Controls.Add(Me.RB_Promedio)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox5.Location = New System.Drawing.Point(378, 209)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(178, 220)
        Me.GroupBox5.TabIndex = 70
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Modalidad:"
        '
        'RB_AutomaticoPromedio
        '
        Me.RB_AutomaticoPromedio.AutoSize = True
        Me.RB_AutomaticoPromedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_AutomaticoPromedio.Location = New System.Drawing.Point(23, 197)
        Me.RB_AutomaticoPromedio.Name = "RB_AutomaticoPromedio"
        Me.RB_AutomaticoPromedio.Size = New System.Drawing.Size(125, 17)
        Me.RB_AutomaticoPromedio.TabIndex = 75
        Me.RB_AutomaticoPromedio.TabStop = True
        Me.RB_AutomaticoPromedio.Text = "Automatico Promedio"
        Me.RB_AutomaticoPromedio.UseVisualStyleBackColor = True
        '
        'RB_Automatico
        '
        Me.RB_Automatico.AutoSize = True
        Me.RB_Automatico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Automatico.Location = New System.Drawing.Point(23, 172)
        Me.RB_Automatico.Name = "RB_Automatico"
        Me.RB_Automatico.Size = New System.Drawing.Size(78, 17)
        Me.RB_Automatico.TabIndex = 74
        Me.RB_Automatico.TabStop = True
        Me.RB_Automatico.Text = "Automatico"
        Me.RB_Automatico.UseVisualStyleBackColor = True
        '
        'RB_Tesis
        '
        Me.RB_Tesis.AutoSize = True
        Me.RB_Tesis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Tesis.Location = New System.Drawing.Point(23, 148)
        Me.RB_Tesis.Name = "RB_Tesis"
        Me.RB_Tesis.Size = New System.Drawing.Size(50, 17)
        Me.RB_Tesis.TabIndex = 67
        Me.RB_Tesis.TabStop = True
        Me.RB_Tesis.Text = "Tesis"
        Me.RB_Tesis.UseVisualStyleBackColor = True
        '
        'RB_ExperienciaLaboral
        '
        Me.RB_ExperienciaLaboral.AutoSize = True
        Me.RB_ExperienciaLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_ExperienciaLaboral.Location = New System.Drawing.Point(22, 123)
        Me.RB_ExperienciaLaboral.Name = "RB_ExperienciaLaboral"
        Me.RB_ExperienciaLaboral.Size = New System.Drawing.Size(118, 17)
        Me.RB_ExperienciaLaboral.TabIndex = 66
        Me.RB_ExperienciaLaboral.TabStop = True
        Me.RB_ExperienciaLaboral.Text = "Experiencia Laboral"
        Me.RB_ExperienciaLaboral.UseVisualStyleBackColor = True
        '
        'RB_Curso
        '
        Me.RB_Curso.AutoSize = True
        Me.RB_Curso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Curso.Location = New System.Drawing.Point(22, 70)
        Me.RB_Curso.Name = "RB_Curso"
        Me.RB_Curso.Size = New System.Drawing.Size(52, 17)
        Me.RB_Curso.TabIndex = 64
        Me.RB_Curso.TabStop = True
        Me.RB_Curso.Text = "Curso"
        Me.RB_Curso.UseVisualStyleBackColor = True
        '
        'RB_MateriasPosgrado
        '
        Me.RB_MateriasPosgrado.AutoSize = True
        Me.RB_MateriasPosgrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_MateriasPosgrado.Location = New System.Drawing.Point(22, 22)
        Me.RB_MateriasPosgrado.Name = "RB_MateriasPosgrado"
        Me.RB_MateriasPosgrado.Size = New System.Drawing.Size(128, 17)
        Me.RB_MateriasPosgrado.TabIndex = 63
        Me.RB_MateriasPosgrado.TabStop = True
        Me.RB_MateriasPosgrado.Text = "Materias de Posgrado"
        Me.RB_MateriasPosgrado.UseVisualStyleBackColor = True
        '
        'RB_Seminario
        '
        Me.RB_Seminario.AutoSize = True
        Me.RB_Seminario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Seminario.Location = New System.Drawing.Point(22, 45)
        Me.RB_Seminario.Name = "RB_Seminario"
        Me.RB_Seminario.Size = New System.Drawing.Size(71, 17)
        Me.RB_Seminario.TabIndex = 63
        Me.RB_Seminario.TabStop = True
        Me.RB_Seminario.Text = "Seminario"
        Me.RB_Seminario.UseVisualStyleBackColor = True
        '
        'RB_Promedio
        '
        Me.RB_Promedio.AutoSize = True
        Me.RB_Promedio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Promedio.Location = New System.Drawing.Point(22, 96)
        Me.RB_Promedio.Name = "RB_Promedio"
        Me.RB_Promedio.Size = New System.Drawing.Size(69, 17)
        Me.RB_Promedio.TabIndex = 65
        Me.RB_Promedio.TabStop = True
        Me.RB_Promedio.Text = "Promedio"
        Me.RB_Promedio.UseVisualStyleBackColor = True
        '
        'RB_Linares
        '
        Me.RB_Linares.AutoSize = True
        Me.RB_Linares.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Linares.Location = New System.Drawing.Point(31, 105)
        Me.RB_Linares.Name = "RB_Linares"
        Me.RB_Linares.Size = New System.Drawing.Size(59, 17)
        Me.RB_Linares.TabIndex = 61
        Me.RB_Linares.TabStop = True
        Me.RB_Linares.Text = "Linares"
        Me.RB_Linares.UseVisualStyleBackColor = True
        '
        'RB_Sabinas
        '
        Me.RB_Sabinas.AutoSize = True
        Me.RB_Sabinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Sabinas.Location = New System.Drawing.Point(31, 78)
        Me.RB_Sabinas.Name = "RB_Sabinas"
        Me.RB_Sabinas.Size = New System.Drawing.Size(63, 17)
        Me.RB_Sabinas.TabIndex = 60
        Me.RB_Sabinas.TabStop = True
        Me.RB_Sabinas.Text = "Sabinas"
        Me.RB_Sabinas.UseVisualStyleBackColor = True
        '
        'RB_Cuautitlan
        '
        Me.RB_Cuautitlan.AutoSize = True
        Me.RB_Cuautitlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Cuautitlan.Location = New System.Drawing.Point(31, 131)
        Me.RB_Cuautitlan.Name = "RB_Cuautitlan"
        Me.RB_Cuautitlan.Size = New System.Drawing.Size(72, 17)
        Me.RB_Cuautitlan.TabIndex = 62
        Me.RB_Cuautitlan.TabStop = True
        Me.RB_Cuautitlan.Text = "Cuautitlán"
        Me.RB_Cuautitlan.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RB_Sepad)
        Me.GroupBox3.Controls.Add(Me.RB_Escolaridad)
        Me.GroupBox3.Controls.Add(Me.RB_Sabinas)
        Me.GroupBox3.Controls.Add(Me.RB_Linares)
        Me.GroupBox3.Controls.Add(Me.RB_Cuautitlan)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(221, 209)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(142, 196)
        Me.GroupBox3.TabIndex = 69
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sistema:"
        '
        'RB_Sepad
        '
        Me.RB_Sepad.AutoSize = True
        Me.RB_Sepad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Sepad.Location = New System.Drawing.Point(31, 51)
        Me.RB_Sepad.Name = "RB_Sepad"
        Me.RB_Sepad.Size = New System.Drawing.Size(56, 17)
        Me.RB_Sepad.TabIndex = 61
        Me.RB_Sepad.TabStop = True
        Me.RB_Sepad.Text = "Sepad"
        Me.RB_Sepad.UseVisualStyleBackColor = True
        '
        'RB_Escolaridad
        '
        Me.RB_Escolaridad.AutoSize = True
        Me.RB_Escolaridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Escolaridad.Location = New System.Drawing.Point(31, 25)
        Me.RB_Escolaridad.Name = "RB_Escolaridad"
        Me.RB_Escolaridad.Size = New System.Drawing.Size(80, 17)
        Me.RB_Escolaridad.TabIndex = 60
        Me.RB_Escolaridad.TabStop = True
        Me.RB_Escolaridad.Text = "Escolaridad"
        Me.RB_Escolaridad.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RB_DerechoyCSociales)
        Me.GroupBox2.Controls.Add(Me.RB_DerechoyCjuridicas)
        Me.GroupBox2.Controls.Add(Me.RB_Criminologia)
        Me.GroupBox2.Controls.Add(Me.RB_CienciasJuridicas)
        Me.GroupBox2.Controls.Add(Me.RB_Derecho)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(54, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 196)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Carrera:"
        '
        'RB_DerechoyCSociales
        '
        Me.RB_DerechoyCSociales.AutoSize = True
        Me.RB_DerechoyCSociales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_DerechoyCSociales.Location = New System.Drawing.Point(16, 131)
        Me.RB_DerechoyCSociales.Name = "RB_DerechoyCSociales"
        Me.RB_DerechoyCSociales.Size = New System.Drawing.Size(130, 17)
        Me.RB_DerechoyCSociales.TabIndex = 67
        Me.RB_DerechoyCSociales.TabStop = True
        Me.RB_DerechoyCSociales.Text = "Derecho y C. Sociales"
        Me.RB_DerechoyCSociales.UseVisualStyleBackColor = True
        '
        'RB_DerechoyCjuridicas
        '
        Me.RB_DerechoyCjuridicas.AutoSize = True
        Me.RB_DerechoyCjuridicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_DerechoyCjuridicas.Location = New System.Drawing.Point(15, 104)
        Me.RB_DerechoyCjuridicas.Name = "RB_DerechoyCjuridicas"
        Me.RB_DerechoyCjuridicas.Size = New System.Drawing.Size(131, 17)
        Me.RB_DerechoyCjuridicas.TabIndex = 59
        Me.RB_DerechoyCjuridicas.TabStop = True
        Me.RB_DerechoyCjuridicas.Text = "Derecho y C. Juridicas"
        Me.RB_DerechoyCjuridicas.UseVisualStyleBackColor = True
        '
        'RB_Criminologia
        '
        Me.RB_Criminologia.AutoSize = True
        Me.RB_Criminologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Criminologia.Location = New System.Drawing.Point(14, 52)
        Me.RB_Criminologia.Name = "RB_Criminologia"
        Me.RB_Criminologia.Size = New System.Drawing.Size(81, 17)
        Me.RB_Criminologia.TabIndex = 45
        Me.RB_Criminologia.TabStop = True
        Me.RB_Criminologia.Text = "Criminologia"
        Me.RB_Criminologia.UseVisualStyleBackColor = True
        '
        'RB_CienciasJuridicas
        '
        Me.RB_CienciasJuridicas.AutoSize = True
        Me.RB_CienciasJuridicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_CienciasJuridicas.Location = New System.Drawing.Point(14, 78)
        Me.RB_CienciasJuridicas.Name = "RB_CienciasJuridicas"
        Me.RB_CienciasJuridicas.Size = New System.Drawing.Size(109, 17)
        Me.RB_CienciasJuridicas.TabIndex = 58
        Me.RB_CienciasJuridicas.TabStop = True
        Me.RB_CienciasJuridicas.Text = "Ciencias Juridicas"
        Me.RB_CienciasJuridicas.UseVisualStyleBackColor = True
        '
        'RB_Derecho
        '
        Me.RB_Derecho.AutoSize = True
        Me.RB_Derecho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Derecho.Location = New System.Drawing.Point(14, 24)
        Me.RB_Derecho.Name = "RB_Derecho"
        Me.RB_Derecho.Size = New System.Drawing.Size(66, 17)
        Me.RB_Derecho.TabIndex = 14
        Me.RB_Derecho.TabStop = True
        Me.RB_Derecho.Text = "Derecho"
        Me.RB_Derecho.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_No_Acta)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TB_Periodo_Generacion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.CBHORA_TP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBSexo)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.TBEdad)
        Me.GroupBox1.Controls.Add(Me.CBSemestre)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.TBMatricula)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(51, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 197)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Alumno"
        '
        'TB_No_Acta
        '
        Me.TB_No_Acta.Location = New System.Drawing.Point(435, 143)
        Me.TB_No_Acta.Name = "TB_No_Acta"
        Me.TB_No_Acta.Size = New System.Drawing.Size(185, 20)
        Me.TB_No_Acta.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(432, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Numero de Acta:"
        '
        'TB_Periodo_Generacion
        '
        Me.TB_Periodo_Generacion.Location = New System.Drawing.Point(435, 85)
        Me.TB_Periodo_Generacion.Name = "TB_Periodo_Generacion"
        Me.TB_Periodo_Generacion.Size = New System.Drawing.Size(326, 20)
        Me.TB_Periodo_Generacion.TabIndex = 48
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(432, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Periodo de Generación:"
        '
        'CBHORA_TP
        '
        Me.CBHORA_TP.FormattingEnabled = True
        Me.CBHORA_TP.Items.AddRange(New Object() {"0700", "0800", "0900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000", "2100"})
        Me.CBHORA_TP.Location = New System.Drawing.Point(297, 153)
        Me.CBHORA_TP.Name = "CBHORA_TP"
        Me.CBHORA_TP.Size = New System.Drawing.Size(87, 21)
        Me.CBHORA_TP.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(161, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Hora de Toma Protesta"
        '
        'CBSexo
        '
        Me.CBSexo.FormattingEnabled = True
        Me.CBSexo.Items.AddRange(New Object() {"M", "F"})
        Me.CBSexo.Location = New System.Drawing.Point(72, 102)
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
        'TBEdad
        '
        Me.TBEdad.Location = New System.Drawing.Point(72, 146)
        Me.TBEdad.Name = "TBEdad"
        Me.TBEdad.Size = New System.Drawing.Size(47, 20)
        Me.TBEdad.TabIndex = 15
        '
        'CBSemestre
        '
        Me.CBSemestre.FormattingEnabled = True
        Me.CBSemestre.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.CBSemestre.Location = New System.Drawing.Point(222, 105)
        Me.CBSemestre.Name = "CBSemestre"
        Me.CBSemestre.Size = New System.Drawing.Size(59, 21)
        Me.CBSemestre.TabIndex = 14
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(435, 35)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(72, 62)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(266, 20)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Edad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Semestre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(432, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de Toma de Protesta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 65)
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
        'Btn_Nuevo
        '
        Me.Btn_Nuevo.Enabled = False
        Me.Btn_Nuevo.Location = New System.Drawing.Point(730, 274)
        Me.Btn_Nuevo.Name = "Btn_Nuevo"
        Me.Btn_Nuevo.Size = New System.Drawing.Size(121, 44)
        Me.Btn_Nuevo.TabIndex = 74
        Me.Btn_Nuevo.Text = "Nuevo"
        Me.Btn_Nuevo.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Enabled = False
        Me.Btn_Guardar.Location = New System.Drawing.Point(730, 327)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(121, 44)
        Me.Btn_Guardar.TabIndex = 75
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        '
        'FRM_Toma_Protesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(910, 704)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Btn_Nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_Actualizar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_Toma_Protesta"
        Me.Text = "Toma Protesta"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Actualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Curso As System.Windows.Forms.RadioButton
    Friend WithEvents RB_MateriasPosgrado As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Seminario As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Promedio As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Linares As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Sabinas As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Cuautitlan As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Sepad As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Escolaridad As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_DerechoyCSociales As System.Windows.Forms.RadioButton
    Friend WithEvents RB_DerechoyCjuridicas As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Criminologia As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CienciasJuridicas As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Derecho As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBSexo As System.Windows.Forms.ComboBox
    Friend WithEvents BtnMostrar As System.Windows.Forms.Button
    Friend WithEvents TBEdad As System.Windows.Forms.TextBox
    Friend WithEvents CBSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RB_Automatico As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Tesis As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ExperienciaLaboral As System.Windows.Forms.RadioButton
    Friend WithEvents CBHORA_TP As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents TB_Periodo_Generacion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TB_No_Acta As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents RB_AutomaticoPromedio As RadioButton
End Class
