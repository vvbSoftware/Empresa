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
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
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
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnElimP
        '
        Me.btnElimP.FlatAppearance.BorderSize = 0
        Me.btnElimP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnElimP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        resources.ApplyResources(Me.btnElimP, "btnElimP")
        Me.btnElimP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnElimP.Name = "btnElimP"
        Me.btnElimP.UseVisualStyleBackColor = True
        '
        'btnAddPer
        '
        Me.btnAddPer.FlatAppearance.BorderSize = 0
        Me.btnAddPer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnAddPer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        resources.ApplyResources(Me.btnAddPer, "btnAddPer")
        Me.btnAddPer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddPer.Name = "btnAddPer"
        Me.btnAddPer.UseVisualStyleBackColor = True
        '
        'btnListarP
        '
        Me.btnListarP.FlatAppearance.BorderSize = 0
        Me.btnListarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnListarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        resources.ApplyResources(Me.btnListarP, "btnListarP")
        Me.btnListarP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListarP.Name = "btnListarP"
        Me.btnListarP.UseVisualStyleBackColor = True
        '
        'btnModifP
        '
        Me.btnModifP.FlatAppearance.BorderSize = 0
        Me.btnModifP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnModifP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        resources.ApplyResources(Me.btnModifP, "btnModifP")
        Me.btnModifP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModifP.Name = "btnModifP"
        Me.btnModifP.UseVisualStyleBackColor = True
        '
        'panelPer
        '
        Me.panelPer.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.panelPer, "panelPer")
        Me.panelPer.Name = "panelPer"
        '
        'frmPrincipalPersonas
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelPer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Name = "frmPrincipalPersonas"
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
