Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        MsgBox("Hola!")
        MsgBox("Hola!!!")
        MessageBox.Show("other way")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("Welcome")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Variables
        Dim name As String = "Karen"
        Dim lastName As String = "Rodriguez"
        MsgBox("My name is: " + name & " " & lastName & " nice to meet you")
        name = "Gueila"
        MsgBox("My name is: " + name & " " & lastName & " nice to meet you")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Tipo de Datos
        Dim age As Integer = 30
        Dim isSingle As Boolean = True
        Dim price As Decimal = 20.45
        Dim today As Date = #01/12/2023#
        MsgBox("Some Data " & vbNewLine & "Age: " & age & vbNewLine & "Single:" & isSingle & vbNewLine & "Price: " & price & vbNewLine & "Date: " & today)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim name As String
        name = InputBox("Enter your name:")
        MsgBox("Your name is: " & name)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ok.Click
        Dim firstName As String
        Dim lastName As String
        firstName = txtFirstName.Text
        lastName = txtLastName.Text
        MsgBox("Data: " & firstName & " " & lastName)

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim val1 As Double = 5
        Dim val2 As Double = 3
        Dim result As Double
        result = val1 + val2
        MsgBox("Suma: " & result & vbNewLine &
            "Resta: " & val1 - val2 & vbNewLine &
            "Multiplicacion: " & val1 * val2 & vbNewLine &
            "Division: " & val1 / val2 & vbNewLine &
            "Potencia: " & val1 ^ val2 & vbNewLine &
            "Divicion entera: " & val1 \ val2 & vbNewLine &
            "Modulo o resto: " & val1 Mod val2)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'prioridad  con parentesis
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'If stttements
        Dim age As Integer = 12
        If age >= 18 Then
            MsgBox("Eres mayor de edad")
        Else
            MsgBox("Eres menor de edad")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim score As Integer
        If IsNumeric(txtConvert.Text) Then
            score = CInt(txtConvert.Text)
        Else
            MsgBox("Inserte un numero")
            Return
        End If
        If score > 51 And score <= 100 Then
            MsgBox("Approved!")
        Else
            MsgBox("Failed")
        End If
    End Sub
End Class
