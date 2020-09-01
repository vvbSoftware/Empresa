<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifE))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnBuscar = New System.Windows.Forms.Button()
        Me.txtidEmp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvModifP = New System.Windows.Forms.DataGridView()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        CType(Me.dgvModifP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Doble click en la persona para poder editarla:"
        '
        'bttnBuscar
        '
        Me.bttnBuscar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBuscar.Location = New System.Drawing.Point(281, 115)
        Me.bttnBuscar.Name = "bttnBuscar"
        Me.bttnBuscar.Size = New System.Drawing.Size(129, 43)
        Me.bttnBuscar.TabIndex = 39
        Me.bttnBuscar.Text = "Buscar"
        Me.bttnBuscar.UseVisualStyleBackColor = True
        '
        'txtidEmp
        '
        Me.txtidEmp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtidEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidEmp.Location = New System.Drawing.Point(118, 132)
        Me.txtidEmp.Name = "txtidEmp"
        Me.txtidEmp.Size = New System.Drawing.Size(160, 13)
        Me.txtidEmp.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(14, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "ced Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(387, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Modificar Empleados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(416, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(330, 26)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "*Puede filtrar por idEmpleado o seleccionar a la persona que desea " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "modificar, d" &
    "irectamente de la tabla, si no se ingresa ninguna cedula.*"
        '
        'dgvModifP
        '
        Me.dgvModifP.AllowUserToAddRows = False
        Me.dgvModifP.AllowUserToDeleteRows = False
        Me.dgvModifP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModifP.Location = New System.Drawing.Point(169, 199)
        Me.dgvModifP.Name = "dgvModifP"
        Me.dgvModifP.ReadOnly = True
        Me.dgvModifP.Size = New System.Drawing.Size(694, 202)
        Me.dgvModifP.TabIndex = 36
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSueldo.Location = New System.Drawing.Point(391, 460)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(177, 13)
        Me.txtSueldo.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(265, 457)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sueldo Mensual:*"
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(617, 434)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 62)
        Me.btnGuardar.TabIndex = 51
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'frmModifE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnBuscar)
        Me.Controls.Add(Me.txtidEmp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvModifP)
        Me.Name = "frmModifE"
        Me.Text = "Modif"
        CType(Me.dgvModifP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents bttnBuscar As Button
    Friend WithEvents txtidEmp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvModifP As DataGridView
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGuardar As Button
End Class
