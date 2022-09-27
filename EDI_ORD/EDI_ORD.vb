Imports System.Text
<Serializable> Public Class EDI_ORD
    Public BGM As BGM
    Public RFF As Rff
    Public RFC As Rfc
    Public NAS As Nas
    Public CTA As Cta
    Public NAB As Nab
    Public NAD As Nad
    Public NAI As Nai
    Public NAC As Nac
    Public NAM As Nam
    Public DTM As Dtm
    Public FTX As Ftx
    Public PAT As Pat
    Public TOD As TOD
    Public LIN_LIST As New List(Of LIN)
    Public MEA As Mea
    Public PAC As Pac
    Public MEI As Mei
    Public DTR As Dtr
    Public ALD As Ald
    Public FTL As Ftl
    Public LOC As Loc
    Public DTL As Dtl
    Public CNT As Cnt


    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        If (Not IsNothing(BGM)) Then
            builder.Append(BGM.ToString() & vbCrLf)
        End If


        If Not IsNothing(RFF) Then
            builder.Append(RFF.ToString() & vbCrLf)

        End If
        If Not IsNothing(RFC) Then
            builder.Append(RFC.ToString() & vbCrLf)
        End If

        If (Not IsNothing(NAS)) Then
            builder.Append(NAS.ToString() & vbCrLf)
        End If
        If Not IsNothing(Me.CTA) Then
            builder.Append(CTA.ToString() & vbCrLf)

        End If
        If Not IsNothing(NAB) Then
            builder.Append(NAB.ToString() & vbCrLf)

        End If
        If Not IsNothing(NAD) Then
            builder.Append(NAD.ToString() & vbCrLf)
        End If


        If Not IsNothing(NAI) Then
            builder.Append(NAI.ToString() & vbCrLf)
        End If
        If Not IsNothing(NAC) Then
            builder.Append(NAC.ToString() & vbCrLf)
        End If
        If Not IsNothing(NAM) Then
            builder.Append(NAM.ToString() & vbCrLf)
        End If
        If Not IsNothing(DTM) Then
            builder.Append(DTM.ToString() & vbCrLf)
        End If
        If Not IsNothing(FTX) Then
            If FTX.NOTE.Trim() <> "" Then
                builder.Append(FTX.ToString() & vbCrLf)
            End If
        End If
        If Not IsNothing(PAT) Then
            builder.Append(PAT.ToString() & vbCrLf)
        End If
        If Not IsNothing(TOD) Then
            builder.Append(TOD.ToString() & vbCrLf)
        End If

        For Each l As LIN In LIN_LIST
            If (Not IsNothing(l)) Then
                builder.Append(l.ToString() & vbCrLf)
            End If
        Next

        If Not IsNothing(PAC) Then
            builder.Append(PAC.ToString() & vbCrLf)
        End If

        If Not IsNothing(MEI) Then
            builder.Append(MEI.ToString() & vbCrLf)
        End If
        If Not IsNothing(DTR) Then
            builder.Append(DTR.ToString() & vbCrLf)
        End If
        If Not IsNothing(ALD) Then
            builder.Append(ALD.ToString() & vbCrLf)
        End If
        If Not IsNothing(LOC) Then
            builder.Append(LOC.ToString() & vbCrLf)
        End If
        If Not IsNothing(DTL) Then
            builder.Append(DTL.ToString() & vbCrLf)
        End If
        If Not IsNothing(CNT) Then
            builder.Append(CNT.ToString() & vbCrLf)
        End If
        Return builder.ToString()
    End Function
End Class

