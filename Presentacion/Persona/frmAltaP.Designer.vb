<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAltaP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltaP))
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtSnom = New System.Windows.Forms.TextBox()
        Me.txtPnom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bttnIngP = New System.Windows.Forms.Button()
        Me.txtSape = New System.Windows.Forms.TextBox()
        Me.txtPape = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel.Location = New System.Drawing.Point(429, 256)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(160, 13)
        Me.txtTel.TabIndex = 21
        '
        'txtDir
        '
        Me.txtDir.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDir.Location = New System.Drawing.Point(429, 213)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(160, 13)
        Me.txtDir.TabIndex = 20
        '
        'txtSnom
        '
        Me.txtSnom.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSnom.Location = New System.Drawing.Point(429, 169)
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.Size = New System.Drawing.Size(160, 13)
        Me.txtSnom.TabIndex = 19
        '
        'txtPnom
        '
        Me.txtPnom.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPnom.Location = New System.Drawing.Point(430, 125)
        Me.txtPnom.Name = "txtPnom"
        Me.txtPnom.Size = New System.Drawing.Size(160, 13)
        Me.txtPnom.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(312, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Primer nombre:*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(303, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Segundo Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(345, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Dirección:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(345, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Teléfono:*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(410, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Alta de Personas"
        '
        'txtci
        '
        Me.txtci.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtci.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtci.Location = New System.Drawing.Point(429, 79)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(160, 13)
        Me.txtci.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(357, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Cedula:*"
        '
        'bttnIngP
        '
        Me.bttnIngP.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnIngP.Location = New System.Drawing.Point(403, 436)
        Me.bttnIngP.Name = "bttnIngP"
        Me.bttnIngP.Size = New System.Drawing.Size(186, 51)
        Me.bttnIngP.TabIndex = 25
        Me.bttnIngP.Text = "Ingresar"
        Me.bttnIngP.UseVisualStyleBackColor = True
        '
        'txtSape
        '
        Me.txtSape.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSape.Location = New System.Drawing.Point(430, 348)
        Me.txtSape.Name = "txtSape"
        Me.txtSape.Size = New System.Drawing.Size(160, 13)
        Me.txtSape.TabIndex = 29
        '
        'txtPape
        '
        Me.txtPape.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPape.Location = New System.Drawing.Point(430, 304)
        Me.txtPape.Name = "txtPape"
        Me.txtPape.Size = New System.Drawing.Size(160, 13)
        Me.txtPape.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(307, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Primer apellido:*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(298, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Segundo apellido:*"
        '
        'frmAltaP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.txtPape)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bttnIngP)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtPnom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmAltaP"
        Me.Text = "frmAltaP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtSnom As TextBox
    Friend WithEvents txtPnom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtci As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bttnIngP As Button
    Friend WithEvents txtSape As TextBox
    Friend WithEvents txtPape As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
