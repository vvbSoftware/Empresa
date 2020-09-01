<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipalEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipalEmpleados))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGestTipoEmp = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnElim = New System.Windows.Forms.Button()
        Me.btnAddEmp = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.panelEmp = New System.Windows.Forms.Panel()
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
        Me.Panel1.Controls.Add(Me.btnGestTipoEmp)
        Me.Panel1.Controls.Add(Me.btnVolver)
        Me.Panel1.Controls.Add(Me.btnElim)
        Me.Panel1.Controls.Add(Me.btnAddEmp)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnListar)
        Me.Panel1.Controls.Add(Me.btnModif)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 673)
        Me.Panel1.TabIndex = 11
        '
        'btnGestTipoEmp
        '
        Me.btnGestTipoEmp.FlatAppearance.BorderSize = 0
        Me.btnGestTipoEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGestTipoEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGestTipoEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGestTipoEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGestTipoEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGestTipoEmp.Image = CType(resources.GetObject("btnGestTipoEmp.Image"), System.Drawing.Image)
        Me.btnGestTipoEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestTipoEmp.Location = New System.Drawing.Point(12, 498)
        Me.btnGestTipoEmp.Name = "btnGestTipoEmp"
        Me.btnGestTipoEmp.Size = New System.Drawing.Size(215, 80)
        Me.btnGestTipoEmp.TabIndex = 7
        Me.btnGestTipoEmp.Text = "Gestinar Tipo de Empleados"
        Me.btnGestTipoEmp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGestTipoEmp.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(0, 620)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(216, 53)
        Me.btnVolver.TabIndex = 6
        Me.btnVolver.Text = "Volver al menu de inicio"
        Me.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnElim
        '
        Me.btnElim.FlatAppearance.BorderSize = 0
        Me.btnElim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnElim.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnElim.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElim.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnElim.Image = CType(resources.GetObject("btnElim.Image"), System.Drawing.Image)
        Me.btnElim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnElim.Location = New System.Drawing.Point(12, 324)
        Me.btnElim.Name = "btnElim"
        Me.btnElim.Size = New System.Drawing.Size(215, 40)
        Me.btnElim.TabIndex = 4
        Me.btnElim.Text = "Eliminar Empleado"
        Me.btnElim.UseVisualStyleBackColor = True
        '
        'btnAddEmp
        '
        Me.btnAddEmp.FlatAppearance.BorderSize = 0
        Me.btnAddEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddEmp.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddEmp.Image = CType(resources.GetObject("btnAddEmp.Image"), System.Drawing.Image)
        Me.btnAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmp.Location = New System.Drawing.Point(12, 181)
        Me.btnAddEmp.Name = "btnAddEmp"
        Me.btnAddEmp.Size = New System.Drawing.Size(215, 40)
        Me.btnAddEmp.TabIndex = 1
        Me.btnAddEmp.Text = "Agregar Empleado"
        Me.btnAddEmp.UseVisualStyleBackColor = True
        '
        'btnListar
        '
        Me.btnListar.FlatAppearance.BorderSize = 0
        Me.btnListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListar.Image = CType(resources.GetObject("btnListar.Image"), System.Drawing.Image)
        Me.btnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListar.Location = New System.Drawing.Point(12, 393)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(215, 40)
        Me.btnListar.TabIndex = 3
        Me.btnListar.Text = "Listar Empleado"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.FlatAppearance.BorderSize = 0
        Me.btnModif.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnModif.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModif.Image = CType(resources.GetObject("btnModif.Image"), System.Drawing.Image)
        Me.btnModif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModif.Location = New System.Drawing.Point(12, 254)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(215, 40)
        Me.btnModif.TabIndex = 2
        Me.btnModif.Text = "Modificar Empleado"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'panelEmp
        '
        Me.panelEmp.BackColor = System.Drawing.Color.Transparent
        Me.panelEmp.BackgroundImage = CType(resources.GetObject("panelEmp.BackgroundImage"), System.Drawing.Image)
        Me.panelEmp.Location = New System.Drawing.Point(239, 0)
        Me.panelEmp.Name = "panelEmp"
        Me.panelEmp.Size = New System.Drawing.Size(1005, 671)
        Me.panelEmp.TabIndex = 12
        '
        'frmPrincipalEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1244, 671)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrincipalEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipalEmpleados"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnElim As Button
    Friend WithEvents btnAddEmp As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents panelEmp As Panel
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnGestTipoEmp As Button
End Class
