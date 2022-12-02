<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Lbl_BroetchenProPerson = New System.Windows.Forms.Label()
        Me.Lbl_MettProBroetchen = New System.Windows.Forms.Label()
        Me.Tb_BroetchenProPerson = New System.Windows.Forms.TextBox()
        Me.Tb_MettProBroetchen = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(182, 124)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Save.TabIndex = 2
        Me.Btn_Save.Text = "Speichern"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Lbl_BroetchenProPerson
        '
        Me.Lbl_BroetchenProPerson.AutoSize = True
        Me.Lbl_BroetchenProPerson.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_BroetchenProPerson.Name = "Lbl_BroetchenProPerson"
        Me.Lbl_BroetchenProPerson.Size = New System.Drawing.Size(155, 15)
        Me.Lbl_BroetchenProPerson.TabIndex = 10
        Me.Lbl_BroetchenProPerson.Text = "Brötchen pro Person [Stück]"
        '
        'Lbl_MettProBroetchen
        '
        Me.Lbl_MettProBroetchen.AutoSize = True
        Me.Lbl_MettProBroetchen.Location = New System.Drawing.Point(12, 64)
        Me.Lbl_MettProBroetchen.Name = "Lbl_MettProBroetchen"
        Me.Lbl_MettProBroetchen.Size = New System.Drawing.Size(122, 15)
        Me.Lbl_MettProBroetchen.TabIndex = 11
        Me.Lbl_MettProBroetchen.Text = "Mett pro Brötchen [g]"
        '
        'Tb_BroetchenProPerson
        '
        Me.Tb_BroetchenProPerson.Location = New System.Drawing.Point(12, 27)
        Me.Tb_BroetchenProPerson.Name = "Tb_BroetchenProPerson"
        Me.Tb_BroetchenProPerson.Size = New System.Drawing.Size(245, 23)
        Me.Tb_BroetchenProPerson.TabIndex = 0
        '
        'Tb_MettProBroetchen
        '
        Me.Tb_MettProBroetchen.Location = New System.Drawing.Point(12, 82)
        Me.Tb_MettProBroetchen.Name = "Tb_MettProBroetchen"
        Me.Tb_MettProBroetchen.Size = New System.Drawing.Size(245, 23)
        Me.Tb_MettProBroetchen.TabIndex = 1
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 162)
        Me.Controls.Add(Me.Tb_MettProBroetchen)
        Me.Controls.Add(Me.Tb_BroetchenProPerson)
        Me.Controls.Add(Me.Lbl_MettProBroetchen)
        Me.Controls.Add(Me.Lbl_BroetchenProPerson)
        Me.Controls.Add(Me.Btn_Save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mettformel anpassen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Save As Button
    Friend WithEvents Lbl_BroetchenProPerson As Label
    Friend WithEvents Lbl_MettProBroetchen As Label
    Friend WithEvents Tb_BroetchenProPerson As TextBox
    Friend WithEvents Tb_MettProBroetchen As TextBox
End Class
