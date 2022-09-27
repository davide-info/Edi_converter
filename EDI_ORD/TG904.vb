
<Serializable> Public Class TG904
    Public TES As Tes
    Public FORN As Forn
    Public RUB As Rub
    Public PDV As Pdv
    Public TSP As Tsp
    Public MIT As Mit
    Public DET_LIST As New List(Of BloccoDet)
    Public ENDTR As EndTr
    Public PPI As PPI_PPT
    Public XNA As Xna_Xft
    Public PPT As PPI_PPT
    Public XFT As Xna_Xft
    Public Overrides Function Tostring() As String
        Dim str = ""
        If Not IsNothing(TES) Then
            str = TES.ToString()
        End If
        Return str
    End Function
End Class
<Serializable> Public Class DET
    Public SCHEMA As String
    Public NART_ORD_D As String
    Public NART_ORD_OM_D As String
    Public NART_CON_D As String
    Public NART_CON_OM_D As String
    Public CART_OR_D As String
    Public CART_ORD_OM_D As String
    Public CART_CON_D As String
    Public CART_CON_OM_D As String
    Public PLT_ORD_D As String
    Public PLT_CON_D As String
    Public FORM_PLT_FORN As String
    Public CART_STRATO_FOR As String
    Public NUM_STRATO_FOR As String
    Public QTA_FORN_FOR As String
    Public QTA_TERMO_FOR As String
    Public NOTE_ORD_D As String
    Public PNT_CAR As String
    Public STATO_RIG As String
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        SCHEMA = line.Substring(3, 4).Trim()
        NART_ORD_D = line.Substring(7, 10).Trim()
        NART_ORD_OM_D = line.Substring(17, 10).Trim()
        NART_CON_D = line.Substring(27, 10).Trim()
        NART_ORD_OM_D = line.Substring(37, 10).Trim()
        CART_OR_D = line.Substring(47, 10).Trim()
        CART_ORD_OM_D = line.Substring(57, 10).Trim()
        PLT_ORD_D = line.Substring(67, 10).Trim()
        PLT_CON_D = line.Substring(77, 10).Trim()
        FORM_PLT_FORN = line.Substring(87, 8).Trim()
        CART_STRATO_FOR = line.Substring(95, 8).Trim()
        QTA_FORN_FOR = line.Substring(103, 20).Trim()
        NOTE_ORD_D = line.Substring(123, 80).Trim()
        PNT_CAR = line.Substring(203, 8).Trim()
        STATO_RIG = line.Substring(211, 1).Trim()
    End Sub
End Class

<Serializable> Public Class BLOCCODET
    Public DET As New Dett()
    Public PRO As New Pro()
    Public COLIST As New List(Of CO)
