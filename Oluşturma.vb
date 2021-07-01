Public Class Detay

    Public Veriler() As String = Split(My.Settings.Veriler, ",")
    Public Kayıt, Toplm, UnKayıt
    Public Sub ArrayNav()
        If Kayıt = 1 Then
            Toplm = Val(Toplam.Text)
            GoTo Line1
        End If
        Toplm = 0

Line1:

        Dim a = 0
        Do While a < Veriler.Length
            Dim Veri() As String = Split(Veriler(a), ".")

            If Veri(0) = "silinmiş" Then
                If Kayıt = 1 Then
                    UnKayıt += 1
                    KayıtSay.Text = "KAYDEDİLMEMİŞ " + UnKayıt.ToString + " ADET İŞLEM VAR"
                    Veriler(a) = isim.Text + "-" + a.ToString + "." + Tarih.Text + "." + Tip.Text + "." + Acik.Text + "." + Borc.Text + "." + Alacak.Text + "." + Bakiye.Text
                    Grid.Rows.Add(New String() {isim.Text + "-" + a.ToString, Tarih.Text, Tip.Text, Acik.Text, Borc.Text, Alacak.Text, Bakiye.Text})
                    Toplm += Val(Alacak.Text)
                    Toplm -= Val(Borc.Text)

                    GoTo Line2

                End If
            End If

            If Veri(0) = "silinmiş" Then
                a = a + 1
            Else
                Dim selectedP() As String = Split(Veri(0), "-")
                If selectedP(0) = Form1.SelectedPrf Then
                    Grid.Rows.Add(New String() {Veri(0), Veri(1), Veri(2), Veri(3), Veri(4), Veri(5), Veri(6)})
                    'veri4 borç veri5 alacak
                    Toplm -= Veri(4)
                    Toplm += Veri(5)
                    a = a + 1
                Else
                    a = a + 1
                End If
            End If
        Loop

