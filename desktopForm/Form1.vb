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

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim temperature As Integer = txtCase.Text
        Select Case temperature
            Case Is = 0
                MsgBox("Freezing")
            Case Is < 0
                MsgBox("Sub Zero")
            Case Else
                MsgBox("Ok")
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim count As Integer
        For count = 1 To 10 Step 5
            Beep()
            Threading.Thread.Sleep(3000)
            'MsgBox("Goes " & count)
        Next
        MsgBox("Down")
        For count = 12 To 2 Step -5
            Beep()
            Threading.Thread.Sleep(3000)
            'MsgBox("Goes " & count)
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim count As Integer
        Do While count <= 3
            MsgBox("hi " & count)
            count += 1
        Loop
        MsgBox("Next")
        Do
            count += 1
            MsgBox("Hii " & count)

        Loop Until count = 6
        MsgBox("Next")
        Do Until count = 8
            count += 1
            MsgBox("Hii " & count)

        Loop
        MsgBox("Next")
        Do
            count += 1
            MsgBox("Hiiii " & count)

        Loop While count = 10
        MsgBox("Done")

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim name As String
        Do While name <> "karen"
            name = InputBox("Ingrese la clave")
        Loop
        MsgBox("Bienvenida " & name)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim fruits(4) As String
        fruits(0) = "Apple"
        fruits(1) = "Banana"
        fruits(2) = "Pineapple"
        fruits(3) = "Mango"
        fruits(4) = "Strawberry"
        MsgBox("Cantidad de frutas:  " & fruits.Length)
        Dim i As Integer
        For i = 0 To 4
            MsgBox(fruits(i))
        Next

    End Sub
End Class
