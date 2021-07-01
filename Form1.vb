Public Class Form1

    Public Veriler() As String = Split(My.Settings.Veriler, ",")
    Public SelectedPrf
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a = 0
        'Dim toplm ana ekran borç/alacak bilgilendirme -Not Implemanted-

        If My.Settings.First_time = "0" Then
            Do While a < 20000
                My.Settings.Veriler = My.Settings.Veriler + "silinmiş.a.b.c.5.8.9,"
                a = a + 1
            Loop
            My.Settings.First_time = "1"
        ElseIf My.Settings.First_time = "1" Then


        Else
            SelectedPrf = My.Settings.First_time
            My.Settings.First_time = "1"
            Detay.Close()
            Detay.Show()
            Me.Close()
            GoTo Line1
        End If


        Do While a < Veriler.Length - 1
            Dim veri() As String = Split(Veriler(a), ".")
            If veri(0) = "silinmiş" Then
                a = a + 1
            Else

                'Dim b
                'If veri(4) > veri(5) Then
                '    b = "Borç Var"
                'Else
                '    b = "Alacak Var"
                'End If

                Dim selec() As String = Split(veri(0), "-")
                If Sum.Items.Contains(selec(0) + "                           ") Then
                    a = a + 1
                Else
                    Sum.Items.Add(selec(0) + "                           ")
                    a = a + 1
                End If
            End If
        Loop
Line1:
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SelectedPrf = "silinmiş"
        Detay.Show()
        Me.Close()

    End Sub


    Sub Selecting()
        'Dim selec() As String = Split(Sum.SelectedItem, "-")
        'SelectedPrf = selec(0)
        SelectedPrf = Trim(Sum.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Selecting()
        Detay.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim say = 0

        Do While say < Veriler.Length
            Dim veri() As String = Split(Veriler(say), ".")

            If veri(0) = Trim(Sum.SelectedItem) + "-" + say.ToString Then

                Veriler(say) = "silinmiş" + "." + veri(1) + "." + veri(2) + "." + veri(3) + "." + veri(4) + "." + veri(5) + "." + veri(6)
                My.Settings.Veriler = Join(Veriler, ",")
                say += 1
            Else
                say += 1
            End If

        Loop
        Sum.Items.RemoveAt(Sum.SelectedIndex)

    End Sub
End Class
