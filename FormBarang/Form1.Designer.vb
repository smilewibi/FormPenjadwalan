<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        path = New TextBox()
        upload = New Button()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 15)
        Label1.TabIndex = 0
        Label1.Text = "Upload File"
        ' 
        ' path
        ' 
        path.Enabled = False
        path.Location = New Point(111, 18)
        path.Name = "path"
        path.Size = New Size(349, 23)
        path.TabIndex = 5
        ' 
        ' upload
        ' 
        upload.Location = New Point(475, 18)
        upload.Name = "upload"
        upload.Size = New Size(75, 23)
        upload.TabIndex = 10
        upload.Text = "Upload"
        upload.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(28, 66)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(522, 349)
        ListBox1.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(590, 450)
        Controls.Add(ListBox1)
        Controls.Add(upload)
        Controls.Add(path)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents path As TextBox
    Friend WithEvents upload As Button
    Friend WithEvents ListBox1 As ListBox

End Class
