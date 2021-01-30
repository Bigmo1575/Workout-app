<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblDateStarted = New System.Windows.Forms.Label()
        Me.txtSquat = New System.Windows.Forms.TextBox()
        Me.lblSquat = New System.Windows.Forms.Label()
        Me.txtDeadlift = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBpress = New System.Windows.Forms.TextBox()
        Me.lblBpress = New System.Windows.Forms.Label()
        Me.txtOpress = New System.Windows.Forms.TextBox()
        Me.lblOpress = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.mncDateStarted = New System.Windows.Forms.MonthCalendar()
        Me.bntCreate = New System.Windows.Forms.Button()
        Me.lbxUser = New System.Windows.Forms.ListBox()
        Me.txtBpressTrn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDeadliftTrn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSquatTrn = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDateStarted = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtOpressTrn = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(33, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(80, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(83, 20)
        Me.txtName.TabIndex = 1
        '
        'lblDateStarted
        '
        Me.lblDateStarted.AutoSize = True
        Me.lblDateStarted.Location = New System.Drawing.Point(1, 51)
        Me.lblDateStarted.Name = "lblDateStarted"
        Me.lblDateStarted.Size = New System.Drawing.Size(67, 13)
        Me.lblDateStarted.TabIndex = 2
        Me.lblDateStarted.Text = "Date Started"
        '
        'txtSquat
        '
        Me.txtSquat.Location = New System.Drawing.Point(118, 242)
        Me.txtSquat.Name = "txtSquat"
        Me.txtSquat.Size = New System.Drawing.Size(83, 20)
        Me.txtSquat.TabIndex = 5
        '
        'lblSquat
        '
        Me.lblSquat.AutoSize = True
        Me.lblSquat.Location = New System.Drawing.Point(29, 245)
        Me.lblSquat.Name = "lblSquat"
        Me.lblSquat.Size = New System.Drawing.Size(35, 13)
        Me.lblSquat.TabIndex = 4
        Me.lblSquat.Text = "Squat"
        '
        'txtDeadlift
        '
        Me.txtDeadlift.Location = New System.Drawing.Point(118, 268)
        Me.txtDeadlift.Name = "txtDeadlift"
        Me.txtDeadlift.Size = New System.Drawing.Size(83, 20)
        Me.txtDeadlift.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Deadlift"
        '
        'txtBpress
        '
        Me.txtBpress.Location = New System.Drawing.Point(118, 294)
        Me.txtBpress.Name = "txtBpress"
        Me.txtBpress.Size = New System.Drawing.Size(83, 20)
        Me.txtBpress.TabIndex = 9
        '
        'lblBpress
        '
        Me.lblBpress.AutoSize = True
        Me.lblBpress.Location = New System.Drawing.Point(29, 297)
        Me.lblBpress.Name = "lblBpress"
        Me.lblBpress.Size = New System.Drawing.Size(67, 13)
        Me.lblBpress.TabIndex = 8
        Me.lblBpress.Text = "Bench Press"
        '
        'txtOpress
        '
        Me.txtOpress.Location = New System.Drawing.Point(118, 323)
        Me.txtOpress.Name = "txtOpress"
        Me.txtOpress.Size = New System.Drawing.Size(83, 20)
        Me.txtOpress.TabIndex = 11
        '
        'lblOpress
        '
        Me.lblOpress.AutoSize = True
        Me.lblOpress.Location = New System.Drawing.Point(29, 326)
        Me.lblOpress.Name = "lblOpress"
        Me.lblOpress.Size = New System.Drawing.Size(83, 13)
        Me.lblOpress.TabIndex = 10
        Me.lblOpress.Text = "Overhead Press"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 213)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "One Rep Max"
        '
        'mncDateStarted
        '
        Me.mncDateStarted.Location = New System.Drawing.Point(80, 42)
        Me.mncDateStarted.Name = "mncDateStarted"
        Me.mncDateStarted.TabIndex = 13
        '
        'bntCreate
        '
        Me.bntCreate.Location = New System.Drawing.Point(36, 349)
        Me.bntCreate.Name = "bntCreate"
        Me.bntCreate.Size = New System.Drawing.Size(84, 38)
        Me.bntCreate.TabIndex = 14
        Me.bntCreate.Text = "Create User"
        Me.bntCreate.UseVisualStyleBackColor = True
        '
        'lbxUser
        '
        Me.lbxUser.FormattingEnabled = True
        Me.lbxUser.Location = New System.Drawing.Point(36, 393)
        Me.lbxUser.Name = "lbxUser"
        Me.lbxUser.Size = New System.Drawing.Size(165, 147)
        Me.lbxUser.TabIndex = 15
        '
        'txtBpressTrn
        '
        Me.txtBpressTrn.Location = New System.Drawing.Point(306, 489)
        Me.txtBpressTrn.Name = "txtBpressTrn"
        Me.txtBpressTrn.Size = New System.Drawing.Size(83, 20)
        Me.txtBpressTrn.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 492)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Bench Press"
        '
        'txtDeadliftTrn
        '
        Me.txtDeadliftTrn.Location = New System.Drawing.Point(306, 463)
        Me.txtDeadliftTrn.Name = "txtDeadliftTrn"
        Me.txtDeadliftTrn.Size = New System.Drawing.Size(83, 20)
        Me.txtDeadliftTrn.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 466)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Deadlift"
        '
        'txtSquatTrn
        '
        Me.txtSquatTrn.Location = New System.Drawing.Point(306, 437)
        Me.txtSquatTrn.Name = "txtSquatTrn"
        Me.txtSquatTrn.Size = New System.Drawing.Size(83, 20)
        Me.txtSquatTrn.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Squat"
        '
        'txtDateStarted
        '
        Me.txtDateStarted.Location = New System.Drawing.Point(306, 411)
        Me.txtDateStarted.Name = "txtDateStarted"
        Me.txtDateStarted.Size = New System.Drawing.Size(83, 20)
        Me.txtDateStarted.TabIndex = 22
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(217, 411)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(67, 13)
        Me.lblDate.TabIndex = 23
        Me.lblDate.Text = "Date Started"
        '
        'txtOpressTrn
        '
        Me.txtOpressTrn.Location = New System.Drawing.Point(306, 515)
        Me.txtOpressTrn.Name = "txtOpressTrn"
        Me.txtOpressTrn.Size = New System.Drawing.Size(83, 20)
        Me.txtOpressTrn.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(217, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "OverHead Press"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(126, 349)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(83, 38)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(215, 349)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(165, 38)
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete User"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 561)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOpressTrn)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtDateStarted)
        Me.Controls.Add(Me.txtBpressTrn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDeadliftTrn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSquatTrn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbxUser)
        Me.Controls.Add(Me.bntCreate)
        Me.Controls.Add(Me.mncDateStarted)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOpress)
        Me.Controls.Add(Me.lblOpress)
        Me.Controls.Add(Me.txtBpress)
        Me.Controls.Add(Me.lblBpress)
        Me.Controls.Add(Me.txtDeadlift)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSquat)
        Me.Controls.Add(Me.lblSquat)
        Me.Controls.Add(Me.lblDateStarted)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblDateStarted As Label
    Friend WithEvents txtSquat As TextBox
    Friend WithEvents lblSquat As Label
    Friend WithEvents txtDeadlift As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBpress As TextBox
    Friend WithEvents lblBpress As Label
    Friend WithEvents txtOpress As TextBox
    Friend WithEvents lblOpress As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mncDateStarted As MonthCalendar
    Friend WithEvents bntCreate As Button
    Friend WithEvents lbxUser As ListBox
    Friend WithEvents txtBpressTrn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDeadliftTrn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSquatTrn As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDateStarted As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents txtOpressTrn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
End Class
