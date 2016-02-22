Public Class Form1
    Private func1 As String

    Private value1 As Double
    Private value2 As Double
    Private temp As Double

    Private status As Boolean
    Private deci As Boolean
    Private cleartext As Boolean




    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDisplay.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TxtDisplay.Text.Length <> 0 Then
            If func1 = String.Empty Then
                value1 = CType(TxtDisplay.Text, Double)
                TxtDisplay.Text = String.Empty
            Else
                calctotals()

            End If
            func1 = "add"
            deci = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TxtDisplay.Text.Length <> 0 Then
            If func1 = String.Empty Then
                value1 = CType(TxtDisplay.Text, Double)
                TxtDisplay.Text = String.Empty
            Else
                calctotals()

            End If
            func1 = "sub"
            deci = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TxtDisplay.Text.Length <> 0 Then
            If func1 = String.Empty Then
                value1 = CType(TxtDisplay.Text, Double)
                TxtDisplay.Text = String.Empty
            Else
                calctotals()

            End If
            func1 = "mult"
            deci = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TxtDisplay.Text.Length <> 0 Then
            If func1 = String.Empty Then
                value1 = CType(TxtDisplay.Text, Double)
                TxtDisplay.Text = String.Empty
            Else
                calctotals()

            End If
            func1 = "divi"
            deci = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If status Then
            TxtDisplay.Text = TxtDisplay.Text & Button1.Text
        Else
            TxtDisplay.Text = TxtDisplay.Text
            status = True
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TxtDisplay.Text = TxtDisplay.Text & Button6.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TxtDisplay.Text = TxtDisplay.Text & Button7.Text
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TxtDisplay.Text = TxtDisplay.Text & Button8.Text
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TxtDisplay.Text = TxtDisplay.Text & Button9.Text
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TxtDisplay.Text = TxtDisplay.Text & Button10.Text
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TxtDisplay.Text = TxtDisplay.Text & Button11.Text
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TxtDisplay.Text = TxtDisplay.Text & Button12.Text
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TxtDisplay.Text = TxtDisplay.Text & Button13.Text
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
       
        TxtDisplay.Text = TxtDisplay.Text & Button14.Text
        
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TxtDisplay.Text = String.Empty
        deci = False
        func1 = String.Empty
        value1 = 0
        value2 = 0

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If TxtDisplay.Text = "" Then
            TxtDisplay.Text = "0"
        ElseIf TxtDisplay.Text <> 0 AndAlso value1 <> 0 Then
            calctotals()
            func1 = String.Empty
            deci = False

        End If

    End Sub
    Private Sub calctotals()
        value2 = CType(TxtDisplay.Text, Double)

        Select Case func1
            Case "add"
                value1 = value1 + value2
            Case "sub"
                value1 = value1 - value2

            Case "mult"
                value1 = value1 * value2
            Case "divi"
                value1 = value1 / value2
        End Select
        TextBox3.Text = CType(value1, String)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TxtDisplay.Text = TxtDisplay.Text & Button17.Text
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class


