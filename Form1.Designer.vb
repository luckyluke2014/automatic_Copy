<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FolderFrom = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderTo = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CopyFromBtn = New System.Windows.Forms.Button()
        Me.CopyToBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gotxt = New System.Windows.Forms.TextBox()
        Me.txtFE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NoGotxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMB = New System.Windows.Forms.TextBox()
        Me.COPYBtn = New System.Windows.Forms.Button()
        Me.Copynowbtn = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.chkshow = New System.Windows.Forms.CheckBox()
        Me.SearchTxt = New System.Windows.Forms.TextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "copy from"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "copy to"
        '
        'CopyFromBtn
        '
        Me.CopyFromBtn.Location = New System.Drawing.Point(12, 63)
        Me.CopyFromBtn.Name = "CopyFromBtn"
        Me.CopyFromBtn.Size = New System.Drawing.Size(106, 23)
        Me.CopyFromBtn.TabIndex = 2
        Me.CopyFromBtn.Text = "Choose Folder"
        Me.CopyFromBtn.UseVisualStyleBackColor = true
        '
        'CopyToBtn
        '
        Me.CopyToBtn.Location = New System.Drawing.Point(448, 63)
        Me.CopyToBtn.Name = "CopyToBtn"
        Me.CopyToBtn.Size = New System.Drawing.Size(126, 23)
        Me.CopyToBtn.TabIndex = 3
        Me.CopyToBtn.Text = "Choose Folder"
        Me.CopyToBtn.UseVisualStyleBackColor = true
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "nothing"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(445, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "nothing"
        '
        'Gotxt
        '
        Me.Gotxt.Location = New System.Drawing.Point(12, 155)
        Me.Gotxt.Name = "Gotxt"
        Me.Gotxt.Size = New System.Drawing.Size(251, 20)
        Me.Gotxt.TabIndex = 6
        '
        'txtFE
        '
        Me.txtFE.Location = New System.Drawing.Point(12, 266)
        Me.txtFE.Name = "txtFE"
        Me.txtFE.Size = New System.Drawing.Size(68, 20)
        Me.txtFE.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(327, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "text included in file to copy (e.g. ""s01"" or ""s01;bigbang"" for 2 words)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "file extension (e.g. ""mkv"")"
        '
        'NoGotxt
        '
        Me.NoGotxt.Location = New System.Drawing.Point(12, 212)
        Me.NoGotxt.Name = "NoGotxt"
        Me.NoGotxt.Size = New System.Drawing.Size(251, 20)
        Me.NoGotxt.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "text must not be included in file to copy (e.g. ""sample"")"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(154, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "min size in megabytes"
        '
        'txtMB
        '
        Me.txtMB.Location = New System.Drawing.Point(157, 266)
        Me.txtMB.Name = "txtMB"
        Me.txtMB.Size = New System.Drawing.Size(100, 20)
        Me.txtMB.TabIndex = 13
        '
        'COPYBtn
        '
        Me.COPYBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COPYBtn.Location = New System.Drawing.Point(12, 308)
        Me.COPYBtn.Name = "COPYBtn"
        Me.COPYBtn.Size = New System.Drawing.Size(244, 64)
        Me.COPYBtn.TabIndex = 14
        Me.COPYBtn.Text = "preview of files to be copied"
        Me.COPYBtn.UseVisualStyleBackColor = True
        '
        'Copynowbtn
        '
        Me.Copynowbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copynowbtn.Location = New System.Drawing.Point(646, 265)
        Me.Copynowbtn.Name = "Copynowbtn"
        Me.Copynowbtn.Size = New System.Drawing.Size(255, 64)
        Me.Copynowbtn.TabIndex = 16
        Me.Copynowbtn.Text = "COPY"
        Me.Copynowbtn.UseVisualStyleBackColor = True
        Me.Copynowbtn.Visible = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(17, 410)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(886, 23)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 18
        '
        'chkshow
        '
        Me.chkshow.AutoSize = True
        Me.chkshow.Location = New System.Drawing.Point(356, 99)
        Me.chkshow.Name = "chkshow"
        Me.chkshow.Size = New System.Drawing.Size(75, 17)
        Me.chkshow.TabIndex = 19
        Me.chkshow.Text = "show path"
        Me.chkshow.UseVisualStyleBackColor = True
        '
        'SearchTxt
        '
        Me.SearchTxt.Location = New System.Drawing.Point(356, 301)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.Size = New System.Drawing.Size(131, 20)
        Me.SearchTxt.TabIndex = 20
        Me.SearchTxt.Visible = False
        '
        'SearchBtn
        '
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(499, 299)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(75, 40)
        Me.SearchBtn.TabIndex = 21
        Me.SearchBtn.Text = "search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        Me.SearchBtn.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(356, 139)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(545, 121)
        Me.ListBox1.TabIndex = 23
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(356, 266)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(224, 29)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "search files for word"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 445)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.chkshow)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Copynowbtn)
        Me.Controls.Add(Me.COPYBtn)
        Me.Controls.Add(Me.txtMB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NoGotxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFE)
        Me.Controls.Add(Me.Gotxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CopyToBtn)
        Me.Controls.Add(Me.CopyFromBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "luckylukes automatic Copy"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents FolderFrom As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderTo As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CopyFromBtn As System.Windows.Forms.Button
    Friend WithEvents CopyToBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Gotxt As System.Windows.Forms.TextBox
    Friend WithEvents txtFE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NoGotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMB As System.Windows.Forms.TextBox
    Friend WithEvents COPYBtn As System.Windows.Forms.Button
    Friend WithEvents Copynowbtn As System.Windows.Forms.Button
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents chkshow As System.Windows.Forms.CheckBox
    Friend WithEvents SearchTxt As System.Windows.Forms.TextBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