Line2:

        If Toplm < 0 Then
            Label2.Text = "Toplam Borç"
            Toplam.Text = Toplm * -1
        Else
            Label2.Text = "Toplam Alacak"
            Toplam.Text = Toplm
        End If
    End Sub
    Private Sub Oluşturma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tarih.Text = DateAndTime.Today
        Acik.Text = "Yok"
        Alacak.Text = "0"
        Borc.Text = "0"
        Bakiye.Text = "0"
        KayıtSay.Text = ""
        UnKayıt = 0

        If Form1.SelectedPrf = "silinmiş" Then
            ''Yeni veri


        Else
            ''Editleme
            selected.Text = Form1.SelectedPrf
            isim.Text = selected.Text
            isim.Visible = False
            ArrayNav()
        End If
    End Sub

    Private Sub Del_Click(sender As Object, e As EventArgs) Handles Del.Click
        Dim say = 0
        Do While say < Veriler.Length
            Dim Veri() As String = Split(Veriler(say), ".")
            Dim selectedrowindex = Grid.SelectedCells(0).RowIndex
            Dim a

            Dim selectedRow As DataGridViewRow = Grid.Rows(selectedrowindex)

            a = Convert.ToString(selectedRow.Cells("ID").Value)



            If Veri(0) = a Then

                'Grid.Rows.RemoveAt(Grid.SelectedRows(0).Index)

                Dim oneCell As DataGridViewCell

                For Each oneCell In Grid.SelectedCells
                    If (oneCell.Selected) Then
                        Grid.Rows.RemoveAt(oneCell.RowIndex)
                    End If
                Next

                Veriler(say) = "silinmiş" + "." + Veri(1) + "." + Veri(2) + "." + Veri(3) + "." + Veri(4) + "." + Veri(5) + "." + Veri(6)
                UnKayıt += 1
                KayıtSay.Text = "KAYDEDİLMEMİŞ " + UnKayıt.ToString + " ADET İŞLEM VAR"
            Else
                say += 1
            End If
        Loop
        '' veri array inin 0 indexli girdisini silinmiş yap ve yerel veriler array inde ki silinmiş ile başlayan indexin yeni den tanımlanabilir yap
        '' kayıt ederken silinmiş siz olan yerel veriler arraylerini birleştir settings de ki veriler string e kaydet
    End Sub

    Private Sub GeriA_Click(sender As Object, e As EventArgs) Handles GeriA.Click
        If MsgBox("Kaydedilmemiş " + UnKayıt.ToString + " işlem geri alınacak. Devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            My.Settings.First_time = selected.Text

            Form1.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tarih.Text = DateAndTime.Today
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Tip.Click
        If Tip.Text = "Fatura" Then
            Tip.Text = "Ödeme"
        Else
            Tip.Text = "Fatura"
        End If
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        My.Settings.Veriler = Join(Veriler, ",")
        UnKayıt = 0
        KayıtSay.Text = "Tüm işlemler kaydıt edildi"
    End Sub

    Private Sub Eklemek_Click(sender As Object, e As EventArgs) Handles Eklemek.Click

        If isim.Text = "" Then
            MsgBox("İsim girilmedi.")
        ElseIf Tarih.Text = "" Then
            If MsgBox("Tarih girilmedi. Devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Kayıt = 1
                ArrayNav()
                Kayıt = 0
            End If
        ElseIf Acik.Text = "" Then
            If MsgBox("Açıklama girilmedi. Devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Acik.Text = "Yok"
                Kayıt = 1
                ArrayNav()
                Kayıt = 0
            End If
        ElseIf Borc.Text = "" Then
            If MsgBox("Borç girilmedi. Devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Borc.Text = "0"
                Kayıt = 1
                ArrayNav()
                Kayıt = 0
            End If
        ElseIf Alacak.Text = "" Then
            If MsgBox("Alacak girilmedi. Devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Alacak.Text = "0"
                Kayıt = 1
                ArrayNav()
                Kayıt = 0
            End If
        ElseIf Bakiye.Text = "" Then
            If MsgBox("Bakiye girilmedi. Devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Bakiye.Text = "0"
                Kayıt = 1
                ArrayNav()
                Kayıt = 0
            End If
        Else
            Kayıt = 1
            ArrayNav()
            Kayıt = 0
        End If
    End Sub

    Private Sub GeriD_Click(sender As Object, e As EventArgs) Handles GeriD.Click
        If UnKayıt < 0 Then
            If MsgBox("Kaydedilmemiş " + UnKayıt.ToString + " işlem geri alınacak. Devam edilsin mi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Form1.Show()
                Me.Close()
            End If
        Else
            Form1.Show()
            Me.Close()
        End If
    End Sub




    Private Sub Tarih_Click(sender As Object, e As EventArgs) Handles Tarih.Click
        Tarih.Text = ""
    End Sub
    Private Sub Acık_Click(sender As Object, e As EventArgs) Handles Acik.Click
        Acik.Text = ""
    End Sub
    Private Sub Alacak_Click(sender As Object, e As EventArgs) Handles Alacak.Click
        Alacak.Text = ""
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To Grid.RowCount - 2
            For j = 0 To Grid.ColumnCount - 1
                For k As Integer = 1 To Grid.Columns.Count
                    xlWorkSheet.Cells(1, k) = Grid.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = Grid(j, i).Value.ToString()
                Next
            Next
        Next

        'Dim filename = selected.Text + "-" + System.DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss")



        Dim fd As SaveFileDialog = New SaveFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.FileName = selected.Text + "-" + System.DateTime.Now.ToString("dd.MM.yyyy HH-mm-ss")
        fd.InitialDirectory = "C:\"
        fd.Filter = "Excel (.xlsx)|*.xlsx*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If



        xlWorkSheet.SaveAs(strFileName + ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("Çıktı alındı.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Borc_Click(sender As Object, e As EventArgs) Handles Borc.Click
        Borc.Text = ""
    End Sub
    Private Sub Bakiye_Click(sender As Object, e As EventArgs) Handles Bakiye.Click
        Bakiye.Text = ""
    End Sub
End Class