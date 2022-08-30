<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerala
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerala))
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnVolverATirar = New System.Windows.Forms.Button()
        Me.btnArrojar = New System.Windows.Forms.Button()
        Me.pct5 = New System.Windows.Forms.PictureBox()
        Me.pct4 = New System.Windows.Forms.PictureBox()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.pct2 = New System.Windows.Forms.PictureBox()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        CType(Me.pct5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMensaje.Font = New System.Drawing.Font("MV Boli", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.Gold
        Me.lblMensaje.Location = New System.Drawing.Point(32, 206)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(280, 101)
        Me.lblMensaje.TabIndex = 7
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVolverATirar
        '
        Me.btnVolverATirar.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnVolverATirar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolverATirar.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolverATirar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnVolverATirar.Image = Global.Generala.My.Resources.Resources.box
        Me.btnVolverATirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolverATirar.Location = New System.Drawing.Point(46, 397)
        Me.btnVolverATirar.Name = "btnVolverATirar"
        Me.btnVolverATirar.Size = New System.Drawing.Size(239, 41)
        Me.btnVolverATirar.TabIndex = 6
        Me.btnVolverATirar.Text = "Volver a Tirar"
        Me.btnVolverATirar.UseVisualStyleBackColor = False
        '
        'btnArrojar
        '
        Me.btnArrojar.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnArrojar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnArrojar.Font = New System.Drawing.Font("MV Boli", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArrojar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnArrojar.Image = Global.Generala.My.Resources.Resources.star
        Me.btnArrojar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArrojar.Location = New System.Drawing.Point(46, 338)
        Me.btnArrojar.Name = "btnArrojar"
        Me.btnArrojar.Size = New System.Drawing.Size(239, 41)
        Me.btnArrojar.TabIndex = 5
        Me.btnArrojar.Text = "Arrojar Dados"
        Me.btnArrojar.UseVisualStyleBackColor = False
        '
        'pct5
        '
        Me.pct5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct5.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pct5.Location = New System.Drawing.Point(243, 113)
        Me.pct5.Name = "pct5"
        Me.pct5.Size = New System.Drawing.Size(80, 72)
        Me.pct5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct5.TabIndex = 4
        Me.pct5.TabStop = False
        '
        'pct4
        '
        Me.pct4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct4.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pct4.Location = New System.Drawing.Point(135, 113)
        Me.pct4.Name = "pct4"
        Me.pct4.Size = New System.Drawing.Size(80, 72)
        Me.pct4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct4.TabIndex = 3
        Me.pct4.TabStop = False
        '
        'pct3
        '
        Me.pct3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct3.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pct3.Location = New System.Drawing.Point(28, 113)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(80, 72)
        Me.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct3.TabIndex = 2
        Me.pct3.TabStop = False
        '
        'pct2
        '
        Me.pct2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct2.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pct2.Location = New System.Drawing.Point(192, 23)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(80, 72)
        Me.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct2.TabIndex = 1
        Me.pct2.TabStop = False
        '
        'pct1
        '
        Me.pct1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pct1.Image = Global.Generala.My.Resources.Resources.dadoGirando
        Me.pct1.Location = New System.Drawing.Point(71, 23)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(80, 72)
        Me.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct1.TabIndex = 0
        Me.pct1.TabStop = False
        '
        'frmGenerala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(347, 450)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.btnVolverATirar)
        Me.Controls.Add(Me.btnArrojar)
        Me.Controls.Add(Me.pct5)
        Me.Controls.Add(Me.pct4)
        Me.Controls.Add(Me.pct3)
        Me.Controls.Add(Me.pct2)
        Me.Controls.Add(Me.pct1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGenerala"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generala"
        Me.TransparencyKey = System.Drawing.Color.Olive
        CType(Me.pct5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pct1 As PictureBox
    Friend WithEvents pct2 As PictureBox
    Friend WithEvents pct3 As PictureBox
    Friend WithEvents pct4 As PictureBox
    Friend WithEvents pct5 As PictureBox
    Friend WithEvents btnArrojar As Button
    Friend WithEvents btnVolverATirar As Button
    Friend WithEvents lblMensaje As Label
End Class
