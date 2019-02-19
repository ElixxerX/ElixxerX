<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.คะแนนสอบ = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOldTotalScore = New System.Windows.Forms.TextBox()
        Me.lblOldTotalCredit = New System.Windows.Forms.TextBox()
        Me.lblOldGPA = New System.Windows.Forms.TextBox()
        Me.lblNewGPA = New System.Windows.Forms.TextBox()
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "วิชา"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'คะแนนสอบ
        '
        Me.คะแนนสอบ.BackColor = System.Drawing.SystemColors.ControlDark
        Me.คะแนนสอบ.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.คะแนนสอบ.Location = New System.Drawing.Point(178, 17)
        Me.คะแนนสอบ.Name = "คะแนนสอบ"
        Me.คะแนนสอบ.Size = New System.Drawing.Size(150, 29)
        Me.คะแนนสอบ.TabIndex = 5
        Me.คะแนนสอบ.Text = "คะแนนสอบ"
        Me.คะแนนสอบ.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(334, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 29)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "หน่วยกิต"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "เกรด"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(22, 266)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(150, 33)
        Me.txtSubject.TabIndex = 8
        '
        'txtCredit
        '
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCredit.Location = New System.Drawing.Point(334, 266)
        Me.txtCredit.Multiline = True
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(150, 33)
        Me.txtCredit.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(490, 267)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 32)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(573, 267)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 32)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "คะแนนสะสมก่อนหน้า"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "หน่วยกิจสะสม"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(450, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "เกรดเฉลี่ยสะสม"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        '
        'lblOldTotalScore
        '
        Me.lblOldTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldTotalScore.Location = New System.Drawing.Point(152, 318)
        Me.lblOldTotalScore.Multiline = True
        Me.lblOldTotalScore.Name = "lblOldTotalScore"
        Me.lblOldTotalScore.Size = New System.Drawing.Size(82, 39)
        Me.lblOldTotalScore.TabIndex = 17
        Me.lblOldTotalScore.Text = "150"
        '
        'lblOldTotalCredit
        '
        Me.lblOldTotalCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldTotalCredit.Location = New System.Drawing.Point(348, 318)
        Me.lblOldTotalCredit.Multiline = True
        Me.lblOldTotalCredit.Name = "lblOldTotalCredit"
        Me.lblOldTotalCredit.Size = New System.Drawing.Size(82, 39)
        Me.lblOldTotalCredit.TabIndex = 18
        Me.lblOldTotalCredit.Text = "50"
        '
        'lblOldGPA
        '
        Me.lblOldGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblOldGPA.Location = New System.Drawing.Point(548, 318)
        Me.lblOldGPA.Multiline = True
        Me.lblOldGPA.Name = "lblOldGPA"
        Me.lblOldGPA.Size = New System.Drawing.Size(82, 39)
        Me.lblOldGPA.TabIndex = 19
        Me.lblOldGPA.Text = "3.00"
        '
        'lblNewGPA
        '
        Me.lblNewGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblNewGPA.Location = New System.Drawing.Point(211, 375)
        Me.lblNewGPA.Multiline = True
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(82, 39)
        Me.lblNewGPA.TabIndex = 20
        '
        'lstSubject
        '
        Me.lstSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.ItemHeight = 15
        Me.lstSubject.Location = New System.Drawing.Point(22, 49)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(150, 199)
        Me.lstSubject.TabIndex = 21
        '
        'lstScore
        '
        Me.lstScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 15
        Me.lstScore.Location = New System.Drawing.Point(178, 49)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(150, 199)
        Me.lstScore.TabIndex = 22
        '
        'lstCredit
        '
        Me.lstCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.ItemHeight = 15
        Me.lstCredit.Location = New System.Drawing.Point(334, 49)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(150, 199)
        Me.lstCredit.TabIndex = 23
        '
        'lstGrade
        '
        Me.lstGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.ItemHeight = 15
        Me.lstGrade.Location = New System.Drawing.Point(490, 49)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(150, 199)
        Me.lstGrade.TabIndex = 24
        '
        'txtScore
        '
        Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtScore.Location = New System.Drawing.Point(183, 266)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(145, 33)
        Me.txtScore.TabIndex = 25
        '
        'frmLab8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(652, 426)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.lblOldGPA)
        Me.Controls.Add(Me.lblOldTotalCredit)
        Me.Controls.Add(Me.lblOldTotalScore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.คะแนนสอบ)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab8"
        Me.Text = "frmLab8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents คะแนนสอบ As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblOldTotalScore As System.Windows.Forms.TextBox
    Friend WithEvents lblOldTotalCredit As System.Windows.Forms.TextBox
    Friend WithEvents lblOldGPA As System.Windows.Forms.TextBox
    Friend WithEvents lblNewGPA As System.Windows.Forms.TextBox
    Friend WithEvents lstSubject As ListBox
    Friend WithEvents lstScore As ListBox
    Friend WithEvents lstCredit As ListBox
    Friend WithEvents lstGrade As ListBox
    Friend WithEvents txtScore As TextBox
End Class
