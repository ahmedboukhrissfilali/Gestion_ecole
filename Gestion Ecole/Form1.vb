Public Class Form1
    Private Sub BTN_Annuler_Click(sender As Object, e As EventArgs) Handles BTN_Annuler.Click
        Dim Reponse As String
        Reponse = MsgBox("Voulez-vous quitter l'application ?", vbYesNo + vbQuestion, "Erreur")
        If Reponse = vbYes Then End
    End Sub

    Private Sub BTN_OK_Click(sender As Object, e As EventArgs) Handles BTN_OK.Click
        If Txt_Login.Text = "" Then
            MsgBox("Vous devez saisir votre Login !!!", vbCritical, "Erreur")
            Txt_Login.Focus()
            Exit Sub
        End If
        If Txt_Mot_Passe.Text = "" Then
            MsgBox("Vous devez saisir votre Mot de passe !!!", vbCritical, "Erreur")
            Txt_Mot_Passe.Focus()
            Exit Sub
        End If
        'Vérifier la validité du Login et Mot de passe

        'Lancer la feuille principale
        Frm_Principale.Show()

    End Sub
End Class