End Class
<Serializable> Public Class TES
    Public TRK As String
    Public OP As String
    Public DTOPE As String
    Public TMOPE As String
    Public DTPC As String
    Public CMPT As String
    Public STATO_ORD As String
    Public COD_BUYER As String
    Public DES_BUYER As String
    Public NART_ORD_T As String
    Public NART_CON_T As String
    Public CART_ORD_OMT_T As String
    Public CART_CON_T As String
    Public CART_CON_OM_T As String
    Public PLT_ORD_T As String
    Public PLT_CON_T As String
    Public VAL_ORD_T As String
    Public NOTE_ORD_T As String
    Public SC_ORD_T As String
    Public DTCON As String
    Public DTDOC As String
    Public ORD As String
    Public DTORD As String
    Public MAG As String
    Public CODFOR As String
    Public CART_ORD_T As String
    Public CART_ORD_OM_T As String
    Public NDOC As String
    Public CAU As String
    Public CAU_DES As String
    Public TRANS As String
    Public DESOP As String
    Public EDI_MITT1 As String
    Public EDI_MITT2 As String
    Public EDI_DEST1 As String
    Public EDI_DEST2 As String
    Public FHH As String
    Public FHH_DES As String
    Public FHH_TMI_HH As String
    Public FHH_TMI_MM As String
    Public FHH_TMF_HH As String
    Public FHH_TMF_MM As String
    Public MTO_IND As String
    Public FAX_NUM As String
    Public NOME_BUYER As String
    Public CGNM_BUYER As String
    Public CELL_BUYER As String
    Public EMAIL_BUYER As String
    Public ID_CNT As String
    Public CPAG As String
    Public CPAG_DES As String
    Public NAS_CODFORN As String
    Public NAS_QCODFORN As String
    Public TEEDIUM As String
    Public TEMEA As String
    Public TEOM As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal stringTes As String)
        TRK = stringTes.Substring(0, 3).Trim()
        OP = stringTes.Substring(3, 1).Trim()
        TMOPE = stringTes.Substring(12, 8).Trim()
        ORD = stringTes.Substring(20, 10).Trim()
        DTORD = stringTes.Substring(30, 8).Trim()
        MAG = stringTes.Substring(38, 2).Trim()
        CODFOR = stringTes.Substring(40, 6).Trim()
        DTPC = stringTes.Substring(46, 8).Trim()
        CMPT = stringTes.Substring(54, 4).Trim()
        STATO_ORD = stringTes.Substring(58, 1).Trim()
        COD_BUYER = stringTes.Substring(59, 4).Trim()
        DES_BUYER = stringTes.Substring(63, 8).Trim()
        NART_ORD_T = stringTes.Substring(71, 8).Trim() 'Togliamo il segno?'
        NART_CON_T = stringTes.Substring(77, 6).Trim()
        CART_ORD_T = stringTes.Substring(83, 10).Trim()
        CART_ORD_OM_T = stringTes.Substring(93, 10).Trim()
        CART_CON_T = stringTes.Substring(103, 10).Trim()
        CART_CON_OM_T = stringTes.Substring(113, 10).Trim()
        PLT_ORD_T = stringTes.Substring(123, 8).Trim()
        PLT_CON_T = stringTes.Substring(131, 8).Trim()
        VAL_ORD_T = stringTes.Substring(139, 14).Trim()
        NOTE_ORD_T = stringTes.Substring(153, 80).Trim()
        SC_ORD_T = stringTes.Substring(233, 6).Trim()
        DTCON = stringTes.Substring(239, 8).Trim()
        DTDOC = stringTes.Substring(247, 8).Trim()
        NDOC = stringTes.Substring(255, 11).Trim()
        CAU = stringTes.Substring(266, 4).Trim()
        CAU_DES = stringTes.Substring(270, 30).Trim()
        TRANS = stringTes.Substring(300, 10).Trim()
        DESOP = stringTes.Substring(310, 30).Trim()
        EDI_MITT1 = stringTes.Substring(340, 35).Trim()
        EDI_MITT2 = stringTes.Substring(375, 4).Trim()
        EDI_DEST1 = stringTes.Substring(379, 35).Trim()
        EDI_DEST2 = stringTes.Substring(414, 4).Trim()
        FHH = stringTes.Substring(418, 4).Trim()
        FHH_DES = stringTes.Substring(422, 30).Trim()
        FHH_TMI_HH = stringTes.Substring(452, 2).Trim()
        FHH_TMI_MM = stringTes.Substring(454, 2).Trim()
        FHH_TMF_HH = stringTes.Substring(456, 2).Trim()
        FHH_TMF_MM = stringTes.Substring(458, 2).Trim()
        MTO_IND = stringTes.Substring(460, 50).Trim()
        FAX_NUM = stringTes.Substring(510, 20).Trim()
        NOME_BUYER = stringTes.Substring(530, 30).Trim()
        CGNM_BUYER = stringTes.Substring(560, 30).Trim()
        CELL_BUYER = stringTes.Substring(590, 20).Trim()
        EMAIL_BUYER = stringTes.Substring(610, 60).Trim()
        ID_CNT = stringTes.Substring(670, 20).Trim()
        CPAG = stringTes.Substring(690, 4).Trim()
        CPAG_DES = stringTes.Substring(694, 30).Trim()
        NAS_CODFORN = stringTes.Substring(724, 35).Trim()
        NAS_QCODFORN = stringTes.Substring(759, 4).Trim()
        TEEDIUM = stringTes.Substring(763, 1).Trim()
        TEMEA = stringTes.Substring(764, 1).Trim()
        TEOM = stringTes.Substring(765, 1).Trim()
    End Sub
