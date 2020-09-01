<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifArt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifArt))
        Me.lblForm = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.lblFech = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.bttnModif = New System.Windows.Forms.Button()
        Me.dgvDelArt = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bttnBuscar = New System.Windows.Forms.Button()
        Me.txtIdArt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgvDelArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.BackColor = System.Drawing.Color.Transparent
        Me.lblForm.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblForm.Location = New System.Drawing.Point(592, 327)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(110, 13)
        Me.lblForm.TabIndex = 54
        Me.lblForm.Text = "formato: dd/mm/aaaa"
        Me.lblForm.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecha.Location = New System.Drawing.Point(732, 314)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(117, 13)
        Me.txtFecha.TabIndex = 49
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFecha.Visible = False
        '
        'lblFech
        '
        Me.lblFech.AutoSize = True
        Me.lblFech.BackColor = System.Drawing.Color.Transparent
        Me.lblFech.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFech.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFech.Location = New System.Drawing.Point(568, 311)
        Me.lblFech.Name = "lblFech"
        Me.lblFech.Size = New System.Drawing.Size(153, 16)
        Me.lblFech.TabIndex = 48
        Me.lblFech.Text = "Fecha de fabricacion:"
        Me.lblFech.Visible = False
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecio.Location = New System.Drawing.Point(732, 277)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(228, 13)
        Me.txtPrecio.TabIndex = 47
        Me.txtPrecio.Visible = False
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.BackColor = System.Drawing.Color.Transparent
        Me.lblPre.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre.ForeColor = System.Drawing.SystemColors.Control
        Me.lblPre.Location = New System.Drawing.Point(660, 274)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(55, 16)
        Me.lblPre.TabIndex = 46
        Me.lblPre.Text = "Precio:"
        Me.lblPre.Visible = False
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.Location = New System.Drawing.Point(732, 154)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(228, 91)
        Me.txtDesc.TabIndex = 45
        Me.txtDesc.Visible = False
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.BackColor = System.Drawing.Color.Transparent
        Me.lblDesc.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDesc.Location = New System.Drawing.Point(634, 152)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(92, 16)
        Me.lblDesc.TabIndex = 44
        Me.lblDesc.Text = "Descripcion:"
        Me.lblDesc.Visible = False
        '
        'txtcod
        '
        Me.txtcod.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtcod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcod.Location = New System.Drawing.Point(732, 103)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(228, 13)
        Me.txtcod.TabIndex = 43
        Me.txtcod.Visible = False
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.BackColor = System.Drawing.Color.Transparent
        Me.lblCod.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.ForeColor = System.Drawing.SystemColors.Control
        Me.lblCod.Location = New System.Drawing.Point(660, 100)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(59, 16)
        Me.lblCod.TabIndex = 42
        Me.lblCod.Text = "Codigo:"
        Me.lblCod.Visible = False
        '
        'bttnModif
        '
        Me.bttnModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnModif.Location = New System.Drawing.Point(750, 407)
        Me.bttnModif.Name = "bttnModif"
        Me.bttnModif.Size = New System.Drawing.Size(201, 63)
        Me.bttnModif.TabIndex = 41
        Me.bttnModif.Text = "Guardar Cambios"
        Me.bttnModif.UseVisualStyleBackColor = True
        Me.bttnModif.Visible = False
        '
        'dgvDelArt
        '
        Me.dgvDelArt.AllowUserToAddRows = False
        Me.dgvDelArt.AllowUserToDeleteRows = False
        Me.dgvDelArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDelArt.Location = New System.Drawing.Point(12, 293)
        Me.dgvDelArt.Name = "dgvDelArt"
        Me.dgvDelArt.ReadOnly = True
        Me.dgvDelArt.Size = New System.Drawing.Size(550, 196)
        Me.dgvDelArt.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(9, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(582, 14)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Si no conoce el codigo del articulo no ingrese ningun dato y use simplemente en e" &
    "l boton buscar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(9, 274)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(382, 16)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Seleccione el articulo a modificar de la siguente tabla:"
        '
        'bttnBuscar
        '
        Me.bttnBuscar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBuscar.Location = New System.Drawing.Point(12, 208)
        Me.bttnBuscar.Name = "bttnBuscar"
        Me.bttnBuscar.Size = New System.Drawing.Size(115, 34)
        Me.bttnBuscar.TabIndex = 57
        Me.bttnBuscar.Text = "Buscar"
        Me.bttnBuscar.UseVisualStyleBackColor = True
        '
        'txtIdArt
        '
        Me.txtIdArt.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtIdArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdArt.Location = New System.Drawing.Point(145, 159)
        Me.txtIdArt.Name = "txtIdArt"
        Me.txtIdArt.Size = New System.Drawing.Size(160, 13)
        Me.txtIdArt.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(9, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 16)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "codigo del articulo:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(289, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(268, 32)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Modificar Articulo"
        '
        'frmModifArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvDelArt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bttnBuscar)
        Me.Controls.Add(Me.txtIdArt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.lblFech)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.lblPre)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.bttnModif)
        Me.Name = "frmModifArt"
        Me.Text = "frmModifArt"
        CType(Me.dgvDelArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblForm As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents lblFech As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents lblPre As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents txtcod As TextBox
    Friend WithEvents lblCod As Label
    Friend WithEvents bttnModif As Button
    Friend WithEvents dgvDelArt As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents bttnBuscar As Button
    Friend WithEvents txtIdArt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
