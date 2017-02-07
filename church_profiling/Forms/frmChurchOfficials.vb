Public Class frmChurchOfficials


    Public c As New cart
    Public loc As Integer
    Public button_no As Integer
    Public officials As New Collection
    Public o_position
    
    Private Sub btnHostPastor_Click(sender As Object, e As EventArgs) Handles btnHostPastor.Click
        slide_left()
        button_no = 1
        o_position = "HOST PASTOR"
    End Sub

    Public Sub slide_left()
        lsvMemberInformaion.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        lblSearchMember.Visible = False
        Label9.Visible = False
        txtSearch.Visible = False
        btnSave.Visible = False

        loc = Me.Location.X
        While (Me.Width < 1220)
            Me.Width += 1
          
        End While
        c.displayMemberForChurchOfficial(lsvMemberInformaion)
        lsvMemberInformaion.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        lblSearchMember.Visible = True
        Label9.Visible = True
        txtSearch.Visible = True
        btnSave.Visible = True

    End Sub

    Public Sub slide_right()
        While (Me.Width > 870)
            Me.Width -= 1
        End While
    End Sub

    Private Sub frmChurchOfficials_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub frmChurchOfficials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblSearchMember_Click(sender As Object, e As EventArgs) Handles lblSearchMember.Click
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text.Length > 0 Then
            lblSearchMember.Visible = False
        Else
            lblSearchMember.Visible = True
        End If
    End Sub

    Private Sub lsvMemberInformaion_Click(sender As Object, e As EventArgs) Handles lsvMemberInformaion.Click
        If button_no = 1 Then
            txtHostPastor.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 2 Then
            txtElder.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 3 Then
            txtDeacon1.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 4 Then
            txtDeacon2.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 5 Then
            txtDeacon3.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 6 Then
            txtTreasurer.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        ElseIf button_no = 7 Then
            txtSecretary.Text = lsvMemberInformaion.SelectedItems(0).SubItems(2).Text
        End If
       
    End Sub

    Private Sub btnElder_Click(sender As Object, e As EventArgs) Handles btnElder.Click
        button_no = 2
        o_position = "ELDER"
    End Sub

    Private Sub btnDeacon1_Click(sender As Object, e As EventArgs) Handles btnDeacon1.Click
        button_no = 3
        o_position = "DEACON 1"
    End Sub

    Private Sub btnDeacon2_Click(sender As Object, e As EventArgs) Handles btnDeacon2.Click
        button_no = 4
        o_position = "DEACON 2"
    End Sub

    Private Sub btnDeacon3_Click(sender As Object, e As EventArgs) Handles btnDeacon3.Click
        button_no = 5
        o_position = "DEACON 3"
    End Sub

    Private Sub btnTreasurer_Click(sender As Object, e As EventArgs) Handles btnTreasurer.Click
        button_no = 6
        o_position = "TREASURER"
    End Sub

    Private Sub btnSecretary_Click(sender As Object, e As EventArgs) Handles btnSecretary.Click
        button_no = 7
        o_position = "SECRETARY"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'c.saveChurchOfficial(

    End Sub
End Class