End Class
<Serializable> Public Class Forn

    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        RAGSOC_For = line.Substring(3, 50).Trim()
        RAGSOC_E_FOR = line.Substring(53, 40).Trim()
        BANCA_FOR = line.Substring(93, 35).Trim()
        RAPP_TEL = line.Substring(128, 15).Trim()
        TELEX_FOR = line.Substring(143, 10).Trim()
        FAX_FOR = line.Substring(153, 10).Trim()
        RAPP = line.Substring(163, 35).Trim()
        RAPP_TEL = line.Substring(198, 15).Trim()
        CAPO_AREA = line.Substring(213, 35).Trim()
        CAPO_AREA_TEL = line.Substring(248, 15).Trim()
        DIR_COMM = line.Substring(263, 35).Trim()
        DIR_COMM_TEL = line.Substring(298, 15).Trim()
        COD_PAG1 = line.Substring(313, 3).Trim()
        COD_PAG2 = line.Substring(316, 3).Trim()
        COD_PAG3 = line.Substring(319, 3).Trim()
        NOTE1_FOR = line.Substring(322, 72).Trim()
        NOTE2_For = line.Substring(394, 72).Trim()
        IND_FOR = line.Substring(466, 50).Trim()
        CAP_FOR = line.Substring(516, 5).Trim()
        LOC_FOR = line.Substring(521, 50).Trim()
        PROV_FOR = line.Substring(571, 3).Trim()
        CODFISC_For = line.Substring(574, 16).Trim()
        PARTIVA_FOR = line.Substring(590, 11).Trim()
        ORA_PREF = line.Substring(601, 4).Trim()
        EMAIL1 = line.Substring(605, 50).Trim()
        EMAIL2 = line.Substring(655, 50).Trim()
        EMAIL3 = line.Substring(705, 50).Trim()
        WEB = line.Substring(755, 50).Trim()
        TELEX_FOR1 = line.Substring(805, 15).Trim()
        FAX_FOR1 = line.Substring(820, 15).Trim()
        COD_PAG = line.Substring(835, 3).Trim()
        COD_PAG_DES = line.Substring(838, 30).Trim()
        FG050_FLAG1 = line.Substring(868, 1).Trim()
        FG050_FLAG2 = line.Substring(869, 1).Trim()
        FG050_FLAG3 = line.Substring(870, 1).Trim()
        FG050_FLAG4 = line.Substring(871, 1).Trim()
        FG050_FLAG5 = line.Substring(872, 1).Trim()
        CODFORR = line.Substring(873, 6).Trim()
    End Sub
    Public TRK As String
    Public RAGSOC_For As String
    Public RAPP_TEL As String
    Public RAGSOC_E_FOR As String
    Public BANCA_FOR As String
    Public TELEFONO_FOR As String
    Public TELEX_FOR As String
    Public FAX_FOR As String
    Public RAPP As String
    Public CAPO_AREA As String
    Public CAPO_AREA_TEL As String
    Public DIR_COMM As String
    Public DIR_COMM_TEL As String
    Public COD_PAG1 As String
    Public COD_PAG2 As String
    Public COD_PAG3 As String
    Public NOTE1_FOR As String
    Public NOTE2_For As String
    Public IND_FOR As String
    Public CAP_FOR As String
    Public LOC_FOR As String
    Public PROV_FOR As String
    Public CODFISC_For As String
    Public PARTIVA_FOR As String
    Public ORA_PREF As String
    Public EMAIL1 As String
    Public EMAIL2 As String
    Public EMAIL3 As String
    Public WEB As String
    Public TELEX_FOR1 As String
    Public FAX_FOR1 As String
    Public COD_PAG As String
    Public COD_PAG_DES As String
    Public FG050_FLAG1 As String
    Public FG050_FLAG2 As String
    Public FG050_FLAG3 As String
    Public FG050_FLAG4 As String
    Public FG050_FLAG5 As String
    Public CODFORR As String
End Class
<Serializable> Public Class RUB
    Public TRK As String
    Public RUB_SERVIZIO As String
    Public RUB_IND As String
    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        RUB_SERVIZIO = line.Substring(3, 8).Trim()
        RUB_IND = line.Substring(12, 200).Trim()
    End Sub
