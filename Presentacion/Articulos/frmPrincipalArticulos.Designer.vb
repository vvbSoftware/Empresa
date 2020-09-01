<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipalArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipalArticulos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnElimA = New System.Windows.Forms.Button()
        Me.btnAddArt = New System.Windows.Forms.Button()
        Me.btnListarA = New System.Windows.Forms.Button()
        Me.btnModifA = New System.Windows.Forms.Button()
        Me.panelArt = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.Panel1.Controls.Add(Me.btnElimA)
        Me.Panel1.Controls.Add(Me.btnAddArt)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnListarA)
        Me.Panel1.Controls.Add(Me.btnModifA)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 676)
        Me.Panel1.TabIndex = 11
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalir.Location = New System.Drawing.Point(0, 623)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(216, 53)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Volver al menu de inicio"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnElimA
        '
        Me.btnElimA.FlatAppearance.BorderSize = 0
        Me.btnElimA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnElimA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnElimA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnElimA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnElimA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnElimA.Image = CType(resources.GetObject("btnElimA.Image"), System.Drawing.Image)
        Me.btnElimA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElimA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnElimA.Location = New System.Drawing.Point(12, 324)
        Me.btnElimA.Name = "btnElimA"
        Me.btnElimA.Size = New System.Drawing.Size(215, 40)
        Me.btnElimA.TabIndex = 4
        Me.btnElimA.Text = "Eliminar Articulo"
        Me.btnElimA.UseVisualStyleBackColor = True
        '
        'btnAddArt
        '
        Me.btnAddArt.FlatAppearance.BorderSize = 0
        Me.btnAddArt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddArt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAddArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddArt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnAddArt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddArt.Image = CType(resources.GetObject("btnAddArt.Image"), System.Drawing.Image)
        Me.btnAddArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddArt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnAddArt.Location = New System.Drawing.Point(12, 181)
        Me.btnAddArt.Name = "btnAddArt"
        Me.btnAddArt.Size = New System.Drawing.Size(215, 40)
        Me.btnAddArt.TabIndex = 1
        Me.btnAddArt.Text = "Agregar Articulo"
        Me.btnAddArt.UseVisualStyleBackColor = True
        '
        'btnListarA
        '
        Me.btnListarA.FlatAppearance.BorderSize = 0
        Me.btnListarA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnListarA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnListarA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListarA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnListarA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListarA.Image = CType(resources.GetObject("btnListarA.Image"), System.Drawing.Image)
        Me.btnListarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListarA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnListarA.Location = New System.Drawing.Point(12, 393)
        Me.btnListarA.Name = "btnListarA"
        Me.btnListarA.Size = New System.Drawing.Size(215, 40)
        Me.btnListarA.TabIndex = 3
        Me.btnListarA.Text = "Listar Articulos"
        Me.btnListarA.UseVisualStyleBackColor = True
        '
        'btnModifA
        '
        Me.btnModifA.FlatAppearance.BorderSize = 0
        Me.btnModifA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnModifA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModifA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifA.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnModifA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModifA.Image = CType(resources.GetObject("btnModifA.Image"), System.Drawing.Image)
        Me.btnModifA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnModifA.Location = New System.Drawing.Point(12, 254)
        Me.btnModifA.Name = "btnModifA"
        Me.btnModifA.Size = New System.Drawing.Size(215, 40)
        Me.btnModifA.TabIndex = 2
        Me.btnModifA.Text = "Modificar Articulo"
        Me.btnModifA.UseVisualStyleBackColor = True
        '
        'panelArt
        '
        Me.panelArt.BackColor = System.Drawing.Color.Transparent
        Me.panelArt.BackgroundImage = CType(resources.GetObject("panelArt.BackgroundImage"), System.Drawing.Image)
        Me.panelArt.Location = New System.Drawing.Point(239, 0)
        Me.panelArt.Name = "panelArt"
        Me.panelArt.Size = New System.Drawing.Size(1001, 676)
        Me.panelArt.TabIndex = 12
        '
        'frmPrincipalArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 676)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelArt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipalArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipalArticulos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnElimA As Button
    Friend WithEvents btnAddArt As Button
    Friend WithEvents btnListarA As Button
    Friend WithEvents btnModifA As Button
    Friend WithEvents panelArt As Panel
End Class
