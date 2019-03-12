Module Module1
    Private gajba As Double = 0
    Private cena As Double = 0
    Private nenzarada1 As Double = 0
    Private andzarada1 As Double = 0
    Private ukupno2 As Double = 0
    Public nevzarada As Double = 0

    Sub gajbica(ByVal gajbe As Double, ByVal kilogrami As Double)
        If kilogrami > 0 Then
            gajba = gajbe / kilogrami
        End If
    End Sub
    Sub cenica(ByVal cena1 As Double)
        cena = cena1
    End Sub
    Sub andzarada(ByVal andbrgajbi As Double)
        If andbrgajbi > 0 Then
            andzarada1 = andbrgajbi * cena * gajba
        End If

    End Sub

    Sub nenzarda(ByVal nenbrgajbi As Double)
        If nenbrgajbi > 0 Then
            nenzarada1 = nenbrgajbi * cena * gajba
        End If

    End Sub
    Sub ukupno(ByVal ukupno1 As Double, ByVal nevpare As Double)
        If (ukupno1 And nevpare) > 0 Then
            ukupno2 = (ukupno1 - andzarada1 - nenzarada1 - nevpare) / 2
        End If
    End Sub
    Function andjelka() As Double
        If andzarada1 > 0 Then
            Return Format(andzarada1 + ukupno2, "0.0")
        Else
            MsgBox("Popuni polja")
            Return 0
        End If

    End Function
    Function nenad() As Double
        If nenzarada1 > 0 Then
            Return Format(nenzarada1 + ukupno2, "0.0")
        Else
            Return 0
        End If
    End Function






  
End Module