End Class
<Serializable> Public Class PDV

    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        RAGSOC_PDV = line.Substring(3, 50).Trim()
        RAGSOC_E_PDV = line.Substring(53, 40).Trim()
        TELEFONO_PDV = line.Substring(93, 15).Trim()
        TELEX_PDV = line.Substring(108, 10).Trim()
        FAX_PDV = line.Substring(118, 10).Trim()
        IND_PDV = line.Substring(128, 50).Trim()
        CAP_PDV = line.Substring(178, 5).Trim()
        LOC_PDV = line.Substring(183, 50).Trim()
        PROV_PDV = line.Substring(233, 3).Trim()
        IND_BC_PDV = line.Substring(236, 50).Trim()
        CAP_BC_PDV = line.Substring(286, 5).Trim()
        LOC_BC_PDV = line.Substring(291, 50).Trim()
        PROV_BC_PDV = line.Substring(341, 3).Trim()
        CODFISC_PDV = line.Substring(344, 16).Trim()
        PARTIVA_PDV = line.Substring(360, 11).Trim()
        EMAIL1_PDV = line.Substring(371, 50).Trim()
        EMAIL2_PDV = line.Substring(421, 50).Trim()
        EMAIL3_PDV = line.Substring(471, 50).Trim()
        CODSEDEAMM_PDV = line.Substring(521, 6).Trim()
        CODSEDELEG_PDV = line.Substring(527, 6).Trim()
        COD_PDV = line.Substring(533, 6).Trim()
    End Sub
    Public TRK As String
    Public RAGSOC_PDV As String
    Public RAGSOC_E_PDV As String
    Public TELEFONO_PDV As String
    Public TELEX_PDV As String
    Public FAX_PDV As String
    Public IND_PDV As String
    Public CAP_PDV As String
    Public LOC_PDV As String
    Public PROV_PDV As String
    Public IND_BC_PDV As String
    Public CAP_BC_PDV As String
    Public LOC_BC_PDV As String
    Public PROV_BC_PDV As String
    Public CODFISC_PDV As String
    Public PARTIVA_PDV As String
    Public EMAIL1_PDV As String
    Public EMAIL2_PDV As String
    Public EMAIL3_PDV As String
    Public CODSEDEAMM_PDV As String
    Public CODSEDELEG_PDV As String
    Public COD_PDV As String
End Class

<Serializable> Public Class TSP

    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        CODTRASP = line.Substring(3, 6).Trim()
        CODTRASP_TE1 = line.Substring(9, 1).Trim()
        CODTRASP_TE2 = line.Substring(10, 1).Trim()
        CODTRASP_TE3 = line.Substring(11, 1).Trim()
        CODTRASP_TE4 = line.Substring(12, 1).Trim()
        CODTRASP_TE5 = line.Substring(13, 1).Trim()
        CODTRASP_RS = line.Substring(14, 50).Trim()
        CODTRASP_RSE = line.Substring(64, 40).Trim()
        CODTRASP_IND = line.Substring(104, 50).Trim()
        CODTRASP_CAP = line.Substring(154, 5).Trim()
        CODTRASP_LOC = line.Substring(159, 50).Trim()
        CODTRASP_TEL = line.Substring(209, 15).Trim()
        ODTRASP_TLX = line.Substring(224, 10).Trim()
        CODTRASP_FAX = line.Substring(234, 10).Trim()
        CODTRASP_EMAIL1 = line.Substring(244, 50).Trim()
        CODTRASP_EMAIL2 = line.Substring(294, 50).Trim()
        CODTRASP_EMAIL3 = line.Substring(344, 50).Trim()
        CODTRASP_DTPC = line.Substring(394, 8).Trim()
    End Sub
    Public TRK As String
    Public ODTRASP_TLX As String
    Public CODTRASP As String
    Public CODTRASP_TE1 As String
    Public CODTRASP_TE2 As String
    Public CODTRASP_TE3 As String
    Public CODTRASP_TE4 As String
    Public CODTRASP_TE5 As String
    Public CODTRASP_RS As String
    Public CODTRASP_RSE As String
    Public CODTRASP_IND As String
    Public CODTRASP_CAP As String
    Public CODTRASP_LOC As String
    Public CODTRASP_TEL As String
    Public CODTRASP_TLX As String
    Public CODTRASP_FAX As String
    Public CODTRASP_EMAIL1 As String
    Public CODTRASP_EMAIL2 As String
    Public CODTRASP_EMAIL3 As String
    Public CODTRASP_DTPC As String
