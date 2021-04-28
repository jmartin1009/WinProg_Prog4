Public Class Form1
    'Handles user clicking the show button
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If (txtDBFilePath.Text = "" Or txtDBFilePath.Text = "Enter full file path for database file") Then
            MessageBox.Show("Please enter a file path for the database you wish to access!!", "Windows Programming - Program 4",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Dim dt = Prog4_DLL.fnShow(txtDBFilePath.Text)
            Me.dvgEmployee.DataSource = dt
        End If
    End Sub
    'Handles user clicking the delete button
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (txtDBFilePath.Text = "" Or txtDBFilePath.Text = "Enter full file path for database file") Then
            MessageBox.Show("Please enter a file path for the database you wish to access!!", "Windows Programming - Program 4",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Prog4_DLL.fnDelete(txtDeleteID.Text, txtDBFilePath.Text)
        End If
    End Sub
    'Handles user clicking the insert button
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If (txtDBFilePath.Text = "" Or txtDBFilePath.Text = "Enter full file path for database file") Then
            MessageBox.Show("Please enter a file path for the database you wish to access!!", "Windows Programming - Program 4",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Prog4_DLL.fnInsert(txtID.Text, txtName.Text, Convert.ToInt32(txtSalary.Text), txtAddress.Text, txtDBFilePath.Text)
        End If
    End Sub
End Class
