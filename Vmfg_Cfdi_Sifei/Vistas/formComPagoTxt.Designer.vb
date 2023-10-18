<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formComPagoTxt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formComPagoTxt))
        Me.NumeroCobroText = New System.Windows.Forms.Label()
        Me.NumeroCobroTextBox = New System.Windows.Forms.TextBox()
        Me.RutaArchivoTextBox = New System.Windows.Forms.TextBox()
        Me.CarpetaButton = New System.Windows.Forms.Button()
        Me.GenerarArchivoButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroCobroText
        '
        Me.NumeroCobroText.AutoSize = True
        Me.NumeroCobroText.Location = New System.Drawing.Point(12, 32)
        Me.NumeroCobroText.Name = "NumeroCobroText"
        Me.NumeroCobroText.Size = New System.Drawing.Size(93, 13)
        Me.NumeroCobroText.TabIndex = 0
        Me.NumeroCobroText.Text = "Numero de Cobro:"
        '
        'NumeroCobroTextBox
        '
        Me.NumeroCobroTextBox.Location = New System.Drawing.Point(106, 29)
        Me.NumeroCobroTextBox.Name = "NumeroCobroTextBox"
        Me.NumeroCobroTextBox.Size = New System.Drawing.Size(91, 20)
        Me.NumeroCobroTextBox.TabIndex = 1
        '
        'RutaArchivoTextBox
        '
        Me.RutaArchivoTextBox.Location = New System.Drawing.Point(15, 76)
        Me.RutaArchivoTextBox.Name = "RutaArchivoTextBox"
        Me.RutaArchivoTextBox.Size = New System.Drawing.Size(182, 20)
        Me.RutaArchivoTextBox.TabIndex = 2
        '
        'CarpetaButton
        '
        Me.CarpetaButton.Location = New System.Drawing.Point(203, 76)
        Me.CarpetaButton.Name = "CarpetaButton"
        Me.CarpetaButton.Size = New System.Drawing.Size(75, 23)
        Me.CarpetaButton.TabIndex = 3
        Me.CarpetaButton.Text = "Carpeta"
        Me.CarpetaButton.UseVisualStyleBackColor = True
        '
        'GenerarArchivoButton
        '
        Me.GenerarArchivoButton.Location = New System.Drawing.Point(15, 112)
        Me.GenerarArchivoButton.Name = "GenerarArchivoButton"
        Me.GenerarArchivoButton.Size = New System.Drawing.Size(98, 23)
        Me.GenerarArchivoButton.TabIndex = 4
        Me.GenerarArchivoButton.Text = "Generar TXT"
        Me.GenerarArchivoButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vmfg_Cfdi_Sifei.My.Resources.Resources.credito
        Me.PictureBox1.Location = New System.Drawing.Point(203, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'formComPagoTxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(290, 146)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GenerarArchivoButton)
        Me.Controls.Add(Me.CarpetaButton)
        Me.Controls.Add(Me.RutaArchivoTextBox)
        Me.Controls.Add(Me.NumeroCobroTextBox)
        Me.Controls.Add(Me.NumeroCobroText)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formComPagoTxt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Complemento de Pago VMFG TXT"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumeroCobroText As Label
    Friend WithEvents NumeroCobroTextBox As TextBox
    Friend WithEvents RutaArchivoTextBox As TextBox
    Friend WithEvents CarpetaButton As Button
    Friend WithEvents GenerarArchivoButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
