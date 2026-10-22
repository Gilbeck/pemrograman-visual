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
        btnTampil = New Button()
        btnTambah = New Button()
        lblNama = New Label()
        lblNim = New Label()
        lblJurusan = New Label()
        txtNama = New TextBox()
        txtNim = New TextBox()
        txtJurusan = New TextBox()
        dgvMahasiswa = New DataGridView()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(224, 342)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(105, 30)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(746, 229)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 1
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(663, 99)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(663, 141)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(37, 20)
        lblNim.TabIndex = 3
        lblNim.Text = "NIM"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(663, 181)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(57, 20)
        lblJurusan.TabIndex = 4
        lblJurusan.Text = "Jurusan"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(730, 96)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(730, 138)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(125, 27)
        txtNim.TabIndex = 6
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(730, 178)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(125, 27)
        txtJurusan.TabIndex = 7
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(31, 30)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.RowHeadersWidth = 51
        dgvMahasiswa.Size = New Size(514, 276)
        dgvMahasiswa.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1017, 482)
        Controls.Add(dgvMahasiswa)
        Controls.Add(txtJurusan)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(lblJurusan)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(btnTambah)
        Controls.Add(btnTampil)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents dgvMahasiswa As DataGridView

End Class
