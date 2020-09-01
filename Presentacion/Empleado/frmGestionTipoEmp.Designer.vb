<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionTipoEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionTipoEmp))
        Me.dgvTipoEmp = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.txtIngTE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnAddTE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtModifTE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnElimTE = New System.Windows.Forms.Button()
        Me.bttnModif = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvTipoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTipoEmp
        '
        Me.dgvTipoEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoEmp.Location = New System.Drawing.Point(283, 216)
        Me.dgvTipoEmp.Name = "dgvTipoEmp"
        Me.dgvTipoEmp.Size = New System.Drawing.Size(273, 133)
        Me.dgvTipoEmp.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(322, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Gestion de Tipos de Empleados"
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(106, 247)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(111, 31)
        Me.btnVer.TabIndex = 31
        Me.btnVer.Text = "Cargar datos"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'txtIngTE
        '
        Me.txtIngTE.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtIngTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIngTE.Location = New System.Drawing.Point(178, 136)
        Me.txtIngTE.Name = "txtIngTE"
        Me.txtIngTE.Size = New System.Drawing.Size(177, 13)
        Me.txtIngTE.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(40, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Ver tipo de empleado registrados:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(40, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 16)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Tipo de empleado:"
        '
        'bttnAddTE
        '
        Me.bttnAddTE.Location = New System.Drawing.Point(372, 126)
        Me.bttnAddTE.Name = "bttnAddTE"
        Me.bttnAddTE.Size = New System.Drawing.Size(111, 31)
        Me.bttnAddTE.TabIndex = 34
        Me.bttnAddTE.Text = "Ingresar"
        Me.bttnAddTE.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(159, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Listado de los tipos:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(159, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 19)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Ingresar Tipo Empleado:"
        '
        'txtModifTE
        '
        Me.txtModifTE.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtModifTE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtModifTE.Enabled = False
        Me.txtModifTE.Location = New System.Drawing.Point(190, 395)
        Me.txtModifTE.Name = "txtModifTE"
        Me.txtModifTE.Size = New System.Drawing.Size(177, 13)
        Me.txtModifTE.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(52, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Tipo de empleado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(159, 355)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Modificar:"
        '
        'btnElimTE
        '
        Me.btnElimTE.Enabled = False
        Me.btnElimTE.Location = New System.Drawing.Point(670, 264)
        Me.btnElimTE.Name = "btnElimTE"
        Me.btnElimTE.Size = New System.Drawing.Size(145, 31)
        Me.btnElimTE.TabIndex = 40
        Me.btnElimTE.Text = "Eliminar tipo de empleado"
        Me.btnElimTE.UseVisualStyleBackColor = True
        '
        'bttnModif
        '
        Me.bttnModif.Enabled = False
        Me.bttnModif.Location = New System.Drawing.Point(411, 385)
        Me.bttnModif.Name = "bttnModif"
        Me.bttnModif.Size = New System.Drawing.Size(145, 31)
        Me.bttnModif.TabIndex = 41
        Me.bttnModif.Text = "Guardar Cambios"
        Me.bttnModif.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(642, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Eliminar Tipo de Empleado:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(122, 435)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(387, 32)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "*Para habilitar el campo y boton para modificar debe " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "seleccionar previo un elem" &
    "ento a modificar de la tabla*"
        '
        'frmGestionTipoEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bttnModif)
        Me.Controls.Add(Me.btnElimTE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtModifTE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bttnAddTE)
        Me.Controls.Add(Me.dgvTipoEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.txtIngTE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmGestionTipoEmp"
        Me.Text = "frmGestionTipoEmp"
        CType(Me.dgvTipoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTipoEmp As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVer As Button
    Friend WithEvents txtIngTE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnAddTE As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtModifTE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnElimTE As Button
    Friend WithEvents bttnModif As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
End Class
