<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContact
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.dtBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtEmailAdd = New System.Windows.Forms.TextBox()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblEmailAdd = New System.Windows.Forms.Label()
        Me.lblMobileNo = New System.Windows.Forms.Label()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblBirthdate = New System.Windows.Forms.Label()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNickname = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.dtBirthdate)
        Me.GroupBox1.Controls.Add(Me.txtEmailAdd)
        Me.GroupBox1.Controls.Add(Me.txtMobileNo)
        Me.GroupBox1.Controls.Add(Me.txtPhoneNo)
        Me.GroupBox1.Controls.Add(Me.txtCourse)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtNickname)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.lblEmailAdd)
        Me.GroupBox1.Controls.Add(Me.lblMobileNo)
        Me.GroupBox1.Controls.Add(Me.lblPhoneNo)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.lblBirthdate)
        Me.GroupBox1.Controls.Add(Me.lblCourse)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNickname)
        Me.GroupBox1.Controls.Add(Me.lblFullName)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 278)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contact Information"
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Location = New System.Drawing.Point(748, 188)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(84, 23)
        Me.btnRefresh.TabIndex = 22
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Location = New System.Drawing.Point(658, 188)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 23)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(568, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(478, 188)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'dtBirthdate
        '
        Me.dtBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthdate.Location = New System.Drawing.Point(82, 161)
        Me.dtBirthdate.Name = "dtBirthdate"
        Me.dtBirthdate.Size = New System.Drawing.Size(284, 23)
        Me.dtBirthdate.TabIndex = 18
        Me.dtBirthdate.Value = New Date(2021, 5, 6, 0, 0, 0, 0)
        '
        'txtEmailAdd
        '
        Me.txtEmailAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailAdd.Location = New System.Drawing.Point(548, 127)
        Me.txtEmailAdd.Multiline = True
        Me.txtEmailAdd.Name = "txtEmailAdd"
        Me.txtEmailAdd.Size = New System.Drawing.Size(284, 23)
        Me.txtEmailAdd.TabIndex = 17
        '
        'txtMobileNo
        '
        Me.txtMobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNo.Location = New System.Drawing.Point(548, 96)
        Me.txtMobileNo.Multiline = True
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(284, 23)
        Me.txtMobileNo.TabIndex = 16
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNo.Location = New System.Drawing.Point(548, 60)
        Me.txtPhoneNo.Multiline = True
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(284, 23)
        Me.txtPhoneNo.TabIndex = 15
        '
        'txtCourse
        '
        Me.txtCourse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCourse.Location = New System.Drawing.Point(548, 26)
        Me.txtCourse.Multiline = True
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(284, 23)
        Me.txtCourse.TabIndex = 14
        '
        'txtAge
        '
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Location = New System.Drawing.Point(82, 190)
        Me.txtAge.Multiline = True
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(284, 23)
        Me.txtAge.TabIndex = 13
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(82, 89)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(284, 60)
        Me.txtAddress.TabIndex = 11
        '
        'txtNickname
        '
        Me.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNickname.Location = New System.Drawing.Point(82, 59)
        Me.txtNickname.Multiline = True
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(284, 23)
        Me.txtNickname.TabIndex = 10
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Location = New System.Drawing.Point(82, 25)
        Me.txtFullName.Multiline = True
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(284, 23)
        Me.txtFullName.TabIndex = 9
        '
        'lblEmailAdd
        '
        Me.lblEmailAdd.AutoSize = True
        Me.lblEmailAdd.Location = New System.Drawing.Point(446, 130)
        Me.lblEmailAdd.Name = "lblEmailAdd"
        Me.lblEmailAdd.Size = New System.Drawing.Size(90, 15)
        Me.lblEmailAdd.TabIndex = 8
        Me.lblEmailAdd.Text = "Email Address : "
        '
        'lblMobileNo
        '
        Me.lblMobileNo.AutoSize = True
        Me.lblMobileNo.Location = New System.Drawing.Point(446, 99)
        Me.lblMobileNo.Name = "lblMobileNo"
        Me.lblMobileNo.Size = New System.Drawing.Size(72, 15)
        Me.lblMobileNo.TabIndex = 7
        Me.lblMobileNo.Text = "Mobile No : "
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(446, 63)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(69, 15)
        Me.lblPhoneNo.TabIndex = 6
        Me.lblPhoneNo.Text = "Phone No : "
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(6, 197)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(37, 15)
        Me.lblAge.TabIndex = 5
        Me.lblAge.Text = "Age : "
        '
        'lblBirthdate
        '
        Me.lblBirthdate.AutoSize = True
        Me.lblBirthdate.Location = New System.Drawing.Point(6, 169)
        Me.lblBirthdate.Name = "lblBirthdate"
        Me.lblBirthdate.Size = New System.Drawing.Size(64, 15)
        Me.lblBirthdate.TabIndex = 4
        Me.lblBirthdate.Text = "Birthdate : "
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(446, 34)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(53, 15)
        Me.lblCourse.TabIndex = 3
        Me.lblCourse.Text = "Course : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address : "
        '
        'lblNickname
        '
        Me.lblNickname.AutoSize = True
        Me.lblNickname.Location = New System.Drawing.Point(6, 62)
        Me.lblNickname.Name = "lblNickname"
        Me.lblNickname.Size = New System.Drawing.Size(70, 15)
        Me.lblNickname.TabIndex = 1
        Me.lblNickname.Text = "Nickname : "
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(6, 33)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(70, 15)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lblSearch)
        Me.GroupBox2.Controls.Add(Me.lblRecordCount)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.dgvData)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(869, 232)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Listings"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(13, 30)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(51, 15)
        Me.lblSearch.TabIndex = 16
        Me.lblSearch.Text = "Search : "
        '
        'lblRecordCount
        '
        Me.lblRecordCount.AutoSize = True
        Me.lblRecordCount.Location = New System.Drawing.Point(373, 24)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(15, 15)
        Me.lblRecordCount.TabIndex = 15
        Me.lblRecordCount.Text = "[]"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(83, 22)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(284, 23)
        Me.txtSearch.TabIndex = 14
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToOrderColumns = True
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.BackgroundColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(7, 51)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.RowTemplate.Height = 25
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(856, 175)
        Me.dgvData.TabIndex = 0
        '
        'frmContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 495)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contact Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblBirthdate As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNickname As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtNickname As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblEmailAdd As Label
    Friend WithEvents lblMobileNo As Label
    Friend WithEvents lblPhoneNo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtBirthdate As DateTimePicker
    Friend WithEvents txtEmailAdd As TextBox
    Friend WithEvents txtMobileNo As TextBox
    Friend WithEvents txtPhoneNo As TextBox
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents lblSearch As Label
End Class
