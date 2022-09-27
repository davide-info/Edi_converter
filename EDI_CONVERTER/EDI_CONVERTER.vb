Public Class EDI_CONVERTER
    Implements LibIf.LibIf

    Private _Config As New DataSet
    Public Property Config As System.Data.DataSet Implements LibIf.LibIf.Config
        Get
            Return _Config
        End Get
        Set(value As System.Data.DataSet)
            _Config = value
        End Set
    End Property


    Public ReadOnly Property Description As String Implements LibIf.LibIf.Description
        Get
            Return "EDI Converter"
        End Get
    End Property

    Private _CurrentDir As String = ""
    Public Property DllCurrentDir As String Implements LibIf.LibIf.DllCurrentDir
        Get
            Return _CurrentDir
        End Get
        Set(value As String)
            _CurrentDir = value
        End Set
    End Property

    Public Event EvtCallRule(LibraryID As String, RuleID As String, HeadID As String, Params As LibIf.RuleParams) Implements LibIf.LibIf.EvtCallRule

    Public Event EvtError(Routine As String, Message As String) Implements LibIf.LibIf.EvtError

    Public Event EvtMessage(Message As String) Implements LibIf.LibIf.EvtMessage


    Public Sub New()
        Dim TG904 As New Parameters.ObjParameter
        TG904.Type = Parameters.ObjType.T_String
        TG904.Name = "TG094"
        TG904.Value = ""
        _InputParameters.Add(TG904)

        Dim EDI_XML As New Parameters.ObjParameter
        EDI_XML.Type = Parameters.ObjType.T_String
        EDI_XML.Name = "EDI_XML"
        EDI_XML.Value = ""
        _InputParameters.Add(EDI_XML)

        Dim EDI_ORD As New Parameters.ObjParameter
        EDI_ORD.Type = Parameters.ObjType.T_Object
        EDI_ORD.Name = "EDI_ORD_OBJ"
        EDI_ORD.Value = Nothing
        _OutputParameters.Add(EDI_ORD)

        Dim TG904OBJ As New Parameters.ObjParameter
        TG904OBJ.Type = Parameters.ObjType.T_Object
        TG904OBJ.Name = "TG904_OBJ"
        TG904OBJ.Value = Nothing
        _OutputParameters.Add(TG904OBJ)

        Dim EDI_ORD_XML As New Parameters.ObjParameter
        EDI_ORD_XML.Type = Parameters.ObjType.T_String
        EDI_ORD_XML.Name = "EDI_ORD_XML"
        EDI_ORD_XML.Value = Nothing
        _OutputParameters.Add(EDI_ORD_XML)

        Dim TG904OBJ_XML As New Parameters.ObjParameter
        TG904OBJ_XML.Type = Parameters.ObjType.T_String
        TG904OBJ_XML.Name = "TG904_OBJ_XML"
        TG904OBJ_XML.Value = Nothing
        _OutputParameters.Add(TG904OBJ_XML)

        Dim VALUE As New Parameters.ObjParameter
        VALUE.Type = Parameters.ObjType.T_String
        VALUE.Name = "VALUE"
        VALUE.Value = ""
        _OutputParameters.Add(VALUE)



    End Sub
    Public Function Execute(SessionId As String, ByRef Log As String) As Boolean Implements LibIf.LibIf.Execute
        Execute = False
        Try
            If _InputParameters(1).Value <> "" Then
                Dim OrdObj As New EDI_ORD.EDI_ORD
                Dim EDI_XML_Deserializer As New Xml.Serialization.XmlSerializer(OrdObj.GetType())

                Using MS As New IO.MemoryStream(System.Text.Encoding.Default.GetBytes(_InputParameters(1).Value.ToString))
                    OrdObj = EDI_XML_Deserializer.Deserialize(MS)
                    OutputParameters(4).Value = OrdObj.ToString
                End Using

                If OutputParameters(4).Value <> "" Then
                    Return True
                Else
                    Return False
                End If

            End If
            Dim Tg904 As EDI_ORD.Tg904 = EDI_ORD.Parser.ParseTG904(_InputParameters(0).Value)
            Dim Ord As EDI_ORD.EDI_ORD = EDI_ORD.Parser.MapToOrdineEdi(Tg904)
            OutputParameters(0).Value = Ord
            OutputParameters(1).Value = Tg904

            Dim EDI_ORD_Serializer As New Xml.Serialization.XmlSerializer(Ord.GetType())
            Using MS As New IO.MemoryStream
                EDI_ORD_Serializer.Serialize(MS, Ord)
                OutputParameters(2).Value = System.Text.Encoding.Default.GetString(MS.ToArray())
            End Using


            Dim TG904Serializer As New Xml.Serialization.XmlSerializer(Tg904.GetType())
            Using MS As New IO.MemoryStream
                TG904Serializer.Serialize(MS, Tg904)
                OutputParameters(3).Value = System.Text.Encoding.Default.GetString(MS.ToArray())
            End Using




            OutputParameters(4).Value = Ord.ToString
            If Not Ord Is Nothing Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Log += "Errore:" & ex.Message & vbCrLf
        End Try
    End Function

    Public ReadOnly Property Group As String Implements LibIf.LibIf.Group
        Get
            Return "EDI"
        End Get
    End Property

    Public ReadOnly Property Icon32 As System.Drawing.Image Implements LibIf.LibIf.Icon32
        Get
            Return My.Resources.edit_chat
        End Get
    End Property

    Public ReadOnly Property IconPosition As System.Drawing.Point Implements LibIf.LibIf.IconPosition
        Get
            Return New Drawing.Point(13, 13)
        End Get
    End Property

    Private _ID As String = ""
    Public ReadOnly Property ID As String Implements LibIf.LibIf.ID
        Get
            Return _ID
        End Get
    End Property

    Public Sub Init(Library As Library.Library, Rule As Library.Rule, EditMode As Boolean, ObjectID As String, LibraryCollection As System.Collections.ObjectModel.Collection(Of Library.Library)) Implements LibIf.LibIf.Init
        _ID = ObjectID
    End Sub

    Private _InputParameters As New System.Collections.ObjectModel.Collection(Of Parameters.ObjParameter)
    Public Property InputParameters As System.Collections.ObjectModel.Collection(Of Parameters.ObjParameter) Implements LibIf.LibIf.InputParameters
        Get
            Return _InputParameters
        End Get
        Set(value As System.Collections.ObjectModel.Collection(Of Parameters.ObjParameter))
            _InputParameters = value
        End Set
    End Property

    Private _OutputParameters As New System.Collections.ObjectModel.Collection(Of Parameters.ObjParameter)
    Public Property OutputParameters As System.Collections.ObjectModel.Collection(Of Parameters.ObjParameter) Implements LibIf.LibIf.OutputParameters
        Get
            Return _OutputParameters
        End Get
        Set(value As System.Collections.ObjectModel.Collection(Of Parameters.ObjParameter))
            _OutputParameters = value
        End Set
    End Property

    Public ReadOnly Property Shape As Integer Implements LibIf.LibIf.Shape
        Get
            Return 0
        End Get
    End Property

    Public Sub ShowConfig() Implements LibIf.LibIf.ShowConfig

    End Sub

    Public ReadOnly Property ShowFalseIn As Boolean Implements LibIf.LibIf.ShowFalseIn
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property ShowFalseOut As Boolean Implements LibIf.LibIf.ShowFalseOut
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property ShowTrueIn As Boolean Implements LibIf.LibIf.ShowTrueIn
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property ShowTrueOut As Boolean Implements LibIf.LibIf.ShowTrueOut
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property Size As System.Drawing.Size Implements LibIf.LibIf.Size
        Get

        End Get
    End Property

    Private _StackResult As Boolean
    Public Property StackResult As Boolean Implements LibIf.LibIf.StackResult
        Get
            Return _StackResult
        End Get
        Set(value As Boolean)
            _StackResult = value
        End Set
    End Property


    Private _Tag As Object
    Public Property Tag As Object Implements LibIf.LibIf.Tag
        Get
            Return _Tag
        End Get
        Set(value As Object)
            _Tag = value
        End Set
    End Property

    Public ReadOnly Property Version As String Implements LibIf.LibIf.Version
        Get
            Return "1.0"
        End Get
    End Property
End Class
