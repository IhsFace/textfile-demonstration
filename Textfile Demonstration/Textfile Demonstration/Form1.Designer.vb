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
        Label1 = New Label()
        btnDisplay = New Button()
        btnReadUnknownLengthFile = New Button()
        Button3 = New Button()
        lstData = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(35, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(806, 45)
        Label1.TabIndex = 0
        Label1.Text = "A demonstration of reading and writing to a Textfile"
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(74, 128)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(350, 100)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display Contents of textfile"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' btnReadUnknownLengthFile
        ' 
        btnReadUnknownLengthFile.Location = New Point(74, 252)
        btnReadUnknownLengthFile.Name = "btnReadUnknownLengthFile"
        btnReadUnknownLengthFile.Size = New Size(350, 100)
        btnReadUnknownLengthFile.TabIndex = 2
        btnReadUnknownLengthFile.Text = "Append new data to Textfile"
        btnReadUnknownLengthFile.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(74, 373)
        Button3.Name = "Button3"
        Button3.Size = New Size(350, 100)
        Button3.TabIndex = 3
        Button3.Text = "Read a file of unknown length"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' lstData
        ' 
        lstData.FormattingEnabled = True
        lstData.Location = New Point(477, 139)
        lstData.Name = "lstData"
        lstData.Size = New Size(364, 324)
        lstData.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(874, 529)
        Controls.Add(lstData)
        Controls.Add(Button3)
        Controls.Add(btnReadUnknownLengthFile)
        Controls.Add(btnDisplay)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnReadUnknownLengthFile As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lstData As ListBox

End Class
