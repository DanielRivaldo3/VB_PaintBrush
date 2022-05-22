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
        Me.PB_draw = New System.Windows.Forms.PictureBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_color = New System.Windows.Forms.Button()
        Me.cb_size = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PB_draw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_draw
        '
        Me.PB_draw.BackColor = System.Drawing.Color.White
        Me.PB_draw.Location = New System.Drawing.Point(12, 12)
        Me.PB_draw.Name = "PB_draw"
        Me.PB_draw.Size = New System.Drawing.Size(373, 344)
        Me.PB_draw.TabIndex = 0
        Me.PB_draw.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(391, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 36)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Save (debug folder)"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(391, 54)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(80, 36)
        Me.btn_clear.TabIndex = 2
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_color
        '
        Me.btn_color.Location = New System.Drawing.Point(391, 96)
        Me.btn_color.Name = "btn_color"
        Me.btn_color.Size = New System.Drawing.Size(80, 36)
        Me.btn_color.TabIndex = 3
        Me.btn_color.Text = "Color"
        Me.btn_color.UseVisualStyleBackColor = True
        '
        'cb_size
        '
        Me.cb_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_size.FormattingEnabled = True
        Me.cb_size.Items.AddRange(New Object() {"2", "4", "6", "8", "10"})
        Me.cb_size.Location = New System.Drawing.Point(391, 138)
        Me.cb_size.Name = "cb_size"
        Me.cb_size.Size = New System.Drawing.Size(80, 21)
        Me.cb_size.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 368)
        Me.Controls.Add(Me.cb_size)
        Me.Controls.Add(Me.btn_color)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.PB_draw)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paint Brush"
        CType(Me.PB_draw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PB_draw As System.Windows.Forms.PictureBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_color As System.Windows.Forms.Button
    Friend WithEvents cb_size As System.Windows.Forms.ComboBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
