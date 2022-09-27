Imports System.Text

Public Class Parser

    Public Shared Function ParseTG904(Data As String) As Tg904
        Dim lines As String() = Data.Split(vbLf)
        Dim Tg904 As New Tg904()
        For i As Integer = 0 To lines.Count - 1
            If (lines(i).StartsWith("TES")) Then
                Dim tes As New Tes(lines(i))
                Tg904.Tes = tes
            End If
            If (lines(i).StartsWith("TES")) Then
                Dim tes As New Tes(lines(i))
                Tg904.Tes = tes
            End If
            If (lines(i).StartsWith("FOR")) Then
                Dim forn As New Forn(lines(i))
                Tg904.forn = forn
            End If
            If (lines(i).StartsWith("RUB")) Then
                Dim rub As New Rub(lines(i))
                Tg904.rub = rub
            End If
            If (lines(i).StartsWith("PRO")) Then
                Dim bloccoDet As New BloccoDet()
                Dim pro As New Pro(lines(i))
                bloccoDet.pro = pro
                Dim det As New Dett(lines(i + 1))
                bloccoDet.det = det
                For j As Integer = 1 To 6
                    Dim co As New CO(lines(i + 1 + j), j)
                    bloccoDet.coList.Add(co)
                Next
                Tg904.DET_LIST.Add(bloccoDet)
            End If
            If (lines(i).StartsWith("PPI")) Then

                Dim ppi_ppt As New PPI_PPT(lines(i))
                Tg904.ppi = ppi_ppt
            End If
            If (lines(i).StartsWith("PPT")) Then
                Dim ppi_ppt As New PPI_PPT(lines(i))
                Tg904.ppt = ppi_ppt
            End If
            If (lines(i).StartsWith("XNA")) Then
                Tg904.xna = New Xna_Xft(lines(i))
            End If
            If (lines(i).StartsWith("XFT")) Then
                Tg904.xft = New Xna_Xft(lines(i))
            End If
            If (lines(i).StartsWith("MIT")) Then
                Dim mit As New Mit(lines(i))
                Tg904.mit = mit
            End If
            If (lines(i).StartsWith("END")) Then
            End If
        Next
        Return Tg904
    End Function
    Public Shared Function MapToOrdineEdi(tg904 As Tg904) As EDI_ORD
        Dim strB = New StringBuilder()
        Dim bgm As New Bgm()
        Dim nai As New Nai()
        Dim nas As New Nas()
        Dim nab As New Nab()
        Dim nad As New Nad()
        Dim dtm As New Dtm()
        Dim lin As New Lin()
        Dim result As New EDI_ORD()
        Dim ftl As New Ftl()
        Dim cnt As New Cnt()
        Dim ftx As New Ftx()
        'Oggetto Nab manca il campo RAGSOCB'
        'Oggetto Lin Manca il campo CODEANCU , COFORTU, DESART, QTAORD, PRZUNI, TIPOPRZ, '
        bgm.DATADOC = tg904.Tes.DTORD
        bgm.TIPODOC = "ORDERS"
        ''bgm.
        bgm.NUMDOC1 = tg904.Tes.ORD.PadRight(35)
        bgm.numdoc2 = tg904.Tes.ORD.PadRight(35)
        bgm.ID_EDI_MITT1 = tg904.Tes.EDI_MITT1.PadRight(35)
        bgm.ID_EDI_MITT2 = tg904.Tes.EDI_MITT2.PadRight(4)
        bgm.ID_EDI_DEST1 = tg904.Tes.EDI_DEST1.PadRight(35)
        bgm.ID_EDI_DEST2 = tg904.Tes.EDI_DEST2.Substring(0, 2).PadRight(4)
        nas.RAGSOCF = tg904.forn.RAGSOC_For.PadRight(70)
        nas.INDIRF = tg904.forn.IND_FOR.PadRight(70)
        nas.CITTAF = tg904.forn.LOC_FOR.PadRight(35)
        nas.PROVF = tg904.forn.PROV_FOR.PadRight(9)
        nas.CAPF = tg904.forn.CAP_FOR.PadRight(9)
        nas.CODFORN = tg904.forn.PARTIVA_FOR.PadRight(17)
        nas.QCODFORN = "VA".PadRight(3)
        nab.CODBUYER = tg904.mit.PARTIVA_CLI.PadRight(17)
        nab.QCODBUY = "VA".PadRight(3)
        nab.REGSOC = tg904.mit.RAGSOC_CLI.PadRight(70)
        nab.INDRB = tg904.mit.IND_CLI.PadRight(70)
        nab.CITTAB = tg904.mit.LOC_CLI.PadRight(35)
        nab.PROvB = tg904.mit.PROV_CLI.PadRight(9)
        nab.CAPB = tg904.mit.CAP_CLI.PadRight(9)
        nad.RAGSOCD = tg904.mit.RAGSOC_CLI.PadRight(70)
        nai.CODFATT = tg904.mit.PARTIVA_CLI.PadRight(17)
        nai.CITTAI = tg904.mit.LOC_CLI.PadRight(35)
        nai.PROVI = tg904.mit.PROV_CLI.PadRight(9)
        nai.CAPI = tg904.mit.CAP_CLI.PadRight(9)
        dtm.DATACONS = tg904.Tes.DTPC.PadRight(8)
        dtm.TIPODATAc = "002"
        nai.QCODFATT = "VA".PadRight(3)
        nai.INDIRi = tg904.mit.IND_CLI.PadRight(70)
        nai.CITTAI = tg904.mit.LOC_MAG.PadRight(35)
        nai.RAGSOCI = tg904.mit.RAGSOC_CLI.PadRight(70)
        nad.CODCONS = tg904.mit.PARTIVA_CLI.PadRight(17)
        nad.QCODCONS = "VA".PadRight(3)
        nad.INDIRD = tg904.mit.IND_MAG.PadRight(70)
        nad.CITTAD = tg904.mit.LOC_MAG.PadRight(35)
        Dim counter = 0

        For i As Integer = 0 To tg904.DET_LIST.Count - 1
            Dim curPro = tg904.DET_LIST(i).pro
            lin = New LIN()
            lin.UDMQORD = "TU".PadRight(3)
            lin.NUMRIGA = Convert.ToString(counter + 1).PadLeft(6, "0")
            lin.DESART = curPro.DES_PRO.PadRight(35)
            lin.CODEANCU = curPro.BCODE.PadRight(35)
            If (curPro.BCODE <> "") Then
                lin.TIPCODCU = "EN".PadRight(3)
            End If

            Dim curDet = tg904.DET_LIST(i).det
            lin.QTAORD = (curDet.CART_ORD_D.Replace("+", "").Replace("-", "") & "0").PadLeft(15, "0")
            Dim coList = tg904.DET_LIST(i).coList
            For j As Integer = 0 To tg904.DET_LIST(i).coList.Count - 1
                Dim curCos = coList(j)
                If (curCos.TRK = "CO1") Then
                    lin.PRZUNI = (curCos.COS.Replace("+", "").Replace("-", "").Substring(0, 9)).PadLeft(15, "0")
                End If
            Next

            lin.TIPOPRZ = "AAA"
            If curPro.UM = "KG" Then
                lin.UDMPRZUN = "KGM"
            End If

            If curPro.UM = "LT" Then
                lin.UDMPRZUN = "LTR"
            End If

            If curPro.UM = "PZ" Then
                lin.UDMPRZUN = "PCE"
            End If

            lin.NRCUINTU = (curPro.QTA_FORN.Replace("+", "").Replace("-", "") & "0").PadLeft(15, "0")
            For j As Integer = 1 To lin.NUMRIGA
            Next
            ftx.NOTE = tg904.TES.NOTE_ORD_T.PadRight(210)
            lin.CODDISTU = curPro.CODPRO.TrimStart("0").PadRight(35)
            lin.CODFORTU = curPro.CODF.PadRight(35)
            result.LIN_LIST.Add(lin)
            counter += 1
        Next
        cnt.NUMLIT = (Convert.ToString(counter) & "000").PadLeft(15, "0")
        result.cnt = cnt
        result.bgm = bgm
        result.nab = nab
        result.nad = nad
        result.nai = nai
        result.nas = nas
        result.dtm = dtm
        result.ftx = ftx
        result.ftl = ftl
        Return result
    End Function

End Class
