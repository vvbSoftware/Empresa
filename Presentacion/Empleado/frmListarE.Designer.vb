<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarE))
        Me.dgvListarE = New System.Windows.Forms.DataGridView()
        Me.btnCargarDGV = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvListarE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListarE
        '
        Me.dgvListarE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListarE.Location = New System.Drawing.Point(13, 196)
        Me.dgvListarE.Name = "dgvListarE"
        Me.dgvListarE.Size = New System.Drawing.Size(964, 428)
        Me.dgvListarE.TabIndex = 0
        '
        'btnCargarDGV
        '
        Me.btnCargarDGV.Location = New System.Drawing.Point(13, 133)
        Me.btnCargarDGV.Name = "btnCargarDGV"
        Me.btnCargarDGV.Size = New System.Drawing.Size(176, 48)
        Me.btnCargarDGV.TabIndex = 1
        Me.btnCargarDGV.Text = "Cargar Grilla"
        Me.btnCargarDGV.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(387, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 24)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Listado de Empleados"
        '
        'frmListarE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCargarDGV)
        Me.Controls.Add(Me.dgvListarE)
        Me.Name = "frmListarE"
        Me.Text = "frmListar"
        CType(Me.dgvListarE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListarE As DataGridView
    Friend WithEvents btnCargarDGV As Button
    Friend WithEvents Label2 As Label
End Class
