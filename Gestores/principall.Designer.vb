<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principall
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
        MenuStrip1 = New MenuStrip()
        CatalogoToolStripMenuItem = New ToolStripMenuItem()
        ProvedoresToolStripMenuItem = New ToolStripMenuItem()
        ClienteToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        ReportesToolStripMenuItem = New ToolStripMenuItem()
        ConfiguracionToolStripMenuItem = New ToolStripMenuItem()
        SalirToolStripMenuItem = New ToolStripMenuItem()
        VentaToolStripMenuItem = New ToolStripMenuItem()
        ComprasToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {CatalogoToolStripMenuItem, VentaToolStripMenuItem, ComprasToolStripMenuItem, ReportesToolStripMenuItem, ConfiguracionToolStripMenuItem, SalirToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' CatalogoToolStripMenuItem
        ' 
        CatalogoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProvedoresToolStripMenuItem, ClienteToolStripMenuItem, ProductosToolStripMenuItem})
        CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        CatalogoToolStripMenuItem.Size = New Size(82, 24)
        CatalogoToolStripMenuItem.Text = "catalogo"
        ' 
        ' ProvedoresToolStripMenuItem
        ' 
        ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        ProvedoresToolStripMenuItem.Size = New Size(166, 26)
        ProvedoresToolStripMenuItem.Text = "&Provedores"
        ' 
        ' ClienteToolStripMenuItem
        ' 
        ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        ClienteToolStripMenuItem.Size = New Size(166, 26)
        ClienteToolStripMenuItem.Text = "&Cliente"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(166, 26)
        ProductosToolStripMenuItem.Text = "&Productos"
        ' 
        ' ReportesToolStripMenuItem
        ' 
        ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        ReportesToolStripMenuItem.Size = New Size(82, 24)
        ReportesToolStripMenuItem.Text = "Reportes"
        ' 
        ' ConfiguracionToolStripMenuItem
        ' 
        ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        ConfiguracionToolStripMenuItem.Size = New Size(116, 24)
        ConfiguracionToolStripMenuItem.Text = "Configuracion"
        ' 
        ' SalirToolStripMenuItem
        ' 
        SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        SalirToolStripMenuItem.Size = New Size(50, 24)
        SalirToolStripMenuItem.Text = "salir"
        ' 
        ' VentaToolStripMenuItem
        ' 
        VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        VentaToolStripMenuItem.Size = New Size(60, 24)
        VentaToolStripMenuItem.Text = "Venta"
        ' 
        ' ComprasToolStripMenuItem
        ' 
        ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        ComprasToolStripMenuItem.Size = New Size(82, 24)
        ComprasToolStripMenuItem.Text = "Compras"
        ' 
        ' principall
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "principall"
        Text = "principall"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
End Class
