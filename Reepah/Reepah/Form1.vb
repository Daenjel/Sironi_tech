Public Class MainForm

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ReepahDataSet2.Requested_Items' table. You can move, or remove it, as needed.
        Me.Requested_ItemsTableAdapter.Fill(Me.ReepahDataSet2.Requested_Items)
        'TODO: This line of code loads data into the 'ReepahDataSet2.Menu' table. You can move, or remove it, as needed.
        Me.MenuTableAdapter.Fill(Me.ReepahDataSet2.Menu)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Maximized
        UnLockToolStripMenuItem.Visible = False
    End Sub

    Private Sub BtnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnForward.Click

        MsgBox("Forward")
        Dim c, t As Integer
        MenuDataGridView.Columns.Clear()

        For t = 0 To MenuDataGridView1.Columns.Count - 1
            MenuDataGridView.Columns.Add(MenuDataGridView1.Columns(t).Clone())
        Next

        For c = 0 To MenuDataGridView1.Rows.Count - 1

            If MenuDataGridView1.Rows(c).Cells(3).Value = True Then
                MenuDataGridView.Rows.Add(MenuDataGridView1.Rows(c).Cells(0).Value, MenuDataGridView1.Rows(c).Cells(1).Value, MenuDataGridView1.Rows(c).Cells(2).Value)
                MenuDataGridView.Columns(2).Visible = True
                MenuDataGridView.Columns(3).Visible = True

            End If

        Next
        'MenuDataGridView1.Columns.Clear()
        'For Each Col As DataGridViewColumn In MenuDataGridView1.Columns
        'MenuDataGridView.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        'Next
        'For rowIndex As Integer = 0 To (MenuDataGridView1.Rows.Count - 1)
        'MenuDataGridView.Rows.Add(MenuDataGridView1.Rows(rowIndex).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        'Next
    End Sub

    Private Sub BtnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnErase.Click
        MsgBox("Erase")
        ' get the index of the selected row
        Dim index As Integer
        index = MenuDataGridView.CurrentCell.RowIndex

        ' delete the selected row
        MenuDataGridView.Rows.RemoveAt(index)
      
    End Sub
    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        If (TxtName.Text = "") Then
            MsgBox("Ordered by Must be declared")
            'MenuDataGridView1.Columns.Clear()
            For Each Col As DataGridViewColumn In MenuDataGridView.Columns
                Form2.DataGridView1.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
            Next
            For rowIndex As Integer = 0 To (MenuDataGridView.Rows.Count - 1)
                Form2.DataGridView1.Rows.Add(MenuDataGridView.Rows(rowIndex).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
            Next
        Else
            MsgBox("Submit")
            MenuDataGridView.Columns.Clear()
            TxtName.Text = ""
        End If

    End Sub

    Private Sub LockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LockToolStripMenuItem.Click
        Label1.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        MenuDataGridView1.Enabled = False
        MenuDataGridView.Enabled = False
        BtnErase.Enabled = False
        BtnForward.Enabled = False
        BtnSubmit.Enabled = False
        TxtName.Enabled = False
        UnLockToolStripMenuItem.Visible = True
        LockToolStripMenuItem.Visible = False
    End Sub

    Private Sub UnLockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnLockToolStripMenuItem.Click
        Label1.Enabled = True
        Label2.Enabled = True
        Label3.Enabled = True
        MenuDataGridView1.Enabled = True
        MenuDataGridView.Enabled = True
        BtnErase.Enabled = True
        BtnForward.Enabled = True
        BtnSubmit.Enabled = True
        TxtName.Enabled = True
        UnLockToolStripMenuItem.Visible = False
        LockToolStripMenuItem.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenStocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenStocksToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub OpenSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenSalesToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        Try
            Dim val1 As DataGridViewCheckBoxCell = MenuDataGridView1(MenuDataGridView1.CurrentCell.ColumnIndex, MenuDataGridView1.CurrentCell.RowIndex)
            val1.Value = False
        Catch ex As System.Exception
            'Request threw an error - Fatal failure.
            MsgBox("No Checkbox has been selected")
            'MsgBox(ex.Message)
        End Try

    End Sub
End Class