End Class
<Serializable> Public Class MIT
    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        SIGLA = line.Substring(3, 2).Trim()
        DES_MAG = line.Substring(5, 30).Trim()
        IND_MAG = line.Substring(35, 30).Trim()
        LOC_MAG = line.Substring(65, 20).Trim()
        CODFG070 = line.Substring(85, 6).Trim()
        RAGSOC_CLI = line.Substring(91, 50).Trim()
        RAGSOC_E_CLI = line.Substring(141, 40).Trim()
        BANCA_CLI = line.Substring(181, 35).Trim()
        TELEFONO_CLI = line.Substring(216, 15).Trim()
        TELEX_CLI = line.Substring(231, 10).Trim()
        FAX_CLI = line.Substring(241, 10).Trim()
        IND_CLI = line.Substring(251, 50).Trim()
        CAP_CLI = line.Substring(301, 5).Trim()
        LOC_CLI = line.Substring(306, 50).Trim()
        PROV_CLI = line.Substring(356, 3).Trim()
        CODFISC_CLI = line.Substring(359, 16).Trim()
        PARTIVA_CLI = line.Substring(375, 11).Trim()
        TELEX_CLI1 = line.Substring(386, 15).Trim()
        FAX_CLI1 = line.Substring(401, 15).Trim()
        TEL_MAG = line.Substring(416, 15).Trim()
        TELEX_MAG = line.Substring(431, 15).Trim()
        FAX_MAG = line.Substring(446, 15).Trim()
    End Sub
    Public TRK As String
    Public SIGLA As String
    Public LOC_CLI As String
    Public DES_MAG As String
    Public IND_MAG As String
    Public LOC_MAG As String
    Public CODFG070 As String
    Public RAGSOC_CLI As String
    Public RAGSOC_E_CLI As String
    Public BANCA_CLI As String
    Public TELEFONO_CLI As String
    Public TELEX_CLI As String
    Public FAX_CLI As String
    Public IND_CLI As String
    Public CAP_CLI As String
    Public OC_CLI As String
    Public PROV_CLI As String
    Public CODFISC_CLI As String
    Public PARTIVA_CLI As String
    Public TELEX_CLI1 As String
    Public FAX_CLI1 As String
    Public TEL_MAG As String
    Public TELEX_MAG As String
    Public FAX_MAG As String
End Class

'TO DO fare pull di Tg094.vb pc nuovo'
'Arrivato a pagina 288 tg904.txt'

<Serializable> Public Class DETT
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        SCHEMA = line.Substring(3, 4).Trim()
        NART_ORD_D = line.Substring(7, 10).Trim()
        NART_ORD_OM_D = line.Substring(17, 10).Trim()
        NART_CON_D = line.Substring(27, 10).Trim()
        NART_CON_OM_D = line.Substring(37, 10).Trim()
        CART_ORD_D = line.Substring(47, 10).Trim()
        CART_ORD_OM_D = line.Substring(57, 10).Trim()
        CART_CON_D = line.Substring(67, 10).Trim()
        CART_CON_OM_D = line.Substring(77, 10).Trim()
        PLT_ORD_D = line.Substring(87, 8).Trim()
        PLT_CON_D = line.Substring(95, 8).Trim()
        FORM_PLT_FORN = line.Substring(103, 20).Trim()
        CART_STRATO_FOR = line.Substring(103, 4).Trim()
        NUM_STRATO_FOR = line.Substring(107, 4).Trim()
        QTA_FORN_FOR = line.Substring(111, 4).Trim()
        QTA_TERMO_FOR = line.Substring(115, 4).Trim()
        NOTE_ORD_D = line.Substring(123, 80).Trim()
        PNT_CAR = line.Substring(203, 8).Trim()
        STATO_RIG = line.Substring(211, 1).Trim()
    End Sub

    Public TRK As String
    Public CART_ORD_D As String
    Public QTA_FORN_FOR As String
    Public PLT_ORD_D As String
    Public SCHEMA As String
    Public NART_ORD_D As String
    Public NART_ORD_OM_D As String
    Public NART_CON_D As String
    Public NART_CON_OM_D As String
    Public ART_ORD_D As String
    Public CART_ORD_OM_D As String
    Public CART_CON_D As String
    Public CART_CON_OM_D As String
    Public PLT_CON_D As String 'Arrivato a linea 235 file tg094.txt'
    Public FORM_PLT_FORN As String
    Public CART_STRATO_FOR As String
    Public NUM_STRATO_FOR As String
    Public QT_FOR_For As String
    Public QTA_TERMO_FOR As String
    Public NOTE_ORD_D As String
    Public PNT_CAR As String
    Public STATO_RIG As String
    Public FIMB As String
