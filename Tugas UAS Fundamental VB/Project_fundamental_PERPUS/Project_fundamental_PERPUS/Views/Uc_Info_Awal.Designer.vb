<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Uc_Info_Awal
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.slide = New System.Windows.Forms.PictureBox()
        CType(Me.slide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'slide
        '
        Me.slide.BackgroundImage = Global.Project_fundamental_PERPUS.My.Resources.Resources.we
        Me.slide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.slide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.slide.Location = New System.Drawing.Point(0, 0)
        Me.slide.Name = "slide"
        Me.slide.Size = New System.Drawing.Size(1370, 527)
        Me.slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slide.TabIndex = 0
        Me.slide.TabStop = False
        '
        'Uc_Info_Awal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.slide)
        Me.Name = "Uc_Info_Awal"
        Me.Size = New System.Drawing.Size(1370, 527)
        CType(Me.slide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents slide As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
