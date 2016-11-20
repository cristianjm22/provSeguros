Imports System.Data.SqlClient
Module Variables
    'Public SERVIDOR As String = "NATYCRIS-PC"
    Public SERVIDOR As String = "MC0XGCTC"
    Public BASE As String = "dbPoyCPS"
    Public sCnn As String = "Data Source=" & SERVIDOR & ";Initial Catalog=" & BASE & ";Integrated Security=True"
    Public conn As SqlConnection = Nothing
End Module
