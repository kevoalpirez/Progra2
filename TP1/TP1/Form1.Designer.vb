﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Imperial = New System.Windows.Forms.RadioButton()
        Me.Matrimonial = New System.Windows.Forms.RadioButton()
        Me.Queen = New System.Windows.Forms.RadioButton()
        Me.King = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtLino = New System.Windows.Forms.TextBox()
        Me.txtAlgodon = New System.Windows.Forms.TextBox()
        Me.txtSeda = New System.Windows.Forms.TextBox()
        Me.txtHilo = New System.Windows.Forms.TextBox()
        Me.Lino = New System.Windows.Forms.CheckBox()
        Me.Algodón = New System.Windows.Forms.CheckBox()
        Me.Seda = New System.Windows.Forms.CheckBox()
        Me.HiloCrudo = New System.Windows.Forms.CheckBox()
        Me.Aceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrecioCosto = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Imperial)
        Me.GroupBox1.Controls.Add(Me.Matrimonial)
        Me.GroupBox1.Controls.Add(Me.Queen)
        Me.GroupBox1.Controls.Add(Me.King)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(145, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaño"
        '
        'Imperial
        '
        Me.Imperial.AutoSize = True
        Me.Imperial.Location = New System.Drawing.Point(8, 131)
        Me.Imperial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Imperial.Name = "Imperial"
        Me.Imperial.Size = New System.Drawing.Size(85, 24)
        Me.Imperial.TabIndex = 3
        Me.Imperial.TabStop = True
        Me.Imperial.Text = "Imperial"
        Me.Imperial.UseVisualStyleBackColor = True
        '
        'Matrimonial
        '
        Me.Matrimonial.AutoSize = True
        Me.Matrimonial.Location = New System.Drawing.Point(8, 97)
        Me.Matrimonial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Matrimonial.Name = "Matrimonial"
        Me.Matrimonial.Size = New System.Drawing.Size(111, 24)
        Me.Matrimonial.TabIndex = 2
        Me.Matrimonial.TabStop = True
        Me.Matrimonial.Text = "Matrimonial"
        Me.Matrimonial.UseVisualStyleBackColor = True
        '
        'Queen
        '
        Me.Queen.AutoSize = True
        Me.Queen.Location = New System.Drawing.Point(7, 64)
        Me.Queen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Queen.Name = "Queen"
        Me.Queen.Size = New System.Drawing.Size(73, 24)
        Me.Queen.TabIndex = 1
        Me.Queen.TabStop = True
        Me.Queen.Text = "Queen"
        Me.Queen.UseVisualStyleBackColor = True
        '
        'King
        '
        Me.King.AutoSize = True
        Me.King.Location = New System.Drawing.Point(8, 31)
        Me.King.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.King.Name = "King"
        Me.King.Size = New System.Drawing.Size(60, 24)
        Me.King.TabIndex = 0
        Me.King.TabStop = True
        Me.King.Text = "King"
        Me.King.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtLino)
        Me.GroupBox2.Controls.Add(Me.txtAlgodon)
        Me.GroupBox2.Controls.Add(Me.txtSeda)
        Me.GroupBox2.Controls.Add(Me.txtHilo)
        Me.GroupBox2.Controls.Add(Me.Lino)
        Me.GroupBox2.Controls.Add(Me.Algodón)
        Me.GroupBox2.Controls.Add(Me.Seda)
        Me.GroupBox2.Controls.Add(Me.HiloCrudo)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 212)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(248, 177)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Material"
        '
        'txtLino
        '
        Me.txtLino.Enabled = False
        Me.txtLino.Location = New System.Drawing.Point(112, 131)
        Me.txtLino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLino.Name = "txtLino"
        Me.txtLino.Size = New System.Drawing.Size(114, 27)
        Me.txtLino.TabIndex = 7
        Me.txtLino.Text = "0"
        '
        'txtAlgodon
        '
        Me.txtAlgodon.Enabled = False
        Me.txtAlgodon.Location = New System.Drawing.Point(112, 97)
        Me.txtAlgodon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAlgodon.Name = "txtAlgodon"
        Me.txtAlgodon.Size = New System.Drawing.Size(114, 27)
        Me.txtAlgodon.TabIndex = 6
        Me.txtAlgodon.Text = "0"
        '
        'txtSeda
        '
        Me.txtSeda.Enabled = False
        Me.txtSeda.Location = New System.Drawing.Point(112, 61)
        Me.txtSeda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSeda.Name = "txtSeda"
        Me.txtSeda.Size = New System.Drawing.Size(114, 27)
        Me.txtSeda.TabIndex = 5
        Me.txtSeda.Text = "0"
        '
        'txtHilo
        '
        Me.txtHilo.Enabled = False
        Me.txtHilo.Location = New System.Drawing.Point(112, 31)
        Me.txtHilo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHilo.Name = "txtHilo"
        Me.txtHilo.Size = New System.Drawing.Size(114, 27)
        Me.txtHilo.TabIndex = 4
        Me.txtHilo.Text = "0"
        '
        'Lino
        '
        Me.Lino.AutoSize = True
        Me.Lino.Location = New System.Drawing.Point(7, 131)
        Me.Lino.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Lino.Name = "Lino"
        Me.Lino.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lino.Size = New System.Drawing.Size(59, 24)
        Me.Lino.TabIndex = 3
        Me.Lino.Text = "Lino"
        Me.Lino.UseVisualStyleBackColor = True
        '
        'Algodón
        '
        Me.Algodón.AutoSize = True
        Me.Algodón.Location = New System.Drawing.Point(7, 97)
        Me.Algodón.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Algodón.Name = "Algodón"
        Me.Algodón.Size = New System.Drawing.Size(89, 24)
        Me.Algodón.TabIndex = 2
        Me.Algodón.Text = "Algodón"
        Me.Algodón.UseVisualStyleBackColor = True
        '
        'Seda
        '
        Me.Seda.AutoSize = True
        Me.Seda.Location = New System.Drawing.Point(7, 64)
        Me.Seda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Seda.Name = "Seda"
        Me.Seda.Size = New System.Drawing.Size(64, 24)
        Me.Seda.TabIndex = 1
        Me.Seda.Text = "Seda"
        Me.Seda.UseVisualStyleBackColor = True
        '
        'HiloCrudo
        '
        Me.HiloCrudo.AutoSize = True
        Me.HiloCrudo.Location = New System.Drawing.Point(8, 31)
        Me.HiloCrudo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.HiloCrudo.Name = "HiloCrudo"
        Me.HiloCrudo.Size = New System.Drawing.Size(103, 24)
        Me.HiloCrudo.TabIndex = 0
        Me.HiloCrudo.Text = "Hilo Crudo"
        Me.HiloCrudo.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(15, 427)
        Me.Aceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(86, 31)
        Me.Aceptar.TabIndex = 2
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Precio de Costo: Q."
        '
        'lblPrecioCosto
        '
        Me.lblPrecioCosto.AutoSize = True
        Me.lblPrecioCosto.Location = New System.Drawing.Point(430, 81)
        Me.lblPrecioCosto.Name = "lblPrecioCosto"
        Me.lblPrecioCosto.Size = New System.Drawing.Size(36, 20)
        Me.lblPrecioCosto.TabIndex = 4
        Me.lblPrecioCosto.Text = "0.00"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(299, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 27)
        Me.TextBox1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 600)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblPrecioCosto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Imperial As RadioButton
    Friend WithEvents Matrimonial As RadioButton
    Friend WithEvents Queen As RadioButton
    Friend WithEvents King As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lino As CheckBox
    Friend WithEvents Algodón As CheckBox
    Friend WithEvents Seda As CheckBox
    Friend WithEvents HiloCrudo As CheckBox
    Friend WithEvents txtLino As TextBox
    Friend WithEvents txtAlgodon As TextBox
    Friend WithEvents txtSeda As TextBox
    Friend WithEvents txtHilo As TextBox
    Friend WithEvents Aceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPrecioCosto As Label
    Friend WithEvents TextBox1 As TextBox
End Class
