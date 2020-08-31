<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElimP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElimP))
        Me.bttnElimP = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bttnBuscar = New System.Windows.Forms.Button()
        Me.dgvPersona = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttnElimP
        '
        Me.bttnElimP.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnElimP.Location = New System.Drawing.Point(280, 370)
        Me.bttnElimP.Name = "bttnElimP"
        Me.bttnElimP.Size = New System.Drawing.Size(186, 51)
        Me.bttnElimP.TabIndex = 26
        Me.bttnElimP.Text = "Eliminar Persona"
        Me.bttnElimP.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(208, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cedula:*"
        '
        'txtci
        '
        Me.txtci.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtci.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtci.Location = New System.Drawing.Point(280, 98)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(160, 13)
        Me.txtci.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "ingrese la cedula de la persona a eliminar"
        '
        'bttnBuscar
        '
        Me.bttnBuscar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBuscar.Location = New System.Drawing.Point(470, 86)
        Me.bttnBuscar.Name = "bttnBuscar"
        Me.bttnBuscar.Size = New System.Drawing.Size(115, 34)
        Me.bttnBuscar.TabIndex = 30
        Me.bttnBuscar.Text = "Buscar"
        Me.bttnBuscar.UseVisualStyleBackColor = True
        '
        'dgvPersona
        '
        Me.dgvPersona.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersona.Location = New System.Drawing.Point(12, 177)
        Me.dgvPersona.Name = "dgvPersona"
        Me.dgvPersona.Size = New System.Drawing.Size(718, 94)
        Me.dgvPersona.TabIndex = 31
        Me.dgvPersona.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(222, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Baja de Personas"
        '
        'frmElimP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(762, 463)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvPersona)
        Me.Controls.Add(Me.bttnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bttnElimP)
        Me.Name = "frmElimP"
        Me.Text = "frmElimP"
        CType(Me.dgvPersona, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttnElimP As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtci As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bttnBuscar As Button
    Friend WithEvents dgvPersona As DataGridView
    Friend WithEvents Label2 As Label
End Class
