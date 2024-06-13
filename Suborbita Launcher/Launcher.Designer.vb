<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.Label_LauncherTitle = New System.Windows.Forms.Label()
        Me.Label_Warning = New System.Windows.Forms.Label()
        Me.Button_Level1 = New System.Windows.Forms.Button()
        Me.Button_Level2 = New System.Windows.Forms.Button()
        Me.Button_Level3 = New System.Windows.Forms.Button()
        Me.Button_Level4 = New System.Windows.Forms.Button()
        Me.Button_Level5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_LevelIntro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label_LauncherTitle
        '
        Me.Label_LauncherTitle.AutoSize = True
        Me.Label_LauncherTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_LauncherTitle.Location = New System.Drawing.Point(141, 20)
        Me.Label_LauncherTitle.Name = "Label_LauncherTitle"
        Me.Label_LauncherTitle.Size = New System.Drawing.Size(159, 21)
        Me.Label_LauncherTitle.TabIndex = 2
        Me.Label_LauncherTitle.Text = "Suborbita Launcher"
        '
        'Label_Warning
        '
        Me.Label_Warning.AutoSize = True
        Me.Label_Warning.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Warning.Location = New System.Drawing.Point(96, 100)
        Me.Label_Warning.Name = "Label_Warning"
        Me.Label_Warning.Size = New System.Drawing.Size(248, 21)
        Me.Label_Warning.TabIndex = 3
        Me.Label_Warning.Text = "[!] Save data will be overwritten [!]"
        '
        'Button_Level1
        '
        Me.Button_Level1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Level1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Level1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Level1.Location = New System.Drawing.Point(13, 145)
        Me.Button_Level1.Name = "Button_Level1"
        Me.Button_Level1.Size = New System.Drawing.Size(70, 60)
        Me.Button_Level1.TabIndex = 4
        Me.Button_Level1.Text = "1"
        Me.Button_Level1.UseVisualStyleBackColor = True
        '
        'Button_Level2
        '
        Me.Button_Level2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Level2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Level2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Level2.Location = New System.Drawing.Point(99, 145)
        Me.Button_Level2.Name = "Button_Level2"
        Me.Button_Level2.Size = New System.Drawing.Size(70, 60)
        Me.Button_Level2.TabIndex = 5
        Me.Button_Level2.Text = "2"
        Me.Button_Level2.UseVisualStyleBackColor = True
        '
        'Button_Level3
        '
        Me.Button_Level3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Level3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Level3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Level3.Location = New System.Drawing.Point(185, 145)
        Me.Button_Level3.Name = "Button_Level3"
        Me.Button_Level3.Size = New System.Drawing.Size(70, 60)
        Me.Button_Level3.TabIndex = 6
        Me.Button_Level3.Text = "3"
        Me.Button_Level3.UseVisualStyleBackColor = True
        '
        'Button_Level4
        '
        Me.Button_Level4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Level4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Level4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Level4.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Level4.Location = New System.Drawing.Point(271, 145)
        Me.Button_Level4.Name = "Button_Level4"
        Me.Button_Level4.Size = New System.Drawing.Size(70, 60)
        Me.Button_Level4.TabIndex = 7
        Me.Button_Level4.Text = "4"
        Me.Button_Level4.UseVisualStyleBackColor = True
        '
        'Button_Level5
        '
        Me.Button_Level5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Level5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_Level5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Level5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Level5.Location = New System.Drawing.Point(357, 145)
        Me.Button_Level5.Name = "Button_Level5"
        Me.Button_Level5.Size = New System.Drawing.Size(70, 60)
        Me.Button_Level5.TabIndex = 8
        Me.Button_Level5.Text = "5"
        Me.Button_Level5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select a level to load on ""Continue"""
        '
        'Button_LevelIntro
        '
        Me.Button_LevelIntro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_LevelIntro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Button_LevelIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_LevelIntro.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_LevelIntro.Location = New System.Drawing.Point(13, 224)
        Me.Button_LevelIntro.Name = "Button_LevelIntro"
        Me.Button_LevelIntro.Size = New System.Drawing.Size(414, 60)
        Me.Button_LevelIntro.TabIndex = 10
        Me.Button_LevelIntro.Text = "HELICOPTER INTRO"
        Me.Button_LevelIntro.UseVisualStyleBackColor = True
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 305)
        Me.Controls.Add(Me.Button_LevelIntro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Level5)
        Me.Controls.Add(Me.Button_Level4)
        Me.Controls.Add(Me.Button_Level3)
        Me.Controls.Add(Me.Button_Level2)
        Me.Controls.Add(Me.Button_Level1)
        Me.Controls.Add(Me.Label_Warning)
        Me.Controls.Add(Me.Label_LauncherTitle)
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Launcher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Suborbita Launcher by SRGn64 | v1.2.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_LauncherTitle As Label
    Friend WithEvents Label_Warning As Label
    Friend WithEvents Button_Level1 As Button
    Friend WithEvents Button_Level2 As Button
    Friend WithEvents Button_Level3 As Button
    Friend WithEvents Button_Level4 As Button
    Friend WithEvents Button_Level5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_LevelIntro As Button
End Class