<Serializable> Public Class BGM
    Public TIPOREC As String = "BGM"
    Public ID_EDI_MITT1 As String = "".PadLeft(35)
    Public ID_EDI_MITT2 As String = "".PadLeft(4)
    Public ID_EDI_MITT3 As String = "".PadLeft(14)
    Public ID_EDI_DEST1 As String = "".PadLeft(35)
    Public ID_EDI_DEST2 As String = "".PadLeft(4)
    Public ID_EDI_DEST3 As String = "".PadLeft(14)
    Public TIPODOC As String = "".PadLeft(6)
    Public NUMDOC1 As String = ""
    Public NUMDOC2 As String = ""
    Public DATADOC As String = "".PadLeft(8)
    Public FORDPROM As String = "".PadLeft(4)
    Public NUMORDF As String = "".PadLeft(14)
    Public DATAORDF As String = ""
    Public ORAORDF As String = "" ''"".PadLeft(4)
    Public NUMORDC As String = "".PadLeft(14)
    Public DATAORDC As String = ""
    Public ORADOC As String = ""
    Public NUMPROFDF As String = ""
    Public NUMPORDC As String = ""
    Public CODAZION As String = "".PadLeft(3)
    Public FLAGIMPE As String = "".PadLeft(3)
    Public TIPOORD As String = "".PadLeft(3)
    Public Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        builder.Append(Me.TIPOREC)
        builder.Append(Me.ID_EDI_MITT1)
        builder.Append(Me.ID_EDI_MITT2)
        builder.Append(Me.ID_EDI_MITT3)
        builder.Append(ID_EDI_DEST1)
        builder.Append(ID_EDI_DEST2)
        builder.Append(ID_EDI_DEST3)
        builder.Append(TIPODOC)
        builder.Append(NUMDOC1)
        builder.Append(DATADOC)
        builder.Append(ORADOC)
        builder.Append(CODAZION)
        builder.Append(FLAGIMPE)
        builder.Append(TIPOORD)
        builder.Append(NUMDOC2)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class RFF
    Public TIPOREC As String = "RFF"
    Public FORDPROM As String = "".PadLeft(3)
    Public NUMORDF As String = "".PadLeft(35)
    Public DATAORDF As String = ""
    Public ORAORDF As String = ""
    Public NUMORDC As String = "".PadLeft(35)
    Public DATAORDC As String = ""
    Public ORAORDC As String = ""
    Public NUMPORDF As String = "".PadLeft(35)
    Public NUMPORDC As String = "".PadLeft(35)

    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(FORDPROM).Append(NUMORDF).Append(DATAORDF).Append(ORAORDF).Append(NUMORDC).Append(DATAORDC).Append(ORAORDC).Append(NUMPORDF).Append(NUMPORDC)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class RFC
    Public TIPOREC As String = "RFC"
    Public NUMCO As String = "".PadLeft(35)
    Public DATAINCO As String = ""
    Public DATAFICO As String = ""
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(NUMCO).Append(DATAINCO).Append(DATAFICO)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class NAS
    Public TIPOREC As String = "NAS"
    Public CODFORN As String = "".PadLeft(17)
    Public QCODFORN As String = "".PadLeft(3)
    Public RAGSOCF As String = "".PadLeft(70)
    Public INDIRF As String = "".PadLeft(70)
    Public CITTAF As String = "".PadLeft(35)
    Public PROVF As String = "".PadLeft(9)
    Public CAPF As String = "".PadLeft(9)
    Public NAZIOF As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(CODFORN).Append(QCODFORN).Append(RAGSOCF).Append(INDIRF).Append(CITTAF).Append(PROVF).Append(CAPF).Append(NAZIOF)
        Return builder.ToString()
    End Function
End Class

<Serializable> Public Class CTA
    Public TIPOREC As String = "CTA"
    Public FUNZCONT As String = "".PadLeft(3)
    Public TELEFONO As String = "".PadLeft(25)
    Public FAX As String = "".PadLeft(25)
    Public TELEX As String = "".PadLeft(25)
    Public EMAIL As String = "".PadLeft(70)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(FUNZCONT).Append(TELEFONO).Append(FAX).Append(TELEX).Append(EMAIL)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class NAB
    Public TIPOREC As String = "NAB"

    Public CODBUYER As String = "".PadLeft(17)
    Public QCODBUY As String = "".PadLeft(3)
    Public REGSOC As String = "".PadLeft(70)
    Public INDRB As String = "".PadLeft(70)
    Public CITTAB As String = "".PadLeft(35)
    Public CAPB As String = "".PadLeft(9)
    Public PROvB As String = "".PadLeft(9)
    Public NAZIOB As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(CODBUYER).Append(QCODBUY).Append(REGSOC).Append(INDRB).Append(CITTAB).Append(PROvB).Append(CAPB).Append(NAZIOB)
        Return builder.ToString()
    End Function
