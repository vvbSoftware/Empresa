<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaE))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.bttnIngE = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTipoEmp = New System.Windows.Forms.ComboBox()
        Me.dgvTipoEmp = New System.Windows.Forms.DataGridView()
        Me.txtTipoEmp = New System.Windows.Forms.TextBox()
        CType(Me.dgvTipoEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(345, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cedula:*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(295, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo Empleado:*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(291, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sueldo Mensual:*"
        '
        'txtci
        '
        Me.txtci.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtci.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtci.Location = New System.Drawing.Point(417, 97)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(177, 13)
        Me.txtci.TabIndex = 8
        '
        'txtSueldo
        '
        Me.txtSueldo.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSueldo.Location = New System.Drawing.Point(417, 145)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(177, 13)
        Me.txtSueldo.TabIndex = 11
        '
        'bttnIngE
        '
        Me.bttnIngE.Location = New System.Drawing.Point(401, 305)
        Me.bttnIngE.Name = "bttnIngE"
        Me.bttnIngE.Size = New System.Drawing.Size(201, 63)
        Me.bttnIngE.TabIndex = 15
        Me.bttnIngE.Text = "Ingresar"
        Me.bttnIngE.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(397, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Alta de Empleados"
        '
        'cbTipoEmp
        '
        Me.cbTipoEmp.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbTipoEmp.FormattingEnabled = True
        Me.cbTipoEmp.Location = New System.Drawing.Point(801, 196)
        Me.cbTipoEmp.Name = "cbTipoEmp"
        Me.cbTipoEmp.Size = New System.Drawing.Size(160, 21)
        Me.cbTipoEmp.TabIndex = 24
        Me.cbTipoEmp.Visible = False
        '
        'dgvTipoEmp
        '
        Me.dgvTipoEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoEmp.Location = New System.Drawing.Point(417, 194)
        Me.dgvTipoEmp.Name = "dgvTipoEmp"
        Me.dgvTipoEmp.Size = New System.Drawing.Size(177, 85)
        Me.dgvTipoEmp.TabIndex = 25
        '
        'txtTipoEmp
        '
        Me.txtTipoEmp.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTipoEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipoEmp.Location = New System.Drawing.Point(417, 196)
        Me.txtTipoEmp.Name = "txtTipoEmp"
        Me.txtTipoEmp.Size = New System.Drawing.Size(160, 13)
        Me.txtTipoEmp.TabIndex = 26
        '
        'frmAltaE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 404)
        Me.Controls.Add(Me.dgvTipoEmp)
        Me.Controls.Add(Me.cbTipoEmp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnIngE)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTipoEmp)
        Me.Name = "frmAltaE"
        Me.Text = "frmAlta"
        CType(Me.dgvTipoEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtci As TextBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents bttnIngE As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTipoEmp As ComboBox
    Friend WithEvents dgvTipoEmp As DataGridView
    Friend WithEvents txtTipoEmp As TextBox
End Class
