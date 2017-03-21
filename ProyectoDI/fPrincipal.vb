Public Class fPrincipal
    Dim resource As String
    Public Sub idioma_Click(sender As Object, e As EventArgs) Handles selectEsp.Click, selectEng.Click
        'Hacemos la comprobacion del idioma
        If sender.Equals(selectEsp) Then
            If selectEng.Checked = True Then
                selectEng.Checked = False
                selectEsp.Checked = True
            End If
            resource = "es-ES"
        ElseIf sender.Equals(selectEng) Then
            If selectEsp.Checked = True Then
                selectEsp.Checked = False
                selectEng.Checked = True
            End If
            resource = "en"
        End If
        traducirInterfaz(resource)
    End Sub

    Private Sub traducirInterfaz(resource As String)
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo(resource)
        My.Settings.Save()
        Controls.Clear()
        InitializeComponent()
    End Sub

    Dim Resultado As MsgBoxResult
    Private Sub fPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Segun el idioma saca el mensaje en un idioma especifico
        If resource = "en" Then
            Resultado = CType(MessageBox.Show("Do you want to exit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        Else
            Resultado = CType(MessageBox.Show("¿Desea salir de la apliacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        End If

        If Resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub btnRNormal_Click(sender As Object, e As EventArgs) Handles btnRNormal.Click
        Dim frm As New RegistroEmpleado()

        'Pasamos el logo del from y la imagen principal
        frm.ControlRegistro.setpbLogo(My.Resources.rlogo2)

        frm.Icon = My.Resources.logo2

        frm.ShowDialog()
    End Sub

    Private Sub btnRLol_Click(sender As Object, e As EventArgs) Handles btnRLol.Click
        Dim frm As New RegistroEmpleado()

        'Pasamos el logo del from y la imagen principal
        frm.ControlRegistro.setpbLogo(My.Resources.rlogo1)

        frm.Icon = My.Resources.logo1

        frm.ShowDialog()
    End Sub

    Private Sub ayudaOnline_Click(sender As Object, e As EventArgs) Handles ayudaOnline.Click
        'Cuando pulsamos el boton de ayuda que nos mande a esta pagina
        System.Diagnostics.Process.Start("https://www.gambas-es.org/")
    End Sub

    Private Sub Reserv_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Cuando pulsamos F1 que nos mande a una pagina de ayuda
        If e.KeyCode = Keys.F1 Then
            ayudaOnline_Click(Nothing, Nothing)
        End If
    End Sub
End Class
