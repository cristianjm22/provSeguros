Imports System.Data.SqlClient
Module Variables

    Public SERVIDOR As String = "NOTE-CMORALES"
    'Public SERVIDOR As String = "MC0XGCTC"
    Public BASE As String = "dbPoyPS" ' tuve que cambiar el nombre de la base!
    Public sCnn As String = "Data Source=" & SERVIDOR & ";Initial Catalog=" & BASE & ";Integrated Security=True"
    Public conn As SqlConnection = Nothing
    Public Usuario As String = "Usuario"
    Public cmd As SqlCommand
    Public SQLread As SqlDataReader


    Public indexdgvReporte As Integer
    Public ModificacionReporte As Boolean = False
    Public idComprobante As Integer

End Module
