Imports System.IO
Imports System.Threading

Public Class frmCafe

    Private WithEvents frm_list As New frmList

    'building up the price of the food into variable
    Private Const Apple_price As Double = 10.0
    Private Const Lettuce_price As Double = 12.5
    Private Const Tomato_price As Double = 8.5
    Private Const Ham_price As Double = 20.0
    Private Const Tuna_price As Double = 18.5
    Private Const Grain_price As Double = 8.0
    Private Const Honey_price As Double = 10.5

    Private staff As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initform()
        'this code will be allowed to download the database file when the file was not found
        If Not System.IO.File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Database.mdb") Then
            My.Computer.Network.DownloadFile("http://www.yiukamsum.tk/file.php?dir=/17-18/ITE3711_Program/Project/Database.mdb", System.AppDomain.CurrentDomain.BaseDirectory & "Database.mdb")
        End If

        'Fill the "Order" Table data in OrderTableAdapter1
        Me.OrderTableAdapter1.Fill(Me.DatabaseDataSet1.Order)
    End Sub
    Private Sub Form1_Loaded(sender As Object, e As EventArgs) Handles MyBase.Shown
        change_staff()
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'lock the form when data recording to database
        Me.Cursor = Cursors.WaitCursor
        btnConfirm.Enabled = False
        Me.Enabled = False

        ToolStripProgressBar1.Value = 7
        ToolStripStatusLabel1.Text = "Prepareing"

        If CheckForm() Then
            ToolStripStatusLabel1.Text = "Saving"

            'Create a new row in Dataset
            Dim newOrderRow As DatabaseDataSet.OrderRow
            newOrderRow = DatabaseDataSet1.Order.NewRow()
            ToolStripProgressBar1.Value += 7

            'Set some base info. into row
            Dim newDataTime As String = DateTime.Now()
            newOrderRow.DateTime = newDataTime
            newOrderRow.CustomerName = txtCustomerName.Text
            newOrderRow.Quantity = CInt(nupQuantity.Value)
            newOrderRow.Staff = staff
            ToolStripProgressBar1.Value += 7

            'building up the price_total is 0 into variable
            Dim price_total As Double = 0

            'if apple’s checkbox was selected, that will count the price in toto ‘sum’ variable
            calc_price(ckbApple.Checked, Apple_price, price_total, newOrderRow.Apple)
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'if lettuce’s checkbox was selected, that will count the price in toto ‘sum’ variable
            calc_price(ckbLettuce.Checked, Lettuce_price, price_total, newOrderRow.Lettuce)
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'if tomato’s checkbox was selected, that will count the price in toto ‘sum’ variable
            calc_price(ckbTomato.Checked, Tomato_price, price_total, newOrderRow.Tomato)
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'if ham’s checkbox was selected, that will count the price in toto ‘sum’ variable
            calc_price(ckbHam.Checked, Ham_price, price_total, newOrderRow.Ham)
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'if tuna’s checkbox was selected, that will count the price in toto ‘sum’ variable
            calc_price(ckbTuna.Checked, Tuna_price, price_total, newOrderRow.Tuna)
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'if grain’s radiobutton was selected, that will count the price in toto ‘sum’ variable
            calc_price(rdbGrain.Checked, Grain_price, price_total, newOrderRow.GrainWheat)
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'if honey’s radiobutton was selected, that will count the price in toto ‘sum’ variable
            calc_price(rdbHoney.Checked, Honey_price, price_total, newOrderRow.HoneyOat)
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'calculate final price for Quantity* Price Total
            price_total *= nupQuantity.Value
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'after that calcuate final price_total over $100 to give discount to calcuate new final price_total
            If price_total >= 100 Then
                price_total *= 0.9
            End If
            ToolStripProgressBar1.Value += 7
            Thread.Sleep(250)

            'put the total price into row.
            newOrderRow.Total = price_total

            'putting the new row in to dataset
            DatabaseDataSet1.Order.Rows.Add(newOrderRow)
            ToolStripProgressBar1.Value = 100
            ToolStripStatusLabel1.Text = "Saved"

            'display Order amount, number of order, total sales, average of sales and largest sales into textbox
            txtOrderAMT.Text = String.Format("{0:C}", price_total)
            txtNumOfOrders.Text = CStr(lstCustomer.Items.Count)
            Dim query = (From Order In DatabaseDataSet1.Order Select Order.Total).Sum
            txtTotalSales.Text = String.Format("{0:C}", Math.Round(query, 2))
            txtAveOfSales.Text = String.Format("{0:C}", Math.Round(query / CStr(lstCustomer.Items.Count), 2))
            txtLargestSales.Text = String.Format("{0:C}", Math.Round((From Order In DatabaseDataSet1.Order Select Order.Total).Max, 2))
        Else
            'if the form is not completed, show the messagebox.
            ToolStripProgressBar1.Value = 100
            ToolStripStatusLabel1.Text = "Error"
        End If
        MessageBox.Show("Saved!")

        'ignore all the click command when the button is disable.
        My.Application.DoEvents()

        Me.Enabled = True
        btnConfirm.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub calc_price(ByVal checked As Boolean, ByVal price As Double, ByRef sum As Double, ByRef data As Boolean)
        If checked Then
            sum += price
            data = True
        End If
    End Sub

    Private Sub initform()
        'init the Announcement into the textbox
        txtAnnouncement.Text = "Discount Offerd per Order" & vbNewLine & "10.00% discount if order amount >= $100"
        'init all the price of foods in to all label
        ckbApple.Text &= String.Format("{0:C}", Apple_price)
        ckbLettuce.Text &= String.Format("{0:C}", Lettuce_price)
        ckbTomato.Text &= String.Format("{0:C}", Tomato_price)
        ckbHam.Text &= String.Format("{0:C}", Ham_price)
        ckbTuna.Text &= String.Format("{0:C}", Tuna_price)
        rdbGrain.Text &= String.Format("{0:C}", Grain_price)
        rdbHoney.Text &= String.Format("{0:C}", Honey_price)
    End Sub

    Sub change_staff()
        'show the original form and buliding up tmp assign the staff 
        Dim tmp As String = staff
        staff = ""
        While staff = ""
            staff = InputBox("Staff, What is your name?", "", tmp)
            'if not input the staff in textbox second time , the staff will not be charge
            If staff = "" Then
                staff = tmp
            End If
            ToolStripStatusLabel2.Text = "Staff: " & staff
        End While
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'set all checkbox to unchecked status and clear the textbox.
        ckbApple.Checked = False
        ckbHam.Checked = False
        ckbLettuce.Checked = False
        ckbTomato.Checked = False
        ckbTuna.Checked = False
        rdbGrain.Checked = False
        rdbHoney.Checked = False
        nupQuantity.Value = 1
        txtCustomerName.Text = ""
        txtOrderAMT.Text = ""
    End Sub

    Private Sub lstCustomer_DoubleClick(sender As Object, e As EventArgs) Handles lstCustomer.DoubleClick
        If IsNothing(lstCustomer.SelectedValue) Then
            'if listbox item have not selected, show the messagebox.
            MessageBox.Show("Error")
        Else
            'find the Customer form the database and pass the data to "query"
            Dim query = From Order In DatabaseDataSet1.Order Where Order.DateTime = lstCustomer.SelectedValue Select Order
            Dim list As New frmList
            list.Text = "Order"
            list.txtName.Text = query(0).CustomerName.ToString & " ordered"
            list.txtTime.Text = "Order was cteate at" & query(0).DateTime.ToString & "  by staff  " & query(0).Staff.ToString

            'checking which thing was bought bt someone
            If query(0).Apple Then
                list.lstFood.Items.Add("Apple" & "  x" & query(0).Quantity)
            End If
            If query(0).Lettuce Then
                list.lstFood.Items.Add("Lettuce" & "  x" & query(0).Quantity)
            End If
            If query(0).Tomato Then
                list.lstFood.Items.Add("Tomato" & "  x" & query(0).Quantity)
            End If
            If query(0).Ham Then
                list.lstFood.Items.Add("Ham" & "  x" & query(0).Quantity)
            End If
            If query(0).Tuna Then
                list.lstFood.Items.Add("Tuna" & "  x" & query(0).Quantity)
            End If
            If query(0).GrainWheat Then
                list.lstFood.Items.Add("Grain Wheat" & "  x" & query(0).Quantity)
            End If
            If query(0).HoneyOat Then
                list.lstFood.Items.Add("Honey Oat" & "  x" & query(0).Quantity)
            End If

            list.ShowDialog()
        End If
    End Sub

    Function CheckForm() As Boolean
        Dim i As Integer = 0

        'check have or haven't select Salad Ingredients
        For Each rdo As CheckBox In gpbSelectionofSaladIngredients.Controls()
            If rdo.Checked Then
                i += 1
            End If
        Next

        'if not select, return false
        If i < 1 Then
            MessageBox.Show("Please Select Salad Ingredients")
            Return False
        Else
            i = 0
        End If

        'check have or haven't select Bread
        For Each rdo As RadioButton In gpbSelectionofBread.Controls()
            If rdo.Checked Then
                i += 1
            End If
        Next

        'if not select, return false
        If i < 1 Then
            MessageBox.Show("Please Select Bread")
            Return False
        Else
            i = 0
        End If

        'check Customer Name were entered or not
        If txtCustomerName.Text = "" Then
            MessageBox.Show("Please Enter the Customer Name")
            'if not, return false
            Return False
        End If
        Return True
    End Function

    Private Sub ExitEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitEToolStripMenuItem.Click
        'click the exit button , the form will be close
        Me.Close()
    End Sub

    Private Sub AboutAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAToolStripMenuItem.Click
        'open aboutbox
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ChangePToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePToolStripMenuItem.Click
        change_staff()
    End Sub

    Private Sub txtFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If Not txtFindName.Text = "" Then
            Dim lines As String = ""
            'check and research the customer record is what lines in listbox
            For i As Integer = 0 To lstCustomer.Items.Count - 1
                If txtFindName.Text.ToUpper = lstCustomer.Items(i)(1).ToString.ToUpper Then

                    lines &= i + 1 & ", "
                End If
            Next
            If lines = "" Then
                MessageBox.Show("Customer not found")
            Else
                MessageBox.Show(txtFindName.Text & " is on line " & lines & "of the list.")
            End If
        Else
            MessageBox.Show("Please Enter the Customer Name.")
        End If
    End Sub

    Private Sub btnClearAcc_Click(sender As Object, e As EventArgs) Handles btnClearAcc.Click
        'warning the user
        Select Case MessageBox.Show("You are cleaning up the data. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)
            'if choose the "yes" button , the record will be delete
            Case MsgBoxResult.Yes
                Try
                    'try to delete all data in database.
                    Dim ordFetch = From ofetch In DatabaseDataSet1.Order Select ofetch
                    While ordFetch.Count >= 1
                        DatabaseDataSet1.Order.RemoveOrderRow(ordFetch(0))
                    End While

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

                'clean textbox
                txtAveOfSales.Text = ""
                txtTotalSales.Text = ""
                txtNumOfOrders.Text = ""
                txtLargestSales.Text = ""
                txtFindName.Text = ""
           'if choose the "no" button , then nothing to process
            Case MsgBoxResult.No

        End Select
    End Sub

    Private Sub ExportEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportEToolStripMenuItem.Click

        'ask this question someone want to save data when the record is nothing 
        If (From Order In DatabaseDataSet1.Order Select Order).Count <= 0 Then
            If MessageBox.Show("You are saving an empty database data. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        'collect data from DataSet
        Dim querys = (From Order In DatabaseDataSet1.Order Select Order)
        'generate the file content
        Dim str As String = "DateTime,CustomerName,Quantity,Apple,Lettuce,Tomato,Ham,Tuna,GrainWheat,HoneyOat,Total,Staff" & vbNewLine
        For Each rows As DatabaseDataSet.OrderRow In querys
            For i As Integer = 0 To 11
                If i = 11 Then
                    str &= rows(i)
                Else
                    str &= rows(i) & ","
                End If
            Next
            str &= vbNewLine
        Next

        'save as the file
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, str)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        'ask this question that is close the form
        Select Case MessageBox.Show("Are you want to save data?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            'if choose the "yes" button , the record will be save
            Case MsgBoxResult.Yes
                OrderBindingSource.EndEdit()
                OrderTableAdapter1.Update(DatabaseDataSet1)
           'if choose the "no" button , the form will be close 
            Case MsgBoxResult.No

            'if choose the "cancel" button , the record will be cancel and show in original form
            Case MsgBoxResult.Cancel
                e.Cancel = True
                Exit Sub
        End Select

    End Sub

    Private Sub btnMost_Click(sender As Object, e As EventArgs) Handles btnMost.Click
        'counting how many thing have selled.
        Dim count_Apple = (From Order In DatabaseDataSet1.Order Where Order.Apple).Count
        Dim count_Lettuce = (From Order In DatabaseDataSet1.Order Where Order.Lettuce).Count
        Dim count_Tomato = (From Order In DatabaseDataSet1.Order Where Order.Tomato).Count
        Dim count_Ham = (From Order In DatabaseDataSet1.Order Where Order.Ham).Count
        Dim count_Tuna = (From Order In DatabaseDataSet1.Order Where Order.Tuna).Count

        'put data in to array
        Dim count_array() As Integer = {count_Apple, count_Lettuce, count_Tomato, count_Ham, count_Tuna}
        Dim list As New frmList
        list.Text = "The Most Popular Ingredient"
        list.txtName.Text = "Most Popular Ingredient:"
        'compare which is the most.
        If count_Apple = count_array.Max And count_Apple > 0 Then
            list.lstFood.Items.Add("Apple")
        End If
        If count_Lettuce = count_array.Max And count_Lettuce > 0 Then
            list.lstFood.Items.Add("Lettuce")
        End If
        If count_Tomato = count_array.Max And count_Tomato > 0 Then
            list.lstFood.Items.Add("Tomato")
        End If
        If count_Ham = count_array.Max And count_Ham > 0 Then
            list.lstFood.Items.Add("Ham")
        End If
        If count_Tuna = count_array.Max And count_Tuna > 0 Then
            list.lstFood.Items.Add("Tuna")
        End If
        If count_array.Max = 0 Then
            list.lstFood.Items.Add("No any Order in the System.")
        End If
        'show the result
        list.ShowDialog()
    End Sub

    Private Sub ImportCSVFileIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportCSVFileIToolStripMenuItem.Click
        Dim table As New ArrayList
        'open the file and pass data
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim data As StreamReader = System.IO.File.OpenText(OpenFileDialog1.FileName)
            Dim line As String = ""
            While data.EndOfStream = False
                table.Add(data.ReadLine.Split(","))
            End While
        End If

        'Create a New row in Dataset
        For i As Integer = 1 To table.Count - 1
            Dim newOrderRow As DatabaseDataSet.OrderRow
            newOrderRow = DatabaseDataSet1.Order.NewRow()
            newOrderRow.DateTime = table(i)(0)
            newOrderRow.CustomerName = table(i)(1)
            newOrderRow.Quantity = Convert.ToInt64(table(i)(2))
            newOrderRow.Apple = Convert.ToBoolean(table(i)(3))
            newOrderRow.Lettuce = Convert.ToBoolean(table(i)(4))
            newOrderRow.Tomato = Convert.ToBoolean(table(i)(5))
            newOrderRow.Ham = Convert.ToBoolean(table(i)(6))
            newOrderRow.Tuna = Convert.ToBoolean(table(i)(7))
            newOrderRow.GrainWheat = Convert.ToBoolean(table(i)(8))
            newOrderRow.HoneyOat = Convert.ToBoolean(table(i)(9))
            newOrderRow.Total = Convert.ToDouble(table(i)(10))
            newOrderRow.Staff = table(i)(11)
            DatabaseDataSet1.Order.Rows.Add(newOrderRow)
        Next

    End Sub

    Sub frmlist_SimulateForm1ButtonClick() Handles frm_list.SimulateForm1ButtonClick
        Try
            'try to delete selected data in database.
            Dim ordFetch = From ofetch In DatabaseDataSet1.Order Select ofetch Where ofetch.DateTime = lstCustomer.SelectedValue
            If ordFetch.Count = 1 Then
                DatabaseDataSet1.Order.RemoveOrderRow(ordFetch(0))
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        frm_list.Close()
    End Sub

    Private Sub RemoveRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveRToolStripMenuItem.Click
        frm_list.btnDelete.Visible = True
        If IsNothing(lstCustomer.SelectedValue) Then
            'if listbox item have not selected, show the messagebox.
            MessageBox.Show("Error")
        Else
            'find the Customer form the database and pass the data to "query"
            Dim query = From Order In DatabaseDataSet1.Order Where Order.DateTime = lstCustomer.SelectedValue Select Order
            frm_list.Text = "Delete Order"
            frm_list.txtName.Text = query(0).CustomerName.ToString & " ordered"
            frm_list.txtTime.Text = "Order was cteate at" & query(0).DateTime.ToString & "  by staff  " & query(0).Staff.ToString
            frm_list.lstFood.Items.Clear()
            'checking which thing was bought bt someone
            If query(0).Apple Then
                frm_list.lstFood.Items.Add("Apple" & "  x" & query(0).Quantity)
            End If
            If query(0).Lettuce Then
                frm_list.lstFood.Items.Add("Lettuce" & "  x" & query(0).Quantity)
            End If
            If query(0).Tomato Then
                frm_list.lstFood.Items.Add("Tomato" & "  x" & query(0).Quantity)
            End If
            If query(0).Ham Then
                frm_list.lstFood.Items.Add("Ham" & "  x" & query(0).Quantity)
            End If
            If query(0).Tuna Then
                frm_list.lstFood.Items.Add("Tuna" & "  x" & query(0).Quantity)
            End If
            If query(0).GrainWheat Then
                frm_list.lstFood.Items.Add("Grain Wheat" & "  x" & query(0).Quantity)
            End If
            If query(0).HoneyOat Then
                frm_list.lstFood.Items.Add("Honey Oat" & "  x" & query(0).Quantity)
            End If

            frm_list.ShowDialog()
        End If
    End Sub
End Class