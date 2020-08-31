<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBajaE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBajaE))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvBaja = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnElim = New System.Windows.Forms.Button()
        CType(Me.dgvBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(388, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 24)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Baja de Empleados"
        '
        'dgvBaja
        '
        Me.dgvBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBaja.Location = New System.Drawing.Point(12, 151)
        Me.dgvBaja.Name = "dgvBaja"
        Me.dgvBaja.Size = New System.Drawing.Size(965, 306)
        Me.dgvBaja.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Seleccione con doble click al emleado que desea eliminar:"
        '
        'btnElim
        '
        Me.btnElim.Location = New System.Drawing.Point(392, 557)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(185, 50)
        Me.btnElim.TabIndex = 27
        Me.btnElim.Text = "Eliminar Empleado"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'frmBajaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.btnElim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvBaja)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmBajaE"
        Me.Text = "frmBaja"
        CType(Me.dgvBaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgvBaja As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnElim As Button
End Class
