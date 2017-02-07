Public Class frmRegisterUser

    Public user As New Useraccount

    Private Sub txtFname_TextChanged(sender As Object, e As EventArgs) Handles txtFname.TextChanged
        If txtFname.Text.Length < 1 Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
    End Sub

    Private Sub txtLname_TextChanged(sender As Object, e As EventArgs) Handles txtLname.TextChanged
        If txtLname.Text.Length < 1 Then
            Label2.Visible = True
        Else
            Label2.Visible = False
        End If
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If txtUsername.Text.Length < 1 Then
            Label3.Visible = True
        Else
            Label3.Visible = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Length < 1 Then
            Label4.Visible = True
        Else
            Label4.Visible = False
        End If
    End Sub

    Private Sub cboUsertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsertype.SelectedIndexChanged
        Label5.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        txtFname.Focus()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        txtLname.Focus()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        txtUsername.Focus()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        txtPassword.Focus()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        cboUsertype.Focus()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        With user
            .First_Name = txtFname.Text
            .Last_Name = txtLname.Text
            .Password = txtPassword.Text
            .User_type = cboUsertype.Text
            .Contact_no = txtContactNum.Text
            .saveNewAccount()
            clearInformation()
        End With
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        txtContactNum.Focus()
    End Sub

    Private Sub txtContactNum_TextChanged(sender As Object, e As EventArgs) Handles txtContactNum.TextChanged
        If txtContactNum.Text.Length > 0 Then
            Label7.Visible = False
        Else
            Label7.Visible = True
        End If
    End Sub

    Public Sub clearInformation()
        txtFname.Clear()
        txtLname.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cboUsertype.Text = ""
        txtContactNum.Clear()
        Label5.Visible = True
        txtFname.Focus()
    End Sub
 
End Class