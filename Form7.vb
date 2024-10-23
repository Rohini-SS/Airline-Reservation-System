Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TextBox1.Text = Me.TextBox5.Text
        Me.ComboBox1.Items.Add("STATE BANK")
        Me.TextBox19.Text = Me.TextBox17.Text
        Me.TextBox2.Text = Me.TextBox13.Text
        Me.TextBox20.Text = 0
        Me.TextBox21.Text = 0
        Me.TextBox22.Text = "N/A"


        Me.TextBox5.Visible = False
        Me.TextBox6.Visible = False
        Me.TextBox7.Visible = False
        Me.TextBox8.Visible = False
        Me.TextBox9.Visible = False
        Me.TextBox10.Visible = False
        Me.TextBox11.Visible = False
        Me.TextBox12.Visible = False
        Me.TextBox13.Visible = False
        Me.TextBox14.Visible = False
        Me.TextBox15.Visible = False
        Me.TextBox16.Visible = False
        Me.TextBox17.Visible = False
        Me.TextBox17.Visible = False
        Me.TextBox18.Visible = False

        Me.TextBox19.Visible = False
        Me.TextBox20.Visible = False
        Me.TextBox21.Visible = False
        Me.TextBox22.Visible = False
        Me.TextBox23.Visible = False
        Me.TextBox24.Visible = False
    End Sub

    Private Sub CMDFINISH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDFINISH.Click
        Try
            Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = ConnString
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter
            Dim sql As String = "insert into AIRLINES_TICKET(PNR,PASSENGER_NAME,ADDRESS,DOB,PHONE_NO,FLIGHT_NO,DESTINATION,JOURNEY_DATE,FARE,BOOKING_DATE,STATUS,CANCEL_DATE) values(" & TextBox5.Text & ",'" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "'," & TextBox13.Text & ",'" & TextBox14.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "')"
            Dim SQL1 As String = "INSERT INTO AIRLINES_PAYMENT(PNR,AMOUNT,PAY_MADE_BY,CARD_NAME,CARD_NO,STATUS,REFUND_AMOUNT,DEDUCT_AMOUNT,REFUND_DATE) VALUES (" & TextBox1.Text & ",'" & TextBox2.Text & "','" & ComboBox1.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & TextBox19.Text & "'," & TextBox20.Text & "," & TextBox21.Text & ",'" & TextBox22.Text & "')"
            myConnection.Open()
            Dim com As New OleDbCommand
            Dim COM1 As New OleDbCommand
            Dim dbread
            com = New OleDbCommand(sql, myConnection)
            COM1 = New OleDbCommand(SQL1, myConnection)
            dbread = com.ExecuteReader()
            dbread = COM1.ExecuteReader()
        Catch ex As Exception

        End Try

        Try
            If Me.TextBox10.Text = "SV9" Then
                Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = ConnString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=" & Me.TextBox24.Text - 1 & " WHERE FLIGHT_NO='" & Me.TextBox10.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If

        Catch ex As Exception

        End Try

        Try
            If Me.TextBox10.Text = "AI111" Then
                Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = ConnString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=" & Me.TextBox24.Text - 1 & " WHERE FLIGHT_NO='" & Me.TextBox10.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If

        Catch ex As Exception

        End Try

        Try
            If Me.TextBox10.Text = "SQ26" Then
                Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = ConnString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=" & Me.TextBox24.Text - 1 & " WHERE FLIGHT_NO='" & Me.TextBox10.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If

        Catch ex As Exception

        End Try

        Try
            If Me.TextBox10.Text = "KU101" Then
                Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = ConnString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=" & Me.TextBox24.Text - 1 & " WHERE FLIGHT_NO='" & Me.TextBox10.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If

        Catch ex As Exception

        End Try

        Try
            If Me.TextBox10.Text = "JL6" Then
                Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = ConnString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=" & Me.TextBox24.Text - 1 & " WHERE FLIGHT_NO='" & Me.TextBox10.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If

        Catch ex As Exception

        End Try

        Try
            If Me.TextBox10.Text = "AI141" Then
                Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = ConnString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=" & Me.TextBox24.Text - 1 & " WHERE FLIGHT_NO='" & Me.TextBox10.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
            End If

        Catch ex As Exception

        End Try

        Try
            If Me.TextBox10.Text = "KE81" Then
                Dim ConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\INTERNATIONAL_AIRLINE\INTERNATIONAL_AIRLINE\INTERNATIONAL AIRLINE\AIRLINES.mdb"
                Dim myConnection As OleDbConnection = New OleDbConnection
                myConnection.ConnectionString = ConnString
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter
                Dim sql As String = "UPDATE AIRLINES_NEWYORK SET REMAIN_SEAT=" & Me.TextBox24.Text - 1 & " WHERE FLIGHT_NO='" & Me.TextBox10.Text & "'"
                myConnection.Open()
                Dim com As New OleDbCommand
                Dim COM1 As New OleDbCommand
                Dim dbread
                com = New OleDbCommand(sql, myConnection)
                dbread = com.ExecuteReader()
                MsgBox("Reserved successfully")
            End If

        Catch ex As Exception

        End Try
        MsgBox("THANK YOUR BOOKING")
        Dim JJ As New Form1
        JJ.Show()
        Me.Hide()

    End Sub

   

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Label6.Text = DateTime.Now.ToString
        
    End Sub

    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.TextChanged

        MsgBox("WITHIN 24hr YOU WANT TO PAY OTHERWISE TICKET WILL BE CANCELED THANK YOU")

    End Sub

End Class

