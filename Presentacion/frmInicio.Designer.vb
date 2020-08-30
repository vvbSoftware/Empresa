<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGestionA = New System.Windows.Forms.Button()
        Me.btnGestionE = New System.Windows.Forms.Button()
        Me.btnGestionP = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnGestionA)
        Me.Panel1.Controls.Add(Me.btnGestionE)
        Me.Panel1.Controls.Add(Me.btnGestionP)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 512)
        Me.Panel1.TabIndex = 5
        '
        'btnGestionA
        '
        Me.btnGestionA.FlatAppearance.BorderSize = 0
        Me.btnGestionA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGestionA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGestionA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGestionA.Image = CType(resources.GetObject("btnGestionA.Image"), System.Drawing.Image)
        Me.btnGestionA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionA.Location = New System.Drawing.Point(9, 343)
        Me.btnGestionA.Name = "btnGestionA"
        Me.btnGestionA.Size = New System.Drawing.Size(227, 40)
        Me.btnGestionA.TabIndex = 8
        Me.btnGestionA.Text = "Gestion de Articulos"
        Me.btnGestionA.UseVisualStyleBackColor = True
        '
        'btnGestionE
        '
        Me.btnGestionE.FlatAppearance.BorderSize = 0
        Me.btnGestionE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGestionE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGestionE.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionE.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionE.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGestionE.Image = CType(resources.GetObject("btnGestionE.Image"), System.Drawing.Image)
        Me.btnGestionE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionE.Location = New System.Drawing.Point(7, 267)
        Me.btnGestionE.Name = "btnGestionE"
        Me.btnGestionE.Size = New System.Drawing.Size(227, 40)
        Me.btnGestionE.TabIndex = 7
        Me.btnGestionE.Text = "Gestion de Empleados"
        Me.btnGestionE.UseVisualStyleBackColor = True
        '
        'btnGestionP
        '
        Me.btnGestionP.FlatAppearance.BorderSize = 0
        Me.btnGestionP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGestionP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGestionP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestionP.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestionP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGestionP.Image = CType(resources.GetObject("btnGestionP.Image"), System.Drawing.Image)
        Me.btnGestionP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionP.Location = New System.Drawing.Point(7, 188)
        Me.btnGestionP.Name = "btnGestionP"
        Me.btnGestionP.Size = New System.Drawing.Size(227, 40)
        Me.btnGestionP.TabIndex = 6
        Me.btnGestionP.Text = "Gestion de Personas"
        Me.btnGestionP.UseVisualStyleBackColor = True
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
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(0, 456)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(53, 53)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelPrincipal
        '
        Me.panelPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.panelPrincipal.Location = New System.Drawing.Point(240, 0)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(561, 512)
        Me.panelPrincipal.TabIndex = 6
        '
        'frmInicio
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 511)
        Me.Controls.Add(Me.panelPrincipal)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "App gestion"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelPrincipal As Panel
    Friend WithEvents btnGestionP As Button
    Friend WithEvents btnGestionE As Button
    Friend WithEvents btnGestionA As Button
End Class
