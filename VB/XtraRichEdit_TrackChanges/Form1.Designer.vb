Namespace XtraRichEdit_TrackChanges

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
            Me.SuspendLayout()
            ' 
            ' richEditControl1
            ' 
            Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
            Me.richEditControl1.Name = "richEditControl1"
            Me.richEditControl1.Size = New System.Drawing.Size(800, 450)
            Me.richEditControl1.TabIndex = 0
            Me.richEditControl1.Text = "richEditControl1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 450)
            Me.Controls.Add(Me.richEditControl1)
            Me.Name = "Form1"
            Me.Text = "Rich Text Editor"
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
    End Class
End Namespace
