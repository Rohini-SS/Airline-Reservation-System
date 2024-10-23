Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "General Enquiry"
        Me.ComboBox1.Focus()
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Dim JJ As New Form1
        JJ.Show()
        Me.Hide()
    End Sub

    Private Sub CMDADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDADD.Click
        Me.ComboBox1.Enabled = False
        Me.TextBox1.Text = ""
        Me.txtairlinename.Text = ""
        Me.txtcountry.Text = ""
        Me.txtowner.Text = ""
        Me.txtbase.Text = ""
        Me.txttype.Text = ""
        Me.txttotseat.Text = ""
        Me.txtbagallowed.Text = ""
        Me.txtairlinename.Focus()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = ConnString

            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Dim sql As String
                sql = "select * from airlines_genenq where owned_by='" & ComboBox1.Text & "'"

                myConnection.Open()
                Dim com As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader
                If Not dbread.read Then
                    MsgBox("Sorry ! No Records Found")
                    ComboBox1.Text = ""
                    ComboBox1.Focus()
                Else
                    TextBox1.Text = dbread.getstring(0)
                    txtairlinename.Text = dbread.getstring(1)
                    txtcountry.Text = dbread.getString(2)
                    txtowner.Text = dbread.getstring(3)
                    txtbase.Text = dbread.getstring(4)
                    txttype.Text = dbread.getstring(5)
                    txttotseat.Text = dbread.getvalue(6)
                    txtbagallowed.Text = dbread.getstring(7)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsubmit.Click
        Try
            Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString

            Dim sql As String
            sql = "select * from airlines_genenq where owned_by='" & ComboBox1.Text & "'"

            myConnection.Open()
            Dim com As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            dbread = com.ExecuteReader
            If Not dbread.read Then
                MsgBox("Sorry ! No Records Found")
                ComboBox1.Text = ""
                ComboBox1.Focus()
            Else
                TextBox1.Text = dbread.getstring(0)
                txtairlinename.Text = dbread.getstring(1)
                txtcountry.Text = dbread.getString(2)
                txtowner.Text = dbread.getstring(3)
                txtbase.Text = dbread.getstring(4)
                txttype.Text = dbread.getstring(5)
                txttotseat.Text = dbread.getvalue(6)
                txtbagallowed.Text = dbread.getstring(7)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ComboBox1.Text = "" Then
            Me.TextBox1.Text = ""
            Me.txtairlinename.Text = ""
            Me.txtcountry.Text = ""
            Me.txtowner.Text = ""
            Me.txtbase.Text = ""
            Me.txttype.Text = ""
            Me.txttotseat.Text = ""
            Me.txtbagallowed.Text = ""
        End If
    End Sub
    Private Sub CMDSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDSAVE.Click
        Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "insert into airlines_genenq(flight_no,airline_name,country,owned_by,base,type,total_seat,bag_allowed) values('" & TextBox1.Text & "','" & txtairlinename.Text & "','" & txtcountry.Text & "','" & txtowner.Text & "','" & txtbase.Text & "','" & txttype.Text & "'," & txttotseat.Text & ",'" & txtbagallowed.Text & "')"
        myConnection.Open()
        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()
        MsgBox("Save Successfully")
    End Sub

    Private Sub cmdcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdcancel.Click
        Me.ComboBox1.Enabled = True
        Me.ComboBox1.Text = ""
        Me.TextBox1.Text = ""
        Me.txtairlinename.Text = ""
        Me.txtcountry.Text = ""
        Me.txtowner.Text = ""
        Me.txtbase.Text = ""
        Me.txttype.Text = ""
        Me.txttotseat.Text = ""
        Me.txtbagallowed.Text = ""
        Me.ComboBox1.Focus()
    End Sub

    Private Sub CMDUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDUPDATE.Click
        Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "update airlines_genenq set flight_no='" & TextBox1.Text & "',airline_name='" & txtairlinename.Text & "',country='" & txtcountry.Text & "',owned_by='" & txtowner.Text & "',base='" & txtbase.Text & "',type='" & txttype.Text & "',total_seat=" & txttotseat.Text & ",bag_allowed='" & txtbagallowed.Text & "' where owned_by='" & ComboBox1.Text & "'"
        myConnection.Open()
        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()
        MsgBox("Update Successfully")

    End Sub

    Private Sub CMDDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDDELETE.Click
        Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
        Dim myConnection As OleDbConnection = New OleDbConnection
        myConnection.ConnectionString = connString
        Dim dsinvoice As New DataSet
        Dim dainvoice As New OleDbDataAdapter
        Dim sql As String = "delete from airlines_genenq where owned_by='" & ComboBox1.Text & "'"
        myConnection.Open()

        Dim com As New OleDbCommand
        Dim dbread
        com = New OleDbCommand(sql, myConnection)
        dbread = com.ExecuteReader()
        MsgBox("Delete Successfully")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class