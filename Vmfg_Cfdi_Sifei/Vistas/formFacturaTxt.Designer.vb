﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFacturaTxt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formFacturaTxt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumeroFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.CarpetaButton = New System.Windows.Forms.Button()
        Me.RutaArchivoTextBox = New System.Windows.Forms.TextBox()
        Me.GenerarArchivoButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero de Factura:"
        '
        'NumeroFacturaTextBox
        '
        Me.NumeroFacturaTextBox.Location = New System.Drawing.Point(119, 29)
        Me.NumeroFacturaTextBox.Name = "NumeroFacturaTextBox"
        Me.NumeroFacturaTextBox.Size = New System.Drawing.Size(78, 20)
        Me.NumeroFacturaTextBox.TabIndex = 1
        '
        'CarpetaButton
        '
        Me.CarpetaButton.Location = New System.Drawing.Point(203, 76)
        Me.CarpetaButton.Name = "CarpetaButton"
        Me.CarpetaButton.Size = New System.Drawing.Size(75, 23)
        Me.CarpetaButton.TabIndex = 2
        Me.CarpetaButton.Text = "Carpeta"
        Me.CarpetaButton.UseVisualStyleBackColor = True
        '
        'RutaArchivoTextBox
        '
        Me.RutaArchivoTextBox.Location = New System.Drawing.Point(15, 76)
        Me.RutaArchivoTextBox.Name = "RutaArchivoTextBox"
        Me.RutaArchivoTextBox.Size = New System.Drawing.Size(182, 20)
        Me.RutaArchivoTextBox.TabIndex = 3
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
        Me.PictureBox1.Image = Global.Vmfg_Cfdi_Sifei.My.Resources.Resources.recibo
        Me.PictureBox1.Location = New System.Drawing.Point(203, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'formFacturaTxt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(290, 146)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GenerarArchivoButton)
        Me.Controls.Add(Me.RutaArchivoTextBox)
        Me.Controls.Add(Me.CarpetaButton)
        Me.Controls.Add(Me.NumeroFacturaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formFacturaTxt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura VMFG TXT"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NumeroFacturaTextBox As TextBox
    Friend WithEvents CarpetaButton As Button
    Friend WithEvents RutaArchivoTextBox As TextBox
    Friend WithEvents GenerarArchivoButton As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
