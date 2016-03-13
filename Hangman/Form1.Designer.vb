<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hangman
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hangman))
        Me.picPicture = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lstLetters = New System.Windows.Forms.ListBox()
        Me.lstHangman = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPicture
        '
        Me.picPicture.BackColor = System.Drawing.Color.Transparent
        Me.picPicture.Location = New System.Drawing.Point(17, 52)
        Me.picPicture.Name = "picPicture"
        Me.picPicture.Size = New System.Drawing.Size(169, 194)
        Me.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPicture.TabIndex = 0
        Me.picPicture.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.Cursor = System.Windows.Forms.Cursors.PanNW
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Mistral", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Maroon
        Me.btnStart.Location = New System.Drawing.Point(-7, 1)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(260, 53)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Play"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblWord
        '
        Me.lblWord.BackColor = System.Drawing.Color.White
        Me.lblWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWord.Location = New System.Drawing.Point(-7, 250)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(239, 89)
        Me.lblWord.TabIndex = 2
        Me.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstLetters
        '
        Me.lstLetters.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstLetters.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.lstLetters.FormattingEnabled = True
        Me.lstLetters.ItemHeight = 18
        Me.lstLetters.Location = New System.Drawing.Point(189, 67)
        Me.lstLetters.Name = "lstLetters"
        Me.lstLetters.Size = New System.Drawing.Size(43, 180)
        Me.lstLetters.TabIndex = 3
        '
        'lstHangman
        '
        Me.lstHangman.ImageStream = CType(resources.GetObject("lstHangman.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstHangman.TransparentColor = System.Drawing.Color.Transparent
        Me.lstHangman.Images.SetKeyName(0, "1.png")
        Me.lstHangman.Images.SetKeyName(1, "2.png")
        Me.lstHangman.Images.SetKeyName(2, "3.png")
        Me.lstHangman.Images.SetKeyName(3, "6.png")
        Me.lstHangman.Images.SetKeyName(4, "5.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 5.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(187, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 9)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Guessed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-7, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!)
        Me.Button1.Location = New System.Drawing.Point(220, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(12, 21)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "?"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Hangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.BG1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(242, 330)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstLetters)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picPicture)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Hangman"
        Me.Text = "Hangman"
        CType(Me.picPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picPicture As System.Windows.Forms.PictureBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents lstLetters As System.Windows.Forms.ListBox
    Friend WithEvents lstHangman As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
