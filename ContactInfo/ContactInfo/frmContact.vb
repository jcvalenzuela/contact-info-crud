
Imports System.Data.OleDb
Public Class frmContact
    Dim PK As Integer   '// Local variable.
    Dim NewData As Boolean = False  '// NewData = True (Add), False is Edit mode.
    Private Sub frmContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = ConnectDataBase()
        lblRecordCount.Text = ""
        Call NewMode()
        Call SetupDGVData()
        Call RetrieveData()
    End Sub

    Private Sub SetupDGVData()
        With dgvData
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .ReadOnly = True
            .Font = New Font("Tahoma", 9)
            ' Columns Specified
            .Columns.Add("ContactID", "ContactID")
            .Columns.Add("Fullname", "Full name")
            .Columns.Add("Nickname", "Nickname")
            .Columns.Add("Address", "Address")
            .Columns.Add("Course", "Course")
            .Columns.Add("Birthdate", "Birthdate")
            .Columns.Add("Age", "Age")
            .Columns.Add("MobileNo", "MobileNo")
            .Columns.Add("TelephoneNo", "TelephoneNo")
            .Columns.Add("EmailAddress", "Email Address")

            '// Hidden Columns
            .Columns(0).Visible = False

            ' Autosize Column
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoResizeColumns()
            '// Even-Odd Color
            .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
            ' Adjust Header Styles
            With .ColumnHeadersDefaultCellStyle
                .BackColor = Color.White
                .ForeColor = Color.Black ' Color.White
                .Font = New Font("Tahoma", 9, FontStyle.Bold)
            End With
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtFullName.Text = "" Or IsNothing(txtFullName.Text) Or txtFullName.Text.Length = 0 Then
            MessageBox.Show("Full name cannot be empty.", "Report Status",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFullName.Focus()
            Exit Sub
        End If

        If NewData Then
            '// Is there a duplicate of the existing one?
            strSQL =
                " SELECT Count(tblContactInfo.Fullname) AS CountFullname FROM tblContactInfo " &
                " WHERE Fullname = " & "'" & txtFullName.Text & "'"
            If DuplicateName(strSQL) Then
                MessageBox.Show("Duplicate Fullname, please enter new value.", "Report Status",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtFullName.Focus()
                Exit Sub
            End If
            '//
            strSQL = "INSERT INTO tblContactInfo(" &
                " ContactID, Fullname, Nickname, Address, Course, BirthDate, Age, MobileNo, TelephoneNo, EmailAddress) " &
                " VALUES(" &
                "'" & SetupNewPK() & "'," &
                "'" & txtFullName.Text & "'," &
                "'" & txtNickname.Text & "'," &
                "'" & txtAddress.Text & "'," &
                "'" & txtCourse.Text & "'," &
                "'" & dtBirthdate.Value & "'," &
                "'" & txtAge.Text & "'," &
                "'" & txtMobileNo.Text & "'," &
                "'" & txtPhoneNo.Text & "'," &
                "'" & txtEmailAdd.Text & "'" &
                ")"
            '// EDIT MODE
        Else
            '// If the new value (Text) with the original value (Tag) is not equal, then the value changed in field "Fullname"
            If txtFullName.Text <> txtFullName.Tag Then
                strSQL =
                " SELECT Count(tblContactInfo.Fullname) AS CountFullname FROM tblContactInfo " &
                " WHERE Fullname = " & "'" & txtFullName.Text & "'"
                If DuplicateName(strSQL) Then
                    MessageBox.Show("Duplicate Full name, please enter new value.", "Report Status",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtFullName.Focus()
                    Exit Sub
                End If
            End If
            '// START UPDATE
            strSQL = "UPDATE tblContactInfo SET " &
                     "[Fullname]='" & txtFullName.Text & "'," &
                     "[Nickname]='" & txtNickname.Text & "'," &
                     "[Address]='" & txtAddress.Text & "', " &
                     "[Course]='" & txtCourse.Text & "'," &
                     "[BirthDate]='" & dtBirthdate.Value & "'," &
                     "[Age]='" & txtAge.Text & "'," &
                     "[MobileNo]='" & txtMobileNo.Text & "', " &
                     "[TelephoneNo]='" & txtPhoneNo.Text & "'," &
                     "[EmailAddress]='" & txtEmailAdd.Text & "'" &
                     "WHERE ContactID = " & PK & ""
        End If
        '// Insert or Update same as operation
        DoSQL(strSQL)
        '//

        '// Clear rows in DataGridView
        dgvData.Rows.Clear()
        '// Refresh DataGridView
        Call RetrieveData()
        '// Add New Mode
        Call NewMode()
    End Sub

    Public Function DuplicateName(ByVal Sql As String) As Boolean
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        Cmd = New OleDb.OleDbCommand(Sql, Conn)
        ' Return count records
        DuplicateName = Cmd.ExecuteScalar
    End Function

    ' / Function to find and create the new Primary Key not to duplicate.
    Function SetupNewPK() As Long
        strSQL =
            " SELECT MAX(tblContactInfo.ContactID) AS MaxPK FROM tblContactInfo "
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        Cmd = New OleDb.OleDbCommand(strSQL, Conn)
        '/ Check if the information is available. And return it back
        If IsDBNull(Cmd.ExecuteScalar) Then
            '// Start at 1
            SetupNewPK = 1
        Else
            SetupNewPK = Cmd.ExecuteScalar + 1
        End If
    End Function

    '// UPDATE DATA
    Private Sub DoSQL(ByVal Sql As String)
        Cmd = New OleDb.OleDbCommand
        If Conn.State = ConnectionState.Closed Then Conn.Open()
        'MsgBox(Sql)
        Try
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = Sql
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Records Updated Completed.", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NewMode()
        '// Clear all TextBox.
        For Each c In GroupBox1.Controls
            If TypeOf c Is TextBox Then
                DirectCast(c, TextBox).Clear()
                DirectCast(c, TextBox).Enabled = False
            End If
        Next
        '// Clear all ComboBox
        For Each cbo In GroupBox1.Controls.OfType(Of ComboBox)()
            cbo.Enabled = False
        Next
        '//
        btnAdd.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnDelete.Text = "Delete"
        btnRefresh.Enabled = True
        '//
    End Sub

    Private Sub EditMode()
        '// Clear all TextBox
        For Each c In GroupBox1.Controls
            If TypeOf c Is TextBox Then
                DirectCast(c, TextBox).Enabled = True
            End If
        Next

        btnAdd.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = True
        btnDelete.Text = "Cancel"
        btnRefresh.Enabled = False
        '//
    End Sub

    Private Sub RetrieveData(Optional ByVal blnSearch As Boolean = False)
        strSQL = " SELECT * FROM tblContactInfo "

        '// blnSearch = True for Serach
        If blnSearch Then
            strSQL = strSQL &
                " WHERE " &
             " [Fullname]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [Nickname]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [Address]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [Course]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [BirthDate]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [Age]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [MobileNo]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [TelephoneNo]" & " Like '%" & txtSearch.Text & "%'" & " OR " &
                " [EmailAddress] " & " Like '%" & txtSearch.Text & "%'" &
                  " ORDER BY ContactID "
        Else
            strSQL = strSQL & " ORDER BY ContactID "
        End If
        '//
        Try
            Cmd = New OleDbCommand
            If Conn.State = ConnectionState.Closed Then Conn.Open()
            Cmd.Connection = Conn
            Cmd.CommandText = strSQL
            Dim DR As OleDbDataReader = Cmd.ExecuteReader
            Dim i As Long = dgvData.RowCount
            While DR.Read
                With dgvData
                    .Rows.Add(i)
                    .Rows(i).Cells(0).Value = DR.Item("ContactID").ToString
                    .Rows(i).Cells(1).Value = DR.Item("Fullname").ToString
                    .Rows(i).Cells(2).Value = DR.Item("Nickname").ToString
                    .Rows(i).Cells(3).Value = DR.Item("Address").ToString
                    .Rows(i).Cells(4).Value = DR.Item("Course").ToString
                    .Rows(i).Cells(5).Value = DR.Item("BirthDate").ToString
                    .Rows(i).Cells(6).Value = DR.Item("Age").ToString
                    .Rows(i).Cells(7).Value = DR.Item("MobileNo").ToString
                    .Rows(i).Cells(8).Value = DR.Item("TelephoneNo").ToString
                    .Rows(i).Cells(9).Value = DR.Item("EmailAddress").ToString


                End With
                i += 1
            End While
            lblRecordCount.Text = "[Total : " & dgvData.RowCount & " records]"
            DR.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '//
        txtSearch.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        NewData = True  '// Add New Mode
        EditMode()
        '//
        txtFullName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        '// If Edit Data Mode
        If btnDelete.Text = "Cancel" Then
            btnAdd.Enabled = True
            btnSave.Enabled = True
            btnDelete.Enabled = True
            btnDelete.Text = "Delete"
            btnRefresh.Enabled = True
            NewMode()
        Else
            If dgvData.RowCount = 0 Then Exit Sub
            '// Receive Primary Key value to confirm the deletion.
            Dim iRow As Long = dgvData.Item(0, dgvData.CurrentRow.Index).Value
            Dim FName As String = dgvData.Item(1, dgvData.CurrentRow.Index).Value
            Dim Result As Byte = MessageBox.Show("Are you sure you want to delete the data?" & vbCrLf & "Full Name: " & FName, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Result = DialogResult.Yes Then
                '// iRow is the ContactPK or Primary key that is hidden.
                strStmt = " DELETE FROM tblContactInfo WHERE ContactID = " & iRow
                '// UPDATE RECORD
                DoSQL(strStmt)
                '// Delete Current Row.
                dgvData.Rows.Remove(dgvData.CurrentRow)
                '//
                Call NewMode()
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dgvData.Rows.Clear()
        Call RetrieveData()
    End Sub

    Private Sub frmContact_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If Conn.State = ConnectionState.Open Then Conn.Close()
        Conn.Dispose()
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        'Undesirable characters from DB
        txtSearch.Text = Replace(Trim(txtSearch.Text), "'", "")
        txtSearch.Text = Replace(Trim(txtSearch.Text), "%", "")
        txtSearch.Text = Replace(Trim(txtSearch.Text), "*", "")
        If Trim(txtSearch.Text) = "" Or Len(Trim(txtSearch.Text)) = 0 Then Exit Sub
        'Retrieve
        If e.KeyChar = Chr(13) Then '//Enter Key
            e.Handled = True
            dgvData.Rows.Clear()
            Call RetrieveData(True)
        End If
    End Sub

    Private Sub dgvData_DoubleClick(sender As Object, e As EventArgs) Handles dgvData.DoubleClick
        If btnDelete.Text = "Cancel" Then
            Dim Result As Byte = MessageBox.Show("Do you want to abort the on-screen action?" & vbCrLf &
                                                 "Yes, If you want to abort or " & vbCrLf &
                                                 "No, If you want to continue.", "Confirm you job",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

            If Result = DialogResult.No Then Exit Sub
        End If

        Dim iRow As Integer
        'Read the value of the focus row
        iRow = dgvData.CurrentRow.Index
        'Keep the Primary Key
        PK = dgvData.Item(0, iRow).Value
        txtFullName.Text = "" & dgvData.Item(1, iRow).Value
        txtNickname.Text = "" & dgvData.Item(2, iRow).Value
        txtAddress.Text = "" & dgvData.Item(3, iRow).Value
        txtCourse.Text = "" & dgvData.Item(4, iRow).Value
        dtBirthdate.Text = "" & dgvData.Item(5, iRow).Value
        txtAge.Text = "" & dgvData.Item(6, iRow).Value
        txtMobileNo.Text = "" & dgvData.Item(7, iRow).Value
        txtPhoneNo.Text = "" & dgvData.Item(8, iRow).Value
        txtEmailAdd.Text = "" & dgvData.Item(9, iRow).Value

        NewData = False
        EditMode()
    End Sub
End Class
