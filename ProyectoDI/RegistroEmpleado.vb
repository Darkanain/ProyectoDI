﻿Public Class RegistroEmpleado
    Dim Resultado As MsgBoxResult
    Private Sub fPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Resultado = CType(MessageBox.Show("¿Desea salir de la apliacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If Resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

    Private Sub btnConf_Click(sender As Object, e As EventArgs) Handles btnConf.Click
        MessageBox.Show("Reserva confirmada", "Confirmación", MessageBoxButtons.OK)

        RemoveHandler MyBase.FormClosing, AddressOf fPrincipal_FormClosing
        Me.Close()
    End Sub

    Private Sub btnCanc_Click(sender As Object, e As EventArgs) Handles btnCanc.Click
        Resultado = CType(MessageBox.Show("¿Desea cancelar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If Resultado = MsgBoxResult.No Then

        Else
            RemoveHandler MyBase.FormClosing, AddressOf fPrincipal_FormClosing
            Me.Close()
        End If
    End Sub

    Private Sub Reg_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("https://www.gambas-es.org/")
        End If
    End Sub
End Class