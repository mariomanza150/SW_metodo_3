Imports System.Data.OleDb
Imports System.Drawing.Imaging
Imports System.IO

Public Class Visualizer
    Dim file As String
    Private Sub clean()
        txt_name.Clear()
        txt_race.Clear()
        txt_alliance.Clear()
        txt_age.Clear()
        pic_apperance.Image = Nothing
        txt_id.Clear()
        txt_id.Focus()
    End Sub
    Private Sub bttn_search_Click(sender As Object, e As EventArgs) Handles bttn_search.Click
        Dim query = "Select * From Characters Where Id=@Id"
        Dim cmd_search As New OleDbCommand(query, Cnx_SW)
        cmd_search.CommandType = CommandType.Text
        cmd_search.Parameters.AddWithValue("@Id", txt_id.Text)
        Cnx_SW.Open()
        Dim Read As OleDbDataReader
        Read = cmd_search.ExecuteReader
        If Read.Read Then
            txt_name.Text = Read(1)
            txt_race.Text = Read(2)
            txt_alliance.Text = Read(3)
            txt_age.Text = Read(4)
            pic_apperance.ImageLocation = Read(5)
        Else
            MsgBox("Id no encontrado", MsgBoxStyle.Information, "Agenda")
            txt_id.Clear()
            txt_id.Focus()
        End If
        Cnx_SW.Close()
    End Sub
    Private Sub bttn_clean_Click(sender As Object, e As EventArgs) Handles bttn_clean.Click
        clean()
    End Sub
    Private Sub bttn_add_Click(sender As Object, e As EventArgs) Handles bttn_add.Click
        Try
            Dim save = "Insert Into Characters Values(Id=@Id, Nombre=@Nombre, Raza=@Raza, Bando=@Bando, Edad=@Edad, Imagen=@Imagen)"
            Dim cmd_save As New OleDbCommand(save, Cnx_SW)
            cmd_save.CommandType = CommandType.Text
            cmd_save.Parameters.AddWithValue("@Id", txt_id.Text)
            cmd_save.Parameters.AddWithValue("@Nombre", txt_name.Text)
            cmd_save.Parameters.AddWithValue("@Raza", txt_race.Text)
            cmd_save.Parameters.AddWithValue("@Bando", txt_alliance.Text)
            cmd_save.Parameters.AddWithValue("@Edad", txt_age.Text)
            cmd_save.Parameters.AddWithValue("@Imagen", pic_apperance.ImageLocation)
            Cnx_SW.Open()
            cmd_save.ExecuteNonQuery()
            Cnx_SW.Close()
            MsgBox("Datos Guardados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title,
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub bttn_delete_Click(sender As Object, e As EventArgs) Handles bttn_delete.Click
        Try
            Dim delete = "Delete From Characters Where Id=@Id"
            Dim cmd_delete As New OleDbCommand(delete, Cnx_SW)
            cmd_delete.CommandType = CommandType.Text
            cmd_delete.Parameters.AddWithValue("@Id", txt_id.Text)
            Cnx_SW.Open()
            cmd_delete.ExecuteNonQuery()
            Cnx_SW.Close()
            clean()
            MsgBox("Datos Eliminados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title,
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub bttn_save_Click(sender As Object, e As EventArgs) Handles bttn_save.Click
        Try
            Dim save = "Update Characters Set Nombre=@Nombre, Raza=@Raza, Bando=@Bando, Edad=@Edad, Imagen=@Imagen Where Id=@Id"
            Dim cmd_save As New OleDbCommand(save, Cnx_SW)
            cmd_save.CommandType = CommandType.Text
            cmd_save.Parameters.AddWithValue("@Id", txt_id.Text)
            cmd_save.Parameters.AddWithValue("@Nombre", txt_name.Text)
            cmd_save.Parameters.AddWithValue("@Raza", txt_race.Text)
            cmd_save.Parameters.AddWithValue("@Bando", txt_alliance.Text)
            cmd_save.Parameters.AddWithValue("@Edad", txt_age.Text)
            cmd_save.Parameters.AddWithValue("@Imagen", pic_apperance.ImageLocation)
            Cnx_SW.Open()
            cmd_save.ExecuteNonQuery()
            Cnx_SW.Close()
            MsgBox("Datos Actualizados")
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title,
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub bttn_exit_Click(sender As Object, e As EventArgs) Handles bttn_exit.Click
        End
    End Sub

    Private Sub bttn_upload_Click(sender As Object, e As EventArgs) Handles bttn_upload.Click
        Dim filedialog As New OpenFileDialog
        With filedialog
            .Filter = "jpegs|*.jpg|gifs|*.gif|Bitmaps|*.bmp|pngs|*.png"
            .FilterIndex = 1
            .Title = "Selecciona una imagen"
        End With
        If filedialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                pic_apperance.Image = Image.FromFile(filedialog.FileName)
                filedialog.Reset()
            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title,
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
