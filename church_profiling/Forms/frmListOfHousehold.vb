Public Class frmListOfHousehold

    Public c As New cart

    Private Sub frmListOfHousehold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.displayMemberInformation(lsvListOfMember)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmViewMemberDetails.ShowDialog()
    End Sub
End Class