End Class
'Arrivato riga 248'
<Serializable> Public Class PRO
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        CODPRO = line.Substring(3, 12).Trim()
        DES_PRO = line.Substring(15, 50).Trim()
        BCODE = line.Substring(65, 14).Trim()
        TIPO = line.Substring(79, 1).Trim()
        PUM = line.Substring(80, 8).Trim()
        PUM_UM = line.Substring(80, 2).Trim()
        PUM_QTA = line.Substring(82, 6).Trim()
        GR = line.Substring(88, 2).Trim()
        PESO_PRO = line.Substring(90, 6).Trim()
        DIM_PRO = line.Substring(96, 12).Trim()
        DIM_LATO1_PRO = line.Substring(96, 4).Trim()
        DIM_LATO2_PRO = line.Substring(100, 4).Trim()
        DIM_LATO3_PRO = line.Substring(104, 4).Trim()
        PNT_SC_CAR = line.Substring(108, 6).Trim()
        FORMA = line.Substring(114, 3).Trim()
        DURATA = line.Substring(117, 4).Trim()
        QTA_BCODE = line.Substring(121, 4).Trim()
        QTA_FORN = line.Substring(125, 6).Trim()
        QTA_TERMO = line.Substring(131, 6).Trim()
        FORM_PLT_MAG = line.Substring(137, 8).Trim()
        CART_STRATO_MAG = line.Substring(137, 4).Trim()
        NUM_STRATO_MAG = line.Substring(141, 4).Trim()
        QTA_VENDITA = line.Substring(145, 6).Trim()
        PESO_UVC = line.Substring(151, 6).Trim()
        DIM_UVC = line.Substring(157, 12).Trim()
        Dim_LATO1_UVC = line.Substring(157, 4).Trim()
        DIM_LATO2_UVC = line.Substring(161, 4).Trim()
        DIM_LATO3_UVC = line.Substring(165, 4).Trim()
        VARIETA = line.Substring(170, 10).Trim()
        NAZORI = line.Substring(180, 4).Trim()
        LOCAL = line.Substring(184, 5).Trim()
        CALIBRO = line.Substring(189, 7).Trim()
        CATEG = line.Substring(196, 2).Trim()
        TCONF = line.Substring(198, 4).Trim()
        TIMB = line.Substring(202, 3).Trim()
        FIMB = line.Substring(205, 1).Trim()
        UM = line.Substring(206, 2).Trim()
        CODIVA = line.Substring(208, 3).Trim()
        ALIQ = line.Substring(211, 4).Trim()
        CODF_TV = line.Substring(215, 200) 'Arrivato riga 288 file tg904.txt'   .Trim()
        CODF_E = line.Substring(215, 200).Trim()
        CODF = line.Substring(215, 20) 'Devo inserire questo campo?'            .Trim()
        PG_LIST = line.Substring(415, 4).Trim()
        RG_LIST = line.Substring(419, 2).Trim()
        P_BUYER = line.Substring(421, 4).Trim()
        P_DES_BUYER = line.Substring(425, 8).Trim()
        BCODE_IMB = line.Substring(433, 14).Trim()
        QTA_BCODE_IMB = line.Substring(447, 4).Trim()
        DTSCAD1 = line.Substring(451, 8).Trim()
        DTSCAD2 = line.Substring(459, 8).Trim()
        ART62 = line.Substring(467, 1).Trim()
        RE5 = line.Substring(468, 10).Trim()
        LNF = line.Substring(478, 2).Trim()
        BCODA = line.Substring(480, 30).Trim()
        DTINS_BCODE = line.Substring(510, 8).Trim()
        DTINS_BCODE_IMB = line.Substring(518, 8).Trim()
        DTINS_BCODA = line.Substring(526, 8).Trim()
        GR1 = line.Substring(534, 2).Trim()
        GR2 = line.Substring(536, 2).Trim()
        GR3 = line.Substring(538, 2).Trim()
        GR4 = line.Substring(540, 2).Trim()
        GR5 = line.Substring(542, 2)
    End Sub

    Public TRK As String
    Public CODPRO As String
    Public FIMB As String
    Public RG_LIST As String
    Public NUM_STRATO_MAG As String
    Public DES_PRO As String
    Public BCODE As String
    Public TIPO As String
    Public PUM As String
    Public PUM_UM As String
    Public PUM_QTA As String
    Public GR As String
    Public PESO_PRO As String
    Public DIM_PRO As String
    Public DIM_LATO1_PRO As String
    Public DIM_LATO2_PRO As String
    Public DIM_LATO3_PRO As String
    Public PNT_SC_CAR As String
    Public FORMA As String
    Public DURATA As String
    Public QTA_BCODE As String
    Public QTA_FORN As String
    Public QTA_TERMO As String
    Public FORM_PLT_MAG As String
    Public CART_STRATO_MAG As String
    Public QTA_VENDITA As String
    Public PESO_UVC As String
    Public DIM_UVC As String
    Public Dim_LATO1_UVC As String
    Public DIM_LATO2_UVC As String
    Public DIM_LATO3_UVC As String
    Public VARIETA As String
    Public NAZORI As String
    Public LOCAL As String
    Public CALIBRO As String
    Public CATEG As String
    Public TCONF As String
    Public TIMB As String
    Public _FIMB As String
    Public UM As String
    Public CODIVA As String
    Public ALIQ As String
    Public CODF_TV As String
    Public CODF_E As String
    Public CODF As String
    Public PG_LIST As String
    Public P_BUYER As String
    Public P_DES_BUYER As String
    Public BCODE_IMB As String
    Public QTA_BCODE_IMB As String
    Public DTSCAD1 As String
    Public DTSCAD2 As String
    Public ART62 As String
    Public RE5 As String
    Public LNF As String
    Public BCODA As String
    Public DTINS_BCODE As String
    Public DTINS_BCODE_IMB As String
    Public DTINS_BCODA As String
    Public GR1 As String
    Public GR2 As String
    Public GR3 As String
    Public GR4 As String
    Public GR5 As String
