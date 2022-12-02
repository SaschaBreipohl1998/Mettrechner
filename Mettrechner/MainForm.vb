Public Class MainForm
    ' Einstellungsfenster beim Klick auf den Button "Einstellungen" öffnen
    Private Sub Btn_Settings_Click(sender As Object, e As EventArgs) Handles Btn_Settings.Click
        Settings.ShowDialog()
    End Sub
    ' Beim Klick auf Berechnen mittels der Mettformel und Personenzahl die entsprechende Menge Mett berechnen
    Private Sub Btn_Berechnen_Click(sender As Object, e As EventArgs) Handles Btn_Berechnen.Click
        Dim AnzahlPersonen As Integer = Tb_Personenanzahl.Text
        Dim MettProBroetchen As Integer = My.Settings.MettProBroetchen
        Dim BroetchenProPerson As Integer = My.Settings.BroetchenProPerson
    End Sub
End Class
