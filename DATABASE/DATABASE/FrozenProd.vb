Public Class FrozenProd
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Private Sub FrozenProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropPanel.Size = DropPanel.MinimumSize
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If isCollapsed Then
            DropButton.Image = My.Resources.Arrow_Down

            DropPanel.Height += 10
            If DropPanel.Size = DropPanel.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            DropButton.Image = My.Resources.Arrow_Left
            DropPanel.Height -= 10
            If DropPanel.Size = DropPanel.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        isCollapsed2 = False

        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Beverages.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PerishableGoods.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Non_Perishable_Goods.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dry_Goods.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Condiments_and_Sauces.Show()
    End Sub

End Class