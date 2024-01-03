Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val As String
        val = TextBox1.Text
        cmbState.Items.Add(val)
        MessageBox.Show(val & "state is added....")
        TextBox1.Text = "" 'empty or clear textbox value
    End Sub

    Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged
        cmbCity.Items.Clear() 'clear all

        Dim state As String
        state = cmbState.SelectedItem.ToString
        If state = "GUJ" Then
            cmbCity.Items.Add("Surat")
            cmbCity.Items.Add("Rajkot")
            cmbCity.Items.Add("Vadodra")
            cmbCity.Items.Add("Ahemdabad")
        ElseIf state = "MH" Then
            cmbCity.Items.Add("Mumbai")
            cmbCity.Items.Add("Pune")
            cmbCity.Items.Add("Lonavala")
        ElseIf state = "RJ" Then
            cmbCity.Items.Add("Jaipur")
            cmbCity.Items.Add("Jodhpur")
            cmbCity.Items.Add("Jaisailmair")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cs As Integer
        cs = cmbState.Items.Count
        MsgBox("Total state is " & cs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cc As Integer
        cc = cmbCity.Items.Count
        MsgBox("Total city is " & cc)
    End Sub
End Class
