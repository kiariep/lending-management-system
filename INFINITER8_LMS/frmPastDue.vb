﻿
Imports MySql.Data.MySqlClient
Public Class frmPastDue

    Private Sub LoadCollectors()
        Try
            sqL = "SELECT CollectorName FROM collector Order By CollectorName"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            cmbCollector.Items.Clear()
            Do While dr.Read = True
                cmbCollector.Items.Add(dr(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub LoadArea()
        Try
            sqL = "SELECT AREANAME FROM areas ORDER BY AREANAME"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            cmbArea.Items.Clear()
            Do While dr.Read = True
                cmbArea.Items.Add(dr(0))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub LoadPastdue()
        Dim totPastDue As Double
        Try
            sqL = "SELECT MatDate, Concat(Lastname, ', ', Firstname, ' ', MI) as BorName, Area, MatValue, WRemittance, L.Balance, COUNT(TransactionNo) as RemNum, duration FROM loan as L, borrower as B, remittance as R WHERE L.BorrowerNo = B.BorrowerNo AND L.LoanNo = R.LoanNo AND L.Balance > 0 AND Collector LIKE '" & cmbCollector.Text & "%' AND AREA LIKE '" & cmbArea.Text & "%' GROUP BY L.LoanNo ORDER BY MatDate, Lastname"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            dgw.Rows.Clear()
            totPastDue = 0
            Do While dr.Read = True
                If dr(6) = dr(7) Then
                    dgw.Rows.Add(dr(0), dr(1), dr(2), Format(dr(3), "#,##0.00"), Format(dr(4), "#,##0.00"), Format(dr(5), "#,##0.00"))
                    totPastDue += dr(5)
                End If

            Loop
            lblCollectables.Text = Format(totPastDue, "#,##0.0")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

    End Sub

    Private Sub frmPastDue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbArea.Text = ""
        cmbCollector.Text = ""

        LoadPastdue()
        LoadCollectors()
        LoadArea()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

   

    Private Sub cmbCollector_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCollector.TextChanged
        LoadPastdue()
    End Sub

    Private Sub cmbArea_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbArea.TextChanged
        LoadPastdue()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        frmPrintPastDue.ShowDialog()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblCollectables_Click(sender As Object, e As EventArgs) Handles lblCollectables.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub cmbCollector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCollector.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub cmbArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbArea.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub dgw_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellContentClick

    End Sub
End Class