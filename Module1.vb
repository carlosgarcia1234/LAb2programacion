Module Module1

    Sub Main1(args As String())
        Dim costo As Double
        Dim pago As Double

        'sub main1
        'sub main2
        Console.WriteLine("Ingrese el costo del artículo vendido:")
        costo = CDbl(Console.ReadLine())

        Console.WriteLine("Ingrese la cantidad de dinero entregada por el cliente:")
        pago = CDbl(Console.ReadLine())

        If pago > costo Then
            Dim cambio As Double = pago - costo
            Console.WriteLine("El cambio a entregar al cliente es: " & cambio)
        ElseIf pago = costo Then
            Console.WriteLine("Se realiza la entrega del producto.")
        Else
            Dim falta As Double = costo - pago
            Console.WriteLine("Falta pagar: " & falta)
            Console.WriteLine("la mentable mente El cliente no tiene suficiente dinero. Vuelva pronto por el producto que desea y trabaje mas para que le alcanse.")
        End If

        Console.ReadLine()


    End Sub


    Sub Main2(args As String())
        Dim total As Double = 0

        Console.WriteLine("Ingrese los montos de las compras (ingrese 0 para finalizar):")

        While True
            Console.Write("Monto de la compra (o 0 para finalizar): ")
            Dim input As String = Console.ReadLine()
            Dim monto As Double

            If Double.TryParse(input, monto) Then
                If monto = 0 Then
                    Exit While
                ElseIf monto < 0 Then
                    Console.WriteLine("No se permite un monto negativo.")
                Else
                    If monto > 1000 Then
                        monto *= 0.9 ' Aplicar 10% de descuento
                    ElseIf monto > 500 Then
                        monto *= 0.95 ' Aplicar 5% de descuento
                    End If

                    total += monto
                End If
            Else
                Console.WriteLine("Monto no válido. Ingrese un número válido.")
            End If
        End While

        Console.WriteLine($"El total a pagar con descuentos es: ${total}")
    End Sub

End Module
