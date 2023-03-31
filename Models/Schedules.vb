Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity
Imports System.Runtime.Versioning

Public Class Schedules
    <Key>
    Property Sch_Idx As Long

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Sch_Name As String

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Sch_Professor As String

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Sch_Day As String

    <Required, Range(1, Integer.MaxValue)>
    Property Sch_StartTime As Integer

    <Required, Range(1, Integer.MaxValue)>
    Property Sch_EndTime As Integer

    <Required, Range(1, 3)>
    Property Sch_Credit As Integer

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Sch_Created_Date As DateTime

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Sch_Modified_Date As DateTime

    <Required, MaxLength(20)>
    Property Sch_Subject As String

    <Required, DefaultSettingValue("false")>
    Property Sch_Updated As Boolean

    <Required, DefaultSettingValue("false")>
    Property Sch_IsValid As Boolean

End Class
