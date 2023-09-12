<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CertificadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarTXTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem, Me.GenerarTXTToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1600, 40)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CertificadoToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(185, 36)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'CertificadoToolStripMenuItem
        '
        Me.CertificadoToolStripMenuItem.Name = "CertificadoToolStripMenuItem"
        Me.CertificadoToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.CertificadoToolStripMenuItem.Text = "Certificado"
        '
        'GenerarTXTToolStripMenuItem
        '
        Me.GenerarTXTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaciónToolStripMenuItem, Me.PagoToolStripMenuItem})
        Me.GenerarTXTToolStripMenuItem.Name = "GenerarTXTToolStripMenuItem"
        Me.GenerarTXTToolStripMenuItem.Size = New System.Drawing.Size(166, 36)
        Me.GenerarTXTToolStripMenuItem.Text = "Generar TXT"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Label1)
        Me.ToolStripContainer1.ContentPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1600, 62)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 806)
        Me.ToolStripContainer1.Margin = New System.Windows.Forms.Padding(6)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1600, 62)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        Me.ToolStripContainer1.TopToolStripPanelVisible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'PagoToolStripMenuItem
        '
        Me.PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        Me.PagoToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.PagoToolStripMenuItem.Text = "Pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(903, 823)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio CFDI 4.0 Sifei"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CertificadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents GenerarTXTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
End Class
