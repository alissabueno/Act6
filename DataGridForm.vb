Imports System.Data.Common
Imports Excel = Microsoft.Office.Interop.Excel
Imports MySql.Data.MySqlClient
Public Class DataGridForm
    Dim connectionString As String = "Server=127.0.0.1;Database=trialdb;Uid=root;Pwd=alissamoresbueno;"
    Dim connection As MySqlConnection = New MySqlConnection(connectionString)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM users"
        Dim adapter As MySqlDataAdapter = New MySqlDataAdapter(query, connection)
        Dim table As DataTable = New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackupModule.BackupTableToExcel("MyTable", "C:\Users\User\OneDrive\Documents\template.xlsx", "C:\Users\User\Desktop\MyBackup.xlsx")
    End Sub
End Class
