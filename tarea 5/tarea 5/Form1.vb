Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click






        If indice < 9 Then

            vfuncion(indice) = ComboBox2.SelectedItem
            vcine(indice) = ComboBox2.SelectedItem
            subtotal_a_pagar(indice) = calcularsubtotal(vfuncion(indice), vcine(indice))
            descuento(indice) = subtotal_a_pagar(indice) * calculodescuento1(vfuncion(indice), vcine(indice))
            vcantidad(indice) = subtotal_a_pagar(indice)
            descuentodos(indice) = calculodescuento2(vcantidad(indice)) * vcantidad(indice)
            total_a_pagar(indice) = vcantidad(indice) - descuento(indice) - descuentodos(indice)





            funcion.Items.Add(vfuncion(indice))
            funcion.Items.Add(vcine(indice))
            funcion.Items.Add(subtotal_a_pagar(indice))
            funcion.Items.Add(descuento(indice))
            funcion.Items.Add(vcantidad(indice))
            funcion.Items.Add(descuentodos(indice))
            funcion.Items.Add(total_a_pagar(indice))





        ElseIf indice >= 9 Then

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiarFormulario(Me.Controls)
    End Sub


End Class

