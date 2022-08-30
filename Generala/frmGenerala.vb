Public Class frmGenerala
    Private r As New Random()

    Private Sub btnArrojar_Click(sender As Object, e As EventArgs) Handles btnArrojar.Click
        Dim d1 As Integer = r.Next(1, 7)
        Dim d2 As Integer = r.Next(1, 7)
        Dim d3 As Integer = r.Next(1, 7)
        Dim d4 As Integer = r.Next(1, 7)
        Dim d5 As Integer = r.Next(1, 7)

        lblMensaje.Text = ""

        DibujarDado(d1, pct1)
        DibujarDado(d2, pct2)
        DibujarDado(d3, pct3)
        DibujarDado(d4, pct4)
        DibujarDado(d5, pct5)

        If (d1 = d2 And d2 = d3 And d3 = d4 And d4 = d5) Then
            lblMensaje.Text = " Obtubiste Generala !!!"
            btnArrojar.Enabled = False
        Else
            If ((d1 = d2 And d1 = d3 And d1 = d4) Or (d1 = d3 And d1 = d4 And d1 = d5) Or
            (d1 = d2 And d1 = d4 And d1 = d5) Or (d1 = d2 And d1 = d3 And d1 = d5) Or
            (d5 = d2 And d5 = d3 And d5 = d4)) Then
                lblMensaje.Text = " Obtubiste Poker !!!"
                btnArrojar.Enabled = False
            Else
                If ((d1 = d2 And d1 = d3 And d4 = d5) Or
                (d1 = d2 And d1 = d4 And d3 = d5) Or
                (d1 = d2 And d1 = d5 And d3 = d4) Or
                (d1 = d4 And d1 = d5 And d2 = d3) Or
                (d1 = d3 And d1 = d5 And d2 = d4) Or
                (d2 = d3 And d2 = d5 And d1 = d4) Or
                (d2 = d3 And d2 = d4 And d1 = d5) Or
                (d2 = d4 And d2 = d5 And d1 = d3) Or
                (d3 = d4 And d3 = d5 And d1 = d2) Or
                (d1 = d3 And d3 = d4 And d2 = d5)) Then
                    lblMensaje.Text = " Obtubiste Full !!!"
                    btnArrojar.Enabled = False
                Else
                    If ((d1 <> d2 And d1 <> d3 And d1 <> d4 And d1 <> d5 And d2 <> d3 And d2 <> d4 And d2 <> d5 And d3 <> d4 And d3 <> d5 And d4 <> d5) And (d1 + d2 + d3 + d4 + d5 = 15)) Then
                        lblMensaje.Text = " Obtubiste Escalera Menor !!!"
                        btnArrojar.Enabled = False
                    Else
                        If ((d1 <> d2 And d1 <> d3 And d1 <> d4 And d1 <> d5 And d2 <> d3 And d2 <> d4 And d2 <> d5 And d3 <> d4 And d3 <> d5 And d4 <> d5) And (d1 + d2 + d3 + d4 + d5 = 20)) Then
                            lblMensaje.Text = " Obtubiste Escalera Mayor !!!"
                            btnArrojar.Enabled = False
                        End If
                    End If
                End If

            End If
        End If
    End Sub
    Private Sub DibujarDado(x As Integer, imagen As PictureBox)
        Select Case (x)
            Case 1
                imagen.Image = My.Resources.dado1
            Case 2
                imagen.Image = My.Resources.dado2
            Case 3
                imagen.Image = My.Resources.dado3
            Case 4
                imagen.Image = My.Resources.dado4
            Case 5
                imagen.Image = My.Resources.dado5
            Case 6
                imagen.Image = My.Resources.dado6
        End Select
    End Sub
    Private Sub btnVolverATirar_Click(sender As Object, e As EventArgs) Handles btnVolverATirar.Click
        btnArrojar.Enabled = True
    End Sub
End Class
