<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelArt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDelArt))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bttnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdArt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bttnElimA = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvDelArt = New System.Windows.Forms.DataGridView()
        CType(Me.dgvDelArt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bookman Old Style", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(419, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 24)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Eliminar Articulos"
        '
        'bttnBuscar
        '
        Me.bttnBuscar.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnBuscar.Location = New System.Drawing.Point(15, 157)
        Me.bttnBuscar.Name = "bttnBuscar"
        Me.bttnBuscar.Size = New System.Drawing.Size(115, 34)
        Me.bttnBuscar.TabIndex = 37
        Me.bttnBuscar.Text = "Buscar"
        Me.bttnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 16)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Para eliminar un articulo en específico:"
        '
        'txtIdArt
        '
        Me.txtIdArt.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtIdArt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdArt.Location = New System.Drawing.Point(147, 106)
        Me.txtIdArt.Name = "txtIdArt"
        Me.txtIdArt.Size = New System.Drawing.Size(160, 13)
        Me.txtIdArt.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(12, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "codigo del articulo:"
        '
        'bttnElimA
        '
        Me.bttnElimA.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnElimA.Location = New System.Drawing.Point(404, 457)
        Me.bttnElimA.Name = "bttnElimA"
        Me.bttnElimA.Size = New System.Drawing.Size(186, 51)
        Me.bttnElimA.TabIndex = 33
        Me.bttnElimA.Text = "Eliminar Articulo"
        Me.bttnElimA.UseVisualStyleBackColor = True
        Me.bttnElimA.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(12, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Seleccione el articulo a eliminar de la siguente tabla:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Bookman Old Style", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(313, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(669, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Si no conoce el codigo del articulo no ingrese ningun dato y use simplemente en e" &
    "l boton buscar"
        '
        'dgvDelArt
        '
        Me.dgvDelArt.AllowUserToAddRows = False
        Me.dgvDelArt.AllowUserToDeleteRows = False
        Me.dgvDelArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDelArt.Location = New System.Drawing.Point(91, 235)
        Me.dgvDelArt.Name = "dgvDelArt"
        Me.dgvDelArt.ReadOnly = True
        Me.dgvDelArt.Size = New System.Drawing.Size(804, 196)
        Me.dgvDelArt.TabIndex = 42
        '
        'frmDelArt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(989, 636)
        Me.Controls.Add(Me.dgvDelArt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bttnBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdArt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bttnElimA)
        Me.Name = "frmDelArt"
        Me.Text = "frmDelArt"
        CType(Me.dgvDelArt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents bttnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdArt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bttnElimA As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvDelArt As DataGridView
End Class
