<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visualizer
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
        Me.bttn_exit = New System.Windows.Forms.Button()
        Me.bttn_save = New System.Windows.Forms.Button()
        Me.bttn_delete = New System.Windows.Forms.Button()
        Me.bttn_add = New System.Windows.Forms.Button()
        Me.bttn_search = New System.Windows.Forms.Button()
        Me.pic_apperance = New System.Windows.Forms.PictureBox()
        Me.lbl_holder_age = New System.Windows.Forms.Label()
        Me.lbl_holder_alliance = New System.Windows.Forms.Label()
        Me.lbl_holder_race = New System.Windows.Forms.Label()
        Me.lbl_holder_name = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_race = New System.Windows.Forms.TextBox()
        Me.txt_alliance = New System.Windows.Forms.TextBox()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.bttn_clean = New System.Windows.Forms.Button()
        Me.Cnx_SW = New System.Data.OleDb.OleDbConnection()
        Me.bttn_upload = New System.Windows.Forms.Button()
        CType(Me.pic_apperance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttn_exit
        '
        Me.bttn_exit.Location = New System.Drawing.Point(625, 286)
        Me.bttn_exit.Name = "bttn_exit"
        Me.bttn_exit.Size = New System.Drawing.Size(80, 40)
        Me.bttn_exit.TabIndex = 27
        Me.bttn_exit.Text = "Salir"
        Me.bttn_exit.UseVisualStyleBackColor = True
        '
        'bttn_save
        '
        Me.bttn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.bttn_save.Location = New System.Drawing.Point(625, 237)
        Me.bttn_save.Name = "bttn_save"
        Me.bttn_save.Size = New System.Drawing.Size(80, 40)
        Me.bttn_save.TabIndex = 26
        Me.bttn_save.Text = "Modificar"
        Me.bttn_save.UseVisualStyleBackColor = True
        '
        'bttn_delete
        '
        Me.bttn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.bttn_delete.Location = New System.Drawing.Point(539, 237)
        Me.bttn_delete.Name = "bttn_delete"
        Me.bttn_delete.Size = New System.Drawing.Size(80, 40)
        Me.bttn_delete.TabIndex = 25
        Me.bttn_delete.Text = "Eliminar"
        Me.bttn_delete.UseVisualStyleBackColor = True
        '
        'bttn_add
        '
        Me.bttn_add.Location = New System.Drawing.Point(453, 237)
        Me.bttn_add.Name = "bttn_add"
        Me.bttn_add.Size = New System.Drawing.Size(80, 40)
        Me.bttn_add.TabIndex = 24
        Me.bttn_add.Text = "Agregar"
        Me.bttn_add.UseVisualStyleBackColor = True
        '
        'bttn_search
        '
        Me.bttn_search.Location = New System.Drawing.Point(367, 237)
        Me.bttn_search.Name = "bttn_search"
        Me.bttn_search.Size = New System.Drawing.Size(80, 40)
        Me.bttn_search.TabIndex = 23
        Me.bttn_search.Text = "Buscar"
        Me.bttn_search.UseVisualStyleBackColor = True
        '
        'pic_apperance
        '
        Me.pic_apperance.Location = New System.Drawing.Point(32, 30)
        Me.pic_apperance.Name = "pic_apperance"
        Me.pic_apperance.Size = New System.Drawing.Size(304, 296)
        Me.pic_apperance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_apperance.TabIndex = 22
        Me.pic_apperance.TabStop = False
        '
        'lbl_holder_age
        '
        Me.lbl_holder_age.AutoSize = True
        Me.lbl_holder_age.Location = New System.Drawing.Point(363, 177)
        Me.lbl_holder_age.Name = "lbl_holder_age"
        Me.lbl_holder_age.Size = New System.Drawing.Size(47, 20)
        Me.lbl_holder_age.TabIndex = 17
        Me.lbl_holder_age.Text = "Edad"
        '
        'lbl_holder_alliance
        '
        Me.lbl_holder_alliance.AutoSize = True
        Me.lbl_holder_alliance.Location = New System.Drawing.Point(363, 145)
        Me.lbl_holder_alliance.Name = "lbl_holder_alliance"
        Me.lbl_holder_alliance.Size = New System.Drawing.Size(56, 20)
        Me.lbl_holder_alliance.TabIndex = 16
        Me.lbl_holder_alliance.Text = "Bando"
        '
        'lbl_holder_race
        '
        Me.lbl_holder_race.AutoSize = True
        Me.lbl_holder_race.Location = New System.Drawing.Point(362, 111)
        Me.lbl_holder_race.Name = "lbl_holder_race"
        Me.lbl_holder_race.Size = New System.Drawing.Size(47, 20)
        Me.lbl_holder_race.TabIndex = 15
        Me.lbl_holder_race.Text = "Raza"
        '
        'lbl_holder_name
        '
        Me.lbl_holder_name.AutoSize = True
        Me.lbl_holder_name.Location = New System.Drawing.Point(363, 76)
        Me.lbl_holder_name.Name = "lbl_holder_name"
        Me.lbl_holder_name.Size = New System.Drawing.Size(65, 20)
        Me.lbl_holder_name.TabIndex = 14
        Me.lbl_holder_name.Text = "Nombre"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(363, 42)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(23, 20)
        Me.lbl_id.TabIndex = 28
        Me.lbl_id.Text = "Id"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(453, 39)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 26)
        Me.txt_id.TabIndex = 29
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(453, 73)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(252, 26)
        Me.txt_name.TabIndex = 30
        '
        'txt_race
        '
        Me.txt_race.Location = New System.Drawing.Point(453, 108)
        Me.txt_race.Name = "txt_race"
        Me.txt_race.Size = New System.Drawing.Size(252, 26)
        Me.txt_race.TabIndex = 31
        '
        'txt_alliance
        '
        Me.txt_alliance.Location = New System.Drawing.Point(453, 142)
        Me.txt_alliance.Name = "txt_alliance"
        Me.txt_alliance.Size = New System.Drawing.Size(252, 26)
        Me.txt_alliance.TabIndex = 32
        '
        'txt_age
        '
        Me.txt_age.Location = New System.Drawing.Point(453, 174)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(252, 26)
        Me.txt_age.TabIndex = 33
        '
        'bttn_clean
        '
        Me.bttn_clean.Location = New System.Drawing.Point(367, 286)
        Me.bttn_clean.Name = "bttn_clean"
        Me.bttn_clean.Size = New System.Drawing.Size(80, 40)
        Me.bttn_clean.TabIndex = 34
        Me.bttn_clean.Text = "Limpiar"
        Me.bttn_clean.UseVisualStyleBackColor = True
        '
        'Cnx_SW
        '
        Me.Cnx_SW.ConnectionString = Global.SW_metodo_3.My.MySettings.Default.CNX
        '
        'bttn_upload
        '
        Me.bttn_upload.Location = New System.Drawing.Point(114, 332)
        Me.bttn_upload.Name = "bttn_upload"
        Me.bttn_upload.Size = New System.Drawing.Size(160, 40)
        Me.bttn_upload.TabIndex = 35
        Me.bttn_upload.Text = "Subir Foto"
        Me.bttn_upload.UseVisualStyleBackColor = True
        '
        'Visualizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 376)
        Me.Controls.Add(Me.bttn_upload)
        Me.Controls.Add(Me.bttn_clean)
        Me.Controls.Add(Me.txt_age)
        Me.Controls.Add(Me.txt_alliance)
        Me.Controls.Add(Me.txt_race)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.bttn_exit)
        Me.Controls.Add(Me.bttn_save)
        Me.Controls.Add(Me.bttn_delete)
        Me.Controls.Add(Me.bttn_add)
        Me.Controls.Add(Me.bttn_search)
        Me.Controls.Add(Me.pic_apperance)
        Me.Controls.Add(Me.lbl_holder_age)
        Me.Controls.Add(Me.lbl_holder_alliance)
        Me.Controls.Add(Me.lbl_holder_race)
        Me.Controls.Add(Me.lbl_holder_name)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Visualizer"
        Me.Text = "Form1"
        CType(Me.pic_apperance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttn_exit As Button
    Friend WithEvents bttn_save As Button
    Friend WithEvents bttn_delete As Button
    Friend WithEvents bttn_add As Button
    Friend WithEvents bttn_search As Button
    Friend WithEvents pic_apperance As PictureBox
    Friend WithEvents lbl_holder_age As Label
    Friend WithEvents lbl_holder_alliance As Label
    Friend WithEvents lbl_holder_race As Label
    Friend WithEvents lbl_holder_name As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_race As TextBox
    Friend WithEvents txt_alliance As TextBox
    Friend WithEvents txt_age As TextBox
    Friend WithEvents bttn_clean As Button
    Friend WithEvents Cnx_SW As OleDb.OleDbConnection
    Friend WithEvents bttn_upload As Button
End Class
