<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Label1 = New Label()
        DataGridView_ventas = New DataGridView()
        CType(DataGridView_ventas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 22.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(483, 9)
        Label1.MaximumSize = New Size(500, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 44)
        Label1.TabIndex = 0
        Label1.Text = "Ventas"
        ' 
        ' DataGridView_ventas
        ' 
        DataGridView_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView_ventas.Location = New Point(269, 64)
        DataGridView_ventas.Name = "DataGridView_ventas"
        DataGridView_ventas.RowHeadersWidth = 51
        DataGridView_ventas.RowTemplate.Height = 29
        DataGridView_ventas.Size = New Size(1000, 366)
        DataGridView_ventas.TabIndex = 1
        ' 
        ' Ventas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PeachPuff
        ClientSize = New Size(1331, 688)
        Controls.Add(DataGridView_ventas)
        Controls.Add(Label1)
        Cursor = Cursors.Default
        Name = "Ventas"
        Text = "Ventas"
        CType(DataGridView_ventas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_ventas As DataGridView
End Class
