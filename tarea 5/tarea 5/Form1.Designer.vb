<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.total = New System.Windows.Forms.ListBox()
        Me.descuento2 = New System.Windows.Forms.ListBox()
        Me.descuento1 = New System.Windows.Forms.ListBox()
        Me.subtotal = New System.Windows.Forms.ListBox()
        Me.funcion = New System.Windows.Forms.ListBox()
        Me.cine = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ELECCION DE FUNCION Y CINE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(113, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "cantidad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(86, 186)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 27)
        Me.TextBox1.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(135, 97)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(135, 28)
        Me.ComboBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(135, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 28)
        Me.ComboBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FUNCION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CINE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(479, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 43)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(479, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "BORRAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.total)
        Me.GroupBox2.Controls.Add(Me.descuento2)
        Me.GroupBox2.Controls.Add(Me.descuento1)
        Me.GroupBox2.Controls.Add(Me.subtotal)
        Me.GroupBox2.Controls.Add(Me.funcion)
        Me.GroupBox2.Controls.Add(Me.cine)
        Me.GroupBox2.Location = New System.Drawing.Point(36, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(699, 181)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "precios"
        '
        'total
        '
        Me.total.FormattingEnabled = True
        Me.total.ItemHeight = 20
        Me.total.Location = New System.Drawing.Point(588, 32)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(72, 144)
        Me.total.TabIndex = 5
        '
        'descuento2
        '
        Me.descuento2.FormattingEnabled = True
        Me.descuento2.ItemHeight = 20
        Me.descuento2.Location = New System.Drawing.Point(461, 31)
        Me.descuento2.Name = "descuento2"
        Me.descuento2.Size = New System.Drawing.Size(95, 144)
        Me.descuento2.TabIndex = 4
        '
        'descuento1
        '
        Me.descuento1.FormattingEnabled = True
        Me.descuento1.ItemHeight = 20
        Me.descuento1.Location = New System.Drawing.Point(327, 31)
        Me.descuento1.Name = "descuento1"
        Me.descuento1.Size = New System.Drawing.Size(96, 144)
        Me.descuento1.TabIndex = 3
        '
        'subtotal
        '
        Me.subtotal.FormattingEnabled = True
        Me.subtotal.ItemHeight = 20
        Me.subtotal.Location = New System.Drawing.Point(223, 32)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(72, 144)
        Me.subtotal.TabIndex = 2
        '
        'funcion
        '
        Me.funcion.FormattingEnabled = True
        Me.funcion.ItemHeight = 20
        Me.funcion.Location = New System.Drawing.Point(126, 32)
        Me.funcion.Name = "funcion"
        Me.funcion.Size = New System.Drawing.Size(72, 144)
        Me.funcion.TabIndex = 1
        '
        'cine
        '
        Me.cine.FormattingEnabled = True
        Me.cine.ItemHeight = 20
        Me.cine.Location = New System.Drawing.Point(25, 32)
        Me.cine.Name = "cine"
        Me.cine.Size = New System.Drawing.Size(73, 144)
        Me.cine.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents total As ListBox
    Friend WithEvents descuento2 As ListBox
    Friend WithEvents descuento1 As ListBox
    Friend WithEvents subtotal As ListBox
    Friend WithEvents funcion As ListBox
    Friend WithEvents cine As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
