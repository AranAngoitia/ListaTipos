Imports System

Module Program
    Sub Main(args As String())
        Dim a As SByte = 0
        Dim b As Byte = 0
        Dim c As Int16 = 0
        Dim d As Int32 = 0
        Dim e As Int64 = 0
        Dim s As String = ""
        Dim ex As Exception = New Exception

        Dim objetoTipos As Object() = {a, b, c, d, e, s, ex}

        For Each o As Object In objetoTipos
            Dim type As String
            If o.GetType.IsValueType Then
                type = "Tipo por valor"
            Else
                type = "Tipo por referencia"
            End If

            Console.WriteLine("Tipo {0}: {1}", o.GetType, type)
        Next
    End Sub
End Module