End Class

<Serializable> Public Class NAD
    Public TIPOREC As String = "NAD"
    Public CODCONS As String = "".PadLeft(17)
    Public QCODCONS As String = "".PadLeft(3)
    Public RAGSOCD As String = "".PadLeft(70)
    Public INDIRD As String = "".PadLeft(70)
    Public CITTAD As String = "".PadLeft(35)
    Public PROVD As String = "".PadLeft(9)
    Public CAPD As String = "".PadLeft(9)
    Public NAZIOD As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(CODCONS).Append(QCODCONS).Append(RAGSOCD).Append(INDIRD).Append(CITTAD).Append(PROVD).Append(CAPD).Append(NAZIOD)
        Return builder.ToString()
    End Function

End Class

<Serializable> Public Class NAI
    Public TIPOREC As String = "NAI"
    Public CODFATT As String = "".PadLeft(17)
    Public QCODFATT As String = "".PadLeft(3)
    Public RAGSOCI As String = "".PadLeft(70)
    Public INDIRi As String = "".PadLeft(70)
    Public CITTAI As String = "".PadLeft(35)
    Public PROVI As String = "".PadLeft(9)
    Public CAPI As String = "".PadLeft(9)
    Public NAZOI As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(CODFATT).Append(QCODFATT).Append(RAGSOCI).Append(INDIRi).Append(CITTAI).Append(PROVI).Append(CAPI).Append(NAZOI)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class NAC
    Public TIPOREC As String = "NAC"
    Public CODMAGI As String = "".PadLeft(17)
    Public QCODMAGI As String = "".PadLeft(3)
    Public RAGSOCC As String = "".PadLeft(70)
    Public INDIRC As String = "".PadLeft(70)
    Public CITTAC As String = "".PadLeft(35)
    Public PROVC As String = "".PadLeft(9)
    Public CAPC As String = "".PadLeft(9)
    Public NAZIOC As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(CODMAGI).Append(QCODMAGI).Append(RAGSOCC).Append(INDIRC).Append(CITTAC).Append(PROVC).Append(CAPC).Append(NAZIOC)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class NAM
    Public TIPOREC As String = "NAM"
    Public CODMAGP As String = "".PadLeft(17)
    Public QCODMAGP As String = "".PadLeft(3)
    Public RAGOSCM As String = "".PadLeft(70)
    Public INDRIM As String = "".PadLeft(70)
    Public CITTAM As String = "".PadLeft(35)
    Public PROVM As String = "".PadLeft(9)
    Public CAPM As String = "".PadLeft(9)
    Public NAZIOM As String = "".PadLeft(3)
    Public Sub New()
    End Sub

    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        builder.Append(Me.TIPOREC).Append(Me.CODMAGP).Append(QCODMAGP).Append(RAGOSCM).Append(INDRIM).Append(CITTAM).Append(PROVM).Append(CAPM).Append(NAZIOM)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class DTM
    Public TIPOREC As String = "DTM"
    Public DATACONS As String = ""
    Public ORACONS As String = "".PadRight(4)
    Public TIPODATAc As String = "".PadLeft(3)
    Public DATACON2 As String = ""
    Public ORACON2 As String = ""
    Public TIPODATA2 As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(DATACONS).Append(ORACONS).Append(TIPODATAc).Append(DATACON2).Append(ORACON2).Append(TIPODATA2)

        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class FTX
    Public TIPOREC As String = "FTX"
    Public DIVISA As String = "".PadLeft(3)
    Public NOTE As String = "".PadLeft(210)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(DIVISA).Append(NOTE)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class PAT
    Public TIPOREC As String = "PAT"
    Public TIPOCOND As String = "".PadLeft(3)
    Public DATASCAD As String = ""
    Public RIFERMP As String = "".PadLeft(3)
    Public RELTERMP As String = "".PadLeft(3)
    Public UNTEMP As String = "".PadLeft(3)
    Public NUMTEMP As String = ""
    Public IMPORTO As String = "".PadLeft(32)
    Public DIVISA As String = "".PadLeft(3)
    Public PERC As String = "".PadLeft(14)
    Public DESCRIZ As String = "".PadLeft(35)
    Public BANCACOD As String = "".PadLeft(35)
    Public BANCADESC As String = "".PadLeft(35)
    Public FACTOR As String = "".PadLeft(35)
    Public COPAG As String = "".PadLeft(3)
    Public MEZZOPAG As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(TIPOCOND).Append(DATASCAD).Append(RIFERMP).Append(RELTERMP).Append(UNTEMP).Append(NUMTEMP).Append(IMPORTO).Append(DIVISA).Append(PERC).Append(DESCRIZ).Append(BANCACOD).Append(BANCADESC).Append(FACTOR).Append(COPAG).Append(MEZZOPAG)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class TOD
    Public TIPOREC As String = "TOD"
    Public CODCONS As String = "".PadLeft(3)
    Public CODCOST As String = "".PadLeft(3)
    Public CODCOND As String = "".PadLeft(3)
    Public DESCOND1 As String = "".PadLeft(70)
    Public DESCOND2 As String = "".PadLeft(70)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(CODCONS).Append(CODCOST).Append(CODCOND).Append(DESCOND1).Append(DESCOND2)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class LIN
    Public TIPOREC As String = "LIN"
    Public NUMRIGA As String = ""
    Public CODEANCU As String = "".PadLeft(35)
    Public TIPCODCU As String = "".PadLeft(3)
    Public CODEANTU As String = "".PadLeft(35)
    Public CODFORTU As String = "".PadLeft(35)
    Public CODDISTU As String = "".PadLeft(35)
    Public DESART As String = "".PadLeft(35)
    Public FLINPROM As String = "".PadLeft(3)
    Public QTAORD As String = ""
    Public UDMQORD As String = "".PadLeft(3)
    Public PRZUNI As String = ""

    Public TIPOPRZ As String = "".PadLeft(3)
    Public UDMPRZUN As String = "".PadLeft(3)
    Public NRCUINTU As String = ""
    Public QTACONF As String = ""
    Public UDMQCONF As String = "".PadLeft(3)
    Public PRZUN2 As String = ""
    Public TIPOPRZ2 As String = "".PadLeft(3)
    Public UDMPRUNZ2 As String = "".PadLeft(3)
    Public PRZBASE As String = ""
    Public CODAZIOL As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder As New StringBuilder()
        builder.Append(Me.TIPOREC).
            Append(Me.NUMRIGA).
            Append(CODEANCU).
            Append(TIPCODCU).
            Append(CODEANTU).
            Append(CODFORTU).
            Append(CODDISTU).
            Append(DESART).
            Append(FLINPROM).
            Append(QTAORD).
            Append(UDMQORD).
            Append(PRZUNI).
            Append(TIPOPRZ).
            Append(UDMPRZUN).
            Append(NRCUINTU).
            Append(CODAZIOL).
            Append(QTACONF).
            Append(UDMQCONF).
            Append(PRZUN2).
            Append(TIPOPRZ2).
            Append(UDMPRUNZ2).
            Append(PRZBASE)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class MEA
    Public TIPOREC As String = "MEA"
    Public QUALMISURA As String = "".PadLeft(3)
    Public IDDICOMMNCOD As String = "".PadLeft(3)
    Public SIGNIMISCOD As String = "".PadLeft(3)
    Public QUALUNIMIS As String = "".PadLeft(3)
    Public VALOMISURA As String = ""
    Public RANGEMIN As String = ""
    Public RANGEMAS As String = ""

    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(QUALMISURA).Append(IDDICOMMNCOD).Append(SIGNIMISCOD).Append(QUALUNIMIS).Append(VALOMISURA).Append(RANGEMIN).Append(RANGEMAS)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class PAC
    Public TIPOREC As String = "PAC"
    Public NUMRIGA As String = ""
    Public CODART As String = "".PadLeft(35)
    Public TIPCODART As String = "".PadLeft(3)
    Public UDMQUIMB As String = "".PadLeft(3)
    Public INFIBACOD As String = "".PadLeft(3)
    Public CONIMBCOD As String = "".PadLeft(3)
    Public IDETIPIMB As String = "".PadLeft(3)
    Public RESPAGIMBREST As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(NUMRIGA).Append(CODART).Append(TIPCODART).Append(INFIBACOD).Append(CONIMBCOD).Append(IDETIPIMB).Append(RESPAGIMBREST)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class MEI
    Public TIPOREC As String = "MEI"
    Public QUALMISURA As String = "".PadLeft(3)
    Public IDDIEMENCOD As String = "".PadLeft(3)
    Public SIGNIMISCOD As String = "".PadLeft(3)
    Public QUALUNIMIS As String = "".PadLeft(3)
    Public VALOMIMISURA As String = ""
    Public RANGEMIN As String = ""
    Public RANGEMAS As String = ""
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(QUALMISURA).Append(IDDIEMENCOD).Append(SIGNIMISCOD).Append(QUALUNIMIS).Append(VALOMIMISURA).Append(RANGEMIN).Append(RANGEMAS)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class DTR
    Public TIPOREC As String = "DTR"
    Public DATRCONS As String = ""
    Public ORARCONS As String = ""
    Public TIPODATRC As String = "".PadLeft(3)
    Public DATRCON2 As String = ""
    Public ORARCON2 As String = ""
    Public TIPODATTR2 As String = "".PadLeft(3)
    Public QTACONS As String = ""
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(DATRCONS).Append(ORARCONS).Append(TIPODATRC).Append(DATRCON2).Append(ORARCON2).Append(TIPODATTR2).Append(QTACONS)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class ALD
    Public TIPOREC As String = "ALD"
    Public INSCADD As String = "".PadLeft(3)
    Public DESCR As String = "".PadLeft(35)
    Public INDSEQ As String = ""
    Public TIPOSCADD As String = "".PadLeft(6)
    Public IMPORTO As String = ""
    Public PERC As String = ""
    Public FLGPRZUN As String = "".PadLeft(3)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(INSCADD).Append(DESCR).Append(INDSEQ).Append(TIPOSCADD).Append(IMPORTO).Append(PERC).Append(FLGPRZUN)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class FTL
    Public TIPOREC As String = "FTL"
    Public NOTE As String = "".PadLeft(140)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(NOTE)
        Return builder.ToString()
    End Function
