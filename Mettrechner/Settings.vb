Public Class Settings
    ' Einstellungen speichern
    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        My.Settings.BroetchenProPerson = Tb_BroetchenProPerson.Text
        My.Settings.MettProBroetchen = Tb_MettProBroetchen.Text
        My.Settings.Save()
        Me.Close()
    End Sub
    ' Einstellungen vom System laden
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tb_BroetchenProPerson.Text = My.Settings.BroetchenProPerson
        Tb_MettProBroetchen.Text = My.Settings.MettProBroetchen
    End Sub
End Class