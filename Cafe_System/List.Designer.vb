<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        Me.lstFood = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFood
        '
        Me.lstFood.FormattingEnabled = True
        Me.lstFood.ItemHeight = 15
        Me.lstFood.Location = New System.Drawing.Point(12, 37)
        Me.lstFood.Name = "lstFood"
        Me.lstFood.Size = New System.Drawing.Size(364, 229)
        Me.lstFood.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(157, 330)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Location = New System.Drawing.Point(12, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(0, 15)
        Me.txtName.TabIndex = 2
        '
        'txtTime
        '
        Me.txtTime.AutoSize = True
        Me.txtTime.Location = New System.Drawing.Point(12, 284)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(0, 15)
        Me.txtTime.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(157, 301)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 365)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lstFood)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(406, 412)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(406, 412)
        Me.Name = "frmList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstFood As ListBox
    Friend WithEvents btnClose As Button
    Friend WithEvents txtName As Label
    Friend WithEvents txtTime As Label
    Friend WithEvents btnDelete As Button
End Class
