
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form1

    Dim selectedUser As User
    Dim users As New BindingList(Of User)
    Dim dsUser As New DataSet()

    Dim dbConnection As SqlConnection = ConnectToDb()




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'loading database
        lbxUser.DataSource = users
        lbxUser.DisplayMember = "Name"


        Try
            'creating connection with exception handling 
            Dim dbConnection As SqlConnection = ConnectToDb()
            Dim daUser As New SqlDataAdapter("SELECT * FROM LIFTERS", dbConnection)
            daUser.FillSchema(dsUser, SchemaType.Source, "Lifters")
            daUser.Fill(dsUser, "Lifters")

            daUser.Dispose()
            dbConnection.Close()
            dbConnection.Dispose()

            For Each lifterRow As DataRow In dsUser.Tables("Lifters").Rows

                Dim dbLifter As New User()
                ' Loading the table collums 
                dbLifter.Id = CInt(lifterRow.Item("Id"))
                dbLifter.Name = lifterRow.Item("Name").ToString
                dbLifter.DateSelected = lifterRow.Item("Date Started").ToString
                dbLifter.Squat = CInt(lifterRow.Item("Squat"))
                dbLifter.Deadlift = CInt(lifterRow.Item("Deadlift"))
                dbLifter.BenchPress = CInt(lifterRow.Item("Bench Press"))
                dbLifter.OverHeadPress = CInt(lifterRow.Item("Overhead Press"))

                users.Add(dbLifter)
                selectedUser = dbLifter
                lbxUser.SelectedItem = selectedUser
            Next
        Catch ex As Exception
            MessageBox.Show("The following error occured: " + ex.Message)
        End Try


    End Sub

    Private Function ConnectToDb() As SqlConnection
        ' Function to connect to the file path
        Dim ConnectionString As String = "Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\olson\Documents\Semester_2\.NET\531Program_Portfolio_molson172\531Program_Portfolio_molson172\UserDB.mdf;Integrated Security=True"
        Dim dbConnection As New SqlConnection(ConnectionString)
        dbConnection.Open()

        Return dbConnection
    End Function

    Private Sub displayStats()
        ' sub to display training max for the user
        If selectedUser IsNot Nothing Then
            txtDateStarted.Text = CType(selectedUser.DateSelected, String)
            txtSquatTrn.Text = CType(selectedUser.Squat * 0.9, String)
            txtDeadliftTrn.Text = CType(selectedUser.Deadlift * 0.9, String)
            txtBpressTrn.Text = CType(selectedUser.BenchPress * 0.9, String)
            txtOpressTrn.Text = CType(selectedUser.OverHeadPress * 0.9, String)

        Else

            txtSquatTrn.Text = "0"
            txtDeadliftTrn.Text = "0"
            txtBpressTrn.Text = "0"
            txtOpressTrn.Text = "0"

        End If

    End Sub

    Private Sub bntCreate_Click(sender As Object, e As EventArgs) Handles bntCreate.Click
        Dim newUser As New User
        newUser.Name = txtName.Text
        Try

            'converting the Date selected to a string and storing that into the stats. 
            txtDateStarted.Text = mncDateStarted.SelectionRange.Start.Date.ToString("dd-MM-yyyy")
            newUser.DateSelected = txtDateStarted.Text
            newUser.Squat = CInt(txtSquat.Text)
            newUser.Deadlift = CInt(txtDeadlift.Text)
            newUser.BenchPress = CInt(txtBpress.Text)
            newUser.OverHeadPress = CInt(txtOpress.Text)

        Catch ex As Exception
            MessageBox.Show("The following error occured: " + ex.Message)
        End Try

        selectedUser = newUser
        users.Add(newUser)
        lbxUser.SelectedItem = selectedUser

    End Sub

    Private Sub lbxUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxUser.SelectedIndexChanged
        selectedUser = CType(lbxUser.SelectedItem, User)
        displayStats()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If lbxUser.SelectedItem IsNot Nothing Then
            Dim dbConnection As SqlConnection = ConnectToDb()
            Dim daUser As New SqlDataAdapter("SELECT * FROM LIFTERS", dbConnection)

            ' command building to update or insert data based on if ID is present in database
            Dim cmdBuilder As New SqlCommandBuilder(daUser)
            ' commands used based on ID
            daUser.InsertCommand = cmdBuilder.GetInsertCommand()
            daUser.UpdateCommand = cmdBuilder.GetUpdateCommand()

            If dsUser.Tables("Lifters").Rows.Contains(selectedUser.Id) Then
                Dim existingRow As DataRow = dsUser.Tables("Lifters").Rows.Find(selectedUser.Id)
                fillRow(existingRow)

            Else
                Dim newRow As DataRow = dsUser.Tables("Lifters").NewRow

                fillRow(newRow)
                dsUser.Tables("Lifters").Rows.Add(newRow)
                selectedUser.Id = CInt(newRow.Item("Id"))
            End If

            Try
                daUser.Update(dsUser, "Lifters")
                MessageBox.Show(selectedUser.Name + " Has been saved to the database.")

                daUser.Dispose()
                dbConnection.Close()
                dbConnection.Dispose()
            Catch ex As Exception
                MessageBox.Show("The following error occured: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub fillRow(row As DataRow)
        ' sub to fill the updated or new data into existing rows. 
        row.Item("Name") = selectedUser.Name
        row.Item("Date Started") = selectedUser.DateSelected
        row.Item("Squat") = selectedUser.Squat
        row.Item("DeadLift") = selectedUser.Deadlift
        row.Item("Bench Press") = selectedUser.BenchPress
        row.Item("Overhead Press") = selectedUser.OverHeadPress
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lbxUser.SelectedItem IsNot Nothing Then
            Dim dbConnection As SqlConnection = ConnectToDb()
            Dim daUser As New SqlDataAdapter("SELECT * FROM LIFTERS", dbConnection)
            Dim cmdBuilder As New SqlCommandBuilder(daUser)

            ' Command used if ID is present
            daUser.DeleteCommand = cmdBuilder.GetDeleteCommand()

            dsUser.Tables("Lifters").Rows.Find(selectedUser.Id).Delete()

            Try
                ' Error Hanlding for deleting the users
                daUser.Update(dsUser, "Lifters")
                MessageBox.Show(selectedUser.Name + " Has been Deleted from the database.")

                daUser.Dispose()
                dbConnection.Close()
                dbConnection.Dispose()
            Catch ex As Exception
                MessageBox.Show("The following error occured: " + ex.Message)
            End Try
        End If

        users.Remove(CType(lbxUser.SelectedItem, User))

        ' Making sure that a user is selected after one is deleted. 
        If lbxUser.SelectedItem IsNot Nothing Then
            selectedUser = CType(lbxUser.SelectedItem, User)
            displayStats()

        Else
            selectedUser = Nothing
        End If
    End Sub
End Class
