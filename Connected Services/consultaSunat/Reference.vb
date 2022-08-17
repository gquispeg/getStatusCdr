﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace consultaSunat
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://service.sunat.gob.pe", ConfigurationName:="consultaSunat.billService")>  _
    Public Interface billService
        
        'CODEGEN: El parámetro 'statusCdr' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="urn:getStatusCdr", ReplyAction:="http://service.sunat.gob.pe/billService/getStatusCdrResponse"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function getStatusCdr(ByVal request As consultaSunat.getStatusCdrRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="statusCdr")> consultaSunat.getStatusCdrResponse
        
        'CODEGEN: El parámetro 'status' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        <System.ServiceModel.OperationContractAttribute(Action:="urn:getStatus", ReplyAction:="http://service.sunat.gob.pe/billService/getStatusResponse"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function getStatus(ByVal request As consultaSunat.getStatusRequest) As <System.ServiceModel.MessageParameterAttribute(Name:="status")> consultaSunat.getStatusResponse
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://service.sunat.gob.pe")>  _
    Partial Public Class statusResponse
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private contentField() As Byte
        
        Private statusCodeField As String
        
        Private statusMessageField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary", Order:=0)>  _
        Public Property content() As Byte()
            Get
                Return Me.contentField
            End Get
            Set
                Me.contentField = value
                Me.RaisePropertyChanged("content")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=1)>  _
        Public Property statusCode() As String
            Get
                Return Me.statusCodeField
            End Get
            Set
                Me.statusCodeField = value
                Me.RaisePropertyChanged("statusCode")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, Order:=2)>  _
        Public Property statusMessage() As String
            Get
                Return Me.statusMessageField
            End Get
            Set
                Me.statusMessageField = value
                Me.RaisePropertyChanged("statusMessage")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatusCdr", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusCdrRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public rucComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=1),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public tipoComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=2),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public serieComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=3),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public numeroComprobante As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal rucComprobante As String, ByVal tipoComprobante As String, ByVal serieComprobante As String, ByVal numeroComprobante As Integer)
            MyBase.New
            Me.rucComprobante = rucComprobante
            Me.tipoComprobante = tipoComprobante
            Me.serieComprobante = serieComprobante
            Me.numeroComprobante = numeroComprobante
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatusCdrResponse", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusCdrResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public statusCdr As consultaSunat.statusResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal statusCdr As consultaSunat.statusResponse)
            MyBase.New
            Me.statusCdr = statusCdr
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatus", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public rucComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=1),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public tipoComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=2),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public serieComprobante As String
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=3),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public numeroComprobante As Integer
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal rucComprobante As String, ByVal tipoComprobante As String, ByVal serieComprobante As String, ByVal numeroComprobante As Integer)
            MyBase.New
            Me.rucComprobante = rucComprobante
            Me.tipoComprobante = tipoComprobante
            Me.serieComprobante = serieComprobante
            Me.numeroComprobante = numeroComprobante
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(WrapperName:="getStatusResponse", WrapperNamespace:="http://service.sunat.gob.pe", IsWrapped:=true)>  _
    Partial Public Class getStatusResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://service.sunat.gob.pe", Order:=0),  _
         System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public status As consultaSunat.statusResponse
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal status As consultaSunat.statusResponse)
            MyBase.New
            Me.status = status
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface billServiceChannel
        Inherits consultaSunat.billService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class billServiceClient
        Inherits System.ServiceModel.ClientBase(Of consultaSunat.billService)
        Implements consultaSunat.billService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function consultaSunat_billService_getStatusCdr(ByVal request As consultaSunat.getStatusCdrRequest) As consultaSunat.getStatusCdrResponse Implements consultaSunat.billService.getStatusCdr
            Return MyBase.Channel.getStatusCdr(request)
        End Function
        
        Public Function getStatusCdr(ByVal rucComprobante As String, ByVal tipoComprobante As String, ByVal serieComprobante As String, ByVal numeroComprobante As Integer) As consultaSunat.statusResponse
            Dim inValue As consultaSunat.getStatusCdrRequest = New consultaSunat.getStatusCdrRequest()
            inValue.rucComprobante = rucComprobante
            inValue.tipoComprobante = tipoComprobante
            inValue.serieComprobante = serieComprobante
            inValue.numeroComprobante = numeroComprobante
            Dim retVal As consultaSunat.getStatusCdrResponse = CType(Me,consultaSunat.billService).getStatusCdr(inValue)
            Return retVal.statusCdr
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function consultaSunat_billService_getStatus(ByVal request As consultaSunat.getStatusRequest) As consultaSunat.getStatusResponse Implements consultaSunat.billService.getStatus
            Return MyBase.Channel.getStatus(request)
        End Function
        
        Public Function getStatus(ByVal rucComprobante As String, ByVal tipoComprobante As String, ByVal serieComprobante As String, ByVal numeroComprobante As Integer) As consultaSunat.statusResponse
            Dim inValue As consultaSunat.getStatusRequest = New consultaSunat.getStatusRequest()
            inValue.rucComprobante = rucComprobante
            inValue.tipoComprobante = tipoComprobante
            inValue.serieComprobante = serieComprobante
            inValue.numeroComprobante = numeroComprobante
            Dim retVal As consultaSunat.getStatusResponse = CType(Me,consultaSunat.billService).getStatus(inValue)
            Return retVal.status
        End Function
    End Class
End Namespace
