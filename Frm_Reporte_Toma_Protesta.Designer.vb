<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reporte_Toma_Protesta
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
        Me.CRV2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CRV2
        '
        Me.CRV2.ActiveViewIndex = -1
        Me.CRV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV2.Location = New System.Drawing.Point(0, 0)
        Me.CRV2.Name = "CRV2"
        Me.CRV2.Size = New System.Drawing.Size(852, 507)
        Me.CRV2.TabIndex = 0
        '
        'Frm_Reporte_Toma_Protesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 507)
        Me.Controls.Add(Me.CRV2)
        Me.Name = "Frm_Reporte_Toma_Protesta"
        Me.Text = "Frm_Reporte_Toma_Protesta"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
