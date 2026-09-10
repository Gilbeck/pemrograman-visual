<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        picImage = New PictureBox()
        lblRole = New Label()
        lblNama = New Label()
        lblNIM = New Label()
        cmbRole = New ComboBox()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(152, 45)
        picImage.Name = "picImage"
        picImage.Size = New Size(100, 100)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(103, 167)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(46, 20)
        lblRole.TabIndex = 1
        lblRole.Text = "Role :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(103, 220)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama :"
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(103, 273)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(44, 20)
        lblNIM.TabIndex = 3
        lblNIM.Text = "NIM :"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cmbRole.Location = New Point(177, 164)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(125, 28)
        cmbRole.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(177, 217)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 5
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(177, 270)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(125, 27)
        txtNIM.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(152, 329)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(413, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(cmbRole)
        Controls.Add(lblNIM)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(picImage)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnLogin As Button

End Class