End Class
<Serializable> Public Class XNA_XFT
    Public TRK
    Public TG904_XVAL As String
    Public Sub New()

    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        TG904_XVAL = line.Substring(4, 16).Trim()
    End Sub
End Class

<Serializable> Public Class CO
    Public Sub New()
    End Sub
    Public Sub New(colStr As String, index As Integer)
        TRK = "CO" & index
        COS = colStr.Substring(3, 12).Trim()
        COSV = colStr.Substring(3, 12).Trim()
        STRINGA = colStr.Substring(15, 136).Trim()
    End Sub
    Public TRK As String
    Public COS As String
    Public COSV As String
    Public STRINGA As String
End Class
<Serializable> Public Class ENDTR
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        TG904_NRK = line.Substring(4, 6).Trim()
    End Sub
    Public TG904_NRK As String
    Public TRK As String
End Class
<Serializable> Public Class PPI_PPT
    Public TRK As String
    Public PP_IMP As String
    Public PP_IMPV As String
    Public PP_IVA As String
    Public PP_IVAV As String
    Public PP_ALIQ As String
    Public PP_CODIVA As String
    Public Sub New()
    End Sub
    Public Sub New(line As String)
        TRK = line.Substring(0, 3).Trim()
        PP_IMP = line.Substring(3, 14).Trim()
        PP_IMPV = line.Substring(3, 14).Trim()
        PP_IVA = line.Substring(17, 14).Trim()
        PP_IVAV = line.Substring(17, 14).Trim() 'Devo aggiungere questo Campo?' 
        PP_ALIQ = line.Substring(31, 4).Trim()
        PP_CODIVA = line.Substring(35, 3).Trim()
    End Sub
End Class










