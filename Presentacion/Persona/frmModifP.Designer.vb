<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvModifP = New System.Windows.Forms.DataGridView()
        Me.bttnBuscar = New System.Windows.Forms.Button()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSape = New System.Windows.Forms.TextBox()
        Me.txtPape = New System.Windows.Forms.TextBox()
        Me.lblpA = New System.Windows.Forms.Label()
        Me.lblsA = New System.Windows.Forms.Label()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.lblci = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtSnom = New System.Windows.Forms.TextBox()
        Me.txtPnom = New System.Windows.Forms.TextBox()
        Me.lblpN = New System.Windows.Forms.Label()
        Me.lblsN = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.bttnGuardar = New System.Windows.Forms.Button()
        Me.txtIdP = New System.Windows.Forms.TextBox()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.lblFot = New System.Windows.Forms.Label()
        CType(Me.dgvModifP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(365, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Modificar de Personas"
        '
        'dgvModifP
        '
        Me.dgvModifP.AllowUserToAddRows = False
        Me.dgvModifP.AllowUserToDeleteRows = False
        Me.dgvModifP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvModifP.Location = New System.Drawing.Point(11, 212)
        Me.dgvModifP.Name = "dgvModifP"
        Me.dgvModifP.ReadOnly = True
        Me.dgvModifP.Size = New System.Drawing.Size(957, 202)
        Me.dgvModifP.TabIndex = 24
        '
        'bttnBuscar
        '
        Me.bttnBuscar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBuscar.Location = New System.Drawing.Point(281, 128)
        Me.bttnBuscar.Name = "bttnBuscar"
        Me.bttnBuscar.Size = New System.Drawing.Size(129, 43)
        Me.bttnBuscar.TabIndex = 33
        Me.bttnBuscar.Text = "Buscar"
        Me.bttnBuscar.UseVisualStyleBackColor = True
        '
        'txtci
        '
        Me.txtci.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtci.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtci.Location = New System.Drawing.Point(97, 145)
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(160, 13)
        Me.txtci.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(25, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Cedula:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Doble click en la persona para poder editarla:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(416, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(330, 26)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "*Puede filtrar por cedula o seleccionar a la persona que desea " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "modificar, direc" &
    "tamente de la tabla, si no se ingresa ninguna cedula.*"
        '
        'txtSape
        '
        Me.txtSape.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSape.Location = New System.Drawing.Point(580, 526)
        Me.txtSape.Name = "txtSape"
        Me.txtSape.Size = New System.Drawing.Size(160, 13)
        Me.txtSape.TabIndex = 49
        Me.txtSape.Visible = False
        '
        'txtPape
        '
        Me.txtPape.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPape.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPape.Location = New System.Drawing.Point(580, 482)
        Me.txtPape.Name = "txtPape"
        Me.txtPape.Size = New System.Drawing.Size(160, 13)
        Me.txtPape.TabIndex = 48
        Me.txtPape.Visible = False
        '
        'lblpA
        '
        Me.lblpA.AutoSize = True
        Me.lblpA.BackColor = System.Drawing.Color.Transparent
        Me.lblpA.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpA.ForeColor = System.Drawing.SystemColors.Control
        Me.lblpA.Location = New System.Drawing.Point(457, 480)
        Me.lblpA.Name = "lblpA"
        Me.lblpA.Size = New System.Drawing.Size(124, 16)
        Me.lblpA.TabIndex = 47
        Me.lblpA.Text = "Primer apellido:*"
        Me.lblpA.Visible = False
        '
        'lblsA
        '
        Me.lblsA.AutoSize = True
        Me.lblsA.BackColor = System.Drawing.Color.Transparent
        Me.lblsA.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsA.ForeColor = System.Drawing.SystemColors.Control
        Me.lblsA.Location = New System.Drawing.Point(448, 523)
        Me.lblsA.Name = "lblsA"
        Me.lblsA.Size = New System.Drawing.Size(136, 16)
        Me.lblsA.TabIndex = 46
        Me.lblsA.Text = "Segundo apellido:*"
        Me.lblsA.Visible = False
        '
        'txtcedula
        '
        Me.txtcedula.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtcedula.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcedula.Location = New System.Drawing.Point(287, 435)
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(160, 13)
        Me.txtcedula.TabIndex = 45
        Me.txtcedula.Visible = False
        '
        'lblci
        '
        Me.lblci.AutoSize = True
        Me.lblci.BackColor = System.Drawing.Color.Transparent
        Me.lblci.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblci.ForeColor = System.Drawing.SystemColors.Control
        Me.lblci.Location = New System.Drawing.Point(215, 432)
        Me.lblci.Name = "lblci"
        Me.lblci.Size = New System.Drawing.Size(66, 16)
        Me.lblci.TabIndex = 44
        Me.lblci.Text = "Cedula:*"
        Me.lblci.Visible = False
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTel.Location = New System.Drawing.Point(580, 436)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(160, 13)
        Me.txtTel.TabIndex = 43
        Me.txtTel.Visible = False
        '
        'txtDir
        '
        Me.txtDir.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDir.Location = New System.Drawing.Point(287, 569)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(160, 13)
        Me.txtDir.TabIndex = 42
        Me.txtDir.Visible = False
        '
        'txtSnom
        '
        Me.txtSnom.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSnom.Location = New System.Drawing.Point(287, 525)
        Me.txtSnom.Name = "txtSnom"
        Me.txtSnom.Size = New System.Drawing.Size(160, 13)
        Me.txtSnom.TabIndex = 41
        Me.txtSnom.Visible = False
        '
        'txtPnom
        '
        Me.txtPnom.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPnom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPnom.Location = New System.Drawing.Point(288, 481)
        Me.txtPnom.Name = "txtPnom"
        Me.txtPnom.Size = New System.Drawing.Size(160, 13)
        Me.txtPnom.TabIndex = 40
        Me.txtPnom.Visible = False
        '
        'lblpN
        '
        Me.lblpN.AutoSize = True
        Me.lblpN.BackColor = System.Drawing.Color.Transparent
        Me.lblpN.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpN.ForeColor = System.Drawing.SystemColors.Control
        Me.lblpN.Location = New System.Drawing.Point(170, 479)
        Me.lblpN.Name = "lblpN"
        Me.lblpN.Size = New System.Drawing.Size(121, 16)
        Me.lblpN.TabIndex = 39
        Me.lblpN.Text = "Primer nombre:*"
        Me.lblpN.Visible = False
        '
        'lblsN
        '
        Me.lblsN.AutoSize = True
        Me.lblsN.BackColor = System.Drawing.Color.Transparent
        Me.lblsN.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsN.ForeColor = System.Drawing.SystemColors.Control
        Me.lblsN.Location = New System.Drawing.Point(161, 525)
        Me.lblsN.Name = "lblsN"
        Me.lblsN.Size = New System.Drawing.Size(128, 16)
        Me.lblsN.TabIndex = 38
        Me.lblsN.Text = "Segundo Nombre:"
        Me.lblsN.Visible = False
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.BackColor = System.Drawing.Color.Transparent
        Me.lblDir.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDir.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDir.Location = New System.Drawing.Point(203, 567)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(83, 16)
        Me.lblDir.TabIndex = 37
        Me.lblDir.Text = "Dirección:*"
        Me.lblDir.Visible = False
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.BackColor = System.Drawing.Color.Transparent
        Me.lblTel.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.SystemColors.Control
        Me.lblTel.Location = New System.Drawing.Point(503, 433)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(78, 16)
        Me.lblTel.TabIndex = 36
        Me.lblTel.Text = "Teléfono:*"
        Me.lblTel.Visible = False
        '
        'bttnGuardar
        '
        Me.bttnGuardar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnGuardar.Location = New System.Drawing.Point(765, 482)
        Me.bttnGuardar.Name = "bttnGuardar"
        Me.bttnGuardar.Size = New System.Drawing.Size(133, 59)
        Me.bttnGuardar.TabIndex = 50
        Me.bttnGuardar.Text = "Guardar Cambios"
        Me.bttnGuardar.UseVisualStyleBackColor = True
        Me.bttnGuardar.Visible = False
        '
        'txtIdP
        '
        Me.txtIdP.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtIdP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdP.Enabled = False
        Me.txtIdP.Location = New System.Drawing.Point(28, 451)
        Me.txtIdP.Name = "txtIdP"
        Me.txtIdP.ReadOnly = True
        Me.txtIdP.Size = New System.Drawing.Size(88, 13)
        Me.txtIdP.TabIndex = 51
        Me.txtIdP.Visible = False
        '
        'txtFoto
        '
        Me.txtFoto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtFoto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFoto.Location = New System.Drawing.Point(580, 560)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(160, 13)
        Me.txtFoto.TabIndex = 54
        Me.txtFoto.Visible = False
        '
        'lblFot
        '
        Me.lblFot.AutoSize = True
        Me.lblFot.BackColor = System.Drawing.Color.Transparent
        Me.lblFot.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFot.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFot.Location = New System.Drawing.Point(503, 557)
        Me.lblFot.Name = "lblFot"
        Me.lblFot.Size = New System.Drawing.Size(39, 16)
        Me.lblFot.TabIndex = 53
        Me.lblFot.Text = "foto:"
        Me.lblFot.Visible = False
        '
        'frmModifP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(977, 641)
        Me.Controls.Add(Me.txtFoto)
        Me.Controls.Add(Me.lblFot)
        Me.Controls.Add(Me.txtIdP)
        Me.Controls.Add(Me.bttnGuardar)
        Me.Controls.Add(Me.txtSape)
        Me.Controls.Add(Me.txtPape)
        Me.Controls.Add(Me.lblpA)
        Me.Controls.Add(Me.lblsA)
        Me.Controls.Add(Me.txtcedula)
        Me.Controls.Add(Me.lblci)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtSnom)
        Me.Controls.Add(Me.txtPnom)
        Me.Controls.Add(Me.lblpN)
        Me.Controls.Add(Me.lblsN)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnBuscar)
        Me.Controls.Add(Me.txtci)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvModifP)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmModifP"
        Me.Text = "frmModifP"
        CType(Me.dgvModifP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvModifP As DataGridView
    Friend WithEvents bttnBuscar As Button
    Friend WithEvents txtci As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSape As TextBox
    Friend WithEvents txtPape As TextBox
    Friend WithEvents lblpA As Label
    Friend WithEvents lblsA As Label
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents lblci As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDir As TextBox
    Friend WithEvents txtSnom As TextBox
    Friend WithEvents txtPnom As TextBox
    Friend WithEvents lblpN As Label
    Friend WithEvents lblsN As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents bttnGuardar As Button
    Friend WithEvents txtIdP As TextBox
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents lblFot As Label
End Class