End Class

<Serializable> Public Class LOC
    Public TIPOREC As String = "LOC"
    Public CODCONS As String = "".PadLeft(17)
    Public QCODCONS As String = "".PadLeft(3)
    Public RAGSOCD As String = "".PadLeft(70)
    Public INDIRD As String = "".PadLeft(70)
    Public CITTAD As String = "".PadLeft(35)
    Public PROVD As String = "".PadLeft(9)
    Public CAPD As String = "".PadLeft(9)
    Public NAZIOD As String = ""
    Public QTASPLIt As String = ""
    Public UDMQORD As String = ""
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(CODCONS).Append(QCODCONS).Append(RAGSOCD).Append(INDIRD).Append(CITTAD).Append(PROVD).Append(CAPD).Append(NAZIOD).Append(QTASPLIt).Append(UDMQORD)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class DTL
    Public TIPOREC As String = "DTL"
    Public DATRCONS As String
    Public ORARCONS As String
    Public TIPODATARC As String
    Public DATRCON2 As String
    Public ORARCON2 As String
    Public TIPODATATR2 As String
    Public QTACONS As String
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(DATRCONS).Append(ORARCONS).Append(TIPODATARC).Append(DATRCON2).Append(ORARCON2).Append(TIPODATATR2).Append(QTACONS)
        Return builder.ToString()
    End Function
End Class
<Serializable> Public Class CNT
    Public TIPOREC As String = "CNT"
    Public QTAORDT As String = "".PadRight(15)
    Public UDMQORDT As String = "".PadLeft(3)
    Public NUMLIT As String = "".PadLeft(15)
    Public Overrides Function ToString() As String
        Dim builder = New StringBuilder()
        builder.Append(TIPOREC).Append(QTAORDT).Append(UDMQORDT).Append(NUMLIT)
        Return builder.ToString()
    End Function
End Class