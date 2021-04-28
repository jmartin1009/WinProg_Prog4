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
        Me.dvgEmployee = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtDeleteID = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtDBFilePath = New System.Windows.Forms.TextBox()
        CType(Me.dvgEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgEmployee
        '
        Me.dvgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgEmployee.Location = New System.Drawing.Point(44, 26)
        Me.dvgEmployee.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dvgEmployee.Name = "dvgEmployee"
        Me.dvgEmployee.RowHeadersWidth = 51
        Me.dvgEmployee.RowTemplate.Height = 29
        Me.dvgEmployee.Size = New System.Drawing.Size(757, 182)
        Me.dvgEmployee.TabIndex = 0
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(44, 234)
        Me.btnShow.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(125, 27)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(44, 273)
        Me.btnInsert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(125, 27)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(522, 234)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(125, 27)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtDeleteID
        '
        Me.txtDeleteID.Location = New System.Drawing.Point(676, 234)
        Me.txtDeleteID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDeleteID.Name = "txtDeleteID"
        Me.txtDeleteID.Size = New System.Drawing.Size(125, 22)
        Me.txtDeleteID.TabIndex = 4
        Me.txtDeleteID.Text = "Enter ID"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(200, 278)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(125, 22)
        Me.txtID.TabIndex = 5
        Me.txtID.Text = "Enter ID"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(362, 278)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(125, 22)
        Me.txtName.TabIndex = 6
        Me.txtName.Text = "Enter Name"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(522, 278)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(125, 22)
        Me.txtSalary.TabIndex = 7
        Me.txtSalary.Text = "Enter Salary"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(676, 278)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(125, 22)
        Me.txtAddress.TabIndex = 8
        Me.txtAddress.Text = "Enter Address"
        '
        'txtDBFilePath
        '
        Me.txtDBFilePath.Location = New System.Drawing.Point(200, 323)
        Me.txtDBFilePath.Name = "txtDBFilePath"
        Me.txtDBFilePath.Size = New System.Drawing.Size(447, 22)
        Me.txtDBFilePath.TabIndex = 9
        Me.txtDBFilePath.Text = "Enter full file path for database file"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 371)
        Me.Controls.Add(Me.txtDBFilePath)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtDeleteID)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dvgEmployee)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dvgEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgEmployee As DataGridView
    Friend WithEvents btnShow As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtDeleteID As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtDBFilePath As TextBox
End Class
