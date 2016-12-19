Public Class TicketDeuda
    Private ultimoPago As String
    Private poliza As String
    Private cuota As String
    Private moneda As String
    Private fechaIngreso As String
    Private comprobante As String
    Private ramo As String
    Private deudaInicial As String
    Private deudaPendiente As String

    Public Sub setUltimoPago(ByVal pUltimoPago As String)
        ultimoPago = pUltimoPago
    End Sub

    Public Sub setPoliza(ByVal pPoliza As String)
        poliza = pPoliza
    End Sub
    Public Sub setCuota(ByVal pCuota As String)
        cuota = pCuota
    End Sub
    Public Sub setMoneda(ByVal pMoneda As String)
        moneda = pMoneda
    End Sub
    Public Sub setFechaIngreso(ByVal pFechaIngreso As String)
        fechaIngreso = pFechaIngreso
    End Sub
    Public Sub setComprobante(ByVal pComprobante As String)
        comprobante = pComprobante
    End Sub
    Public Sub setRamo(ByVal pRamo As String)
        ramo = pRamo
    End Sub
    Public Sub setDeudaInicial(ByVal pDeudaInicial As String)
        deudaInicial = pDeudaInicial
    End Sub
    Public Sub setDeudaPendiente(ByVal pDeudaPendiente As String)
        deudaPendiente = pDeudaPendiente
    End Sub

    Public Function getUltimoPago()
        Return ultimoPago
    End Function
    Public Function getPoliza()
        Return poliza
    End Function
    Public Function getCuota()
        Return cuota
    End Function
    Public Function getMoneda()
        Return moneda
    End Function
    Public Function getFechaIngreso()
        Return fechaIngreso
    End Function
    Public Function getComprobante()
        Return comprobante
    End Function
    Public Function getRamo()
        Return ramo
    End Function
    Public Function getDeudaInicial()
        Return deudaInicial
    End Function
    Public Function getDeudaPendiente()
        Return deudaPendiente
    End Function
End Class
