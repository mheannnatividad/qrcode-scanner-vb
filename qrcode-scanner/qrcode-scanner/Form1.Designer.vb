<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.contactLabel = New System.Windows.Forms.Label()
        Me.emailLabel = New System.Windows.Forms.Label()
        Me.studentNumberLabel = New System.Windows.Forms.Label()
        Me.courseSectionLabel = New System.Windows.Forms.Label()
        Me.fullnameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.cameraPicBox = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.cameraPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Person Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.addressLabel)
        Me.Panel1.Controls.Add(Me.contactLabel)
        Me.Panel1.Controls.Add(Me.emailLabel)
        Me.Panel1.Controls.Add(Me.studentNumberLabel)
        Me.Panel1.Controls.Add(Me.courseSectionLabel)
        Me.Panel1.Controls.Add(Me.fullnameLabel)
        Me.Panel1.Location = New System.Drawing.Point(17, 37)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 260)
        Me.Panel1.TabIndex = 1
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.Location = New System.Drawing.Point(3, 181)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(66, 16)
        Me.addressLabel.TabIndex = 0
        Me.addressLabel.Text = "Address"
        Me.addressLabel.Visible = False
        '
        'contactLabel
        '
        Me.contactLabel.AutoSize = True
        Me.contactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactLabel.Location = New System.Drawing.Point(3, 144)
        Me.contactLabel.Name = "contactLabel"
        Me.contactLabel.Size = New System.Drawing.Size(60, 16)
        Me.contactLabel.TabIndex = 0
        Me.contactLabel.Text = "Contact"
        Me.contactLabel.Visible = False
        '
        'emailLabel
        '
        Me.emailLabel.AutoSize = True
        Me.emailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailLabel.Location = New System.Drawing.Point(3, 109)
        Me.emailLabel.Name = "emailLabel"
        Me.emailLabel.Size = New System.Drawing.Size(47, 16)
        Me.emailLabel.TabIndex = 0
        Me.emailLabel.Text = "Email"
        Me.emailLabel.Visible = False
        '
        'studentNumberLabel
        '
        Me.studentNumberLabel.AutoSize = True
        Me.studentNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNumberLabel.Location = New System.Drawing.Point(3, 76)
        Me.studentNumberLabel.Name = "studentNumberLabel"
        Me.studentNumberLabel.Size = New System.Drawing.Size(118, 16)
        Me.studentNumberLabel.TabIndex = 0
        Me.studentNumberLabel.Text = "Student Number"
        Me.studentNumberLabel.Visible = False
        '
        'courseSectionLabel
        '
        Me.courseSectionLabel.AutoSize = True
        Me.courseSectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseSectionLabel.Location = New System.Drawing.Point(3, 42)
        Me.courseSectionLabel.Name = "courseSectionLabel"
        Me.courseSectionLabel.Size = New System.Drawing.Size(113, 16)
        Me.courseSectionLabel.TabIndex = 0
        Me.courseSectionLabel.Text = "Course Section"
        Me.courseSectionLabel.Visible = False
        '
        'fullnameLabel
        '
        Me.fullnameLabel.AutoSize = True
        Me.fullnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullnameLabel.Location = New System.Drawing.Point(3, 9)
        Me.fullnameLabel.Name = "fullnameLabel"
        Me.fullnameLabel.Size = New System.Drawing.Size(71, 16)
        Me.fullnameLabel.TabIndex = 0
        Me.fullnameLabel.Text = "Fullname"
        Me.fullnameLabel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Camera:"
        '
        'startBtn
        '
        Me.startBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBtn.Location = New System.Drawing.Point(416, 12)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(75, 23)
        Me.startBtn.TabIndex = 3
        Me.startBtn.Text = "Start"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.Location = New System.Drawing.Point(17, 303)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 3
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'cameraPicBox
        '
        Me.cameraPicBox.Location = New System.Drawing.Point(322, 38)
        Me.cameraPicBox.Name = "cameraPicBox"
        Me.cameraPicBox.Size = New System.Drawing.Size(466, 288)
        Me.cameraPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.cameraPicBox.TabIndex = 4
        Me.cameraPicBox.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'clearBtn
        '
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(98, 303)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 3
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 338)
        Me.Controls.Add(Me.cameraPicBox)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.startBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Contact Tracing QR Code Scanner"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.cameraPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents addressLabel As Label
    Friend WithEvents contactLabel As Label
    Friend WithEvents emailLabel As Label
    Friend WithEvents studentNumberLabel As Label
    Friend WithEvents courseSectionLabel As Label
    Friend WithEvents fullnameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents startBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents cameraPicBox As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents clearBtn As Button
End Class
