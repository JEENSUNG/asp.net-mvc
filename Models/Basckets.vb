Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity

Public Class Basckets
    <Key>
    Property Bas_Idx As Long

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Bas_Name As String

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Bas_Professor As String

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Bas_Day As String

    <Required, Range(1, Integer.MaxValue)>
    Property Bas_StartTime As Integer

    <Required, Range(1, Integer.MaxValue)>
    Property Bas_EndTime As Integer

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Bas_Create_Date As DateTime

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Bas_Modified_Date As DateTime

    <Required, Range(1, Integer.MaxValue)>
    Property Bas_Credit As Integer

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Bas_Subject As String

    <Required, DefaultSettingValue("false")>
    Property Bas_Updated As Boolean

    <Required, DefaultSettingValue("false")>
    Property Bas_IsValid As Boolean

End Class
