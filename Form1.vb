Imports System.IO
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports consulta_cdr.consultaSunat

Public Class Form1
    Private Sub ObtenerConfig()
        Dim archivoConfig As String = My.Application.Info.DirectoryPath & "/config.ini"
        If Not File.Exists(archivoConfig) Then
            Dim nuevo As New StreamWriter(archivoConfig, False)
            nuevo.WriteLine("usrRuc=")
            nuevo.WriteLine("usrNam=")
            nuevo.WriteLine("usrPas=")
            nuevo.WriteLine("cmpTip=")
            nuevo.WriteLine("cmpRuc=")
            nuevo.WriteLine("cmpSer=")
            nuevo.WriteLine("cmpNum=")
            nuevo.Close()
            Exit Sub
        End If

        Dim lector As New IO.StreamReader(archivoConfig)
        Dim fila As String = lector.ReadLine
        While fila IsNot Nothing
            Dim cadena() As String = fila.Split("=")
            Select Case cadena(0)
                Case "usrRuc"
                    txtUsuarioRuc.Text = cadena(1)
                Case "usrNam"
                    TxtUsuarioNombre.Text = cadena(1)
                Case "usrPas"
                    TxtUsuarioClave.Text = cadena(1)
                Case "cmpTip"
                    TxtTipo.Text = cadena(1)
                Case "cmpRuc"
                    TxtRuc.Text = cadena(1)
                Case "cmpSer"
                    TxtSerie.Text = cadena(1)
                Case "cmpNum"
                    TxtNumero.Text = CInt(Val(cadena(1)))
            End Select
            fila = lector.ReadLine
        End While
        lector.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerConfig()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuarioRuc, usuarioNombre, usuarioPass As String
        usuarioRuc = txtUsuarioRuc.Text
        usuarioNombre = TxtUsuarioNombre.Text
        usuarioPass = TxtUsuarioClave.Text

        Dim reqComprobante As New consultaSunat.getStatusCdrRequest
        reqComprobante.tipoComprobante = TxtTipo.Text
        reqComprobante.rucComprobante = TxtRuc.Text
        reqComprobante.serieComprobante = TxtSerie.Text
        reqComprobante.numeroComprobante = CInt(Val(TxtNumero.Text))

        TxtRslt1.Text = ""
        TxtRslt2.Text = ""
        TxtRslt3.Text = ""

        Try
            'inicio de servicio consulta
            Dim servicio As New consultaSunat.billServiceClient
            'servicio = New billServiceClient(CreateBinding, New EndpointAddress("https://e-beta.sunat.gob.pe:443/ol-ti-itcpfegem-beta/billService"))
            servicio = New billServiceClient(CreateBinding, New EndpointAddress("https://e-factura.sunat.gob.pe/ol-it-wsconscpegem/billConsultService"))
            servicio.ClientCredentials.UserName.UserName = usuarioRuc & usuarioNombre
            servicio.ClientCredentials.UserName.Password = usuarioPass

            Dim rpta As consultaSunat.getStatusCdrResponse
            servicio.Open()
            rpta = servicio.consultaSunat_billService_getStatusCdr(reqComprobante)
            servicio.Close()

            TxtRslt1.Text = rpta.statusCdr.statusCode
            TxtRslt2.Text = rpta.statusCdr.statusMessage
            Dim fs As New FileStream("D:\" & TxtSerie.Text & "-" & TxtNumero.Text & ".zip", FileMode.Create)
            Try
                fs.Write(rpta.statusCdr.content, 0, rpta.statusCdr.content.Length)
                TxtRslt3.Text = "archivo creado"
            Catch ex As Exception
                TxtRslt3.Text = ex.Message
            Finally
                fs.Close()
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        MsgBox("Consulta terminada")
    End Sub

    Private Function CreateBinding() As Binding
        Dim binding = New BasicHttpBinding(BasicHttpSecurityMode.TransportWithMessageCredential)
        Dim elements = binding.CreateBindingElements
        elements.Find(Of SecurityBindingElement).IncludeTimestamp = False
        Return New CustomBinding(elements)
    End Function
End Class
