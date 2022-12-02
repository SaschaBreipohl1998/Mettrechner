<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_Berechnen = New System.Windows.Forms.Button()
        Me.Btn_Settings = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tb_Personenanzahl = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_Berechnen
        '
        Me.Btn_Berechnen.Location = New System.Drawing.Point(12, 263)
        Me.Btn_Berechnen.Name = "Btn_Berechnen"
        Me.Btn_Berechnen.Size = New System.Drawing.Size(243, 23)
        Me.Btn_Berechnen.TabIndex = 1
        Me.Btn_Berechnen.Text = "Berechnen"
        Me.Btn_Berechnen.UseVisualStyleBackColor = True
        '
        'Btn_Settings
        '
        Me.Btn_Settings.Location = New System.Drawing.Point(12, 292)
        Me.Btn_Settings.Name = "Btn_Settings"
        Me.Btn_Settings.Size = New System.Drawing.Size(243, 23)
        Me.Btn_Settings.TabIndex = 2
        Me.Btn_Settings.Text = "Einstellungen"
        Me.Btn_Settings.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Personenanzahl"
        '
        'Tb_Personenanzahl
        '
        Me.Tb_Personenanzahl.Location = New System.Drawing.Point(12, 210)
        Me.Tb_Personenanzahl.Name = "Tb_Personenanzahl"
        Me.Tb_Personenanzahl.Size = New System.Drawing.Size(243, 23)
        Me.Tb_Personenanzahl.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 152)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(267, 328)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Tb_Personenanzahl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Settings)
        Me.Controls.Add(Me.Btn_Berechnen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mettrechner"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Berechnen As Button
    Friend WithEvents Btn_Settings As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Tb_Personenanzahl As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
