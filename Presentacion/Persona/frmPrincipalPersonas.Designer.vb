<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipalPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipalPersonas))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnElimP = New System.Windows.Forms.Button()
        Me.btnAddPer = New System.Windows.Forms.Button()
        Me.btnListarP = New System.Windows.Forms.Button()
        Me.btnModifP = New System.Windows.Forms.Button()
        Me.panelPer = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnElimP)
        Me.Panel1.Controls.Add(Me.btnAddPer)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnListarP)
        Me.Panel1.Controls.Add(Me.btnModifP)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 676)
        Me.Panel1.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(0, 623)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(216, 53)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Volver al menu de inicio"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnElimP
        '
        Me.btnElimP.FlatAppearance.BorderSize = 0
        Me.btnElimP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnElimP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnElimP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnElimP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElimP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnElimP.Image = CType(resources.GetObject("btnElimP.Image"), System.Drawing.Image)
        Me.btnElimP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElimP.Location = New System.Drawing.Point(12, 324)
        Me.btnElimP.Name = "btnElimP"
        Me.btnElimP.Size = New System.Drawing.Size(215, 40)
        Me.btnElimP.TabIndex = 4
        Me.btnElimP.Text = "Eliminar Personas"
        Me.btnElimP.UseVisualStyleBackColor = True
        '
        'btnAddPer
        '
        Me.btnAddPer.FlatAppearance.BorderSize = 0
        Me.btnAddPer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddPer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAddPer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddPer.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddPer.Image = CType(resources.GetObject("btnAddPer.Image"), System.Drawing.Image)
        Me.btnAddPer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddPer.Location = New System.Drawing.Point(12, 181)
        Me.btnAddPer.Name = "btnAddPer"
        Me.btnAddPer.Size = New System.Drawing.Size(215, 40)
        Me.btnAddPer.TabIndex = 1
        Me.btnAddPer.Text = "Agregar Persona"
        Me.btnAddPer.UseVisualStyleBackColor = True
        '
        'btnListarP
        '
        Me.btnListarP.FlatAppearance.BorderSize = 0
        Me.btnListarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnListarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnListarP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListarP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListarP.Image = CType(resources.GetObject("btnListarP.Image"), System.Drawing.Image)
        Me.btnListarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarP.Location = New System.Drawing.Point(12, 393)
        Me.btnListarP.Name = "btnListarP"
        Me.btnListarP.Size = New System.Drawing.Size(215, 40)
        Me.btnListarP.TabIndex = 3
        Me.btnListarP.Text = "Listar Personas"
        Me.btnListarP.UseVisualStyleBackColor = True
        '
        'btnModifP
        '
        Me.btnModifP.FlatAppearance.BorderSize = 0
        Me.btnModifP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnModifP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModifP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModifP.Image = CType(resources.GetObject("btnModifP.Image"), System.Drawing.Image)
        Me.btnModifP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifP.Location = New System.Drawing.Point(12, 254)
        Me.btnModifP.Name = "btnModifP"
        Me.btnModifP.Size = New System.Drawing.Size(215, 40)
        Me.btnModifP.TabIndex = 2
        Me.btnModifP.Text = "Modificar Personas"
        Me.btnModifP.UseVisualStyleBackColor = True
        '
        'panelPer
        '
        Me.panelPer.BackColor = System.Drawing.Color.Transparent
        Me.panelPer.BackgroundImage = CType(resources.GetObject("panelPer.BackgroundImage"), System.Drawing.Image)
        Me.panelPer.Location = New System.Drawing.Point(239, 0)
        Me.panelPer.Name = "panelPer"
        Me.panelPer.Size = New System.Drawing.Size(1005, 675)
        Me.panelPer.TabIndex = 10
        '
        'frmPrincipalPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 678)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelPer)
        Me.Name = "frmPrincipalPersonas"
        Me.Text = "frmPrincipalPersonas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnElimP As Button
    Friend WithEvents btnAddPer As Button
    Friend WithEvents btnListarP As Button
    Friend WithEvents btnModifP As Button
    Friend WithEvents panelPer As Panel
End Class
