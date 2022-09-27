Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization

Module Module1

    Sub Main()
        Dim Tg904 As EDI_ORD.TG904 = EDI_ORD.Parser.ParseTG904(IO.File.ReadAllText("c:\rumenta\o_ed\orig.txt"))
        Dim Ord As EDI_ORD.EDI_ORD = EDI_ORD.Parser.MapToOrdineEdi(Tg904)

        Dim EDI_ORD_Serializer As New Xml.Serialization.XmlSerializer(Ord.GetType())
        Using MS As New IO.MemoryStream
            EDI_ORD_Serializer.Serialize(MS, Ord)
            IO.File.WriteAllText("c:\rumenta\o_ed\o.xml", System.Text.Encoding.Default.GetString(MS.ToArray()))
        End Using

        Dim TG904Serializer As New Xml.Serialization.XmlSerializer(Tg904.GetType())
        Using MS As New IO.MemoryStream
            TG904Serializer.Serialize(MS, Tg904)
            IO.File.WriteAllText("c:\rumenta\o_ed\TG904.xml", System.Text.Encoding.Default.GetString(MS.ToArray()))
        End Using
        testXML()
    End Sub

    Private Sub testXML()
        Dim fileName1 = "C:\rumenta\o_ed\o.xml"
        '' Dim newFileName = "C:\rumenta\prova.xml"
        Dim fileName2 = "C:\rumenta\o_ed\TG904.xml"
        Dim Xelement1 = XElement.Load(fileName1)
        Dim Xelement2 = XElement.Load(fileName2)
        '' Console.WriteLine(CHECK_ID_EDI_MITT_417_1)
        Dim element2 = Xelement2.Element("TES").Element("EDI_DEST2")
        Dim element1 = Xelement2.Element("TES").Element("EDI_MITT1")
        Dim element4 = Xelement2.Element("TES").Element("EDI_MITT2")
        Dim dest1Element = Xelement1.Element("BGM").Element("ID_EDI_DEST1")

        Console.WriteLine(dest1Element)

        Dim CHECK_ID_EDI_MITT_417_1 = element2.Value.Trim()(2)
        Dim CHECK_NAD_CODCONS_418_1 = element2.Value.Trim()(3)
        Console.WriteLine("VALORE 1 " + CHECK_NAD_CODCONS_418_1)

        Console.WriteLine(element2.Value)
        Console.WriteLine("VALORE 2 " + CHECK_ID_EDI_MITT_417_1)


        Select Case CHECK_ID_EDI_MITT_417_1
            Case "N"
                element1.Value = "02236970048N"
            Case "T"
                element1.Value = "02236970048T"
            Case "X"
                element1.Value = "02236970048X"
        End Select

        Dim mitElementCodf = Xelement2.Element("MIT").Element("CODFG070")
        Dim nadCodConsElem = Xelement1.Element("NAD").Element("CODCONS")
        Console.WriteLine(nadCodConsElem)
        'Console.WriteLine(mitElement)

        If CHECK_NAD_CODCONS_418_1 = "M" And dest1Element.Value <> "02754690242" Then

            nadCodConsElem.Value = mitElementCodf.Value


        End If
        Dim nadQConsElem = Xelement1.Element("NAD").Element("QCODCONS")
        Console.WriteLine(nadQConsElem)
        '' Console.WriteLine(Xelement1.Element("NAD"))
        If CHECK_NAD_CODCONS_418_1 = "M" Then
            nadQConsElem.Value = "92"



        End If
        Dim newElement = Xelement2.Element("MIT")
        Console.WriteLine(newElement.Value)

        Xelement1.Save(fileName1)
        Console.WriteLine("FILE  SALVAto")

    End Sub

End Module
