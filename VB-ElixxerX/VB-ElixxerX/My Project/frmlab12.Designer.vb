<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlab12
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
        Me.DgvEmp = New System.Windows.Forms.DataGridView()
        Me.panEmp = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmpId = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmpLname = New System.Windows.Forms.TextBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEmp
        '
        Me.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmp.Location = New System.Drawing.Point(25, 12)
        Me.DgvEmp.Name = "DgvEmp"
        Me.DgvEmp.Size = New System.Drawing.Size(751, 307)
        Me.DgvEmp.TabIndex = 0
        '
        'panEmp
        '
        Me.panEmp.BackColor = System.Drawing.Color.DarkSalmon
        Me.panEmp.Controls.Add(Me.btnCancel)
        Me.panEmp.Controls.Add(Me.btnSave)
        Me.panEmp.Controls.Add(Me.radFemale)
        Me.panEmp.Controls.Add(Me.radMale)
        Me.panEmp.Controls.Add(Me.txtEmpLname)
        Me.panEmp.Controls.Add(Me.Label7)
        Me.panEmp.Controls.Add(Me.Label6)
        Me.panEmp.Controls.Add(Me.cboDepart)
        Me.panEmp.Controls.Add(Me.txtEmpName)
        Me.panEmp.Controls.Add(Me.Label5)
        Me.panEmp.Controls.Add(Me.Label4)
        Me.panEmp.Controls.Add(Me.txtSalary)
        Me.panEmp.Controls.Add(Me.txtAddress)
        Me.panEmp.Controls.Add(Me.txtEmpId)
        Me.panEmp.Controls.Add(Me.Label3)
        Me.panEmp.Controls.Add(Me.Label2)
        Me.panEmp.Controls.Add(Me.Label1)
        Me.panEmp.Enabled = False
        Me.panEmp.Location = New System.Drawing.Point(25, 325)
        Me.panEmp.Name = "panEmp"
        Me.panEmp.Size = New System.Drawing.Size(751, 117)
        Me.panEmp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสพนักงาน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ที่อยู่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "เงินเดือน"
        '
        'txtEmpId
        '
        Me.txtEmpId.Location = New System.Drawing.Point(93, 8)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(119, 20)
        Me.txtEmpId.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(93, 46)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(377, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(93, 85)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(119, 20)
        Me.txtSalary.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(230, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ชื่อพนักงาน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(230, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "แผนก"
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(304, 8)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(166, 20)
        Me.txtEmpName.TabIndex = 8
        '
        'cboDepart
        '
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Location = New System.Drawing.Point(304, 84)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(166, 21)
        Me.cboDepart.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(499, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "นามสกุล"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(508, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "เพศ"
        '
        'txtEmpLname
        '
        Me.txtEmpLname.Location = New System.Drawing.Point(568, 8)
        Me.txtEmpLname.Name = "txtEmpLname"
        Me.txtEmpLname.Size = New System.Drawing.Size(166, 20)
        Me.txtEmpLname.TabIndex = 12
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(568, 50)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(44, 17)
        Me.radMale.TabIndex = 13
        Me.radMale.TabStop = True
        Me.radMale.Text = "ชาย"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(636, 50)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(46, 17)
        Me.radFemale.TabIndex = 14
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "หญิง"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(537, 82)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(636, 82)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancal"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(199, 466)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 17
        Me.btnInsert.Text = "เพิ่ม"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(305, 466)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(405, 466)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(501, 466)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 20
        Me.btnClose.Text = "ออก"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmlab12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 501)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.panEmp)
        Me.Controls.Add(Me.DgvEmp)
        Me.Name = "frmlab12"
        Me.Text = "frmlab12"
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panEmp.ResumeLayout(False)
        Me.panEmp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvEmp As DataGridView
    Friend WithEvents panEmp As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents txtEmpLname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cboDepart As ComboBox
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmpId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClose As Button
End Class
