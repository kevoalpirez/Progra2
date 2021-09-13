Module Module1

    'limpiar vectores falta en la tarea 
    Public subtotal_a_pagar(8)
    Public descuento(8)
    Public descuentodos(8)
    Public total_a_pagar(8)
    Public indice = 0
    Public vfuncion(8)
    Public vcine(8)
    Public vcantidad





    'variable para retornar calculo
    Public calculo_subtotal As Double = 0
    Public calculo_desc1 As Double = 0
    Public calculo_desc2 As Double = 0
    Public limpiar_form As Double = 0

    Function calcularsubtotal(funcion As String, cine As String) As Double

        Select Case cine
            Case "A"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 30

                    Case "2"
                        calculo_subtotal = 35

                    Case Else
                        calculo_subtotal = 40

                End Select

            Case "B"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 24

                    Case "2"
                        calculo_subtotal = 34

                    Case Else
                        calculo_subtotal = 44

                End Select

            Case "C"
                Select Case funcion
                    Case "1"
                        calculo_subtotal = 35

                    Case "2"
                        calculo_subtotal = 40

                    Case Else
                        calculo_subtotal = 50

                End Select


        End Select


        Return calculo_subtotal
    End Function
    Function calculodescuento1(funcion As String, cine As String) As Double

        If (funcion = "3" Or funcion = "4") And (cine = "C" Or cine = "B") Then
            calculodescuento1 = 0.055

        ElseIf (funcion = "1") And (cine = "C" Or cine = "B") Then
            calculodescuento1 = 0.03

        ElseIf (funcion = "2") And (cine = "A") Then
            calculodescuento1 = 0.015

        End If
        Return calculodescuento1

    End Function

    Function calculodescuento2(cantidad As String) As Double

        If (cantidad > "100") And (cantidad < "300") Then
            calculodescuento2 = 0.02

        ElseIf (cantidad >= "300") And (cantidad < "500") Then
            calculodescuento2 = 0.04

        ElseIf (cantidad >= "500") And (cantidad <= "1000") Then
            calculodescuento2 = 0.06

        End If
        Return calculodescuento2
    End Function


    Sub limpiarFormulario(controles As Control.ControlCollection)

        For Each control As Control In controles

            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is ListBox Then
                DirectCast(control, ListBox).Items.Clear()
            ElseIf TypeOf control Is ComboBox Then
                DirectCast(control, ComboBox).SelectedIndex = 0

            End If

        Next

    End Sub

End Module
