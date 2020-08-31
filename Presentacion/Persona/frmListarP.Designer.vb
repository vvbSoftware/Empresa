<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarP))
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListado
        '
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(9, 186)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(969, 438)
        Me.dgvListado.TabIndex = 0
        Me.dgvListado.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(392, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Listado de Personas"
        '
        'bttnBuscar
        '
        Me.bttnBuscar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBuscar.Location = New System.Drawing.Point(8, 126)
        Me.bttnBuscar.Name = "bttnBuscar"
        Me.bttnBuscar.Size = New System.Drawing.Size(185, 44)
        Me.bttnBuscar.TabIndex = 34
        Me.bttnBuscar.Text = "Cargar Grilla"
        Me.bttnBuscar.UseVisualStyleBackColor = True
        '
        'frmListarP
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.bttnBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvListado)
        Me.Name = "frmListarP"
        Me.Text = "frmListarP"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents bttnBuscar As Button
End Class
