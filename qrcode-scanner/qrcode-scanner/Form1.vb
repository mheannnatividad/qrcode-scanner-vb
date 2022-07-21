Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec
Public Class Form1
    Dim cameraDevice As VideoCaptureDevice
    Dim qrCode As Bitmap
    Dim qrCodeData As String()

    Private Sub qrCodeCapture(sender As Object, eventargs As NewFrameEventArgs)
        cameraPicBox.Image = DirectCast(eventargs.Frame.Clone(), Bitmap)
        qrCode = DirectCast(eventargs.Frame.Clone(), Bitmap)

    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        Dim device As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If device.ShowDialog() = DialogResult.OK Then
            cameraDevice = device.VideoDevice
            AddHandler cameraDevice.NewFrame, New NewFrameEventHandler(AddressOf qrCodeCapture)
            cameraDevice.Start()
            Timer1.Start()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If cameraPicBox.Image IsNot Nothing Then
            Dim qrCodeReader As BarcodeReader = New BarcodeReader
            Dim qrCodeText As Result = qrCodeReader.Decode(DirectCast(cameraPicBox.Image, Bitmap))
            Dim qrDataText As String

            If qrCodeText IsNot Nothing Then
                qrDataText = qrCodeText.ToString
                qrCodeData = qrDataText.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)

                fullnameLabel.Text = qrCodeData(0) + ", " + qrCodeData(1)
                courseSectionLabel.Text = qrCodeData(2)
                studentNumberLabel.Text = qrCodeData(3)
                emailLabel.Text = qrCodeData(4)
                contactLabel.Text = qrCodeData(5)
                addressLabel.Text = qrCodeData(6)

                fullnameLabel.Visible = True
                courseSectionLabel.Visible = True
                studentNumberLabel.Visible = True
                emailLabel.Visible = True
                contactLabel.Visible = True
                addressLabel.Visible = True
            End If


        End If
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim fileWriter As System.IO.StreamWriter
        fileWriter = My.Computer.FileSystem.OpenTextFileWriter("studentInfo.txt", True)



        If fullnameLabel.Visible Then
            fileWriter.WriteLine(fullnameLabel.Text)
            fileWriter.WriteLine(courseSectionLabel.Text)
            fileWriter.WriteLine(studentNumberLabel.Text)
            fileWriter.WriteLine(emailLabel.Text)
            fileWriter.WriteLine(contactLabel.Text)
            fileWriter.WriteLine(addressLabel.Text)

            fileWriter.Close()

            MessageBox.Show("File save.")
        Else
            MessageBox.Show("Invalid to save, no qr code text detect")
        End If
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        fullnameLabel.Text = ""
        courseSectionLabel.Text = ""
        studentNumberLabel.Text = ""
        emailLabel.Text = ""
        contactLabel.Text = ""
        addressLabel.Text = ""

        fullnameLabel.Visible = False
        courseSectionLabel.Visible = False
        studentNumberLabel.Visible = False
        emailLabel.Visible = False
        contactLabel.Visible = False
        addressLabel.Visible = False
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If cameraDevice.IsRunning Then
            cameraDevice.Stop()
        End If
    End Sub
End Class
