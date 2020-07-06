<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Vista_Actas_Titulacion
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.BtnMostrarDatos = New System.Windows.Forms.Button()
        Me.CBCarrera = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBHORA_TP = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(842, 429)
        Me.DataGridView1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(13, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(312, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnImprimir.Location = New System.Drawing.Point(772, 27)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(77, 38)
        Me.BtnImprimir.TabIndex = 2
        Me.BtnImprimir.Text = "Imprimir"
        Me.BtnImprimir.UseVisualStyleBackColor = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=148.234.110.22;Initial Catalog=Titulacion;User ID=sa;Password=Facdyc2" &
    "020"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'BtnMostrarDatos
        '
        Me.BtnMostrarDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnMostrarDatos.Location = New System.Drawing.Point(638, 28)
        Me.BtnMostrarDatos.Name = "BtnMostrarDatos"
        Me.BtnMostrarDatos.Size = New System.Drawing.Size(101, 38)
        Me.BtnMostrarDatos.TabIndex = 3
        Me.BtnMostrarDatos.Text = "Mostrar Datos"
        Me.BtnMostrarDatos.UseVisualStyleBackColor = False
        '
        'CBCarrera
        '
        Me.CBCarrera.FormattingEnabled = True
        Me.CBCarrera.Items.AddRange(New Object() {"D", "C"})
        Me.CBCarrera.Location = New System.Drawing.Point(337, 39)
        Me.CBCarrera.Name = "CBCarrera"
        Me.CBCarrera.Size = New System.Drawing.Size(62, 21)
        Me.CBCarrera.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(345, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Carrera:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Seleccione Fecha:"
        '
        'CBHORA_TP
        '
        Me.CBHORA_TP.FormattingEnabled = True
        Me.CBHORA_TP.Items.AddRange(New Object() {"0700", "0800", "0900", "1000", "1100", "1200", "1300", "1400", "1500", "1600", "1700", "1800", "1900", "2000", "2100"})
        Me.CBHORA_TP.Location = New System.Drawing.Point(421, 41)
        Me.CBHORA_TP.Name = "CBHORA_TP"
        Me.CBHORA_TP.Size = New System.Drawing.Size(113, 21)
        Me.CBHORA_TP.TabIndex = 58
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(418, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Hora de Toma Protesta"
        '
        'Frm_Vista_Actas_Titulacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(866, 571)
        Me.Controls.Add(Me.CBHORA_TP)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBCarrera)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnMostrarDatos)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frm_Vista_Actas_Titulacion"
        Me.Text = "Frm_Vista_Actas_Titulacion"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents BtnMostrarDatos As System.Windows.Forms.Button
    Friend WithEvents CBCarrera As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBHORA_TP As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
