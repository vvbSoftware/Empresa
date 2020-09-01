<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarArt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarArt))
        Me.dgvListArt = New System.Windows.Forms.DataGridView()
        Me.btnCargarGrilla = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvListArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListArt
        '
        Me.dgvListArt.AllowUserToAddRows = False
        Me.dgvListArt.AllowUserToDeleteRows = False
        Me.dgvListArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListArt.Location = New System.Drawing.Point(191, 232)
        Me.dgvListArt.Name = "dgvListArt"
        Me.dgvListArt.ReadOnly = True
        Me.dgvListArt.Size = New System.Drawing.Size(632, 273)
        Me.dgvListArt.TabIndex = 0
        '
        'btnCargarGrilla
        '
        Me.btnCargarGrilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarGrilla.Location = New System.Drawing.Point(12, 232)
        Me.btnCargarGrilla.Name = "btnCargarGrilla"
        Me.btnCargarGrilla.Size = New System.Drawing.Size(170, 58)
        Me.btnCargarGrilla.TabIndex = 1
        Me.btnCargarGrilla.Text = "Cargar Articulos Registrados"
        Me.btnCargarGrilla.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(357, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de Articulos"
        '
        'frmListarArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCargarGrilla)
        Me.Controls.Add(Me.dgvListArt)
        Me.Name = "frmListarArt"
        Me.Text = "frmListarArt"
        CType(Me.dgvListArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListArt As DataGridView
    Friend WithEvents btnCargarGrilla As Button
    Friend WithEvents Label1 As Label
End Class
